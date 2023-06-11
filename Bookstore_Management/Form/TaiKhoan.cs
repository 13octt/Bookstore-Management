using System;
using System.Collections;
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
    public partial class TaiKhoan : Form
    {
        String maTK, tenTK, maND, matKhau, vaiTro;
        private string connectionString;
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable dataTable;
        public TaiKhoan()
        {
            InitializeComponent();

            connectionString = "Data Source=DESKTOP-EQ1GSOP\\SQLEXPRESS;Initial Catalog=QLNS;Integrated Security=True;";
            connection = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter();
            dataTable = new DataTable();

            referenceUI();

        }

        private void pictureBox_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            referenceUI();
            AddAccount(maTK, tenTK, matKhau, maND, vaiTro);
            UpdateGridView();
            //CleanData();
            //UpdateGridView();
        }


        private void button_Save_Click(object sender, EventArgs e)
        {

            referenceUI();
            updateAccount(maTK, tenTK, matKhau, maND, vaiTro);

            // Cập nhật GridView
            UpdateGridView();
            // Xóa trắng các trường nhập liệu
            CleanData();
            UpdateGridView();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            // Xoa Tai Khoan
            referenceUI();
            deleteAccount(maTK);
            LoadDataToGridView();
            CleanData();
            UpdateGridView();
        }


        // Seach and show to GridView

        private void comboBox_MaTK_SelectedIndexChanged(object sender, EventArgs e){ findAccount();}

        private void textBox_TenTK_TextChanged(object sender, EventArgs e){ findAccount(); }

        private void textBox_MatKhau_TextChanged(object sender, EventArgs e){ findAccount(); }

        private void comboBox_MaND_SelectedIndexChanged(object sender, EventArgs e){ findAccount(); }

        private void comboBox_VaiTro_SelectedIndexChanged(object sender, EventArgs e){ findAccount(); }


        private void referenceUI()
        {
            maTK = comboBox_MaTK.Text;
            tenTK = textBox_TenTK.Text;
            matKhau = textBox_MatKhau.Text;
            maND = comboBox_MaND.Text;
            vaiTro = comboBox_VaiTro.Text;
        }

        private void CleanData()
        {
            comboBox_MaTK.Text = "";
            textBox_TenTK.Text = "";
            textBox_MatKhau.Text = "";
            comboBox_MaND.Text = "";
            comboBox_VaiTro.Text = "";
        }


        private void findAccount()
        {

            string query = "SELECT * FROM TAIKHOAN WHERE " +
                "MaTK LIKE @MaTK AND " +
                "TenTK LIKE @TenTK AND " +
                "MatKhau LIKE @MatKhau AND " +
                "MaNguoiDung LIKE @MaNguoiDung AND " +
                "VaiTro LIKE @VaiTro";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MaTK", "%" + maTK + "%");
            command.Parameters.AddWithValue("@TenTK", "%" + tenTK + "%");
            command.Parameters.AddWithValue("@MatKhau", "%" + matKhau + "%");
            command.Parameters.AddWithValue("@MaNguoiDung", "%" + maND + "%");
            command.Parameters.AddWithValue("@VaiTro", "%" + vaiTro + "%");

            adapter.SelectCommand = command;

            try
            {
                connection.Open();

                dataTable.Clear(); 
                adapter.Fill(dataTable);

                dataGridView_TaiKhoan.DataSource = dataTable;
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

        private void updateAccount(string maTK, string tenTK, string matKhau, string maNguoiDung, string vaiTro)
        {
            // Kiểm tra điều kiện nhập không được để trống
            if (string.IsNullOrEmpty(maTK) || string.IsNullOrEmpty(tenTK) || string.IsNullOrEmpty(matKhau) || string.IsNullOrEmpty(maNguoiDung) || string.IsNullOrEmpty(vaiTro))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE TAIKHOAN SET TenTK = @TenTK, MatKhau = @MatKhau, MaNguoiDung = @MaNguoiDung, VaiTro = @VaiTro WHERE MaTK = @MaTK";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TenTK", tenTK);
                    command.Parameters.AddWithValue("@MatKhau", matKhau);
                    command.Parameters.AddWithValue("@MaNguoiDung", maNguoiDung);
                    command.Parameters.AddWithValue("@VaiTro", vaiTro);
                    command.Parameters.AddWithValue("@MaTK", maTK);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            UpdateGridView();
        }

        private void UpdateGridView()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Mở kết nối đến database
                connection.Open();

                // Tạo câu truy vấn SQL để lấy danh sách tài khoản
                string query = "SELECT MaTK, TenTK, MatKhau, MaNguoiDung, VaiTro FROM TAIKHOAN";

                // Tạo đối tượng SqlCommand để thực hiện câu truy vấn
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Tạo đối tượng SqlDataAdapter để lấy dữ liệu từ SqlCommand
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    // Tạo đối tượng DataTable để lưu trữ dữ liệu từ SqlDataAdapter
                    DataTable dataTable = new DataTable();

                    // Đổ dữ liệu vào DataTable
                    adapter.Fill(dataTable);

                    // Gán DataTable làm nguồn dữ liệu cho GridView
                    dataGridView_TaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_TaiKhoan.DataSource = dataTable;

                    //dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void AddAccount(string maTK, string tenTK, string matKhau, string maNguoiDung, string vaiTro)
        {
            // Kiểm tra điều kiện nhập không được để trống
            if (string.IsNullOrWhiteSpace(maTK) || string.IsNullOrWhiteSpace(tenTK) ||
                string.IsNullOrWhiteSpace(matKhau) || string.IsNullOrWhiteSpace(maNguoiDung) ||
                string.IsNullOrWhiteSpace(vaiTro))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Thực hiện thêm tài khoản vào database
            // (sử dụng câu lệnh INSERT INTO)
            string query = "INSERT INTO TAIKHOAN (MaTK, TenTK, MatKhau, MaNguoiDung, VaiTro) " +
                           "VALUES (@MaTK, @TenTK, @MatKhau, @MaNguoiDung, @VaiTro)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaTK", maTK);
                command.Parameters.AddWithValue("@TenTK", tenTK);
                command.Parameters.AddWithValue("@MatKhau", matKhau);
                command.Parameters.AddWithValue("@MaNguoiDung", maNguoiDung);
                command.Parameters.AddWithValue("@VaiTro", vaiTro);
                command.ExecuteNonQuery();
            }

            // Cập nhật dữ liệu lên GridView
            LoadDataToGridView();
            //UpdateGridView();
        }



        private void addAccount()
        {
            
            //if (comboBox_MaTK.Text == "" || comboBox_MaND.Text == "" || comboBox_VaiTro.Text == ""
            //                || textBox_TenTK.Text == "" || textBox_MatKhau.Text == "")
            //{
            //    MessageBox.Show("Vui lòng điền đủ thông tin");
            //}
            //else
            //{
            //    bool flag = false;
            //    if(dataGridView_TaiKhoan.Rows.Count != 0) 
            //    {
            //        foreach (var i in comboBox_MaTK.Items)
            //            if (i.ToString().Trim() == comboBox_MaTK.Text.Trim())
            //            {
            //                flag = true;
            //                break;
            //            }
            //    }

            //    string query = "INSERT INTO TAIKHOAN (MaTK, TenTK, MatKhau, MaNguoiDung, VaiTro) VALUES (@MaTK, @TenTK, @MatKhau, @MaNguoiDung, @VaiTro)";
            //}
        }

        private void deleteAccount(String maTK)
        {
            // Kiểm tra điều kiện nhập không được để trống
            if (string.IsNullOrWhiteSpace(maTK))
            {
                MessageBox.Show("Vui lòng nhập mã tài khoản cần xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Thực hiện xóa tài khoản từ database
            // (sử dụng câu lệnh DELETE)
            string query = "DELETE FROM TAIKHOAN WHERE MaTK = @MaTK";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaTK", maTK);
                command.ExecuteNonQuery();
            }
        }

        private void LoadDataToGridView()
        {
            string query = "SELECT * FROM TAIKHOAN";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView_TaiKhoan.DataSource = dataTable;
                //dataGridView.DataSource = dataTable;
            }
        }


    }
}
