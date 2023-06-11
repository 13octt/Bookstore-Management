
namespace Bookstore_Management
{
    partial class TraCuuSach
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
            this.dataGridView_NhapSach = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_head = new System.Windows.Forms.Panel();
            this.textBox_TheLoai = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.textBox_TenSach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NhapSach)).BeginInit();
            this.panel_head.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Data
            // 
            this.panel_Data.Controls.Add(this.dataGridView_NhapSach);
            this.panel_Data.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Data.Location = new System.Drawing.Point(0, 136);
            this.panel_Data.Name = "panel_Data";
            this.panel_Data.Size = new System.Drawing.Size(913, 525);
            this.panel_Data.TabIndex = 1;
            // 
            // dataGridView_NhapSach
            // 
            this.dataGridView_NhapSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_NhapSach.Location = new System.Drawing.Point(31, 3);
            this.dataGridView_NhapSach.Name = "dataGridView_NhapSach";
            this.dataGridView_NhapSach.RowHeadersWidth = 51;
            this.dataGridView_NhapSach.RowTemplate.Height = 24;
            this.dataGridView_NhapSach.Size = new System.Drawing.Size(850, 500);
            this.dataGridView_NhapSach.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(368, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "TRA CỨU SÁCH";
            // 
            // panel_head
            // 
            this.panel_head.Controls.Add(this.textBox_TheLoai);
            this.panel_head.Controls.Add(this.label);
            this.panel_head.Controls.Add(this.textBox_TenSach);
            this.panel_head.Controls.Add(this.label2);
            this.panel_head.Controls.Add(this.label1);
            this.panel_head.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_head.Location = new System.Drawing.Point(0, 0);
            this.panel_head.Name = "panel_head";
            this.panel_head.Size = new System.Drawing.Size(913, 130);
            this.panel_head.TabIndex = 2;
            // 
            // textBox_TheLoai
            // 
            this.textBox_TheLoai.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TheLoai.Location = new System.Drawing.Point(592, 71);
            this.textBox_TheLoai.Name = "textBox_TheLoai";
            this.textBox_TheLoai.Size = new System.Drawing.Size(259, 30);
            this.textBox_TheLoai.TabIndex = 33;
            this.textBox_TheLoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_TheLoai.TextChanged += new System.EventHandler(this.textBox_TheLoai_TextChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.HotPink;
            this.label.Location = new System.Drawing.Point(501, 74);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(85, 23);
            this.label.TabIndex = 32;
            this.label.Text = "Thể loại:";
            // 
            // textBox_TenSach
            // 
            this.textBox_TenSach.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TenSach.Location = new System.Drawing.Point(181, 71);
            this.textBox_TenSach.Name = "textBox_TenSach";
            this.textBox_TenSach.Size = new System.Drawing.Size(249, 30);
            this.textBox_TenSach.TabIndex = 31;
            this.textBox_TenSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_TenSach.TextChanged += new System.EventHandler(this.textBox_TenSach_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.HotPink;
            this.label2.Location = new System.Drawing.Point(70, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tên sách:";
            // 
            // TraCuuSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel_head);
            this.Controls.Add(this.panel_Data);
            this.Name = "TraCuuSach";
            this.Size = new System.Drawing.Size(913, 661);
            this.Load += new System.EventHandler(this.TraCuuSach_Load_1);
            this.panel_Data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NhapSach)).EndInit();
            this.panel_head.ResumeLayout(false);
            this.panel_head.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_NhapSach;
        private System.Windows.Forms.Panel panel_head;
        private System.Windows.Forms.TextBox textBox_TheLoai;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBox_TenSach;
        private System.Windows.Forms.Label label2;
    }
}
