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
    public partial class TraCuuSach : UserControl
    {
        public TraCuuSach()
        {
            InitializeComponent();
        }

        private void textBox_TenSach_TextChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void textBox_TheLoai_TextChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void PerformSearch()
        {
            //
            String bookTitle = textBox_TenSach.Text;
            String bookGenre = textBox_TheLoai.Text;



        }

    }
}
