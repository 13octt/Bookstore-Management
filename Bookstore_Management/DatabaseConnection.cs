using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore_Management
{
    public class DatabaseConnection
    {
        private SqlConnection connection;
        String connectionString = "Data Source=DESKTOP-EQ1GSOP\\SQLEXPRESS;Initial Catalog=QLNS;Integrated Security=True;";


        public DatabaseConnection()
        {
            // Khởi tạo kết nối
            connection = new SqlConnection(connectionString);
        }

        public SqlConnection OpenConnection()
        {
            // Mở kết nối
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
            return connection;
        }

        public void CloseConnection()
        {
            // Đóng kết nối
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }
    }

}
