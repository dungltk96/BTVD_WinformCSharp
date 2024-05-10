using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BTTHEnd_DB
{
    public partial class Form1 : Form
    {
        string strCon = Properties.Settings.Default.stringCon;
        SqlConnection sqlCon = null;

        // Hàm kết nối csdl
        private void OpenCon()
        {
            if (sqlCon == null) sqlCon = new SqlConnection(strCon);
            if(sqlCon.State == ConnectionState.Closed) sqlCon.Open();
        }

        // Hàm đóng kết nối

        private void CloseCon()
        {
            if (sqlCon.State == ConnectionState.Open && sqlCon != null)
            {
                sqlCon.Close();
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiDanhSach(); // Tạo hàm hiển thị danh sách
        }

        private void HienThiDanhSach()
        {
            try
            {
                // Mở kết nối
                OpenCon();

                // Thực hiện truy vấn 
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "select * from tblMayBay";

                // Gán vào trong đường kết nối
                sqlCmd.Connection = sqlCon;

                // Thực thi câu lệnh truy vấn
                SqlDataReader reader = sqlCmd.ExecuteReader();
                lsvDSSP.Items.Clear();
                lsvDSSP.Groups.Clear();

                // Phân nhóm 1 (Thương gia)
                ListViewGroup group1 = new ListViewGroup("Thương gia");
                lsvDSSP.Groups.Add(group1);

                // Phân nhóm 2 (Phổ thông)
                ListViewGroup group2 = new ListViewGroup("Phổ thông");
                lsvDSSP.Groups.Add(group2);

                while (reader.Read())
                {
                    int ma = reader.GetInt32(0);
                    string ten = reader.GetString(1);
                    string hang = reader.GetString(2);
                    int kichThuoc = reader.GetInt32(3);
                    int soGhe = reader.GetInt32(4);
                    string phanLoai = reader.GetString(5);

                    ListViewItem lvi = new ListViewItem(ma.ToString());
                    lvi.SubItems.Add(ten);
                    lvi.SubItems.Add(hang);
                    lvi.SubItems.Add(kichThuoc.ToString());
                    lvi.SubItems.Add(soGhe.ToString());
                    lvi.SubItems.Add(phanLoai);

                    lsvDSSP.Items.Add(lvi);

                    if (string.Compare(phanLoai, "Thương gia", true) == 0)
                    {
                        lvi.Group = group1; // Nhóm thương gia
                    }
                    else
                    {
                        lvi.Group = group2; // Nhóm phổ thông
                    }

                    lvi.Tag = ma;
                }
                reader.Close();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } 

        private void HienThiChiTiet(int ma) //Lấy thông tin chi tiết dựa vào mã sp nên truyền (int ma
        {
            try
            {
                OpenCon();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "select * from tblMayBay where idMayBay = @ma";

                // Định nghĩa para
                SqlParameter paraMa = new SqlParameter("@ma", SqlDbType.Int);
                paraMa.Value = ma;
                sqlCmd.Parameters.Add(paraMa);

                sqlCmd.Connection = sqlCon;

                // Hiển thị dữ liệu lên control giao diện
                SqlDataReader reader = sqlCmd.ExecuteReader();
                if (reader.Read()) // Nếu đầu đọc còn đọc được
                {
                    string ten = reader.GetString(1);
                    string hang = reader.GetString(2);
                    int kichThuoc = reader.GetInt32(3);
                    int soGhe = reader.GetInt32(4);
                    string phanLoai = reader.GetString(5);

                    // Đẩy lên trên giao diện
                    txtIDMay.Text = ma.ToString();
                    txTenMay.Text = ten;
                    txtKichThuoc.Text = kichThuoc.ToString();

                    // So sánh giá trị trong csdl với giá trị được chọn trong combo
                    if (hang == "Vietnam Airlines") cboHangSX.SelectedIndex = 0;
                    else if (hang == "Vietjet Air") cboHangSX.SelectedIndex = 1;
                    else if (hang == " Jetstar Pacific Airlines") cboHangSX.SelectedIndex = 2;
                    else cboHangSX.SelectedIndex = 3;

                    if(soGhe == 100) cboSoGhe.SelectedIndex = 0;
                    else cboSoGhe.SelectedIndex=1;

                    if(phanLoai == "Thương Gia") cboPhanLoai.SelectedIndex = 0;
                    else cboPhanLoai.SelectedIndex = 1;
                }
                reader.Close();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lsvDSSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDSSP.SelectedItems.Count == 0) return; // ==0  là chưa chọn dl
            ListViewItem lvi = lsvDSSP.SelectedItems[0];
            int ma = (int)lvi.Tag;
            HienThiChiTiet(ma);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Clear dữ liệu trước khi thêm
            txtIDMay.Text = "";
            txTenMay.Text = "";
            txtKichThuoc.Text = "";
            cboHangSX.SelectedIndex = 0; // Để mặc định giá trị đầu tiên
            cboPhanLoai.SelectedIndex = 0;
            cboSoGhe.SelectedIndex = 0;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Hàm kiểm tra mã máy bay đã tồn tại hay chưa
            bool kq = KiemTraTonTai(txtIDMay.Text.Trim());

            if(kq == false) // mã chưa tồn tại
            {
                ThemMoiDulieu();
            }
            else
            {
                CapNhatDuLieu(txtIDMay.Text.Trim());
            }
        }

        private void CapNhatDuLieu(string ma)
        {
            try
            {
                OpenCon();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "update tblMayBay set tenMayBay=@ten, hangSanXuat=@hang, kichThuoc=@size, soGhe=@soGhe, phanLoai=@phanLoai where IDMayBay=@ma";


                SqlParameter paraMa = new SqlParameter("@ma", SqlDbType.Int);
                paraMa.Value = txtIDMay.Text.Trim();
                sqlCmd.Parameters.Add(paraMa);

                SqlParameter paraTen = new SqlParameter("@ten", SqlDbType.VarChar);
                paraTen.Value = txTenMay.Text.Trim();
                sqlCmd.Parameters.Add(paraTen);

                SqlParameter paraHangSX = new SqlParameter("@hangsx", SqlDbType.NVarChar);
                paraHangSX.Value = cboHangSX.Text.Trim();
                sqlCmd.Parameters.Add(paraHangSX);

                SqlParameter paraSize = new SqlParameter("@size", SqlDbType.Int);
                paraSize.Value = txtKichThuoc.Text.Trim();
                sqlCmd.Parameters.Add(paraSize);

                SqlParameter paraSoGhe = new SqlParameter("@soGhe", SqlDbType.Int);
                paraSoGhe.Value = cboSoGhe.Text.Trim();
                sqlCmd.Parameters.Add(paraSoGhe);

                SqlParameter paraPhanLoai = new SqlParameter("@phanLoai", SqlDbType.NVarChar);
                paraPhanLoai.Value = cboHangSX.Text.Trim();
                sqlCmd.Parameters.Add(paraPhanLoai);

                sqlCmd.Connection = sqlCon;

                int kq = sqlCmd.ExecuteNonQuery();
                if (kq > 0) // dữ liệu có sự thay đổi
                {
                    MessageBox.Show("Cập nhật thành công!");
                    HienThiDanhSach();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ThemMoiDulieu()
        {
            try
            {
                OpenCon();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "insert into tblMayBay values (@ma, @ten, @hangsx, @size, @soGhe, @phanLoai)";

                SqlParameter paraMa = new SqlParameter("@ma", SqlDbType.Int);
                paraMa.Value = txtIDMay.Text.Trim();
                sqlCmd.Parameters.Add(paraMa);

                SqlParameter paraTen = new SqlParameter("@ten", SqlDbType.VarChar);
                paraTen.Value = txTenMay.Text.Trim();
                sqlCmd.Parameters.Add(paraTen);

                SqlParameter paraHangSX = new SqlParameter("@hangsx", SqlDbType.NVarChar);
                paraHangSX.Value = cboHangSX.Text.Trim();
                sqlCmd.Parameters.Add(paraHangSX);

                SqlParameter paraSize = new SqlParameter("@size", SqlDbType.Int);
                paraSize.Value = txtKichThuoc.Text.Trim();
                sqlCmd.Parameters.Add(paraSize);

                SqlParameter paraSoGhe = new SqlParameter("@soGhe", SqlDbType.Int);
                paraSoGhe.Value = cboSoGhe.Text.Trim();   
                sqlCmd.Parameters.Add(paraSoGhe);

                SqlParameter paraPhanLoai = new SqlParameter("@phanLoai", SqlDbType.NVarChar);
                paraPhanLoai.Value = cboPhanLoai.Text.Trim();
                sqlCmd.Parameters.Add(paraPhanLoai);

                sqlCmd.Connection = sqlCon;

                int kq = sqlCmd.ExecuteNonQuery();
                if(kq > 0) // dữ liệu có sự thay đổi
                {
                    MessageBox.Show("Thêm thành công!");
                    HienThiDanhSach();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool KiemTraTonTai(string ma)
        {
            try
            {
                OpenCon();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "select * from tblMayBay where idMayBay = @ma";

                SqlParameter paraMa = new SqlParameter("@ma", SqlDbType.Int);
                paraMa.Value = ma;
                sqlCmd.Parameters.Add(paraMa);

                sqlCmd.Connection = sqlCon;
                SqlDataReader reader = sqlCmd.ExecuteReader();

                if(reader.Read())
                {
                    reader.Close();
                    return true;
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(lsvDSSP.SelectedItems.Count == 0)
            {
                MessageBox.Show("Chưa chọn dữ liệu xóa!");
                return;
            }
            else
            {
                ListViewItem lvi = lsvDSSP.SelectedItems[0];
                int ma = (int)lvi.Tag;

                DialogResult kq = MessageBox.Show("Bạn có thực sự muốn xóa không?", "Hộp thoại", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(kq == DialogResult.Yes)
                {
                    XoaDuLieu(ma);
                }
            }
        }

        private void XoaDuLieu(int ma)
        {
            try
            {
                OpenCon();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "delete from tblMayBay where idMayBay = @ma";

                SqlParameter paraMa = new SqlParameter("@ma", SqlDbType.Int);
                paraMa.Value = ma;
                sqlCmd.Parameters.Add(paraMa);

                sqlCmd.Connection = sqlCon;

                int kq =sqlCmd.ExecuteNonQuery();
                if(kq > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    HienThiDanhSach();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
