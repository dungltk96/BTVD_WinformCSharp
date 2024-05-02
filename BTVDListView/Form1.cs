using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVDListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Lấy ra dữ liệu trong textbox
            string maSP = txtMaSP.Text.Trim();
            string tenSP = txtTenSP.Text.Trim();    
            int soLuong = int.Parse(txtSoLuong.Text.Trim());

            // Gán dữ liệu vào lsvDanhSachSP
            ListViewItem lvi = new ListViewItem(maSP);
            lvi.SubItems.Add(tenSP);
            lvi.SubItems.Add(soLuong.ToString());

            // Gán ListViewItem lên ListView
            lsvDanhSachSP.Items.Add(lvi);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lsvDanhSachSP.SelectedItems.Count > 0)
            {
                string maSP = txtMaSP.Text.Trim();
                string tenSP = txtTenSP.Text.Trim();
                string soLuong = txtSoLuong.Text.Trim();

                ListViewItem lvi = lsvDanhSachSP.SelectedItems[0];
                lvi.SubItems[0].Text = maSP;
                lvi.SubItems[1].Text = tenSP;
                lvi.SubItems[2].Text = soLuong;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem("SP001");
            lvi.SubItems.Add("Bánh kẹo");
            lvi.SubItems.Add("10");
            lsvDanhSachSP.Items.Add(lvi);

            lvi = new ListViewItem("SP002");
            lvi.SubItems.Add("Bia 333");
            lvi.SubItems.Add("15");
            lsvDanhSachSP.Items.Add(lvi);
        }

        private void lsvDanhSachSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsvDanhSachSP.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lsvDanhSachSP.SelectedItems[0];

                string maSP = lvi.SubItems[0].Text;
                string tenSP = lvi.SubItems[1].Text;
                string soLuong = lvi.SubItems[2].Text;

                txtMaSP.Text = maSP;
                txtTenSP.Text = tenSP;
                txtSoLuong.Text = soLuong;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(lsvDanhSachSP.SelectedItems.Count>0)
            {
                lsvDanhSachSP.Items.RemoveAt(lsvDanhSachSP.SelectedItems[0].Index);
            }
        }
    }
}
