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
    public partial class BaoCaoTon : UserControl
    {
        DashBoard temp;
        public BaoCaoTon()
        {
            InitializeComponent();
            button_BaoCaoTon.BackColor = Color.HotPink;
        }
        public BaoCaoTon(DashBoard a)
        {
            InitializeComponent();
            button_BaoCaoTon.BackColor = Color.HotPink;
            temp = a;

        }
        private void button_BaoCaoCongNo_Click(object sender, EventArgs e)
        {
            BaoCaoCongNo baocao = new BaoCaoCongNo(temp);
            temp.AddConTrol(baocao);

        }

        private void pictureBox_XuatBaoCao_Click(object sender, EventArgs e)
        {

        }
    }
}
