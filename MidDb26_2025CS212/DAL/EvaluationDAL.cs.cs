using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using MidDb26_2025CS212.Helpers;
using MidDb26_2025CS212.Models;

namespace MidDb26_2025CS212.DAL
{
    public class EvaluationDAL
    {
        // Get all assessments for dropdown
        public List<Assessment> GetAssessments()
        {
            var list = new List<Assessment>();
            try
            {
                using (MySqlConnection con = DBHelper.GetConnection())
                {
                    string query = @"
                        SELECT Id, Title, TotalMarks,
                               TotalWeightage, DateCreated
                        FROM assessment
                        ORDER BY Id ASC";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    con.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new Assessment
                        {
                            Id = (int)reader["Id"],
                            Title = reader["Title"].ToString(),
                            TotalMarks = (int)reader["TotalMarks"],
                            TotalWeightage =
                                (int)reader["TotalWeightage"],
                            DateCreated =
                                (DateTime)reader["DateCreated"]
                        });
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception(
                    "Error loading assessments: " + ex.Message);
            }
            return list;
        }

        // Get all students for dropdown
        public List<Student> GetStudents()
        {
            var list = new List<Student>();
            try
            {
                using (MySqlConnection con = DBHelper.GetConnection())
                {
                    string query = @"
                        SELECT Id, FirstName, LastName,
                               RegistrationNumber
                        FROM student
                        ORDER BY FirstName ASC";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    con.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new Student
                        {
                            Id = (int)reader["Id"],
                            FirstName =
                                reader["FirstName"].ToString(),
                            LastName =
                                reader["LastName"].ToString(),
                            RegistrationNumber =
                                reader["RegistrationNumber"]
                                .ToString()
                        });
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception(
                    "Error loading students: " + ex.Message);
            }
            return list;
        }

        // Get components for selected assessment
        public List<AssessmentComponent> GetComponents(
            int assessmentId)
        {
            var list = new List<AssessmentComponent>();
            try
            {
                using (MySqlConnection con = DBHelper.GetConnection())
                {
                    string query = @"
                        SELECT ac.Id, ac.Name,
                               ac.RubricId, ac.TotalMarks,
                               ac.AssessmentId,
                               ac.DateCreated, ac.DateUpdated,
                               r.Details as RubricName
                        FROM assessmentcomponent ac
                        INNER JOIN rubric r
                            ON ac.RubricId = r.Id
                        WHERE ac.AssessmentId = @aid
                        ORDER BY ac.Id ASC";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@aid", assessmentId);
                    con.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new AssessmentComponent
                        {
                            Id = (int)reader["Id"],
                            Name = reader["Name"].ToString(),
                            RubricId = (int)reader["RubricId"],
                            RubricName =
                                reader["RubricName"].ToString(),
                            TotalMarks =
                                (int)reader["TotalMarks"],
                            AssessmentId =
                                (int)reader["AssessmentId"],
                            DateCreated =
                                (DateTime)reader["DateCreated"],
                            DateUpdated =
                                (DateTime)reader["DateUpdated"]
                        });
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception(
                    "Error loading components: " + ex.Message);
            }
            return list;
        }

