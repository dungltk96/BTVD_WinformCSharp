using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckedListbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lsvListItemSelected_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            // Kiểm tra các item được chọn
            int n = chkListItem.CheckedItems.Count;
            if ((n>0))
            {
                int stt = 0;
                lsvListItemSelected.Items.Clear(); // Xóa
                for (int i = 0; i< n; i++)
                {
                    ListViewItem lsv = new ListViewItem((++stt).ToString()); //Sau mỗi lần duyệt xong sẽ hiển thị item trên listview
                    lsv.SubItems.Add(chkListItem.CheckedItems[i].ToString());

                    // Thêm từng dòng dữ liệu vào luiistview 
                    lsvListItemSelected.Items.Add(lsv);
                }

            }
        }

        private void chkListItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
