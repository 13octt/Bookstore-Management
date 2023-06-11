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
    public partial class BaoCaoCongNo : UserControl
    {
        DashBoard temp;
        public BaoCaoCongNo()
        {
            InitializeComponent();
            button_BaoCaoCongNo.BackColor = Color.HotPink;
        }
        public BaoCaoCongNo(DashBoard a)
        {
            InitializeComponent();
            button_BaoCaoCongNo.BackColor = Color.HotPink;
            temp = a;

        }

        private void button_BaoCaoTon_Click(object sender, EventArgs e)
        {
            BaoCaoTon baocao = new BaoCaoTon(temp);
            temp.AddConTrol(baocao);
        }
            
    }
}
