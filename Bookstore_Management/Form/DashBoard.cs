using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore_Management
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
            button_ThongKe.BackColor = Color.HotPink;
            ThongKe thongke = new ThongKe();
            AddConTrol(thongke);

        }

        ////////BUTTON CLICK///////
        private void pictureBox_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
        private void Pick(Button c)
        {
            button_NhapSach.BackColor = button_BanSach.BackColor = button_BaoCao.BackColor = button_LichSuBan.BackColor = button_PhieuThuTien.BackColor = button_ThongKe.BackColor = button_TraCuuSach.BackColor = Color.MediumSlateBlue ;
            c.BackColor = Color.HotPink;
            
        }
        public void AddConTrol(Control c)
        {
            c.Dock = DockStyle.Fill;
            panel_UserControl.Controls.Clear();
            panel_UserControl.Controls.Add(c);
        }
        public void BaoCaoClick(object sender, EventArgs e)
        {
            BaoCaoCongNo baocao = new BaoCaoCongNo();
            AddConTrol(baocao);
        }
        private void button_ThongKe_Click(object sender, EventArgs e)
        {
            Button temp = sender as Button;
            Pick(temp);
            ThongKe thongke = new ThongKe();
            AddConTrol(thongke);
        }

        private void button_NhapSach_Click(object sender, EventArgs e)
        {
            Button temp = sender as Button;
            Pick(temp);
            NhapSach nhapsach = new NhapSach();
            AddConTrol(nhapsach);
        }

        private void button_BanSach_Click(object sender, EventArgs e)
        {
            Button temp = sender as Button;
            Pick(temp);
            BanSach bansach = new BanSach();
            AddConTrol(bansach);
        }

        private void button_TraCuuSach_Click(object sender, EventArgs e)
        {
            Button temp = sender as Button;
            Pick(temp);
            TraCuuSach tracuu = new TraCuuSach();
            AddConTrol(tracuu);
        }

        private void button_PhieuThuTien_Click(object sender, EventArgs e)
        {
            Button temp = sender as Button;
            Pick(temp);
            PhieuThuTien phieuthu = new PhieuThuTien();
            AddConTrol(phieuthu);
        }

        private void button_BaoCao_Click(object sender, EventArgs e)
        {
            Button temp = sender as Button;
            Pick(temp);
            BaoCaoTon baocao = new BaoCaoTon(this);
            AddConTrol(baocao);
        }

        private void button_LichSuBan_Click(object sender, EventArgs e)
        {
            Button temp = sender as Button;
            Pick(temp);
            LichSuBanSach lichsu = new LichSuBanSach();
            AddConTrol(lichsu);
        }

        private void pictureBox_Setting_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            setting.Show();
        }

      
        private void pictureBox_TaiKhoan_Click(object sender, EventArgs e)
        {
            TaiKhoan taikhoan = new TaiKhoan();
            taikhoan.Show();
        }

        private void pictureBox_ThemSach_Click(object sender, EventArgs e)
        {
            TaoXoaSach taosach = new TaoXoaSach();
            taosach.Show();
        }
    }
}
