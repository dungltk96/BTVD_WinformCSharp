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

namespace DataQueryForAValue
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

        private void btnQuery_Click(object sender, EventArgs e)
        {
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

            // Tạo đối tượng thực thi truy vấn
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select COUNT(*) from VATTU";

            // Gửi câu lệnh truy vấn về kết nối
            sqlCmd.Connection = sqlCon;

            // Nhận kết quả
            int soLuongVT = (int)sqlCmd.ExecuteScalar();

            MessageBox.Show("Số lượng vật tư là: " + soLuongVT);
        }
    }
}
