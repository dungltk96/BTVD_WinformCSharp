using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picturebbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int onOff = 1; //1 mặc định sáng
        private void btnOnOff_Click(object sender, EventArgs e)
        {
            if(onOff ==1)
            {
                picOff.Visible = true;
                picOnl.Visible = false;
                btnOnOff.Text = "Bật đèn lên!";
                onOff = 0;
            }
            else
            {
                picOff.Visible = false;
                picOnl.Visible = true;
                btnOnOff.Text = "Tắt đèn đi!";
                onOff = 1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picOff.Visible = false;
            picOnl.Visible = true;
            btnOnOff.Text = "Tắt đèn đi!";
        }
    }
}
