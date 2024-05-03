using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogBasic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Cách 1: Show theo từng đuôi ảnh
            openFileDialog1.Filter = "(*.jpg)|*.jpg|(*.png)|*.png";

            //Cách 2: Show tất cả các đuôi ảnh
            //openFileDialog1.Filter = "(*.png;*.jpg)|*.png;*.jpg";
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
