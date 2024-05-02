using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhTongHieu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int tong;
            Console.WriteLine(txtA.Text);
            Console.WriteLine(txtB.Text);

            tong = int.Parse(txtA.Text) + int.Parse(txtB.Text);
            lblKQ.Text = txtA.Text + " + " + txtB.Text + " = " + tong + "";
        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            int hieu;
            Console.WriteLine(txtA.Text);
            Console.WriteLine(txtB.Text);

            hieu = int.Parse(txtA.Text) - int.Parse(txtB.Text);
            lblKQ.Text = txtA.Text + " - " + txtB.Text + " = " + hieu + "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblKQ_Click(object sender, EventArgs e)
        {

        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn thực sự muốn thoát?", "Hỏi thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question); 
            if (res == DialogResult.Yes) {
                lblKQ.Text = "";
                txtA.Text = "";
                txtB.Text = "";
            }
        }
    }
}
