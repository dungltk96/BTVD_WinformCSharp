using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; //Khai báo thư viện khi chèn nhạc

namespace PictureBoxAdvance
{
    public partial class Form1 : Form
    {
        // Khai báo sử dụng tính năng phát nhạc
        private SoundPlayer choinhac;
        public Form1()
        {
            InitializeComponent();
            // Khai báo sử dụng tính năng phát nhạc
            //choinhac = new SoundPlayer(@"D:\DocumentCSharp\nhactap.wav");
            choinhac = new SoundPlayer("nhactap.wav");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picHaTa.Visible = false;
            picNangTa.Visible = true;
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            //Close();
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            //btnClick.Text = txtInput.Text;
            if(picHaTa.Visible ==  false)
            {
                btnClick.Text = txtInput.Text + " !KD click để hạ tạ đi";
            }else
            {
                btnClick.Text = txtInput.Text + "!KD click để nâng tạ đi";
            }
        }
        int count = 1;
        private void btnClick_Click(object sender, EventArgs e)
        {
            if (picHaTa.Visible == false)
            {
                picHaTa.Visible = true;
                picNangTa.Visible = false;
                btnClick.Text = btnClick.Text.Replace("hạ", "nâng");
                lblCout.Text = count.ToString();
                count++;
                if(count == 11)
                {
                    DialogResult result = MessageBox.Show("Bạn đã hoàn thành set 10 cái! Bạn có muốn tiếp tục tập?","Hỏi",MessageBoxButtons.YesNo,MessageBoxIcon.Question); 
                    if (result == DialogResult.No)
                    {
                        Close();
                    }
                }
            }
            else
            {
                picHaTa.Visible = false;
                picNangTa.Visible = true;
                btnClick.Text = btnClick.Text.Replace("nâng", "hạ");
            }
        }

        private void chkMusic_CheckedChanged(object sender, EventArgs e)
        {
            if(chkMusic.Checked == true)
            {
                choinhac.Play();
            }
            else
            {
                choinhac.Stop();
            }
        }
    }
}
