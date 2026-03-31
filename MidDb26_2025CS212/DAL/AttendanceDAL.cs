using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using MidDb26_2025CS212.Helpers;
using MidDb26_2025CS212.Models;

namespace MidDb26_2025CS212.DAL
{
    public class AttendanceDAL
    {
        // Get all class attendance sessions
        public List<ClassAttendance> GetAllSessions()
        {
            var list = new List<ClassAttendance>();
            try
            {
                using (MySqlConnection con =
                    DBHelper.GetConnection())
                {
                    string query = @"
                        SELECT Id, AttendanceDate
                        FROM classattendance
                        ORDER BY AttendanceDate DESC";
                    MySqlCommand cmd =
                        new MySqlCommand(query, con);
                    con.Open();
                    MySqlDataReader reader =
                        cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new ClassAttendance
                        {
                            Id = (int)reader["Id"],
                            AttendanceDate =
                                (DateTime)reader[
                                    "AttendanceDate"]
                        });
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception(
                    "Error loading sessions: " + ex.Message);
            }
            return list;
        }

        // Create new attendance session
        public int CreateSession(DateTime date)
        {
            try
            {
                using (MySqlConnection con =
                    DBHelper.GetConnection())
                {
                    string query = @"
                INSERT INTO classattendance
                    (AttendanceDate)
                VALUES (@date);
                SELECT LAST_INSERT_ID();";
                    MySqlCommand cmd =
                        new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue(
                        "@date", date);
                    con.Open();
                    return Convert.ToInt32(
                        cmd.ExecuteScalar());
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception(
                    "Error creating session: " + ex.Message);
            }
        }

        // Delete session and its records
        public bool DeleteSession(int sessionId)
        {
            try
            {
                using (MySqlConnection con =
                    DBHelper.GetConnection())
                {
                    con.Open();
                    // Delete student attendance first
                    string q1 = @"
                        DELETE FROM studentattendance
                        WHERE AttendanceId = @id";
                    MySqlCommand cmd1 =
                        new MySqlCommand(q1, con);
                    cmd1.Parameters.AddWithValue(
                        "@id", sessionId);
                    cmd1.ExecuteNonQuery();

                    // Delete session
                    string q2 = @"
                        DELETE FROM classattendance
                        WHERE Id = @id";
                    MySqlCommand cmd2 =
                        new MySqlCommand(q2, con);
                    cmd2.Parameters.AddWithValue(
                        "@id", sessionId);
                    return cmd2.ExecuteNonQuery() > 0;
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception(
                    "Error deleting session: " + ex.Message);
            }
        }

    // Get all students with attendance for a session
    public List<StudentAttendanceView>
     GetSessionAttendance(int sessionId)
        {
            var list = new List<StudentAttendanceView>();
            try
            {
                using (MySqlConnection con =
                    DBHelper.GetConnection())
                {
                    string query = @"
                SELECT s.Id as StudentId,
                    CONCAT(s.FirstName,' ',s.LastName)
                        as StudentName,
                    s.RegistrationNumber,
                    COALESCE(sa.AttendanceStatus, 1)
                        as StatusId
                FROM student s
                LEFT JOIN studentattendance sa
                    ON s.Id = sa.StudentId
                    AND sa.AttendanceId = @sessionId
                ORDER BY s.FirstName ASC";
                    MySqlCommand cmd =
                        new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue(
                        "@sessionId", sessionId);
                    con.Open();
                    MySqlDataReader reader =
                        cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new StudentAttendanceView
                        {
                            StudentId =
                                Convert.ToInt32(
                                    reader["StudentId"]),
                            StudentName =
                                reader["StudentName"]
                                .ToString(),
                            RegistrationNumber =
                                reader["RegistrationNumber"]
                                .ToString(),
                            StatusId =
                                Convert.ToInt32(
                                    reader["StatusId"]),
                            StatusName = "Present"
                        });
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception(
                    "Error loading attendance: " + ex.Message);
            }
            return list;
        }

        // Save attendance for all students
        public bool SaveAttendance(int sessionId,
            int studentId, int statusId)
        {
            try
            {
                using (MySqlConnection con =
                    DBHelper.GetConnection())
                {
                    // Check if record exists
                    string checkQuery = @"
                        SELECT COUNT(*) FROM studentattendance
                        WHERE AttendanceId = @sessionId
                        AND StudentId = @studentId";
                    MySqlCommand checkCmd =
                        new MySqlCommand(checkQuery, con);
                    checkCmd.Parameters.AddWithValue(
                        "@sessionId", sessionId);
                    checkCmd.Parameters.AddWithValue(
                        "@studentId", studentId);
                    con.Open();
                    int exists = Convert.ToInt32(
                        checkCmd.ExecuteScalar());

                    string query;
                    if (exists > 0)
                    {
                        query = @"
                            UPDATE studentattendance
                            SET AttendanceStatus = @statusId
                            WHERE AttendanceId = @sessionId
                            AND StudentId = @studentId";
                    }
                    else
                    {
                        query = @"
                            INSERT INTO studentattendance
                                (AttendanceId, StudentId,
                                 AttendanceStatus)
                            VALUES
                                (@sessionId, @studentId,
                                 @statusId)";
                    }
                    MySqlCommand cmd =
                        new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue(
                        "@sessionId", sessionId);
                    cmd.Parameters.AddWithValue(
                        "@studentId", studentId);
                    cmd.Parameters.AddWithValue(
                        "@statusId", statusId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception(
                    "Error saving attendance: " + ex.Message);
            }
        }

        // Get attendance status lookup
        public List<Lookup> GetAttendanceStatuses()
        {
            var list = new List<Lookup>();
            try
            {
                using (MySqlConnection con =
                    DBHelper.GetConnection())
                {
                    string query = @"
                        SELECT LookupId, Name, Category
                        FROM lookup
                        WHERE Category = 'ATTENDANCE_STATUS'";
                    MySqlCommand cmd =
                        new MySqlCommand(query, con);
                    con.Open();
                    MySqlDataReader reader =
                        cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new Lookup
                        {
                            LookupId =
                                (int)reader["LookupId"],
                            Name = reader["Name"].ToString(),
                            Category =
                                reader["Category"].ToString()
                        });
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception(
                    "Error loading statuses: " + ex.Message);
            }
            return list;
        }

        // Get attendance summary for a student
        public AttendanceSummary GetStudentSummary(
            int studentId)
        {
            try
            {
                using (MySqlConnection con =
                    DBHelper.GetConnection())
                {
                    string query = @"
                        SELECT
                            COUNT(DISTINCT ca.Id) as Total,
                            SUM(CASE WHEN sa.AttendanceStatus=1
                                THEN 1 ELSE 0 END) as Present,
                            SUM(CASE WHEN sa.AttendanceStatus=2
                                THEN 1 ELSE 0 END) as Absent,
                            SUM(CASE WHEN sa.AttendanceStatus=3
                                THEN 1 ELSE 0 END) as Leave,
                            SUM(CASE WHEN sa.AttendanceStatus=4
                                THEN 1 ELSE 0 END) as Late
                        FROM classattendance ca
                        LEFT JOIN studentattendance sa
                            ON ca.Id = sa.AttendanceId
                            AND sa.StudentId = @sid";
                    MySqlCommand cmd =
                        new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue(
                        "@sid", studentId);
                    con.Open();
                    MySqlDataReader reader =
                        cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return new AttendanceSummary
                        {
                            Total =
                                (int)reader["Total"],
                            Present =
                                reader["Present"] ==
                                DBNull.Value ? 0 :
                                (int)reader["Present"],
                            Absent =
                                reader["Absent"] ==
                                DBNull.Value ? 0 :
                                (int)reader["Absent"],
                            Leave =
                                reader["Leave"] ==
                                DBNull.Value ? 0 :
                                (int)reader["Leave"],
                            Late =
                                reader["Late"] ==
                                DBNull.Value ? 0 :
                                (int)reader["Late"]
                        };
                    }
                }
            }
            catch { }
            return new AttendanceSummary();
        }
    }

    // Helper classes
    public class StudentAttendanceView
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string RegistrationNumber { get; set; }
        public int StatusId { get; set; }
        public string StatusName { get; set; }
    }

    public class ClassAttendance
    {
        public int Id { get; set; }
        public DateTime AttendanceDate { get; set; }
        public override string ToString() =>
            AttendanceDate.ToString("dd MMM yyyy - dddd");
    }

    public class AttendanceSummary
    {
        public int Total { get; set; }
        public int Present { get; set; }
        public int Absent { get; set; }
        public int Leave { get; set; }
        public int Late { get; set; }
        public decimal Percentage => Total > 0 ?
            ((decimal)Present / Total * 100) : 0;
    }
}