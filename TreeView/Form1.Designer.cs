namespace TreeView
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Khoa công nghệ thông tin");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Khoa thú y");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Khoa cơ điện");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Học viện nông nghiệp Việt Nam", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Khoa luật");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Bộ phận tài chính kế toán");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Học viện MNQ", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node2";
            treeNode1.Text = "Khoa công nghệ thông tin";
            treeNode2.Name = "Node3";
            treeNode2.Text = "Khoa thú y";
            treeNode3.Name = "Node4";
            treeNode3.Text = "Khoa cơ điện";
            treeNode4.Name = "Node0";
            treeNode4.Text = "Học viện nông nghiệp Việt Nam";
            treeNode5.Name = "Node5";
            treeNode5.Text = "Khoa luật";
            treeNode6.Name = "Node6";
            treeNode6.Text = "Bộ phận tài chính kế toán";
            treeNode7.Name = "Node1";
            treeNode7.Text = "Học viện MNQ";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode7});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(1553, 988);
            this.treeView1.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1553, 988);
            this.Controls.Add(this.treeView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
    }
}

