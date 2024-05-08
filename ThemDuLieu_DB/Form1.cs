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

namespace ThemDuLieu_DB
{
    public partial class Form1 : Form
    {
        // Tạo biến cục bộ
        string strCon = @"Data Source=DESKTOP-R37J0MS\DUNGLTK;Initial Catalog=Quanlybanhang;Integrated Security=True";
        SqlConnection sqlCon = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load dữ liệu đã được khởi tạo trước đó
            HienThiDanhSach();
        }

        private void HienThiDanhSach()
        {
            if(sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }

            if(sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            // Đối tượng thực thi truy vấn
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select * from VATTU";

            sqlCmd.Connection = sqlCon;

            // Thực thi truy vấn
            SqlDataReader reader = sqlCmd.ExecuteReader();
            lsvDanhSachVT.Items.Clear();
            while(reader.Read())
            {
                string maVTu = reader.GetString(0);
                string tenVTu = reader.GetString(1);
                string donViTinh = reader.GetString(2);
                float phanTram = reader.GetFloat(3);

                // Hiển thị lên listView
                ListViewItem lvi = new ListViewItem(maVTu);
                lvi.SubItems.Add(tenVTu);
                lvi.SubItems.Add(donViTinh);
                lvi.SubItems.Add(phanTram.ToString());

                lsvDanhSachVT.Items.Add(lvi);
            }
            reader.Close();
        }

        private void lsvDanhSachVT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThemVTu_Click(object sender, EventArgs e)
        {
            /*KhongDungPara();*/

            CoDungPara();
        }

        private void CoDungPara()
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }

            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            // Đối tượng thực thi truy vấn
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "insert into VATTU values (@maVTu,@tenVTu,@donVTinh,@phanTram)";

            // Định nghĩa
            SqlParameter paraMaVT = new SqlParameter("@maVTu", SqlDbType.Char);
            SqlParameter paraTenVT = new SqlParameter("@tenVTu", SqlDbType.NVarChar);
            SqlParameter paraDonVTinh = new SqlParameter("@donVTinh", SqlDbType.NVarChar);
            SqlParameter paraPhanTram = new SqlParameter("@phanTram", SqlDbType.Real);

            // Gán giá trị
            paraMaVT.Value = txtMaVT.Text.Trim();
            paraTenVT.Value = txtTenVT.Text.Trim();
            paraDonVTinh.Value = txtDonViTinh.Text.Trim();
            paraPhanTram.Value = txtPhanTram.Text.Trim();

            sqlCmd.Parameters.Add(paraMaVT);
            sqlCmd.Parameters.Add(paraTenVT);
            sqlCmd.Parameters.Add(paraDonVTinh);
            sqlCmd.Parameters.Add(paraPhanTram);

            sqlCmd.Connection = sqlCon;

            int kq = sqlCmd.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công!");
                HienThiDanhSach();
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu không thành công!");
            }
        }

        private void KhongDungPara()
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }

            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            // Lấy dữ liệu
            string maVTu = txtMaVT.Text.Trim();
            string tenVTu = txtTenVT.Text.Trim();
            string donViTinh = txtDonViTinh.Text.Trim();
            string phanTram = txtPhanTram.Text.Trim();


            // Đối tượng thực thi truy vấn
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "insert into VATTU values ('"+maVTu+"',N'"+tenVTu+"',N'"+donViTinh+"',"+phanTram+")";

            sqlCmd.Connection = sqlCon;

            // Kiểm tra thực thi, giá tị = 0 (ko thành công) - giá trị # 0 (có thành công)
            int kq = sqlCmd.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công!");
                HienThiDanhSach();
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu không thành công!");
            }
        }
    }
}
