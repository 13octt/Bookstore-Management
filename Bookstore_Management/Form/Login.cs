﻿using System;
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
    public partial class Login : Form
    {
        DatabaseConnection databaseConnection;
        SqlConnection connection;
        public Login()
        {
            InitializeComponent();
            databaseConnection = new DatabaseConnection();
            connection = databaseConnection.OpenConnection();
        }

        private void pictureBox_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            this.Hide();

            string username = textBox_TenTK.Text;
            string password = textBox_MatKhau.Text;

            if (AuthenticateUser(username, password))
            {
                MessageBox.Show("Đăng nhập thành công");
                DashBoard main = new DashBoard();
                main.Show();

            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                //this.Close();
                Login login = new Login();
                login.Show();
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            bool isAuthenticated = false;
            string query = "SELECT COUNT(*) FROM TAIKHOAN WHERE TenTK = @Username AND MatKhau = @Password";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);
            int count = (int)command.ExecuteScalar();
            if (count > 0)
            {
                isAuthenticated = true;
            }
            return isAuthenticated;
        }
    }
}
