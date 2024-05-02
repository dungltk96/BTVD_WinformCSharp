using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Display_Clear_Exit
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

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "timoday.vn";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //txtDisplay.Text = null;
            //txtDisplay.Text = "";
            //txtDisplay.Clear();
            txtDisplay.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            //this.Close();

            //Hiển thị hộp thoại xác nhận thoát\
            DialogResult res = MessageBox.Show("Bạn có thưc sự muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Close();    
            }
        }
    }
}
