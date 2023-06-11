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
    public partial class TraCuuSach : UserControl
    {
        private string connectionString;
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable dataTable;

        public TraCuuSach()
        {
            InitializeComponent();
            connectionString= "Data Source=DESKTOP-EQ1GSOP\\SQLEXPRESS;Initial Catalog=QLNS;Integrated Security=True;";
            connection = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter();
            dataTable = new DataTable();
        }

        private void textBox_TenSach_TextChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void textBox_TheLoai_TextChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void PerformSearch()
        {
            //
            String bookTitle = textBox_TenSach.Text;
            String bookCategory = textBox_TheLoai.Text;
            string query = "SELECT * FROM THONGTINSACH WHERE TenSach LIKE @BookName AND TheLoai LIKE @Category";

            // Tạo đối tượng SqlCommand
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BookName", "%" + bookTitle + "%");
            command.Parameters.AddWithValue("@Category", "%" + bookCategory + "%");

            // Gán SqlCommand cho SqlDataAdapter
            adapter.SelectCommand = command;

            try
            {
                // Mở kết nối
                connection.Open();

                // Đổ dữ liệu từ database vào DataTable
                dataTable.Clear(); // Xóa dữ liệu cũ trước khi đổ mới
                adapter.Fill(dataTable);

                // Hiển thị kết quả tra cứu trên GridView
                dataGridView_NhapSach.DataSource = dataTable;
                //dataGridViewBooks.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                // Xử lý exception (nếu cần)
                MessageBox.Show("Lỗi truy vấn: " + ex.Message);
            }
            finally
            {
                // Đóng kết nối
                connection.Close();
            }

        }

    }
}
