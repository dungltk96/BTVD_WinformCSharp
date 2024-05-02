using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridVview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<SanPham> ds = new List<SanPham>();
            SanPham sp;

            sp = new SanPham() { maSP = "SP001", tenSP = "Bánh ngọt", soLuong = 10 };
            ds.Add(sp);
                
            sp = new SanPham() { maSP = "SP002", tenSP = "kẹo chanh", soLuong = 15 };
            ds.Add(sp);

            sp = new SanPham() { maSP = "SP003", tenSP = "Trái cây", soLuong = 10 };
            ds.Add(sp);

            sp = new SanPham() { maSP = "SP004", tenSP = "Hướng dương", soLuong = 30};
            ds.Add(sp);

            sp = new SanPham() { maSP = "SP005", tenSP = "Hạt dinh dưỡng", soLuong = 10 };
            ds.Add(sp);

            dgvSP.DataSource = ds;
        }

        private void dgvSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kích row hiển thị nội dung row trên popup
            if(e.RowIndex == -1) { return; }
            DataGridViewRow row = dgvSP.Rows[e.RowIndex];
             string ma = row.Cells[0].Value.ToString();
             string ten = row.Cells[1].Value.ToString();
             int soluong = int.Parse(row.Cells[2].Value.ToString());

            MessageBox.Show(ma + "-" + ten + "-" + soluong);

        }
    }
}