        // Get rubric levels for a rubric
        public List<RubricLevel> GetRubricLevels(int rubricId)
        {
            var list = new List<RubricLevel>();
            try
            {
                using (MySqlConnection con = DBHelper.GetConnection())
                {
                    string query = @"
                        SELECT Id, RubricId,
                               Details, MeasurementLevel
                        FROM rubriclevel
                        WHERE RubricId = @rid
                        ORDER BY MeasurementLevel ASC";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@rid", rubricId);
                    con.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new RubricLevel
                        {
                            Id = (int)reader["Id"],
                            RubricId = (int)reader["RubricId"],
                            Details =
                                reader["Details"].ToString(),
                            MeasurementLevel =
                                (int)reader["MeasurementLevel"]
                        });
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception(
                    "Error loading rubric levels: " + ex.Message);
            }
            return list;
        }

        // Get max rubric level for a rubric
        public int GetMaxLevel(int rubricId)
        {
            try
            {
                using (MySqlConnection con = DBHelper.GetConnection())
                {
                    string query = @"
                        SELECT COALESCE(MAX(MeasurementLevel), 4)
                        FROM rubriclevel
                        WHERE RubricId = @rid";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@rid", rubricId);
                    con.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch
            {
                return 4;
            }
        }

        // Check if evaluation already exists
        public bool EvaluationExists(int studentId,
            int componentId)
        {
            try
            {
                using (MySqlConnection con = DBHelper.GetConnection())
                {
                    string query = @"
                        SELECT COUNT(*) FROM studentresult
                        WHERE StudentId = @sid
                        AND AssessmentComponentId = @cid";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@sid", studentId);
                    cmd.Parameters.AddWithValue("@cid", componentId);
                    con.Open();
                    return Convert.ToInt32(
                        cmd.ExecuteScalar()) > 0;
                }
            }
            catch
            {
                return false;
            }
        }

        // Save evaluation
        public bool SaveEvaluation(StudentResult result)
        {
            try
            {
                using (MySqlConnection con = DBHelper.GetConnection())
                {
                    string query;
                    if (EvaluationExists(
                        result.StudentId,
                        result.AssessmentComponentId))
                    {
                        // Update existing
                        query = @"
                            UPDATE studentresult
                            SET RubricMeasurementId = @levelId,
                                EvaluationDate = @date
                            WHERE StudentId = @sid
                            AND AssessmentComponentId = @cid";
                    }
                    else
                    {
                        // Insert new
                        query = @"
                            INSERT INTO studentresult
                                (StudentId, AssessmentComponentId,
                                 RubricMeasurementId, EvaluationDate)
                            VALUES
                                (@sid, @cid, @levelId, @date)";
                    }
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@sid",
                        result.StudentId);
                    cmd.Parameters.AddWithValue("@cid",
                        result.AssessmentComponentId);
                    cmd.Parameters.AddWithValue("@levelId",
                        result.RubricMeasurementId);
                    cmd.Parameters.AddWithValue("@date",
                        DateTime.Now);
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception(
                    "Error saving evaluation: " + ex.Message);
            }
        }

        // Get existing evaluation for a student
        public List<StudentResult> GetStudentResults(
            int studentId, int assessmentId)
        {
            var list = new List<StudentResult>();
            try
            {
                using (MySqlConnection con = DBHelper.GetConnection())
                {
                    string query = @"
                        SELECT sr.StudentId,
                               sr.AssessmentComponentId,
                               sr.RubricMeasurementId,
                               sr.EvaluationDate,
                               ac.Name as ComponentName,
                               ac.TotalMarks as ComponentMarks,
                               rl.MeasurementLevel as ObtainedLevel,
                               (SELECT MAX(MeasurementLevel)
                                FROM rubriclevel
                                WHERE RubricId = ac.RubricId)
                                    as MaxLevel
                        FROM studentresult sr
                        INNER JOIN assessmentcomponent ac
                            ON sr.AssessmentComponentId = ac.Id
                        INNER JOIN rubriclevel rl
                            ON sr.RubricMeasurementId = rl.Id
                        WHERE sr.StudentId = @sid
                        AND ac.AssessmentId = @aid
                        ORDER BY ac.Id ASC";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@sid", studentId);
                    cmd.Parameters.AddWithValue("@aid", assessmentId);
                    con.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new StudentResult
                        {
                            StudentId =
                                (int)reader["StudentId"],
                            AssessmentComponentId =
                                (int)reader["AssessmentComponentId"],
                            RubricMeasurementId =
                                (int)reader["RubricMeasurementId"],
                            EvaluationDate =
                                (DateTime)reader["EvaluationDate"],
                            ComponentName =
                                reader["ComponentName"].ToString(),
                            ComponentMarks =
                                (decimal)(int)reader["ComponentMarks"],
                            ObtainedLevel =
                                (int)reader["ObtainedLevel"],
                            MaxLevel =
                                (int)reader["MaxLevel"]
                        });
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception(
                    "Error loading results: " + ex.Message);
            }
            return list;
        }
    }
}