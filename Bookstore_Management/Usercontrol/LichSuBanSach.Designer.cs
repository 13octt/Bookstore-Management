
namespace Bookstore_Management
{
    partial class LichSuBanSach
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
            this.panel_head = new System.Windows.Forms.Panel();
            this.button_TimKiem = new System.Windows.Forms.Button();
            this.dateTimePicker_NgayBan = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Data = new System.Windows.Forms.Panel();
            this.dataGridView_LichSuBan = new System.Windows.Forms.DataGridView();
            this.panel_head.SuspendLayout();
            this.panel_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LichSuBan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_head
            // 
            this.panel_head.Controls.Add(this.button_TimKiem);
            this.panel_head.Controls.Add(this.dateTimePicker_NgayBan);
            this.panel_head.Controls.Add(this.label4);
            this.panel_head.Controls.Add(this.label1);
            this.panel_head.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_head.Location = new System.Drawing.Point(0, 0);
            this.panel_head.Name = "panel_head";
            this.panel_head.Size = new System.Drawing.Size(913, 115);
            this.panel_head.TabIndex = 3;
            // 
            // button_TimKiem
            // 
            this.button_TimKiem.BackColor = System.Drawing.Color.Indigo;
            this.button_TimKiem.FlatAppearance.BorderSize = 0;
            this.button_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_TimKiem.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_TimKiem.ForeColor = System.Drawing.Color.White;
            this.button_TimKiem.Location = new System.Drawing.Point(560, 59);
            this.button_TimKiem.Name = "button_TimKiem";
            this.button_TimKiem.Size = new System.Drawing.Size(160, 47);
            this.button_TimKiem.TabIndex = 42;
            this.button_TimKiem.Text = "Tìm Kiếm";
            this.button_TimKiem.UseVisualStyleBackColor = false;
            this.button_TimKiem.Click += new System.EventHandler(this.button_TimKiem_Click);
            // 
            // dateTimePicker_NgayBan
            // 
            this.dateTimePicker_NgayBan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_NgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_NgayBan.Location = new System.Drawing.Point(373, 65);
            this.dateTimePicker_NgayBan.Name = "dateTimePicker_NgayBan";
            this.dateTimePicker_NgayBan.Size = new System.Drawing.Size(148, 30);
            this.dateTimePicker_NgayBan.TabIndex = 37;
            this.dateTimePicker_NgayBan.ValueChanged += new System.EventHandler(this.dateTimePicker_NgayBan_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.HotPink;
            this.label4.Location = new System.Drawing.Point(259, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 23);
            this.label4.TabIndex = 36;
            this.label4.Text = "Ngày Bán: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(349, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "LỊCH SỬ BÁN SÁCH";
            // 
            // panel_Data
            // 
            this.panel_Data.Controls.Add(this.dataGridView_LichSuBan);
            this.panel_Data.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Data.Location = new System.Drawing.Point(0, 121);
            this.panel_Data.Name = "panel_Data";
            this.panel_Data.Size = new System.Drawing.Size(913, 540);
            this.panel_Data.TabIndex = 4;
            // 
            // dataGridView_LichSuBan
            // 
            this.dataGridView_LichSuBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_LichSuBan.Location = new System.Drawing.Point(31, 8);
            this.dataGridView_LichSuBan.Name = "dataGridView_LichSuBan";
            this.dataGridView_LichSuBan.RowHeadersWidth = 51;
            this.dataGridView_LichSuBan.RowTemplate.Height = 24;
            this.dataGridView_LichSuBan.Size = new System.Drawing.Size(850, 495);
            this.dataGridView_LichSuBan.TabIndex = 0;
            // 
            // LichSuBanSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel_Data);
            this.Controls.Add(this.panel_head);
            this.Name = "LichSuBanSach";
            this.Size = new System.Drawing.Size(913, 661);
            this.panel_head.ResumeLayout(false);
            this.panel_head.PerformLayout();
            this.panel_Data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LichSuBan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_head;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_Data;
        private System.Windows.Forms.DataGridView dataGridView_LichSuBan;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgayBan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_TimKiem;
    }
}
