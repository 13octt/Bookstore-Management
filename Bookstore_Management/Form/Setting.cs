﻿using System;
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
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void pictureBox_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
