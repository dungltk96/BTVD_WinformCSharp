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

namespace DeleteData
{
    public partial class Form1 : Form
    {
        // Tạo biến cục bộ
        string strCon = @"Data Source=DESKTOP-R37J0MS\DUNGLTK;Initial Catalog=QLNH;Integrated Security=True";
        SqlConnection sqlCon = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Kiểm tra chuỗi kết nối
            if(sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }

            if(sqlCon.State == ConnectionState.Closed )
            {
                sqlCon.Open();
            }

            // Đối tượng thực thi truy vấn
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select * from NHOMMONAN";

            // Gán đối tượng thực thi truy vấn vào kết nối sqlCmd
            sqlCmd.Connection = sqlCon;

            // Thực thi đọc bảng
            SqlDataReader reader = sqlCmd.ExecuteReader();
            cboChonMon.Items.Clear(); //Clear dữ liệu cũ

            while(reader.Read()) // Trong khi vẫm còn đọc được
            {
                // Lấy dl từ trong csdl lên
                string maNhom = reader.GetString(0);
                string tenNhom = reader.GetString(1);

                //
                string line = maNhom.Trim() +"/"+ tenNhom.Trim();

                cboChonMon.Items.Add(line);
            }
            reader.Close();
        }
        string idNhomMA = "";
        private void lsvListMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboChonMon.SelectedIndex == -1) return;  // Chưa chọn thì return

            string line = cboChonMon.SelectedItem.ToString();

            string[] arr = line.Split('/');

            idNhomMA = arr[0];

            HienThiMonAnTheoNhom(idNhomMA);
        }

        private void HienThiMonAnTheoNhom(string idNhomMA)
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
            sqlCmd.CommandText = "select * from MONAN where IDNhomMA = '"+ idNhomMA + "'";

            // Gán đối tượng thực thi truy vấn vào kết nối sqlCmd
            sqlCmd.Connection = sqlCon;

            // Thực thi đọc bảng
            SqlDataReader reader = sqlCmd.ExecuteReader();
            cboChonMon.Items.Clear(); //Clear dữ liệu cũ

            while (reader.Read()) // Trong khi vẫm còn đọc được
            {
                // Lấy dl từ trong csdl lên
                string maMonAn = reader.GetString(0);
                /*string maNhom*/
                string tenMon = reader.GetString(2);
                string donVTinh = reader.GetString(3);
                float donGiaMon = reader.GetFloat(4);

                ListViewItem lvi = new ListViewItem(maMonAn);

                lvi.SubItems.Add(idNhomMA);
                lvi.SubItems.Add(tenMon); 
                lvi.SubItems.Add(donVTinh);
                lvi.SubItems.Add(donGiaMon.ToString());

                lsvListMon.Items.Add(lvi);
            }
            reader.Close();
        }
    }
}
