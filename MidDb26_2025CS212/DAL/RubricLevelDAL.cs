using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using MidDb26_2025CS212.Helpers;
using MidDb26_2025CS212.Models;

namespace MidDb26_2025CS212.DAL
{
    public class RubricLevelDAL
    {
        public List<RubricLevel> GetAll()
        {
            var list = new List<RubricLevel>();
            try
            {
                using (MySqlConnection con = DBHelper.GetConnection())
                {
                    string query = @"
                        SELECT rl.Id, rl.RubricId,
                               rl.Details, rl.MeasurementLevel,
                               r.Details as RubricName
                        FROM rubriclevel rl
                        INNER JOIN rubric r ON rl.RubricId = r.Id
                        ORDER BY rl.RubricId ASC,
                                 rl.MeasurementLevel DESC";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    con.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                        list.Add(MapReader(reader));
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception(
                    "Error loading rubric levels: " + ex.Message);
            }
            return list;
        }

        public List<RubricLevel> GetByRubric(int rubricId)
        {
            var list = new List<RubricLevel>();
            try
            {
                using (MySqlConnection con = DBHelper.GetConnection())
                {
                    string query = @"
                        SELECT rl.Id, rl.RubricId,
                               rl.Details, rl.MeasurementLevel,
                               r.Details as RubricName
                        FROM rubriclevel rl
                        INNER JOIN rubric r ON rl.RubricId = r.Id
                        WHERE rl.RubricId = @rid
                        ORDER BY rl.MeasurementLevel DESC";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@rid", rubricId);
                    con.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                        list.Add(MapReader(reader));
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception(
                    "Error loading rubric levels: " + ex.Message);
            }
            return list;
        }

        public bool Add(RubricLevel rl)
        {
            try
            {
                using (MySqlConnection con = DBHelper.GetConnection())
                {
                    string query = @"
                        INSERT INTO rubriclevel
                            (RubricId, Details, MeasurementLevel)
                        VALUES
                            (@rubricId, @details, @level)";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@rubricId",
                        rl.RubricId);
                    cmd.Parameters.AddWithValue("@details",
                        rl.Details);
                    cmd.Parameters.AddWithValue("@level",
                        rl.MeasurementLevel);
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception(
                    "Error adding rubric level: " + ex.Message);
            }
        }

        public bool Update(RubricLevel rl)
        {
            try
            {
                using (MySqlConnection con = DBHelper.GetConnection())
                {
                    string query = @"
                        UPDATE rubriclevel
                        SET Details = @details,
                            MeasurementLevel = @level,
                            RubricId = @rubricId
                        WHERE Id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@details",
                        rl.Details);
                    cmd.Parameters.AddWithValue("@level",
                        rl.MeasurementLevel);
                    cmd.Parameters.AddWithValue("@rubricId",
                        rl.RubricId);
                    cmd.Parameters.AddWithValue("@id", rl.Id);
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception(
                    "Error updating rubric level: " + ex.Message);
            }
        }

        public bool Delete(int id)
        {
            try
            {
                using (MySqlConnection con = DBHelper.GetConnection())
                {
                    string query =
                        "DELETE FROM rubriclevel WHERE Id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception(
                    "Error deleting rubric level: " + ex.Message);
            }
        }

        private RubricLevel MapReader(MySqlDataReader r)
        {
            return new RubricLevel
            {
                Id = (int)r["Id"],
                RubricId = (int)r["RubricId"],
                Details = r["Details"].ToString(),
                MeasurementLevel = (int)r["MeasurementLevel"]
            };
        }
    }
}