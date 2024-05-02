using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatetimePickerAdvance
{
    public partial class frmĐK : Form
    {
        public frmĐK()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Kiểm tra input Phone
            int phone;
            int tuoi;
            bool check = true;

            errorProvider1.Clear(); // Xóa toàn bộ thông báo lỗi trước khi kiểm tra
            if(txtPhone.Text == "")
            {
                errorProvider1.SetError(txtPhone, "Bạn chưa nhập số điện thoại!");
            }else if(int.TryParse(txtPhone.Text, out phone) == false)
            {
                errorProvider1.SetError(txtPhone, "Số điện thoại không hợp lệ!");
            }

            // Kiểm tra input Age
            // Kiểm tra nhập đúng định dạng số (cần dùng ép kiểu)
            if (txtAge.Text == "")
            {
                errorProvider1.SetError(txtAge, "Bạn chưa nhập tuổi!");
                check = false;
            }else if (int.TryParse(txtAge.Text, out tuoi) == false) 
            {
                errorProvider1.SetError(txtAge, "Sai định dạng!");
                check = false;
            }
            else
            {
                if (tuoi <= 17)
                {
                    errorProvider1.SetError(txtAge, "Tuổi phải lớn hơn 17");
                    check = false;
                }
            }

            // Kiểm tra input DatetimePicker
            if(dtpDK.Value.DayOfWeek == DayOfWeek.Monday)
            {
                errorProvider1.SetError(dtpDK, "Thứ 2 rạp không chiếu phim");
                check = false;
            }

            if (check == true)
            {
                MessageBox.Show("Bạn đă đăng ký thành công!");
                Close();
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpDK_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
