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
using static System.Net.Mime.MediaTypeNames;

namespace DataQuery_ARow1
{
    public partial class Form1 : Form
    {
        // Chuỗi kết nối, tạo biến cục bộ
        string strCon = @"Data Source=DESKTOP-R37J0MS\DUNGLTK;Initial Catalog=Quanlybanhang;Integrated Security=True";

        // Tạo đối tượng kết nối
        SqlConnection sqlCon = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNotParam_Click(object sender, EventArgs e)
        {
            //CÁCH 1: KHÔNG DÙNG PARAMETER
            // Rỗng thì tạo
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }

            // Đóng thì mở
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            string maVtu = txtMaVtu.Text.Trim();

            // Tạo đối tượng thực thi truy vấn
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select * from VATTU where MaVTu = '" + maVtu + "'"; // Cách 1: Không dùng parameter

            // Gửi câu lệnh truy vấn về kết nối (Gán đối tượng thực thi truy vấn vào trong đường kết nối)
            sqlCmd.Connection = sqlCon;

            // Thực thi
            SqlDataReader sqlDataReader = sqlCmd.ExecuteReader();
            if (sqlDataReader.Read())
            {
                string tenVT = sqlDataReader.GetString(1);
                string donViTinh = sqlDataReader.GetString(2);
                float phanTram = sqlDataReader.GetFloat(3);

                // Hiển thị kết quả
                txtTenVTu.Text = tenVT;
                txtDonViTinh.Text = donViTinh;
                txtPhanTram.Text = phanTram.ToString();
            }

            // Đóng đầu đọc
            sqlDataReader.Close();
        }

        private void btnYesParam_Click(object sender, EventArgs e)
        {
            //CÁCH 2: DÙNG PARAMETER
            // Rỗng thì tạo
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }

            // Đóng thì mở
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            string maVtu = txtMaVtu.Text.Trim();

            // Tạo đối tượng thực thi truy vấn
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select * from VATTU where MaVTu=@MaVTu"; // Cách 2: Dùng parameter --> Thay chuỗi dữ liệu cần tìm bằng biến (vd: chuỗi ID: TV14)

            // Định nghĩa @
            SqlParameter paraVTu = new SqlParameter("@MaVTu", SqlDbType.Char);
            paraVTu.Value = txtMaVtu.Text.Trim(); // Lấy giá trị
            sqlCmd.Parameters.Add(paraVTu);        // Gán paraMaVT vào trong đối tượng truy vấn

            sqlCmd.Connection = sqlCon;

            // Thực thi
            SqlDataReader sqlDataReader = sqlCmd.ExecuteReader();
            if (sqlDataReader.Read())
            {
                string tenVT = sqlDataReader.GetString(1);
                string donViTinh = sqlDataReader.GetString(2);
                float phanTram = sqlDataReader.GetFloat(3);

                // Hiển thị kết quả
                txtTenVTu.Text = tenVT;
                txtDonViTinh.Text = donViTinh;
                txtPhanTram.Text = phanTram.ToString();
            }

            // Đóng đầu đọc
            sqlDataReader.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
