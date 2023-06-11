
namespace Bookstore_Management
{
    partial class BaoCaoTon
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
            this.button_BaoCaoTon = new System.Windows.Forms.Button();
            this.button_BaoCaoCongNo = new System.Windows.Forms.Button();
            this.panel_BaoCao = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_BaoCaoTon = new System.Windows.Forms.DataGridView();
            this.maskedTextBox_Thang = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox_XuatBaoCao = new System.Windows.Forms.PictureBox();
            this.panel_head.SuspendLayout();
            this.panel_BaoCao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BaoCaoTon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_XuatBaoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_head
            // 
            this.panel_head.Controls.Add(this.button_BaoCaoCongNo);
            this.panel_head.Controls.Add(this.button_BaoCaoTon);
            this.panel_head.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_head.Location = new System.Drawing.Point(0, 0);
            this.panel_head.Name = "panel_head";
            this.panel_head.Size = new System.Drawing.Size(913, 86);
            this.panel_head.TabIndex = 0;
            // 
            // button_BaoCaoTon
            // 
            this.button_BaoCaoTon.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_BaoCaoTon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_BaoCaoTon.FlatAppearance.BorderSize = 0;
            this.button_BaoCaoTon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_BaoCaoTon.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_BaoCaoTon.ForeColor = System.Drawing.Color.White;
            this.button_BaoCaoTon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_BaoCaoTon.Location = new System.Drawing.Point(107, 3);
            this.button_BaoCaoTon.Name = "button_BaoCaoTon";
            this.button_BaoCaoTon.Size = new System.Drawing.Size(286, 75);
            this.button_BaoCaoTon.TabIndex = 11;
            this.button_BaoCaoTon.Text = "Báo Cáo Tồn Kho";
            this.button_BaoCaoTon.UseVisualStyleBackColor = false;
            // 
            // button_BaoCaoCongNo
            // 
            this.button_BaoCaoCongNo.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_BaoCaoCongNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_BaoCaoCongNo.FlatAppearance.BorderSize = 0;
            this.button_BaoCaoCongNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_BaoCaoCongNo.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_BaoCaoCongNo.ForeColor = System.Drawing.Color.White;
            this.button_BaoCaoCongNo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_BaoCaoCongNo.Location = new System.Drawing.Point(523, 3);
            this.button_BaoCaoCongNo.Name = "button_BaoCaoCongNo";
            this.button_BaoCaoCongNo.Size = new System.Drawing.Size(286, 75);
            this.button_BaoCaoCongNo.TabIndex = 12;
            this.button_BaoCaoCongNo.Text = "Báo Cáo Công Nợ";
            this.button_BaoCaoCongNo.UseVisualStyleBackColor = false;
            this.button_BaoCaoCongNo.Click += new System.EventHandler(this.button_BaoCaoCongNo_Click);
            // 
            // panel_BaoCao
            // 
            this.panel_BaoCao.Controls.Add(this.pictureBox_XuatBaoCao);
            this.panel_BaoCao.Controls.Add(this.label4);
            this.panel_BaoCao.Controls.Add(this.maskedTextBox_Thang);
            this.panel_BaoCao.Controls.Add(this.dataGridView_BaoCaoTon);
            this.panel_BaoCao.Controls.Add(this.label1);
            this.panel_BaoCao.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_BaoCao.Location = new System.Drawing.Point(0, 86);
            this.panel_BaoCao.Name = "panel_BaoCao";
            this.panel_BaoCao.Size = new System.Drawing.Size(913, 572);
            this.panel_BaoCao.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(330, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "BÁO CÁO TỒN KHO";
            // 
            // dataGridView_BaoCaoTon
            // 
            this.dataGridView_BaoCaoTon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_BaoCaoTon.Location = new System.Drawing.Point(32, 128);
            this.dataGridView_BaoCaoTon.Name = "dataGridView_BaoCaoTon";
            this.dataGridView_BaoCaoTon.RowHeadersWidth = 51;
            this.dataGridView_BaoCaoTon.RowTemplate.Height = 24;
            this.dataGridView_BaoCaoTon.Size = new System.Drawing.Size(862, 426);
            this.dataGridView_BaoCaoTon.TabIndex = 3;
            // 
            // maskedTextBox_Thang
            // 
            this.maskedTextBox_Thang.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_Thang.Location = new System.Drawing.Point(240, 89);
            this.maskedTextBox_Thang.Mask = "00";
            this.maskedTextBox_Thang.Name = "maskedTextBox_Thang";
            this.maskedTextBox_Thang.Size = new System.Drawing.Size(50, 30);
            this.maskedTextBox_Thang.TabIndex = 4;
            this.maskedTextBox_Thang.Text = "00";
            this.maskedTextBox_Thang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.HotPink;
            this.label4.Location = new System.Drawing.Point(37, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 23);
            this.label4.TabIndex = 35;
            this.label4.Text = "Báo cáo theo tháng:";
            // 
            // pictureBox_XuatBaoCao
            // 
            this.pictureBox_XuatBaoCao.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_XuatBaoCao.BackgroundImage = global::Bookstore_Management.Properties.Resources.export;
            this.pictureBox_XuatBaoCao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_XuatBaoCao.Location = new System.Drawing.Point(831, 61);
            this.pictureBox_XuatBaoCao.Name = "pictureBox_XuatBaoCao";
            this.pictureBox_XuatBaoCao.Size = new System.Drawing.Size(63, 58);
            this.pictureBox_XuatBaoCao.TabIndex = 36;
            this.pictureBox_XuatBaoCao.TabStop = false;
            this.pictureBox_XuatBaoCao.Click += new System.EventHandler(this.pictureBox_XuatBaoCao_Click);
            // 
            // BaoCaoTon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel_BaoCao);
            this.Controls.Add(this.panel_head);
            this.Name = "BaoCaoTon";
            this.Size = new System.Drawing.Size(913, 661);
            this.panel_head.ResumeLayout(false);
            this.panel_BaoCao.ResumeLayout(false);
            this.panel_BaoCao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BaoCaoTon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_XuatBaoCao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_head;
        private System.Windows.Forms.Button button_BaoCaoTon;
        private System.Windows.Forms.Button button_BaoCaoCongNo;
        private System.Windows.Forms.Panel panel_BaoCao;
        private System.Windows.Forms.DataGridView dataGridView_BaoCaoTon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Thang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox_XuatBaoCao;
    }
}
