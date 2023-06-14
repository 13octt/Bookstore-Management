using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore_Management
{
    public partial class ThongKe : UserControl
    {
        String connectionString;
        private DatabaseConnection databaseConnection;
        SqlConnection connection;
        public ThongKe()
        {
            InitializeComponent();

            databaseConnection = new DatabaseConnection();
            connection = databaseConnection.OpenConnection();

            int tongKH = CountKhachHang();
            label_KhachHang.Text = tongKH.ToString();
            int tongSachNhap = CountSachNhap();
            label_TongSachNhap.Text = tongSachNhap.ToString();
            int tongSachBan = CountSachBan();
            label_TongSachBan.Text = tongSachBan.ToString();

        }

        public int CountKhachHang()
        {
            string query = "SELECT COUNT(DISTINCT MaKH) AS TongSoKhachHang FROM KHACHHANG";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                int totalCount = (int)command.ExecuteScalar();
                return totalCount;
            }
        }

        public int CountSachNhap()
        {
            string query = "SELECT SUM(SachDaNhap) FROM BAOCAOTONKHO";
            using(SqlCommand command = new SqlCommand(query, connection))
            {
                int totalCount = (int)command.ExecuteScalar();
                return totalCount;
            }
        }

        public int CountSachBan()
        {
            string query = "SELECT SUM(SachDaBan) FROM BAOCAOTONKHO";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                int totalCount = (int)command.ExecuteScalar();
                return totalCount;
            }
        }
    }
}
