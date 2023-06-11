
namespace Bookstore_Management
{
    partial class NhapSach
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_Data = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_NhapSach = new System.Windows.Forms.DataGridView();
            this.panel_button = new System.Windows.Forms.Panel();
            this.button_Save = new System.Windows.Forms.Button();
            this.textBox_SL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_MaSach = new System.Windows.Forms.ComboBox();
            this.textBox_DonGia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker_NgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_TacGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_TheLoai = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.textBox_TenSach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_MaSach = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.panel_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NhapSach)).BeginInit();
            this.panel_button.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Data
            // 
            this.panel_Data.Controls.Add(this.label1);
            this.panel_Data.Controls.Add(this.dataGridView_NhapSach);
            this.panel_Data.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Data.Location = new System.Drawing.Point(0, 0);
            this.panel_Data.Name = "panel_Data";
            this.panel_Data.Size = new System.Drawing.Size(907, 414);
            this.panel_Data.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(381, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "NHẬP SÁCH";
            // 
            // dataGridView_NhapSach
            // 
            this.dataGridView_NhapSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_NhapSach.Location = new System.Drawing.Point(36, 66);
            this.dataGridView_NhapSach.Name = "dataGridView_NhapSach";
            this.dataGridView_NhapSach.RowHeadersWidth = 51;
            this.dataGridView_NhapSach.RowTemplate.Height = 24;
            this.dataGridView_NhapSach.Size = new System.Drawing.Size(850, 342);
            this.dataGridView_NhapSach.TabIndex = 0;
            // 
            // panel_button
            // 
            this.panel_button.Controls.Add(this.button_Add);
            this.panel_button.Controls.Add(this.button_Save);
            this.panel_button.Controls.Add(this.textBox_SL);
            this.panel_button.Controls.Add(this.label6);
            this.panel_button.Controls.Add(this.comboBox_MaSach);
            this.panel_button.Controls.Add(this.textBox_DonGia);
            this.panel_button.Controls.Add(this.label5);
            this.panel_button.Controls.Add(this.dateTimePicker_NgayNhap);
            this.panel_button.Controls.Add(this.label4);
            this.panel_button.Controls.Add(this.textBox_TacGia);
            this.panel_button.Controls.Add(this.label3);
            this.panel_button.Controls.Add(this.textBox_TheLoai);
            this.panel_button.Controls.Add(this.label);
            this.panel_button.Controls.Add(this.textBox_TenSach);
            this.panel_button.Controls.Add(this.label2);
            this.panel_button.Controls.Add(this.label_MaSach);
            this.panel_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_button.Location = new System.Drawing.Point(0, 414);
            this.panel_button.Name = "panel_button";
            this.panel_button.Size = new System.Drawing.Size(907, 242);
            this.panel_button.TabIndex = 1;
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.Indigo;
            this.button_Save.FlatAppearance.BorderSize = 0;
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Save.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save.ForeColor = System.Drawing.Color.White;
            this.button_Save.Location = new System.Drawing.Point(524, 189);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(235, 49);
            this.button_Save.TabIndex = 41;
            this.button_Save.Text = "CẬP NHẬT";
            this.button_Save.UseVisualStyleBackColor = false;
            // 
            // textBox_SL
            // 
            this.textBox_SL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SL.Location = new System.Drawing.Point(789, 20);
            this.textBox_SL.Name = "textBox_SL";
            this.textBox_SL.Size = new System.Drawing.Size(96, 30);
            this.textBox_SL.TabIndex = 40;
            this.textBox_SL.Text = "150";
            this.textBox_SL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.HotPink;
            this.label6.Location = new System.Drawing.Point(687, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 23);
            this.label6.TabIndex = 39;
            this.label6.Text = "Số lượng:";
            // 
            // comboBox_MaSach
            // 
            this.comboBox_MaSach.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_MaSach.FormattingEnabled = true;
            this.comboBox_MaSach.Location = new System.Drawing.Point(144, 20);
            this.comboBox_MaSach.Name = "comboBox_MaSach";
            this.comboBox_MaSach.Size = new System.Drawing.Size(163, 31);
            this.comboBox_MaSach.TabIndex = 38;
            // 
            // textBox_DonGia
            // 
            this.textBox_DonGia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_DonGia.Location = new System.Drawing.Point(472, 125);
            this.textBox_DonGia.Name = "textBox_DonGia";
            this.textBox_DonGia.Size = new System.Drawing.Size(168, 30);
            this.textBox_DonGia.TabIndex = 37;
            this.textBox_DonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.HotPink;
            this.label5.Location = new System.Drawing.Point(369, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 23);
            this.label5.TabIndex = 36;
            this.label5.Text = "Đơn giá:";
            // 
            // dateTimePicker_NgayNhap
            // 
            this.dateTimePicker_NgayNhap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_NgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_NgayNhap.Location = new System.Drawing.Point(144, 122);
            this.dateTimePicker_NgayNhap.Name = "dateTimePicker_NgayNhap";
            this.dateTimePicker_NgayNhap.Size = new System.Drawing.Size(149, 30);
            this.dateTimePicker_NgayNhap.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.HotPink;
            this.label4.Location = new System.Drawing.Point(32, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 23);
            this.label4.TabIndex = 34;
            this.label4.Text = "Ngày nhập:";
            // 
            // textBox_TacGia
            // 
            this.textBox_TacGia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TacGia.Location = new System.Drawing.Point(472, 20);
            this.textBox_TacGia.Name = "textBox_TacGia";
            this.textBox_TacGia.Size = new System.Drawing.Size(168, 30);
            this.textBox_TacGia.TabIndex = 33;
            this.textBox_TacGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.HotPink;
            this.label3.Location = new System.Drawing.Point(369, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 32;
            this.label3.Text = "Tác giả:";
            // 
            // textBox_TheLoai
            // 
            this.textBox_TheLoai.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TheLoai.Location = new System.Drawing.Point(472, 70);
            this.textBox_TheLoai.Name = "textBox_TheLoai";
            this.textBox_TheLoai.Size = new System.Drawing.Size(168, 30);
            this.textBox_TheLoai.TabIndex = 31;
            this.textBox_TheLoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.HotPink;
            this.label.Location = new System.Drawing.Point(369, 73);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(85, 23);
            this.label.TabIndex = 30;
            this.label.Text = "Thể loại:";
            // 
            // textBox_TenSach
            // 
            this.textBox_TenSach.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TenSach.Location = new System.Drawing.Point(144, 70);
            this.textBox_TenSach.Name = "textBox_TenSach";
            this.textBox_TenSach.Size = new System.Drawing.Size(168, 30);
            this.textBox_TenSach.TabIndex = 29;
            this.textBox_TenSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.HotPink;
            this.label2.Location = new System.Drawing.Point(32, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "Tên sách:";
            // 
            // label_MaSach
            // 
            this.label_MaSach.AutoSize = true;
            this.label_MaSach.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MaSach.ForeColor = System.Drawing.Color.HotPink;
            this.label_MaSach.Location = new System.Drawing.Point(32, 23);
            this.label_MaSach.Name = "label_MaSach";
            this.label_MaSach.Size = new System.Drawing.Size(91, 23);
            this.label_MaSach.TabIndex = 26;
            this.label_MaSach.Text = "Mã sách:";
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(188)))));
            this.button_Add.FlatAppearance.BorderSize = 0;
            this.button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add.ForeColor = System.Drawing.Color.White;
            this.button_Add.Location = new System.Drawing.Point(127, 189);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(235, 49);
            this.button_Add.TabIndex = 42;
            this.button_Add.Text = "THÊM";
            this.button_Add.UseVisualStyleBackColor = false;
            // 
            // NhapSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel_button);
            this.Controls.Add(this.panel_Data);
            this.Name = "NhapSach";
            this.Size = new System.Drawing.Size(907, 655);
            this.panel_Data.ResumeLayout(false);
            this.panel_Data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NhapSach)).EndInit();
            this.panel_button.ResumeLayout(false);
            this.panel_button.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Data;
        private System.Windows.Forms.DataGridView dataGridView_NhapSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_button;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgayNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_TacGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_TheLoai;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBox_TenSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_MaSach;
        private System.Windows.Forms.TextBox textBox_DonGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_MaSach;
        private System.Windows.Forms.TextBox textBox_SL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Add;
    }
}
