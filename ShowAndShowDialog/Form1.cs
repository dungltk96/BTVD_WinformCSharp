using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowAndShowDialog
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2CLick = new Form2();
            frm2CLick.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm3CLick = new Form3();
            frm3CLick.Show();
        }
    }
}
