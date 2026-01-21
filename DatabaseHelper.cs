using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BakeryShopManagementSystem
{
    public class DatabaseHelper
    {
        private static string conn =@"Data Source=localhost\SQLEXPRESS;Initial Catalog=bakerydb;Integrated Security=True";
        public static DataTable GetData(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
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
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
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
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
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
