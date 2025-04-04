using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace quanlyvattu
{
    internal class Connection
    {// Trong file App.config hoặc một file riêng
        private string connectionString;
        // Kiểm tra kết nối
        public Connection(string database, string username, string password)
        {
            connectionString = $"Data Source=localhost;Initial Catalog={database};User ID={username};Password={password}";
        }

        public bool TestConnection()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
                return false;
            }
        }

        public void closeConnection()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Close();
            }
        }
    }
}
