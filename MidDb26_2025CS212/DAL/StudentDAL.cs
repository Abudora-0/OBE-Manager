using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using MidDb26_2025CS212.Helpers;
using MidDb26_2025CS212.Models;

namespace MidDb26_2025CS212.DAL
{
    public class StudentDAL
    {
        // Gets all Students with their status names
        public List<Student> GetAllStudents()
        {
            var list = new List<Student>();
            try
            {
                using (MySqlConnection con = DBHelper.GetConnection())
                {
                    string query = @"
                        SELECT s.Id, s.FirstName, s.LastName, 
                               s.Contact, s.Email, 
                               s.RegistrationNumber, s.Status,
                               l.Name as StatusName
                        FROM student s
                        INNER JOIN lookup l ON s.Status = l.LookupId
                        ORDER BY s.Id ASC";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    con.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(MapReader(reader));
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error loading students: " + ex.Message);
            }
            return list;
        }

        // Gets single student by ID 
        public Student GetById(int id)
        {
            try
            {
                using (MySqlConnection con = DBHelper.GetConnection())
                {
                    string query = @"
                        SELECT s.Id, s.FirstName, s.LastName,
                               s.Contact, s.Email,
                               s.RegistrationNumber, s.Status,
                               l.Name as StatusName
                        FROM student s
                        INNER JOIN lookup l ON s.Status = l.LookupId
                        WHERE s.Id = @id";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                        return MapReader(reader);
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error finding student: " + ex.Message);
            }
            return null;
        }

        // Add a new student to the database
        public bool Add(Student s)
        {
            try
            {
                using (MySqlConnection con = DBHelper.GetConnection())
                {
                    string query = @"
                        INSERT INTO student 
                            (FirstName, LastName, Contact, Email, 
                             RegistrationNumber, Status)
                        VALUES 
                            (@fn, @ln, @contact, @email, @reg, @status)";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@fn", s.FirstName);
                    cmd.Parameters.AddWithValue("@ln", s.LastName ?? "");
                    cmd.Parameters.AddWithValue("@contact", s.Contact ?? "");
                    cmd.Parameters.AddWithValue("@email", s.Email);
                    cmd.Parameters.AddWithValue("@reg", s.RegistrationNumber);
                    cmd.Parameters.AddWithValue("@status", s.Status);
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error adding student: " + ex.Message);
            }
        }

        // Update existing student details
        public bool Update(Student s)
        {
            try
            {
                using (MySqlConnection con = DBHelper.GetConnection())
                {
                    string query = @"
                        UPDATE student 
                        SET FirstName = @fn,
                            LastName = @ln,
                            Contact = @contact,
                            Email = @email,
                            RegistrationNumber = @reg,
                            Status = @status
                        WHERE Id = @id";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@fn", s.FirstName);
                    cmd.Parameters.AddWithValue("@ln", s.LastName ?? "");
                    cmd.Parameters.AddWithValue("@contact", s.Contact ?? "");
                    cmd.Parameters.AddWithValue("@email", s.Email);
                    cmd.Parameters.AddWithValue("@reg", s.RegistrationNumber);
                    cmd.Parameters.AddWithValue("@status", s.Status);
                    cmd.Parameters.AddWithValue("@id", s.Id);
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error updating student: " + ex.Message);
            }
        }

        // Delete a student by ID
        public bool Delete(int id)
        {
            try
            {
                using (MySqlConnection con = DBHelper.GetConnection())
                {
                    string query = "DELETE FROM student WHERE Id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error deleting student: " + ex.Message);
            }
        }

        // Search students by keyword in first name, last name, or registration number
        public List<Student> Search(string keyword)
        {
            var list = new List<Student>();
            try
            {
                using (MySqlConnection con = DBHelper.GetConnection())
                {
                    string query = @"
                        SELECT s.Id, s.FirstName, s.LastName,
                               s.Contact, s.Email,
                               s.RegistrationNumber, s.Status,
                               l.Name as StatusName
                        FROM student s
                        INNER JOIN lookup l ON s.Status = l.LookupId
                        WHERE s.FirstName LIKE @kw 
                           OR s.LastName LIKE @kw
                           OR s.RegistrationNumber LIKE @kw
                        ORDER BY s.Id ASC";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");
                    con.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(MapReader(reader));
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error searching students: " + ex.Message);
            }
            return list;
        }

        // Get lookup values for student status dropdown
        public List<Lookup> GetStatusLookup()
        {
            var list = new List<Lookup>();
            try
            {
                using (MySqlConnection con = DBHelper.GetConnection())
                {
                    string query = @"
                        SELECT LookupId, Name, Category 
                        FROM lookup 
                        WHERE Category = 'STUDENT_STATUS'";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    con.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new Lookup
                        {
                            LookupId = (int)reader["LookupId"],
                            Name = reader["Name"].ToString(),
                            Category = reader["Category"].ToString()
                        });
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error loading status list: " + ex.Message);
            }
            return list;
        }

        // Private helper method to map data reader to Student object
        private Student MapReader(MySqlDataReader r)
        {
            return new Student
            {
                Id = (int)r["Id"],
                FirstName = r["FirstName"].ToString(),
                LastName = r["LastName"].ToString(),
                Contact = r["Contact"].ToString(),
                Email = r["Email"].ToString(),
                RegistrationNumber = r["RegistrationNumber"].ToString(),
                Status = (int)r["Status"],
                StatusName = r["StatusName"].ToString()
            };
        }
    }
}
