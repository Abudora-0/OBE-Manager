using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using MidDb26_2025CS212.Helpers;
using MidDb26_2025CS212.Models;

namespace MidDb26_2025CS212.DAL
{
    public class RubricDAL
    {
        public List<Rubric> GetAll()
        {
            var list = new List<Rubric>();
            try
            {
                using (MySqlConnection con = DBHelper.GetConnection())
                {
                    string query = @"
                        SELECT r.Id, r.Details, r.CloId,
                               c.Name as CloName
                        FROM rubric r
                        INNER JOIN clo c ON r.CloId = c.Id
                        ORDER BY r.Id ASC";
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
                    "Error loading rubrics: " + ex.Message);
            }
            return list;
        }

        public bool Add(Rubric r)
        {
            try
            {
                using (MySqlConnection con = DBHelper.GetConnection())
                {
                    string query = @"
                        INSERT INTO rubric (Id, Details, CloId)
                        VALUES (@id, @details, @cloId)";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", r.Id);
                    cmd.Parameters.AddWithValue("@details", r.Details);
                    cmd.Parameters.AddWithValue("@cloId", r.CloId);
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception(
                    "Error adding rubric: " + ex.Message);
            }
        }

        public bool Update(Rubric r)
        {
            try
            {
                using (MySqlConnection con = DBHelper.GetConnection())
                {
                    string query = @"
                        UPDATE rubric 
                        SET Details = @details,
                            CloId = @cloId
                        WHERE Id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@details", r.Details);
                    cmd.Parameters.AddWithValue("@cloId", r.CloId);
                    cmd.Parameters.AddWithValue("@id", r.Id);
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception(
                    "Error updating rubric: " + ex.Message);
            }
        }

        public bool Delete(int id)
        {
            try
            {
                using (MySqlConnection con = DBHelper.GetConnection())
                {
                    string query =
                        "DELETE FROM rubric WHERE Id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception(
                    "Error deleting rubric: " + ex.Message);
            }
        }

        public List<Rubric> Search(string keyword)
        {
            var list = new List<Rubric>();
            try
            {
                using (MySqlConnection con = DBHelper.GetConnection())
                {
                    string query = @"
                        SELECT r.Id, r.Details, r.CloId,
                               c.Name as CloName
                        FROM rubric r
                        INNER JOIN clo c ON r.CloId = c.Id
                        WHERE r.Details LIKE @kw
                           OR c.Name LIKE @kw
                        ORDER BY r.Id ASC";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@kw",
                        "%" + keyword + "%");
                    con.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                        list.Add(MapReader(reader));
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception(
                    "Error searching rubrics: " + ex.Message);
            }
            return list;
        }

        // Get next available ID since rubric ID is not auto increment
        public int GetNextId()
        {
            try
            {
                using (MySqlConnection con = DBHelper.GetConnection())
                {
                    string query =
                        "SELECT COALESCE(MAX(Id), 0) + 1 FROM rubric";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    con.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch
            {
                return 1;
            }
        }

        private Rubric MapReader(MySqlDataReader r)
        {
            return new Rubric
            {
                Id = (int)r["Id"],
                Details = r["Details"].ToString(),
                CloId = (int)r["CloId"],
                CloName = r["CloName"].ToString()
            };
        }
    }
}