using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNhap_Click(object sender, EventArgs e)
        {
            // Lấy ra số trong textbox
            int x = Convert.ToInt32(btnNhap.Text.Trim());

            // Thêm x vào listbox
            lstDanhSach.Items.Add(x);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            //Lấy ra số trong textbox
            int x = Convert.ToInt32((txtInput.Text.Trim()));

            //Thêm x vào listbox
            lstDanhSach.Items.Add(x);

            //Xóa pt đã nhập trong textbox
            txtInput.Clear();

        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn thực sự muốn thoát?","Xác nhận thoát",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnTongDS_Click(object sender, EventArgs e)
        {
            int s = 0;
            int n = lstDanhSach.Items.Count;

            for (int i = 0; i < n; i++)
            {

            }
        }

        private void btnChonSoChan_Click(object sender, EventArgs e)
        {

        }
    }
}
