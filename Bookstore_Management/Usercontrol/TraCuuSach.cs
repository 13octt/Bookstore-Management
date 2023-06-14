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
        DatabaseConnection databaseConnection;

        public TraCuuSach()
        {
            InitializeComponent();

            databaseConnection = new DatabaseConnection();
            connection = databaseConnection.OpenConnection();

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
            String bookTitle = textBox_TenSach.Text;
            String bookCategory = textBox_TheLoai.Text;
            string query = "SELECT * FROM THONGTINSACH WHERE TenSach LIKE @BookName AND TheLoai LIKE @Category";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BookName", "%" + bookTitle + "%");
            command.Parameters.AddWithValue("@Category", "%" + bookCategory + "%");
            adapter.SelectCommand = command;

            try
            {
                dataTable.Clear(); 
                adapter.Fill(dataTable);
                dataGridView_NhapSach.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy vấn: " + ex.Message);
            }
            finally
            {
                databaseConnection.CloseConnection();
            }
        }

        private void UpdateGridView()
        {
            string query = "SELECT * FROM THONGTINSACH";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView_NhapSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView_NhapSach.DataSource = dataTable;
            }
        }

        private void TraCuuSach_Load_1(object sender, EventArgs e)
        {
            UpdateGridView();
        }
    }
}
