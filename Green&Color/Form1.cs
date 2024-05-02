using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Green_Color
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            //Thay đổi màu nền
            this.BackColor = Color.Green;

            // Hiển thị text
            this.Text = "Green Color!";
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
            this.Text = "Yellow Color!";
        }
    }
}
