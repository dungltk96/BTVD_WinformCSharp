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

namespace UpdateData_DB
{
    public partial class Form1 : Form
    {
        string strCon = @"Data Source=DESKTOP-R37J0MS\DUNGLTK;Initial Catalog=QLNH;Integrated Security=True";
        SqlConnection sqlCon = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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
            sqlCmd.CommandText = "select * from NHOMMONAN";

            // Gán vào đường truyền kết nối
            sqlCmd.Connection = sqlCon;

            SqlDataReader reader = sqlCmd.ExecuteReader();
            cboChonGroupMonAn.Items.Clear();    

            while(reader.Read())
            {
                string idNhom = reader.GetString(0);
                string tenNhom = reader.GetString(1);

                string line = idNhom.Trim() + "/" + tenNhom;

                cboChonGroupMonAn.Items.Add(line);
            }
            reader.Close();
        }

        private void cboChonGroupMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboChonGroupMonAn.SelectedIndex == -1) return; // Chưa chọn

            string line = cboChonGroupMonAn.SelectedItem.ToString();
            string[] arr = line.Split('/');
            string idNhom = arr[0];

            // Hiển thị thông tin của các món ăn theo nhóm
            HienThiThongTinMonAn(idNhom);
        }

        private void HienThiThongTinMonAn(string idNhom)
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
            sqlCmd.CommandText = "select * from MONAN where IDNhomMA = '"+idNhom+"'";

            sqlCmd.Connection = sqlCon;

            SqlDataReader reader = sqlCmd.ExecuteReader();
            lsvThongTinMonAn.Items.Clear();

            while(reader.Read())
            {
                string idMon = reader.GetString(0);
                string idNhomMon = reader.GetString(1);
                string tenMon = reader.GetString(2);
                string donViTinh = reader.GetString(3);
                float donGia = reader.GetFloat(4);

                ListViewItem lvi = new ListViewItem(idMon);
                lvi.SubItems.Add(idNhomMon);
                lvi.SubItems.Add(tenMon);
                lvi.SubItems.Add(donViTinh);
                lvi.SubItems.Add(donGia.ToString());

                lsvThongTinMonAn.Items.Add(lvi);
            }
            reader.Close();
        }

        private void lsvThongTinMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvThongTinMonAn.SelectedItems.Count == 0) return;

            // Lấy phần tử được chọn trên listview
            ListViewItem lvi = lsvThongTinMonAn.SelectedItems[0];

            // Hiển thị thông tin từ listview sang các textbox
            txtIDMonAn.Text = lvi.SubItems[0].Text;
            txtIDGroupMonAn.Text = lvi.SubItems[1].Text;
            txtTenMonAn.Text = lvi.SubItems[2].Text;
            txtDonViTinh.Text = lvi.SubItems[3].Text;
            txtDonGia.Text = lvi.SubItems[4].Text;
        }

        private void btnNotPara_Click(object sender, EventArgs e)
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
            sqlCmd.CommandText = "update MONAN set IDMA = '"+txtIDMonAn.Text.Trim()+"',IDNhomMA = '"+txtIDGroupMonAn.Text.Trim()+"',TenMA = N'"+txtTenMonAn.Text.Trim()+"',DonViTinh = N'"+txtDonViTinh.Text.Trim()+"',DonGiaMA = "+txtDonGia.Text.Trim()+ "where IDMA = '"+txtIDMonAn.Text.Trim()+"'";

            sqlCmd.Connection =sqlCon;

            int kq = sqlCmd.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Chỉnh sửa thành công!");
                HienThiThongTinMonAn(txtIDGroupMonAn.Text.Trim());
            }
            else
            {
                MessageBox.Show("Chỉnh sửa thông tin thất bại!");
            }
        }

        private void btnYesPara_Click(object sender, EventArgs e)
        {
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
            sqlCmd.CommandText = "update MONAN set IDMA = @IDMon,IDNhomMA = @IDNhom,TenMA = @tenMon,DonViTinh = @donVT,DonGiaMA = @donGia where IDMA = @IDMon";

            // Định nghĩa para
            SqlParameter paraIDMon = new SqlParameter("@IDMon", SqlDbType.Char);
            SqlParameter paraIDNhom = new SqlParameter("@IDNhom", SqlDbType.Char);
            SqlParameter paraTenMon = new SqlParameter("@tenMon", SqlDbType.NVarChar);
            SqlParameter paraDonVT = new SqlParameter("@donVT", SqlDbType.NVarChar);
            SqlParameter paraDonGia = new SqlParameter("@donGia", SqlDbType.Real);

            paraIDMon.Value = txtIDMonAn.Text.Trim();   
            paraIDNhom.Value = txtIDGroupMonAn.Text.Trim();   
            paraTenMon.Value = txtTenMonAn.Text.Trim();   
            paraDonVT.Value = txtDonViTinh.Text.Trim();
            paraDonGia.Value = txtDonGia.Text.Trim(); 
            
            sqlCmd.Parameters.Add(paraIDMon);
            sqlCmd.Parameters.Add(paraIDNhom);
            sqlCmd.Parameters.Add(paraTenMon);
            sqlCmd.Parameters.Add(paraDonVT);
            sqlCmd.Parameters.Add(paraDonGia);

            sqlCmd.Connection = sqlCon;
            sqlCmd.Connection = sqlCon;

            int kq = sqlCmd.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Chỉnh sửa thành công!");
                HienThiThongTinMonAn(txtIDGroupMonAn.Text.Trim());
            }
            else
            {
                MessageBox.Show("Chỉnh sửa thông tin thất bại!");
            }

        }
    }
}