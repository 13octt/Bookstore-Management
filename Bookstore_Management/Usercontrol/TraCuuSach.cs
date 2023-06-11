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
            String bookTitle = textBox_TenSach.Text;
            String bookCategory = textBox_TheLoai.Text;
            string query = "SELECT * FROM THONGTINSACH WHERE TenSach LIKE @BookName AND TheLoai LIKE @Category";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BookName", "%" + bookTitle + "%");
            command.Parameters.AddWithValue("@Category", "%" + bookCategory + "%");
            adapter.SelectCommand = command;

            try
            {
                connection.Open();
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
                connection.Close();
            }

        }

        private void TraCuuSach_Load(object sender, EventArgs e)
        {
            //UpdateGridView();
            //PerformSearch();
        }

        private void UpdateGridView()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

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
        }

        private void TraCuuSach_Load_1(object sender, EventArgs e)
        {
            UpdateGridView();
        }
    }
}
