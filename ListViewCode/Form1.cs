using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListViewCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem("SP001");
            lvi.SubItems.Add("Nước ngọt");
            lvi.SubItems.Add("10");

            lstSanPham.Items.Add(lvi);

            lvi = new ListViewItem("SP002");
            lvi.SubItems.Add("Bia 333");
            lvi.SubItems.Add("15");

            lstSanPham.Items.Add(lvi); 
            
            lvi = new ListViewItem("SP003");
            lvi.SubItems.Add("Bánh kẹo");
            lvi.SubItems.Add("20");

            lstSanPham.Items.Add(lvi); 
        }

        private void lstSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstSanPham.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lstSanPham.SelectedItems[0];

                string maSP = lvi.SubItems[0].Text;
                string tenSP = lvi.SubItems[1].Text;
                string soLuong = lvi.SubItems[2].Text;

                MessageBox.Show(maSP + ": " + tenSP + ": " + soLuong);
            }
        }

        private void lstSanPham_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if(e.Column!= -1)
            {
                ColumnHeader col = lstSanPham.Columns[e.Column];

                MessageBox.Show(col.Text);
            }
        }
    }
}
