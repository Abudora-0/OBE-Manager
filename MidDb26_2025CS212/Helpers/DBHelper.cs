using System;
using MySql.Data.MySqlClient;

namespace MidDb26_2025CS212.Helpers
{
    public class DBHelper
    {
        private static readonly string connectionString =
            "Server=localhost;Database=projectbdb26;Uid=root;Pwd=T9x!mQ7#vL2@rZ8;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public static bool TestConnection()
        {
            try
            {
                using (MySqlConnection con = GetConnection())
                {
                    con.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}