using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTTongHop.Models;

namespace BTTongHop
{
    public partial class frmQLSP : Form
    {
        DanhSachKhachHang csdl = new DanhSachKhachHang();
        public frmQLSP()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtThongTinKH_TextChanged(object sender, EventArgs e)
        {
        } //

        private void txtTongDoanhThu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTongSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.HoTenKHang = txtHoTenKH.Text.Trim();
            kh.SoLuongMua = int.Parse(txtSoLuonMua.Text.Trim());
            kh.LaSinhVien = chkLaSinhVien.Checked;

            //Thêm vào danh sách
            csdl.ThemKH(kh);

            //Tính tiền
            txtThanhTien.Text = kh.TinhTien.ToString();
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txtHoTenKH.Clear();
            txtSoLuonMua.Clear();
            txtThanhTien.Clear();
            chkLaSinhVien.Checked = true;
            //txtHoTenKH.Focus();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {

        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            txtTongKH.Text = csdl.TongKH.ToString();
            txtTongSV.Text = csdl.TongSV.ToString();
            txtTongDoanhThu.Text = csdl.TongDoanhThu.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn thực sự muốn thoát?", "Hộp thoại",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                Close();
            }
        }

        private void txtHoTenKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoLuonMua_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void chkLaSinhVien_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtTongKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn thực sự muốn thoát?", "Tiêu đề", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(res == DialogResult.Yes) { 
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
