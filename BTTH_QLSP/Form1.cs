using BTTH_QLSP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH_QLSP
{
    public partial class Form1 : Form
    {
        // Tạo nơi chứa danh mục    
        List <DanhMuc> ListDM = new List <DanhMuc>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có thực sự muốn thoát?", "Hỏi thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KhoiTaoDuLieu();
            HienThiDanhMuc();
        }

        private void HienThiDanhMuc()
        {
            tvDanhMuc.Nodes.Clear();

            foreach(DanhMuc itemDM in ListDM)
            {
                TreeNode nodeDM = new TreeNode (itemDM.Name);
                nodeDM.Tag = itemDM;
                tvDanhMuc.Nodes.Add(nodeDM);
            }
        }

        private void KhoiTaoDuLieu()
        {
            // Tạo danh mục
            DanhMuc DienThoaiDiDong = new DanhMuc()
            {
                ID = "DT01",
                Name = "Điện thoại di động"
            };

            DanhMuc MayTinhBang = new DanhMuc()
            {
                ID = "MTB01",
                Name = "Máy tính bảng"
            };

            DanhMuc Laptop = new DanhMuc()
            {
                ID = "LT01",
                Name = "Laptop"
            };

            // Thêm các đối tượng danh mục vào cây danh mục
            ListDM.Add(DienThoaiDiDong);
            ListDM.Add(MayTinhBang);
            ListDM.Add(Laptop);

            // Tạo ra các sản phẩm
            SanPham IP11 = new SanPham()
            {
                ID = "IP01",
                Name = "IP11 ProMax",
                Price = 15000000,
                Origin = "Trung Quốc",
                NgaySX = new DateTime(2022,12,12)
            };

            SanPham SamsungS23ultra = new SanPham()
            {
                ID = "IP02",
                Name = "Samsung S23 Ultra",
                Price = 25000000,
                Origin = "Mỹ",
                NgaySX = new DateTime(2023, 12, 12)
            };

            SanPham IP15 = new SanPham()
            {
                ID = "IP03",
                Name = "IP 15 ProMax",
                Price = 30000000,
                Origin = "Trung Quốc",
                NgaySX = new DateTime(2024, 12, 12)
            };

            // Thêm sp add vào danh muc
            DienThoaiDiDong.ListSP.Add(IP11);
            IP11.isDanhMuc = DienThoaiDiDong;

            DienThoaiDiDong.ListSP.Add(SamsungS23ultra);
            SamsungS23ultra.isDanhMuc = DienThoaiDiDong;

            DienThoaiDiDong.ListSP.Add(IP15);
            IP15.isDanhMuc = DienThoaiDiDong;

            // Hiển thị danh mục lên trên combobox
            cbbDanhMuc.Items.Clear();
            cbbDanhMuc.Items.Add(DienThoaiDiDong);
            cbbDanhMuc.Items.Add(Laptop);
            cbbDanhMuc.Items.Add(MayTinhBang);

        }

        private void tvDanhMuc_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null)
            {
                DanhMuc danhMuc = e.Node.Tag as DanhMuc;
                lvDanhSachSP.Items.Clear();

                foreach(SanPham itemSP in danhMuc.ListSP)
                {
                    ListViewItem lvi = new ListViewItem(itemSP.ID);
                    lvi.SubItems.Add(itemSP.Name);
                    lvi.SubItems.Add(itemSP.Price.ToString());
                    lvi.SubItems.Add(itemSP.Origin);
                    lvi.SubItems.Add(itemSP.NgaySX.ToString("dd/MM/yyyy"));
                    lvi.SubItems.Add(itemSP.isDanhMuc.ToString());

                    lvDanhSachSP.Items.Add(lvi);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cbbDanhMuc.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn danh mục!");
            }
                SanPham sp = new SanPham();
                sp.ID = txtMaSP.Text.Trim();
                sp.Name = txtTenSP.Text.Trim();
                sp.Price = double.Parse(txtDonGia.Text.Trim());
                sp.Origin = txtXuatXu.Text.Trim();
                sp.NgaySX = new DateTime(dtpNgaySX.Value.Year, dtpNgaySX.Value.Month, dtpNgaySX.Value.Day);
                DanhMuc danhMuc = cbbDanhMuc.SelectedItem as DanhMuc;
                sp.isDanhMuc = danhMuc;
                danhMuc.ListSP.Add(sp);

                MessageBox.Show("Thêm thành công!");
        }

        private void lvDanhSachSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDanhSachSP.SelectedItems.Count == 0) return;

            ListViewItem lvi = lvDanhSachSP.SelectedItems[0];
            txtMaSP.Text = lvi.SubItems[0].Text;
            txtTenSP.Text = lvi.SubItems[1].Text;
            txtDonGia.Text = lvi.SubItems[2].Text;
            txtXuatXu.Text = lvi.SubItems[3].Text;

            string[] arr = lvi.SubItems[4].Text.Split('/');
            dtpNgaySX.Value = new DateTime(int.Parse(arr[2]), int.Parse(arr[1]), int.Parse(arr[0]));
            cbbDanhMuc.Text = lvi.SubItems[5].Text;
        }
    }
}
