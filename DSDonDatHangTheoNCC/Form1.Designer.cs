namespace DSDonDatHangTheoNCC
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsvCardNCC = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsbNCC = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1126, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "LẤY DANH SÁCH ĐƠN ĐẶT HÀNG THEO NCC";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lsbNCC);
            this.groupBox1.Location = new System.Drawing.Point(59, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 653);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhà cung cấp:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsvCardNCC);
            this.groupBox2.Location = new System.Drawing.Point(826, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(899, 653);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách đơn hàng theo NCC:";
            // 
            // lsvCardNCC
            // 
            this.lsvCardNCC.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lsvCardNCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvCardNCC.FullRowSelect = true;
            this.lsvCardNCC.GridLines = true;
            this.lsvCardNCC.HideSelection = false;
            this.lsvCardNCC.Location = new System.Drawing.Point(3, 34);
            this.lsvCardNCC.Name = "lsvCardNCC";
            this.lsvCardNCC.Size = new System.Drawing.Size(893, 616);
            this.lsvCardNCC.TabIndex = 0;
            this.lsvCardNCC.UseCompatibleStateImageBehavior = false;
            this.lsvCardNCC.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Số đơn hàng";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ngày đặt hàng";
            this.columnHeader2.Width = 250;
            // 
            // lsbNCC
            // 
            this.lsbNCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbNCC.FormattingEnabled = true;
            this.lsbNCC.ItemHeight = 31;
            this.lsbNCC.Location = new System.Drawing.Point(3, 34);
            this.lsbNCC.Name = "lsbNCC";
            this.lsbNCC.Size = new System.Drawing.Size(715, 616);
            this.lsbNCC.TabIndex = 0;
            this.lsbNCC.SelectedIndexChanged += new System.EventHandler(this.lsbNCC_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1784, 910);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lsvCardNCC;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListBox lsbNCC;
    }
}

