using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkbox_Radiobtn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblNoiDung_Click(object sender, EventArgs e)
        {
            
        }

        private void txtNoiDung_TextChanged(object sender, EventArgs e)
        {
            lblOutPut.Text = txtNoiDung.Text;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radMauDo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radMauDo_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radMauDo.Checked == true)
            {
                lblOutPut.ForeColor = Color.Red;   
            }
        }

        private void radMauXanhLa_CheckedChanged(object sender, EventArgs e)
        {
            if(radMauXanhLa.Checked == true)
            {
                lblOutPut.ForeColor= Color.Green;    
            }
        }

        private void radMauDen_CheckedChanged(object sender, EventArgs e)
        {
            if(radMauDen.Checked == true)
            {
                lblOutPut.ForeColor = Color.Black;
            }  
        }

        private void radMauXanhDuong_CheckedChanged(object sender, EventArgs e)
        {
            if(radMauXanhDuong.Checked == true)
            {
                lblOutPut.ForeColor = Color.Blue;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radMauDo.Checked = true;
            chkChuNghieng.Checked = true;
        }

        private void chkChuDam_CheckedChanged(object sender, EventArgs e)
        {
           /* Console.WriteLine(lblOutPut.Font.Name);
            Console.WriteLine(lblOutPut.Font.Size);*/
            lblOutPut.Font = new Font(lblOutPut.Font.Name, lblOutPut.Font.Size, lblOutPut.Font.Style ^FontStyle.Bold);
        }

        private void chkChuNghieng_CheckedChanged(object sender, EventArgs e)
        {
            lblOutPut.Font = new Font(lblOutPut.Font.Name, lblOutPut.Font.Size, lblOutPut.Font.Style ^ FontStyle.Italic);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            //Cách 1
            //Close();

            //Cách 2:
            DialogResult res = MessageBox.Show("Bạn có chắc chăn muốn thoát?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(res == DialogResult.Yes)
            {
                Close();
            }
        }

        private void lblOutPut_Click(object sender, EventArgs e)
        {

        }

        private void chkChuGachChan_CheckedChanged(object sender, EventArgs e)
        {
            lblOutPut.Font = new Font(lblOutPut.Font.Name, lblOutPut.Font.Size, lblOutPut.Font.Style ^FontStyle.Underline); 
        }
    }
}
