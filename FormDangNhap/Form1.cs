using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDangNhap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            if (user == "")
            {
                txtUsername.Text = "Vui lòng nhập Username!";
            }

            if (user.Equals("dungltk") && password.Equals("123123"))
            {
                MessageBox.Show("Đăng nhập thành công!");
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!");                     
            }
            /*else
            {
                txtUsername.Text = "";
            }*/
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn thực sự muốn thoát", "Hộp thoại", MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
