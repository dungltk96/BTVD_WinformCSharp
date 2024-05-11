namespace BTTHEnd_DB
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInAn = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cboPhanLoai = new System.Windows.Forms.ComboBox();
            this.cboSoGhe = new System.Windows.Forms.ComboBox();
            this.cboHangSX = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKichThuoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txTenMay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDMay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsvDSSP = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1835, 198);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ MÁY BAY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1835, 198);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInAn);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.cboPhanLoai);
            this.groupBox1.Controls.Add(this.cboSoGhe);
            this.groupBox1.Controls.Add(this.cboHangSX);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtKichThuoc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txTenMay);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtIDMay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1835, 656);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết:";
            // 
            // btnInAn
            // 
            this.btnInAn.Location = new System.Drawing.Point(1332, 484);
            this.btnInAn.Name = "btnInAn";
            this.btnInAn.Size = new System.Drawing.Size(261, 76);
            this.btnInAn.TabIndex = 3;
            this.btnInAn.Text = "In ấn";
            this.btnInAn.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(1332, 353);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(261, 76);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(1332, 216);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(261, 76);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(1332, 82);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(261, 76);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cboPhanLoai
            // 
            this.cboPhanLoai.FormattingEnabled = true;
            this.cboPhanLoai.Items.AddRange(new object[] {
            "Thương Gia",
            "Phổ Thông"});
            this.cboPhanLoai.Location = new System.Drawing.Point(395, 514);
            this.cboPhanLoai.Name = "cboPhanLoai";
            this.cboPhanLoai.Size = new System.Drawing.Size(751, 46);
            this.cboPhanLoai.TabIndex = 2;
            // 
            // cboSoGhe
            // 
            this.cboSoGhe.FormattingEnabled = true;
            this.cboSoGhe.Items.AddRange(new object[] {
            "100",
            "150"});
            this.cboSoGhe.Location = new System.Drawing.Point(395, 421);
            this.cboSoGhe.Name = "cboSoGhe";
            this.cboSoGhe.Size = new System.Drawing.Size(751, 46);
            this.cboSoGhe.TabIndex = 2;
            // 
            // cboHangSX
            // 
            this.cboHangSX.FormattingEnabled = true;
            this.cboHangSX.Items.AddRange(new object[] {
            "Vietnam Airlines",
            "Vietjet Air",
            "Jetstar Pacific Airlines",
            "Bamboo Airways",
            ""});
            this.cboHangSX.Location = new System.Drawing.Point(395, 253);
            this.cboHangSX.Name = "cboHangSX";
            this.cboHangSX.Size = new System.Drawing.Size(751, 46);
            this.cboHangSX.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 505);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 39);
            this.label7.TabIndex = 0;
            this.label7.Text = "Phân loại:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 39);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số ghế:";
            // 
            // txtKichThuoc
            // 
            this.txtKichThuoc.Location = new System.Drawing.Point(395, 334);
            this.txtKichThuoc.Name = "txtKichThuoc";
            this.txtKichThuoc.Size = new System.Drawing.Size(751, 45);
            this.txtKichThuoc.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 39);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kích thước:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 39);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hãng sản xuất:";
            // 
            // txTenMay
            // 
            this.txTenMay.Location = new System.Drawing.Point(395, 166);
            this.txTenMay.Name = "txTenMay";
            this.txTenMay.Size = new System.Drawing.Size(751, 45);
            this.txTenMay.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên máy bay:";
            // 
            // txtIDMay
            // 
            this.txtIDMay.Location = new System.Drawing.Point(395, 82);
            this.txtIDMay.Name = "txtIDMay";
            this.txtIDMay.Size = new System.Drawing.Size(751, 45);
            this.txtIDMay.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã máy bay:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsvDSSP);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 854);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1835, 421);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hiển thị danh sách:";
            // 
            // lsvDSSP
            // 
            this.lsvDSSP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lsvDSSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvDSSP.FullRowSelect = true;
            this.lsvDSSP.GridLines = true;
            this.lsvDSSP.HideSelection = false;
            this.lsvDSSP.Location = new System.Drawing.Point(3, 41);
            this.lsvDSSP.Name = "lsvDSSP";
            this.lsvDSSP.Size = new System.Drawing.Size(1829, 377);
            this.lsvDSSP.TabIndex = 0;
            this.lsvDSSP.UseCompatibleStateImageBehavior = false;
            this.lsvDSSP.View = System.Windows.Forms.View.Details;
            this.lsvDSSP.SelectedIndexChanged += new System.EventHandler(this.lsvDSSP_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã máy bay";
            this.columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên máy bay";
            this.columnHeader2.Width = 400;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Hãng sản xuất";
            this.columnHeader3.Width = 300;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kích thước";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Số ghế";
            this.columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Phân loại";
            this.columnHeader6.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1835, 1275);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKichThuoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txTenMay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDMay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInAn;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cboPhanLoai;
        private System.Windows.Forms.ComboBox cboSoGhe;
        private System.Windows.Forms.ComboBox cboHangSX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lsvDSSP;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}

