
namespace Bookstore_Management
{
    partial class Setting
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
            this.pictureBox_Setting = new System.Windows.Forms.PictureBox();
            this.pictureBox_Exit = new System.Windows.Forms.PictureBox();
            this.panel_Setting = new System.Windows.Forms.Panel();
            this.checkBox_SoTienThu = new System.Windows.Forms.CheckBox();
            this.textBox_SoTienNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_SLTon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_SLNhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Save = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Setting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exit)).BeginInit();
            this.panel_Setting.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox_Setting);
            this.panel1.Controls.Add(this.pictureBox_Exit);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 54);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SlateBlue;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(228, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "SETTING";
            // 
            // pictureBox_Setting
            // 
            this.pictureBox_Setting.BackgroundImage = global::Bookstore_Management.Properties.Resources.cogwheel;
            this.pictureBox_Setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Setting.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_Setting.Name = "pictureBox_Setting";
            this.pictureBox_Setting.Size = new System.Drawing.Size(44, 43);
            this.pictureBox_Setting.TabIndex = 5;
            this.pictureBox_Setting.TabStop = false;
            // 
            // pictureBox_Exit
            // 
            this.pictureBox_Exit.BackgroundImage = global::Bookstore_Management.Properties.Resources.multiply;
            this.pictureBox_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Exit.Location = new System.Drawing.Point(524, 9);
            this.pictureBox_Exit.Name = "pictureBox_Exit";
            this.pictureBox_Exit.Size = new System.Drawing.Size(38, 36);
            this.pictureBox_Exit.TabIndex = 1;
            this.pictureBox_Exit.TabStop = false;
            this.pictureBox_Exit.Click += new System.EventHandler(this.pictureBox_Exit_Click);
            // 
            // panel_Setting
            // 
            this.panel_Setting.Controls.Add(this.checkBox_SoTienThu);
            this.panel_Setting.Controls.Add(this.textBox_SoTienNo);
            this.panel_Setting.Controls.Add(this.label4);
            this.panel_Setting.Controls.Add(this.textBox_SLTon);
            this.panel_Setting.Controls.Add(this.label3);
            this.panel_Setting.Controls.Add(this.textBox_SLNhap);
            this.panel_Setting.Controls.Add(this.label2);
            this.panel_Setting.Location = new System.Drawing.Point(24, 69);
            this.panel_Setting.Name = "panel_Setting";
            this.panel_Setting.Size = new System.Drawing.Size(529, 209);
            this.panel_Setting.TabIndex = 2;
            // 
            // checkBox_SoTienThu
            // 
            this.checkBox_SoTienThu.AutoSize = true;
            this.checkBox_SoTienThu.Checked = true;
            this.checkBox_SoTienThu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_SoTienThu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_SoTienThu.ForeColor = System.Drawing.Color.HotPink;
            this.checkBox_SoTienThu.Location = new System.Drawing.Point(7, 169);
            this.checkBox_SoTienThu.Name = "checkBox_SoTienThu";
            this.checkBox_SoTienThu.Size = new System.Drawing.Size(418, 27);
            this.checkBox_SoTienThu.TabIndex = 12;
            this.checkBox_SoTienThu.Text = "Số tiền thu của khách không vượt quá số nợ";
            this.checkBox_SoTienThu.UseVisualStyleBackColor = true;
            // 
            // textBox_SoTienNo
            // 
            this.textBox_SoTienNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SoTienNo.Location = new System.Drawing.Point(359, 112);
            this.textBox_SoTienNo.Name = "textBox_SoTienNo";
            this.textBox_SoTienNo.Size = new System.Drawing.Size(158, 30);
            this.textBox_SoTienNo.TabIndex = 10;
            this.textBox_SoTienNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.HotPink;
            this.label4.Location = new System.Drawing.Point(3, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Số tiền nợ tối đa của khách :";
            // 
            // textBox_SLTon
            // 
            this.textBox_SLTon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SLTon.Location = new System.Drawing.Point(359, 61);
            this.textBox_SLTon.Name = "textBox_SLTon";
            this.textBox_SLTon.Size = new System.Drawing.Size(158, 30);
            this.textBox_SLTon.TabIndex = 8;
            this.textBox_SLTon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.HotPink;
            this.label3.Location = new System.Drawing.Point(3, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(337, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số lượng tồn tối thiểu trước khi nhập:";
            // 
            // textBox_SLNhap
            // 
            this.textBox_SLNhap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SLNhap.Location = new System.Drawing.Point(359, 15);
            this.textBox_SLNhap.Name = "textBox_SLNhap";
            this.textBox_SLNhap.Size = new System.Drawing.Size(158, 30);
            this.textBox_SLNhap.TabIndex = 6;
            this.textBox_SLNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.HotPink;
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số lượng nhập tối thiểu:";
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.Indigo;
            this.button_Save.FlatAppearance.BorderSize = 0;
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Save.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save.ForeColor = System.Drawing.Color.White;
            this.button_Save.Location = new System.Drawing.Point(174, 296);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(235, 50);
            this.button_Save.TabIndex = 8;
            this.button_Save.Text = "CẬP NHẬT";
            this.button_Save.UseVisualStyleBackColor = false;
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(565, 358);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.panel_Setting);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Setting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exit)).EndInit();
            this.panel_Setting.ResumeLayout(false);
            this.panel_Setting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox_Exit;
        private System.Windows.Forms.PictureBox pictureBox_Setting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_Setting;
        private System.Windows.Forms.TextBox textBox_SoTienNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_SLTon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_SLNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.CheckBox checkBox_SoTienThu;
    }
}