using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using MidDb26_2025CS212.Helpers;
using MidDb26_2025CS212.Models;

namespace MidDb26_2025CS212.DAL
{
    public class AssessmentDAL
    {
        // ── ASSESSMENT CRUD ────────────────────────────────

        public List<Assessment> GetAll()
        {
            var list = new List<Assessment>();
            try
            {
                using (MySqlConnection con = DBHelper.GetConnection())
                {
                    string query = @"
                        SELECT Id, Title, DateCreated,
                               TotalMarks, TotalWeightage
                        FROM assessment
                        ORDER BY Id ASC";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    con.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                        list.Add(MapAssessment(reader));
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception(
                    "Error loading assessments: " + ex.Message);
            }
            return list;
        }

        public bool AddAssessment(Assessment a)
        {
            try
            {
                using (MySqlConnection con = DBHelper.GetConnection())
                {
                    string query = @"
                        INSERT INTO assessment
                            (Title, DateCreated,
                             TotalMarks, TotalWeightage)
                        VALUES
                            (@title, @created,
                             @marks, @weightage)";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@title", a.Title);
                    cmd.Parameters.AddWithValue("@created",
                        DateTime.Now);
                    cmd.Parameters.AddWithValue("@marks",
                        a.TotalMarks);
                    cmd.Parameters.AddWithValue("@weightage",
                        a.TotalWeightage);
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception(
                    "Error adding assessment: " + ex.Message);
            }
        }

        public bool UpdateAssessment(Assessment a)
        {
            try
            {
                using (MySqlConnection con = DBHelper.GetConnection())
                {
                    string query = @"
                        UPDATE assessment
                        SET Title = @title,
                            TotalMarks = @marks,
                            TotalWeightage = @weightage
                        WHERE Id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@title", a.Title);
                    cmd.Parameters.AddWithValue("@marks",
                        a.TotalMarks);
                    cmd.Parameters.AddWithValue("@weightage",
                        a.TotalWeightage);
                    cmd.Parameters.AddWithValue("@id", a.Id);
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception(
                    "Error updating assessment: " + ex.Message);
            }
        }

        public bool DeleteAssessment(int id)
        {
            try
            {
                using (MySqlConnection con = DBHelper.GetConnection())
                {
                    // Delete components first
                    string q1 = @"DELETE FROM assessmentcomponent
                                  WHERE AssessmentId = @id";
                    MySqlCommand cmd1 = new MySqlCommand(q1, con);
                    cmd1.Parameters.AddWithValue("@id", id);
                    con.Open();
                    cmd1.ExecuteNonQuery();

                    string q2 = @"DELETE FROM assessment
                                  WHERE Id = @id";
                    MySqlCommand cmd2 = new MySqlCommand(q2, con);
                    cmd2.Parameters.AddWithValue("@id", id);
                    return cmd2.ExecuteNonQuery() > 0;
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception(
                    "Error deleting assessment: " + ex.Message);
            }
        }

        // ── COMPONENT CRUD ─────────────────────────────────

        public List<AssessmentComponent> GetComponents(
            int assessmentId)
        {
            var list = new List<AssessmentComponent>();
            try
            {
                using (MySqlConnection con = DBHelper.GetConnection())
                {
                    string query = @"
                        SELECT ac.Id, ac.Name, ac.RubricId,
                               ac.TotalMarks, ac.AssessmentId,
                               ac.DateCreated, ac.DateUpdated,
                               r.Details as RubricName
                        FROM assessmentcomponent ac
                        INNER JOIN rubric r ON ac.RubricId = r.Id
                        WHERE ac.AssessmentId = @aid
                        ORDER BY ac.Id ASC";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@aid", assessmentId);
                    con.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                        list.Add(MapComponent(reader));
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception(
                    "Error loading components: " + ex.Message);
            }
            return list;
        }

        public bool AddComponent(AssessmentComponent c)
        {
            try
            {
                using (MySqlConnection con = DBHelper.GetConnection())
                {
                    string query = @"
                        INSERT INTO assessmentcomponent
                            (Name, RubricId, TotalMarks,
                             DateCreated, DateUpdated,
                             AssessmentId)
                        VALUES
                            (@name, @rubricId, @marks,
                             @created, @updated, @assessmentId)";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@name", c.Name);
                    cmd.Parameters.AddWithValue("@rubricId",
                        c.RubricId);
                    cmd.Parameters.AddWithValue("@marks",
                        c.TotalMarks);
                    cmd.Parameters.AddWithValue("@created",
                        DateTime.Now);
                    cmd.Parameters.AddWithValue("@updated",
                        DateTime.Now);
                    cmd.Parameters.AddWithValue("@assessmentId",
                        c.AssessmentId);
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception(
                    "Error adding component: " + ex.Message);
            }
        }

        public bool UpdateComponent(AssessmentComponent c)
        {
            try
            {
                using (MySqlConnection con = DBHelper.GetConnection())
                {
                    string query = @"
                        UPDATE assessmentcomponent
                        SET Name = @name,
                            RubricId = @rubricId,
                            TotalMarks = @marks,
                            DateUpdated = @updated
                        WHERE Id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@name", c.Name);
                    cmd.Parameters.AddWithValue("@rubricId",
                        c.RubricId);
                    cmd.Parameters.AddWithValue("@marks",
                        c.TotalMarks);
                    cmd.Parameters.AddWithValue("@updated",
                        DateTime.Now);
                    cmd.Parameters.AddWithValue("@id", c.Id);
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception(
                    "Error updating component: " + ex.Message);
            }
        }

        public bool DeleteComponent(int id)
        {
            try
            {
                using (MySqlConnection con = DBHelper.GetConnection())
                {
                    string query = @"
                        DELETE FROM assessmentcomponent
                        WHERE Id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception(
                    "Error deleting component: " + ex.Message);
            }
        }

        // ── HELPERS ────────────────────────────────────────

        private Assessment MapAssessment(MySqlDataReader r)
        {
            return new Assessment
            {
                Id = (int)r["Id"],
                Title = r["Title"].ToString(),
                DateCreated = (DateTime)r["DateCreated"],
                TotalMarks = (int)r["TotalMarks"],
                TotalWeightage = (int)r["TotalWeightage"]
            };
        }

        private AssessmentComponent MapComponent(MySqlDataReader r)
        {
            return new AssessmentComponent
            {
                Id = (int)r["Id"],
                Name = r["Name"].ToString(),
                RubricId = (int)r["RubricId"],
                RubricName = r["RubricName"].ToString(),
                TotalMarks = (int)r["TotalMarks"],
                AssessmentId = (int)r["AssessmentId"],
                DateCreated = (DateTime)r["DateCreated"],
                DateUpdated = (DateTime)r["DateUpdated"]
            };
        }
    }
}