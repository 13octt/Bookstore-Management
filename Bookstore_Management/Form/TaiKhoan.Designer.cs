
namespace Bookstore_Management
{
    partial class TaiKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_Avatar = new System.Windows.Forms.PictureBox();
            this.pictureBox_Exit = new System.Windows.Forms.PictureBox();
            this.panel_TaiKhoan = new System.Windows.Forms.Panel();
            this.button_Add = new System.Windows.Forms.Button();
            this.textBox_MatKhau = new System.Windows.Forms.TextBox();
            this.textBox_TenTK = new System.Windows.Forms.TextBox();
            this.comboBox_MaND = new System.Windows.Forms.ComboBox();
            this.comboBox_VaiTro = new System.Windows.Forms.ComboBox();
            this.comboBox_MaTK = new System.Windows.Forms.ComboBox();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_TaiKhoan = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exit)).BeginInit();
            this.panel_TaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox_Avatar);
            this.panel1.Controls.Add(this.pictureBox_Exit);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(902, 54);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SlateBlue;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(384, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "ACCOUNT";
            // 
            // pictureBox_Avatar
            // 
            this.pictureBox_Avatar.BackgroundImage = global::Bookstore_Management.Properties.Resources.friendlist1;
            this.pictureBox_Avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Avatar.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_Avatar.Name = "pictureBox_Avatar";
            this.pictureBox_Avatar.Size = new System.Drawing.Size(44, 43);
            this.pictureBox_Avatar.TabIndex = 5;
            this.pictureBox_Avatar.TabStop = false;
            // 
            // pictureBox_Exit
            // 
            this.pictureBox_Exit.BackgroundImage = global::Bookstore_Management.Properties.Resources.multiply;
            this.pictureBox_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Exit.Location = new System.Drawing.Point(858, 8);
            this.pictureBox_Exit.Name = "pictureBox_Exit";
            this.pictureBox_Exit.Size = new System.Drawing.Size(38, 36);
            this.pictureBox_Exit.TabIndex = 1;
            this.pictureBox_Exit.TabStop = false;
            this.pictureBox_Exit.Click += new System.EventHandler(this.pictureBox_Exit_Click);
            // 
            // panel_TaiKhoan
            // 
            this.panel_TaiKhoan.BackColor = System.Drawing.Color.White;
            this.panel_TaiKhoan.Controls.Add(this.button_Add);
            this.panel_TaiKhoan.Controls.Add(this.textBox_MatKhau);
            this.panel_TaiKhoan.Controls.Add(this.textBox_TenTK);
            this.panel_TaiKhoan.Controls.Add(this.comboBox_MaND);
            this.panel_TaiKhoan.Controls.Add(this.comboBox_VaiTro);
            this.panel_TaiKhoan.Controls.Add(this.comboBox_MaTK);
            this.panel_TaiKhoan.Controls.Add(this.button_Delete);
            this.panel_TaiKhoan.Controls.Add(this.button_Save);
            this.panel_TaiKhoan.Controls.Add(this.label6);
            this.panel_TaiKhoan.Controls.Add(this.label5);
            this.panel_TaiKhoan.Controls.Add(this.label4);
            this.panel_TaiKhoan.Controls.Add(this.label3);
            this.panel_TaiKhoan.Controls.Add(this.label2);
            this.panel_TaiKhoan.Controls.Add(this.dataGridView_TaiKhoan);
            this.panel_TaiKhoan.Location = new System.Drawing.Point(12, 74);
            this.panel_TaiKhoan.Name = "panel_TaiKhoan";
            this.panel_TaiKhoan.Size = new System.Drawing.Size(876, 642);
            this.panel_TaiKhoan.TabIndex = 3;
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(188)))));
            this.button_Add.FlatAppearance.BorderSize = 0;
            this.button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add.ForeColor = System.Drawing.Color.White;
            this.button_Add.Location = new System.Drawing.Point(33, 572);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(235, 49);
            this.button_Add.TabIndex = 18;
            this.button_Add.Text = "THÊM";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // textBox_MatKhau
            // 
            this.textBox_MatKhau.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MatKhau.Location = new System.Drawing.Point(195, 503);
            this.textBox_MatKhau.Name = "textBox_MatKhau";
            this.textBox_MatKhau.Size = new System.Drawing.Size(202, 30);
            this.textBox_MatKhau.TabIndex = 17;
            this.textBox_MatKhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_MatKhau.TextChanged += new System.EventHandler(this.textBox_MatKhau_TextChanged);
            // 
            // textBox_TenTK
            // 
            this.textBox_TenTK.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TenTK.Location = new System.Drawing.Point(195, 460);
            this.textBox_TenTK.Name = "textBox_TenTK";
            this.textBox_TenTK.Size = new System.Drawing.Size(202, 30);
            this.textBox_TenTK.TabIndex = 16;
            this.textBox_TenTK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_TenTK.TextChanged += new System.EventHandler(this.textBox_TenTK_TextChanged);
            // 
            // comboBox_MaND
            // 
            this.comboBox_MaND.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_MaND.FormattingEnabled = true;
            this.comboBox_MaND.Location = new System.Drawing.Point(663, 419);
            this.comboBox_MaND.Name = "comboBox_MaND";
            this.comboBox_MaND.Size = new System.Drawing.Size(163, 31);
            this.comboBox_MaND.TabIndex = 15;
            this.comboBox_MaND.SelectedIndexChanged += new System.EventHandler(this.comboBox_MaND_SelectedIndexChanged);
            // 
            // comboBox_VaiTro
            // 
            this.comboBox_VaiTro.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_VaiTro.FormattingEnabled = true;
            this.comboBox_VaiTro.Location = new System.Drawing.Point(663, 463);
            this.comboBox_VaiTro.Name = "comboBox_VaiTro";
            this.comboBox_VaiTro.Size = new System.Drawing.Size(163, 32);
            this.comboBox_VaiTro.TabIndex = 14;
            this.comboBox_VaiTro.SelectedIndexChanged += new System.EventHandler(this.comboBox_VaiTro_SelectedIndexChanged);
            // 
            // comboBox_MaTK
            // 
            this.comboBox_MaTK.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_MaTK.FormattingEnabled = true;
            this.comboBox_MaTK.Location = new System.Drawing.Point(195, 415);
            this.comboBox_MaTK.Name = "comboBox_MaTK";
            this.comboBox_MaTK.Size = new System.Drawing.Size(202, 31);
            this.comboBox_MaTK.TabIndex = 13;
            this.comboBox_MaTK.SelectedIndexChanged += new System.EventHandler(this.comboBox_MaTK_SelectedIndexChanged);
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.Crimson;
            this.button_Delete.FlatAppearance.BorderSize = 0;
            this.button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Delete.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.ForeColor = System.Drawing.Color.White;
            this.button_Delete.Location = new System.Drawing.Point(315, 572);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(235, 49);
            this.button_Delete.TabIndex = 12;
            this.button_Delete.Text = "XÓA";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.Indigo;
            this.button_Save.FlatAppearance.BorderSize = 0;
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Save.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save.ForeColor = System.Drawing.Color.White;
            this.button_Save.Location = new System.Drawing.Point(591, 572);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(235, 49);
            this.button_Save.TabIndex = 11;
            this.button_Save.Text = "CẬP NHẬT";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.HotPink;
            this.label6.Location = new System.Drawing.Point(477, 463);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Vai trò:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.HotPink;
            this.label5.Location = new System.Drawing.Point(477, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mã người dùng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.HotPink;
            this.label4.Location = new System.Drawing.Point(29, 510);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mật khẩu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.HotPink;
            this.label3.Location = new System.Drawing.Point(29, 467);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.HotPink;
            this.label2.Location = new System.Drawing.Point(29, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã tài khoản:";
            // 
            // dataGridView_TaiKhoan
            // 
            this.dataGridView_TaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TaiKhoan.Location = new System.Drawing.Point(33, 13);
            this.dataGridView_TaiKhoan.Name = "dataGridView_TaiKhoan";
            this.dataGridView_TaiKhoan.RowHeadersWidth = 51;
            this.dataGridView_TaiKhoan.RowTemplate.Height = 24;
            this.dataGridView_TaiKhoan.Size = new System.Drawing.Size(809, 374);
            this.dataGridView_TaiKhoan.TabIndex = 0;
            // 
            // TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 728);
            this.Controls.Add(this.panel_TaiKhoan);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaiKhoan";
            this.Load += new System.EventHandler(this.TaiKhoan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exit)).EndInit();
            this.panel_TaiKhoan.ResumeLayout(false);
            this.panel_TaiKhoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TaiKhoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_Avatar;
        private System.Windows.Forms.PictureBox pictureBox_Exit;
        private System.Windows.Forms.Panel panel_TaiKhoan;
        private System.Windows.Forms.DataGridView dataGridView_TaiKhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_MaND;
        private System.Windows.Forms.ComboBox comboBox_VaiTro;
        private System.Windows.Forms.ComboBox comboBox_MaTK;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.TextBox textBox_MatKhau;
        private System.Windows.Forms.TextBox textBox_TenTK;
        private System.Windows.Forms.Button button_Add;
    }
}