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
    public partial class LichSuBanSach : UserControl
    {
        SqlConnection connection;
        public LichSuBanSach()
        {
            InitializeComponent();
            String connectionString = "Data Source=DESKTOP-EQ1GSOP\\SQLEXPRESS;Initial Catalog=QLNS;Integrated Security=True;";
            connection = new SqlConnection(connectionString);
            UpdateGridView();

        }

        private void UpdateGridView()
        {

            connection.Open();
            string query = "SELECT * FROM HOADON";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView_LichSuBan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView_LichSuBan.DataSource = dataTable;
            }
            connection.Close();
        }

        private void button_TimKiem_Click(object sender, EventArgs e)
        {

            DateTime selectedDate = dateTimePicker_NgayBan.Value.Date;
            LoadDataToGridView(selectedDate);
        }

        private void dateTimePicker_NgayBan_ValueChanged(object sender, EventArgs e)
        {
            

        }

        private void LoadDataToGridView(DateTime selectedDate)
        {
            string query = "SELECT * FROM HOADON WHERE NgayHD = @NgayHD" ;

            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NgayHD", selectedDate.Date);
            SqlDataReader reader = command.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            dataGridView_LichSuBan.Dock = DockStyle.Fill;
            dataGridView_LichSuBan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridView_LichSuBan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_LichSuBan.DataSource = dataTable;
            reader.Close();
            connection.Close();
        }

    }
}
