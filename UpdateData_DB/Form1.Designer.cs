namespace UpdateData_DB
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
            this.label2 = new System.Windows.Forms.Label();
            this.cboChonGroupMonAn = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lsvThongTinMonAn = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnYesPara = new System.Windows.Forms.Button();
            this.btnNotPara = new System.Windows.Forms.Button();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenMonAn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDGroupMonAn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIDMonAn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(679, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(596, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHỈNH SỬA DỮ LIỆU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn nhóm món ăn:";
            // 
            // cboChonGroupMonAn
            // 
            this.cboChonGroupMonAn.FormattingEnabled = true;
            this.cboChonGroupMonAn.Location = new System.Drawing.Point(394, 124);
            this.cboChonGroupMonAn.Name = "cboChonGroupMonAn";
            this.cboChonGroupMonAn.Size = new System.Drawing.Size(1005, 39);
            this.cboChonGroupMonAn.TabIndex = 2;
            this.cboChonGroupMonAn.SelectedIndexChanged += new System.EventHandler(this.cboChonGroupMonAn_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lsvThongTinMonAn);
            this.groupBox1.Location = new System.Drawing.Point(37, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(980, 831);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin món ăn:";
            // 
            // lsvThongTinMonAn
            // 
            this.lsvThongTinMonAn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lsvThongTinMonAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvThongTinMonAn.FullRowSelect = true;
            this.lsvThongTinMonAn.GridLines = true;
            this.lsvThongTinMonAn.HideSelection = false;
            this.lsvThongTinMonAn.Location = new System.Drawing.Point(3, 34);
            this.lsvThongTinMonAn.Name = "lsvThongTinMonAn";
            this.lsvThongTinMonAn.Size = new System.Drawing.Size(974, 794);
            this.lsvThongTinMonAn.TabIndex = 0;
            this.lsvThongTinMonAn.UseCompatibleStateImageBehavior = false;
            this.lsvThongTinMonAn.View = System.Windows.Forms.View.Details;
            this.lsvThongTinMonAn.SelectedIndexChanged += new System.EventHandler(this.lsvThongTinMonAn_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID món";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID nhóm món";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên món ăn";
            this.columnHeader3.Width = 300;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Đơn vị tính";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Đơn giá";
            this.columnHeader5.Width = 200;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnYesPara);
            this.groupBox2.Controls.Add(this.btnNotPara);
            this.groupBox2.Controls.Add(this.txtDonGia);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtDonViTinh);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtTenMonAn);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtIDGroupMonAn);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtIDMonAn);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(1039, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(917, 794);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chỉnh sửa thông tin món ăn:";
            // 
            // btnYesPara
            // 
            this.btnYesPara.Location = new System.Drawing.Point(591, 552);
            this.btnYesPara.Name = "btnYesPara";
            this.btnYesPara.Size = new System.Drawing.Size(279, 95);
            this.btnYesPara.TabIndex = 2;
            this.btnYesPara.Text = "Có dùng Para";
            this.btnYesPara.UseVisualStyleBackColor = true;
            this.btnYesPara.Click += new System.EventHandler(this.btnYesPara_Click);
            // 
            // btnNotPara
            // 
            this.btnNotPara.Location = new System.Drawing.Point(276, 552);
            this.btnNotPara.Name = "btnNotPara";
            this.btnNotPara.Size = new System.Drawing.Size(279, 95);
            this.btnNotPara.TabIndex = 2;
            this.btnNotPara.Text = "Không dùng Para";
            this.btnNotPara.UseVisualStyleBackColor = true;
            this.btnNotPara.Click += new System.EventHandler(this.btnNotPara_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(288, 426);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(556, 38);
            this.txtDonGia.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 444);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "Đơn giá:";
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Location = new System.Drawing.Point(288, 332);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(556, 38);
            this.txtDonViTinh.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Đơn vị tính:";
            // 
            // txtTenMonAn
            // 
            this.txtTenMonAn.Location = new System.Drawing.Point(288, 241);
            this.txtTenMonAn.Name = "txtTenMonAn";
            this.txtTenMonAn.Size = new System.Drawing.Size(556, 38);
            this.txtTenMonAn.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên món ăn:";
            // 
            // txtIDGroupMonAn
            // 
            this.txtIDGroupMonAn.Location = new System.Drawing.Point(288, 152);
            this.txtIDGroupMonAn.Name = "txtIDGroupMonAn";
            this.txtIDGroupMonAn.Size = new System.Drawing.Size(556, 38);
            this.txtIDGroupMonAn.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID nhóm món ăn:";
            // 
            // txtIDMonAn
            // 
            this.txtIDMonAn.Location = new System.Drawing.Point(288, 61);
            this.txtIDMonAn.Name = "txtIDMonAn";
            this.txtIDMonAn.Size = new System.Drawing.Size(556, 38);
            this.txtIDMonAn.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID món ăn:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1983, 1079);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboChonGroupMonAn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboChonGroupMonAn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lsvThongTinMonAn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnYesPara;
        private System.Windows.Forms.Button btnNotPara;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenMonAn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDGroupMonAn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIDMonAn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

