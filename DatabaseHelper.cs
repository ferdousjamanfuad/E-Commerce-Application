using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace BakeryShopManagementSystem
{
    public class DatabaseHelper
    {
        private static string conn = "Server=localhost;Database=bakerydb;Uid=root;Pwd=;";

        public static DataTable GetData(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(conn))
                {
                    connection.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return dt;
        }

        public static bool Execute(string query)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(conn))
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        public static object GetValue(string query)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(conn))
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        return cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }
    }

    public static class Session
    {
        public static int UserId { get; set; }
        public static string Name { get; set; }
        public static string Role { get; set; }

    }
}
