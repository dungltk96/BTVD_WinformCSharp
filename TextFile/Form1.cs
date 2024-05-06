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
using TextFile.Models;

namespace TextFile
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
            sp.NgaySX = dtpNgaySX.Value;

            ds.Add(sp);
            HienThiDuLieu();

        }

        private void HienThiDuLieu()
        {
            lvDSSP.Items.Clear();


            foreach (SanPham itemSP in ds)
            {
                ListViewItem lvi = new ListViewItem(itemSP.MaSP);
                lvi.SubItems.Add(itemSP.TenSP);
                lvi.SubItems.Add(itemSP.NgaySX.ToString("MM/dd/yyyy"));

                lvDSSP.Items.Add(lvi);
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Application.StartupPath + "\\danhsach.txt";
                bool kt = Files.LuuFile(ds, path);  
                if (kt == true)
                {
                    MessageBox.Show("Lưu thành công!");
                }
                else
                {
                    MessageBox.Show("Lưu thất bại!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Application.StartupPath + "\\danhsach.txt";
                if (System.IO.File.Exists(path))
                {
                    ds = Files.DocFile(path);
                    HienThiDuLieu();
                }
                else
                {
                    MessageBox.Show("File không tofn tại");
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
