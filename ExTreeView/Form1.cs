using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExTreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            // Lấy thông tin trên các tabPages
            string hoTen = txtName.Text.Trim();
            string gioiTinh = cboGender.SelectedItem.ToString();
            double diemToan = double.Parse(txtToan.Text.Trim());
            double diemVan = double.Parse(txtVan.Text.Trim());

            // Hiển thị thông tin
            string s = "Họ tên: " + hoTen + "\n";
            s += "Giới tính: " + gioiTinh + "\n";
            s += "Điểm toán: " + diemToan + "\n";
            s += "Điểm Văn: " + diemVan + "\n";

            MessageBox.Show(s);

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 0)
            {
                MessageBox.Show("Vui lòng cần nhâp đủ thông tin!");
            }else if(tabControl1.SelectedIndex == 1)
            {

            }
        }
    }
}
