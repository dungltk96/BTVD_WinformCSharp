using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatetimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblDangKyThiLX_Click(object sender, EventArgs e)
        {

        }

        private void lblHoTen_Click(object sender, EventArgs e)
        {

        }

        private void lblTuoi_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblNgaySinh_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            //Xóa bỏ thông báo lỗi khi input đã hợp lệ
            Error.SetError(txtHoTen, "");
            Error.SetError(txtTuoi, "");
            Error.SetError(dtpNgayDK, "");

            //Kiểm tra họ tên không được bỏ trống
            if (txtHoTen.Text.Trim() == "")
            {
                Error.SetError(txtHoTen, "Họ tên không được bỏ trống!");
                return;
            }

            //Kiểm tra tuổi > 17
            if (txtTuoi.Text.Trim() == "")
            {
                Error.SetError(txtTuoi, "Tuổi không được bỏ trống!");
                return;
            }
            else
            {
                // Lấy giá trị tuổi
                int tuoi = Convert.ToInt32(txtTuoi.Text.Trim());
                if (tuoi < 18)
                {
                    Error.SetError(txtTuoi, "Tuổi không được nhỏ hơn 18!");
                    return;
                }
            }

            //Kiểm tra ngày ĐK không vào ngày CN
            if (dtpNgayDK.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                Error.SetError(dtpNgayDK, "Không đăng ký thi vào ngày chủ nhật!");
                return;
            }

            //Đúng hết
            MessageBox.Show("Đăng ký thành công!");
            Close();
        }
    }
}
