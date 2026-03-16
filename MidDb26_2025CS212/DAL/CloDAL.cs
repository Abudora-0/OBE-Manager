using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using MidDb26_2025CS212.Helpers;
using MidDb26_2025CS212.Models;

namespace MidDb26_2025CS212.DAL
{
    public class CloDAL
    {
        public List<Clo> GetAll()
        {
            var list = new List<Clo>();
            try
            {
                using (MySqlConnection con = DBHelper.GetConnection())
                {
                    string query = @"
                        SELECT Id, Name, DateCreated, DateUpdated 
                        FROM clo 
                        ORDER BY Id ASC";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    con.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                        list.Add(MapReader(reader));
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error loading CLOs: " + ex.Message);
            }
            return list;
        }

        public bool Add(Clo c)
        {
            try
            {
                using (MySqlConnection con = DBHelper.GetConnection())
                {
                    string query = @"
                        INSERT INTO clo (Name, DateCreated, DateUpdated)
                        VALUES (@name, @created, @updated)";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@name", c.Name);
                    cmd.Parameters.AddWithValue("@created", DateTime.Now);
                    cmd.Parameters.AddWithValue("@updated", DateTime.Now);
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error adding CLO: " + ex.Message);
            }
        }

        public bool Update(Clo c)
        {
            try
            {
                using (MySqlConnection con = DBHelper.GetConnection())
                {
                    string query = @"
                        UPDATE clo 
                        SET Name = @name, DateUpdated = @updated
                        WHERE Id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@name", c.Name);
                    cmd.Parameters.AddWithValue("@updated", DateTime.Now);
                    cmd.Parameters.AddWithValue("@id", c.Id);
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error updating CLO: " + ex.Message);
            }
        }

        public bool Delete(int id)
        {
            try
            {
                using (MySqlConnection con = DBHelper.GetConnection())
                {
                    string query = "DELETE FROM clo WHERE Id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error deleting CLO: " + ex.Message);
            }
        }

        public List<Clo> Search(string keyword)
        {
            var list = new List<Clo>();
            try
            {
                using (MySqlConnection con = DBHelper.GetConnection())
                {
                    string query = @"
                        SELECT Id, Name, DateCreated, DateUpdated 
                        FROM clo 
                        WHERE Name LIKE @kw
                        ORDER BY Id ASC";
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
                throw new Exception("Error searching CLOs: " + ex.Message);
            }
            return list;
        }

        private Clo MapReader(MySqlDataReader r)
        {
            return new Clo
            {
                Id = (int)r["Id"],
                Name = r["Name"].ToString(),
                DateCreated = (DateTime)r["DateCreated"],
                DateUpdated = (DateTime)r["DateUpdated"]
            };
        }
    }
}