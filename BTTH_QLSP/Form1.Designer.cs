namespace BTTH_QLSP
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tvDanhMuc = new System.Windows.Forms.TreeView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvDanhSachSP = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbTthongTinSP = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbbDanhMuc = new System.Windows.Forms.ComboBox();
            this.dtpNgaySX = new System.Windows.Forms.DateTimePicker();
            this.txtXuatXu = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGhiFile = new System.Windows.Forms.Button();
            this.btnDocFile = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grbTthongTinSP.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 55);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(920, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHẦN MỀM QUẢN LÝ SẢN PHẨM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 55);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(1);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(920, 534);
            this.splitContainer1.SplitterDistance = 304;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tvDanhMuc);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.Size = new System.Drawing.Size(304, 534);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh mục sản phẩm:";
            // 
            // tvDanhMuc
            // 
            this.tvDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvDanhMuc.Location = new System.Drawing.Point(1, 15);
            this.tvDanhMuc.Margin = new System.Windows.Forms.Padding(1);
            this.tvDanhMuc.Name = "tvDanhMuc";
            this.tvDanhMuc.Size = new System.Drawing.Size(302, 518);
            this.tvDanhMuc.TabIndex = 0;
            this.tvDanhMuc.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvDanhMuc_AfterSelect);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(1);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.grbTthongTinSP);
            this.splitContainer2.Size = new System.Drawing.Size(614, 534);
            this.splitContainer2.SplitterDistance = 231;
            this.splitContainer2.SplitterWidth = 2;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvDanhSachSP);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox2.Size = new System.Drawing.Size(614, 231);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sản phẩm:";
            // 
            // lvDanhSachSP
            // 
            this.lvDanhSachSP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvDanhSachSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDanhSachSP.FullRowSelect = true;
            this.lvDanhSachSP.GridLines = true;
            this.lvDanhSachSP.HideSelection = false;
            this.lvDanhSachSP.Location = new System.Drawing.Point(1, 15);
            this.lvDanhSachSP.Margin = new System.Windows.Forms.Padding(1);
            this.lvDanhSachSP.Name = "lvDanhSachSP";
            this.lvDanhSachSP.Size = new System.Drawing.Size(612, 215);
            this.lvDanhSachSP.TabIndex = 0;
            this.lvDanhSachSP.UseCompatibleStateImageBehavior = false;
            this.lvDanhSachSP.View = System.Windows.Forms.View.Details;
            this.lvDanhSachSP.SelectedIndexChanged += new System.EventHandler(this.lvDanhSachSP_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã  SP";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên SP";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Xuất xứ";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ngày SX";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Danh mục";
            this.columnHeader6.Width = 150;
            // 
            // grbTthongTinSP
            // 
            this.grbTthongTinSP.Controls.Add(this.btnDocFile);
            this.grbTthongTinSP.Controls.Add(this.btnGhiFile);
            this.grbTthongTinSP.Controls.Add(this.btnSua);
            this.grbTthongTinSP.Controls.Add(this.btnThoat);
            this.grbTthongTinSP.Controls.Add(this.btnXoa);
            this.grbTthongTinSP.Controls.Add(this.btnThem);
            this.grbTthongTinSP.Controls.Add(this.cbbDanhMuc);
            this.grbTthongTinSP.Controls.Add(this.dtpNgaySX);
            this.grbTthongTinSP.Controls.Add(this.txtXuatXu);
            this.grbTthongTinSP.Controls.Add(this.txtDonGia);
            this.grbTthongTinSP.Controls.Add(this.txtTenSP);
            this.grbTthongTinSP.Controls.Add(this.txtMaSP);
            this.grbTthongTinSP.Controls.Add(this.label7);
            this.grbTthongTinSP.Controls.Add(this.label6);
            this.grbTthongTinSP.Controls.Add(this.label5);
            this.grbTthongTinSP.Controls.Add(this.label4);
            this.grbTthongTinSP.Controls.Add(this.label3);
            this.grbTthongTinSP.Controls.Add(this.label2);
            this.grbTthongTinSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbTthongTinSP.Location = new System.Drawing.Point(0, 0);
            this.grbTthongTinSP.Margin = new System.Windows.Forms.Padding(1);
            this.grbTthongTinSP.Name = "grbTthongTinSP";
            this.grbTthongTinSP.Padding = new System.Windows.Forms.Padding(1);
            this.grbTthongTinSP.Size = new System.Drawing.Size(614, 301);
            this.grbTthongTinSP.TabIndex = 0;
            this.grbTthongTinSP.TabStop = false;
            this.grbTthongTinSP.Text = "Thông tin sản phẩm:";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(106, 207);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(86, 36);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(310, 207);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(1);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(86, 36);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(209, 207);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(1);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(86, 36);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(5, 207);
            this.btnThem.Margin = new System.Windows.Forms.Padding(1);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 36);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbbDanhMuc
            // 
            this.cbbDanhMuc.FormattingEnabled = true;
            this.cbbDanhMuc.Location = new System.Drawing.Point(106, 151);
            this.cbbDanhMuc.Margin = new System.Windows.Forms.Padding(1);
            this.cbbDanhMuc.Name = "cbbDanhMuc";
            this.cbbDanhMuc.Size = new System.Drawing.Size(211, 23);
            this.cbbDanhMuc.TabIndex = 5;
            this.cbbDanhMuc.SelectedIndexChanged += new System.EventHandler(this.cbbDanhMuc_SelectedIndexChanged);
            // 
            // dtpNgaySX
            // 
            this.dtpNgaySX.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySX.Location = new System.Drawing.Point(106, 125);
            this.dtpNgaySX.Margin = new System.Windows.Forms.Padding(1);
            this.dtpNgaySX.Name = "dtpNgaySX";
            this.dtpNgaySX.Size = new System.Drawing.Size(211, 21);
            this.dtpNgaySX.TabIndex = 4;
            // 
            // txtXuatXu
            // 
            this.txtXuatXu.Location = new System.Drawing.Point(106, 99);
            this.txtXuatXu.Margin = new System.Windows.Forms.Padding(1);
            this.txtXuatXu.Name = "txtXuatXu";
            this.txtXuatXu.Size = new System.Drawing.Size(211, 21);
            this.txtXuatXu.TabIndex = 3;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(106, 73);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(1);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(211, 21);
            this.txtDonGia.TabIndex = 2;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(106, 47);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(1);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(211, 21);
            this.txtTenSP.TabIndex = 1;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(106, 21);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(1);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(211, 21);
            this.txtMaSP.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 156);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Danh mục:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 130);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày SX:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 103);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Xuất xứ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Đơn giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên SP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã SP:";
            // 
            // btnGhiFile
            // 
            this.btnGhiFile.Location = new System.Drawing.Point(413, 207);
            this.btnGhiFile.Name = "btnGhiFile";
            this.btnGhiFile.Size = new System.Drawing.Size(86, 36);
            this.btnGhiFile.TabIndex = 10;
            this.btnGhiFile.Text = "Ghi File";
            this.btnGhiFile.UseVisualStyleBackColor = true;
            this.btnGhiFile.Click += new System.EventHandler(this.btnGhiFile_Click);
            // 
            // btnDocFile
            // 
            this.btnDocFile.Location = new System.Drawing.Point(516, 207);
            this.btnDocFile.Name = "btnDocFile";
            this.btnDocFile.Size = new System.Drawing.Size(86, 36);
            this.btnDocFile.TabIndex = 11;
            this.btnDocFile.Text = "Đọc File";
            this.btnDocFile.UseVisualStyleBackColor = true;
            this.btnDocFile.Click += new System.EventHandler(this.btnDocFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(920, 589);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PM Quản lý sản phẩm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.grbTthongTinSP.ResumeLayout(false);
            this.grbTthongTinSP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grbTthongTinSP;
        private System.Windows.Forms.TreeView tvDanhMuc;
        private System.Windows.Forms.ListView lvDanhSachSP;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ComboBox cbbDanhMuc;
        private System.Windows.Forms.DateTimePicker dtpNgaySX;
        private System.Windows.Forms.TextBox txtXuatXu;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnDocFile;
        private System.Windows.Forms.Button btnGhiFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

