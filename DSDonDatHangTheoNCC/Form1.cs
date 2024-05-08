using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSDonDatHangTheoNCC
{
    public partial class Form1 : Form
    {
        string strCon = @"Data Source=DESKTOP-R37J0MS\DUNGLTK;Initial Catalog=Quanlybanhang;Integrated Security=True";
        SqlConnection sqlCon = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }

            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select * from NHACC";

            sqlCmd.Connection = sqlCon;

            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string maNCC = reader.GetString(0);
                string tenNCC = reader.GetString(1);
                /*string diaChi = reader.GetString(2);
                string dienThoai = reader.GetString(3);*/

                string line = maNCC + "-" + tenNCC;
                lsbNCC.Items.Add(line);

            }
            reader.Close();
        }

        private void lsbNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbNCC.SelectedIndex == -1) return; // Chưa chọn row thì return

            string line = lsbNCC.SelectedItem.ToString(); //Xác định được row đã chọn
            string[] arr = line.Split('-'); // Phân tách mảng
            string maNCC = arr[0];

            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }

            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select * from DONDH where MaNCC=@MaNCC";

            // Định nghĩa parameter @MaNCC
            SqlParameter parMaNCC = new SqlParameter("@MaNCC", SqlDbType.Char);
            parMaNCC.Value = maNCC.Trim();
            sqlCmd.Parameters.Add(parMaNCC);

            sqlCmd.Connection = sqlCon;

            // Thực thi truy vấn
            SqlDataReader reader = sqlCmd.ExecuteReader();
            lsvCardNCC.Items.Clear(); // Clear dữ liệu đã chọn row trước đó

            while (reader.Read())
            {
                string soDonHang = reader.GetString(0);
                DateTime ngayDatHang = reader.GetDateTime(1);
                /*string diaChi = reader.GetString(2);
                string dienThoai = reader.GetString(3);*/

                /* string lines = soDonHang + "-" + ngayDatHang;
                 lsbNCC.Items.Add(lines);*/

                ListViewItem lvi = new ListViewItem(soDonHang);
                lvi.SubItems.Add(ngayDatHang.ToString());

                lsvCardNCC.Items.Add(lvi);
            }
            reader.Close();
        }
    }
}
