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

namespace DataQuery_AnRow
{
    public partial class Form1 : Form
    {
        string strCon = @"Data Source=DESKTOP-R37J0MS\DUNGLTK;Initial Catalog=Quanlybanhang;Integrated Security=True";
        SqlConnection sqlCon = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if(sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }

            if(sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            SqlCommand sqlCmd = sqlCon.CreateCommand();    
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select * from VATTU";

            sqlCmd.Connection = sqlCon;

            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string maVTu = reader.GetString(0);
                string tenVTu = reader.GetString(1);
                string dvTinh = reader.GetString(2);
                float phanTram = reader.GetFloat(3);

                ListViewItem lvi = new ListViewItem(maVTu);
                lvi.SubItems.Add(tenVTu);
                lvi.SubItems.Add(dvTinh);
                lvi.SubItems.Add(phanTram.ToString());

                lviDSSP.Items.Add(lvi);
            }
            reader.Close();
        }
    }
}
