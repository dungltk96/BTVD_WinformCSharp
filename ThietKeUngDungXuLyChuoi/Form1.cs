using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThietKeUngDungXuLyChuoi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCountStringChar_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtInput.Text.Length.ToString();
        }

        private void btnConvertUppeCase_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtInput.Text.ToUpper();
        }

        private void ConvertLowerCase_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtInput.Text.ToLower();
        }

        private void btnCountUpperCase_Click(object sender, EventArgs e)
        {
            int dem = 0;
            string s = txtInput.Text.Trim();
            foreach (char c in s)
            {
                if (char.IsUpper(c)) dem++;
                txtOutput.Text = dem.ToString();
            }
        }

        private void btnCountLowerCase_Click(object sender, EventArgs e)
        {
            int dem = 0;
            string s = txtInput.Text.Trim();

            foreach(char c in s)
            {
                if(char.IsLower(c)) dem++;
                txtOutput.Text = dem.ToString();
            }
        }

        private void btnCountChar_Click(object sender, EventArgs e)
        {
            int dem = 0;
            string s = txtInput.Text.Trim();
            foreach( char c in s)
            {
                if(char.IsDigit(c)) dem++;
                txtOutput.Text = dem.ToString() ;
            }
        }

        private void btnReversesString_Click(object sender, EventArgs e)
        {
            char[] s = txtInput.Text.Trim().ToCharArray();  
            Array.Reverse(s);
            txtOutput.Text = new string(s);
        }

        private void btnLocationFirstly_Click(object sender, EventArgs e)
        {
            int vt = txtInput.Text.Trim().IndexOf(txtLlocationFirstly.Text.Trim());
            if(vt == -1)
            {
                txtInput.Text = "Không tìm thấy";
            }
            else
            {
                txtOutput.Text = vt.ToString();
            }
        }

        private void btnLloacationFinal_Click(object sender, EventArgs e)
        {
            int vt = txtInput.Text.Trim().IndexOf(txtLocationFinal.Text.Trim());
            if(vt == -1)
            {
                txtInput.Text = "Không tìm thấy";
            }
            else
            {
                txtInput.Text = vt.ToString();  
            }
        }

        private void btnTheCount_Click(object sender, EventArgs e)
        {
            int dem = 0;
            int a = 0;
            string s = txtInput.Text.Trim();    
            while((a=s.IndexOf(txtTheCount.Text.Trim(), a)) != -1)
            {
                a += txtTheCount.Text.Trim().Length;
                dem++;
            }
            txtOutput.Text = dem.ToString();
        }

        private void btnInsertString_Click(object sender, EventArgs e)
        {
            string s = txtInput.Text.Trim();
            txtOutput.Text = s.Insert((int)numLocation.Value, txtInsertString.Text.Trim()); 
        }
    }
}
