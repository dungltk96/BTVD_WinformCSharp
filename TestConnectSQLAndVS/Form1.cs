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

namespace TestConnectSQLAndVS
{
    public partial class Form1 : Form
    {
        // Tạo biến cục bộ
        string strCon = @"Data Source=DESKTOP-R37J0MS\DUNGLTK;Initial Catalog=TestDB;Integrated Security=True";

        // Tạo đối tượng kết nối
        SqlConnection sqlCon = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOpenConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon == null)
                {
                    sqlCon = new SqlConnection(strCon); // Rỗng thì tạo mới
                }

                // Mở kết nối
                if(sqlCon.State == ConnectionState.Closed) // Đóng kết nối thì mở
                {
                    sqlCon.Open();
                    MessageBox.Show("Kết nối thành công!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDisableConnect_Click(object sender, EventArgs e)
        {
            if(sqlCon != null && sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
                MessageBox.Show("Đóng kết nối thành công!");
            }
            else
            {
                MessageBox.Show("Chưa tạo kết nối!");
            }
        }
    }
}
