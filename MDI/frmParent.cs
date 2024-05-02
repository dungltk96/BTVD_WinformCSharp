using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI
{
    public partial class frmParent : Form
    {
        public frmParent()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void canscateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuFileNew_Click(object sender, EventArgs e)
        {
            //Gọi form con nằm trong form cha
            frmChild frmChildForm = new frmChild();
            frmChildForm.MdiParent = this; //Chỉ định form cha cho form con frmChildForm
            frmChildForm.Text = "Untitle"; //Tiêu đề cho frmChildForm
            frmChildForm.Show(); //Hiển thị nó lên
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            mnuFileNew_Click(sender, e);
        }

        private void mnuViewSortAI_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void mnuViewSortC_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void mnuViewSortTH_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuViewSortTV_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            mnuFileNew_Click(sender, e);
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            mnuFileNew_Click(sender, e);
        }
    }
}
