using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace Bookstore_Management
{
    public partial class TaoXoaSach : Form
    {
        private string path_with_image = "";
        private string repository = "";
        public TaoXoaSach()
        {
            InitializeComponent();
        }
        private void GetImage()
        {
            Byte[] BytesOfImage;

            OpenFileDialog ofdPatient = new OpenFileDialog();

            DialogResult dgResult = ofdPatient.ShowDialog();

            if (dgResult == DialogResult.OK)
            {

                path_with_image = ofdPatient.FileName;

                try
                {
                    try
                    {
                        FileStream fsRead = new FileStream(path_with_image, FileMode.Open);
                        BytesOfImage = new Byte[fsRead.Length];
                        fsRead.Read(BytesOfImage, 0, BytesOfImage.Length);
                        fsRead.Close();
                    }
                    catch { return; }

                    string filename = Path.GetFileName(path_with_image);

                    Bitmap bm = Image.FromFile(path_with_image) as Bitmap;
                    bm.Save(repository + filename, ImageFormat.Jpeg);


                }
                catch { }

            }



        }
        private void pictureBox_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox_AnhBia_Click(object sender, EventArgs e)
        {
            GetImage();
        }
    }
}
