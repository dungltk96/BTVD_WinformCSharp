using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XuLySerializeFile.Models;

namespace XuLySerializeFile
{
    public partial class Form1 : Form
    {
        List<SanPham> ds = new List<SanPham>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.MaSP = txtMaSP.Text.Trim();
            sp.TenSP = txtTenSP.Text.Trim();
            sp.NgaySX = new DateTime(dtpNgaySX.Value.Year, dtpNgaySX.Value.Month, dtpNgaySX.Value.Day);

            ds.Add(sp);

            HienThiDanhSach();
        }

        private void HienThiDanhSach()
        {
            lvDSSP.Items.Clear();
            foreach(SanPham itemSP in ds)
            {
                ListViewItem lvi = new ListViewItem(itemSP.MaSP);
                lvi.SubItems.Add(itemSP.TenSP);
                lvi.SubItems.Add(itemSP.NgaySX.ToString("MM/dd/yyyy"));

                lvDSSP.Items.Add(lvi);
            }
        }

        private void btnGhiFile_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\danhsach.bat";
            bool kt = Files.GhiFile(ds, path);

            if (kt == true)
            {
                MessageBox.Show("Ghi file thành công!");
            }
            else
            {
                MessageBox.Show("Ghi file thất bại!");
            }
        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\danhsach.bat";
            if (System.IO.File.Exists(path))
            {
                ds = Files.DocFile(path);
                HienThiDanhSach();
            }
            else
            {
                MessageBox.Show("File không tồn tại!");
            }
        }
    }
}
