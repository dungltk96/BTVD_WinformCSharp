namespace BTTongHop
{
    partial class frmQLSP
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.chkLaSinhVien = new System.Windows.Forms.CheckBox();
            this.txtSoLuonMua = new System.Windows.Forms.TextBox();
            this.txtHoTenKH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTiepTuc = new System.Windows.Forms.Button();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTongKH = new System.Windows.Forms.TextBox();
            this.txtTongDoanhThu = new System.Windows.Forms.TextBox();
            this.txtTongSV = new System.Windows.Forms.TextBox();
            this.lblTongDT = new System.Windows.Forms.Label();
            this.lblTongSV = new System.Windows.Forms.Label();
            this.lblTongKH = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1251, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1251, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ SẢN PHẨM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtThanhTien);
            this.groupBox1.Controls.Add(this.chkLaSinhVien);
            this.groupBox1.Controls.Add(this.txtSoLuonMua);
            this.groupBox1.Controls.Add(this.txtHoTenKH);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1251, 275);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Location = new System.Drawing.Point(420, 199);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(532, 45);
            this.txtThanhTien.TabIndex = 2;
            // 
            // chkLaSinhVien
            // 
            this.chkLaSinhVien.AutoSize = true;
            this.chkLaSinhVien.Location = new System.Drawing.Point(980, 58);
            this.chkLaSinhVien.Name = "chkLaSinhVien";
            this.chkLaSinhVien.Size = new System.Drawing.Size(237, 43);
            this.chkLaSinhVien.TabIndex = 3;
            this.chkLaSinhVien.Text = "Là sinh viên";
            this.chkLaSinhVien.UseVisualStyleBackColor = true;
            this.chkLaSinhVien.CheckedChanged += new System.EventHandler(this.chkLaSinhVien_CheckedChanged);
            // 
            // txtSoLuonMua
            // 
            this.txtSoLuonMua.Location = new System.Drawing.Point(420, 121);
            this.txtSoLuonMua.Name = "txtSoLuonMua";
            this.txtSoLuonMua.Size = new System.Drawing.Size(537, 45);
            this.txtSoLuonMua.TabIndex = 1;
            this.txtSoLuonMua.TextChanged += new System.EventHandler(this.txtSoLuonMua_TextChanged);
            // 
            // txtHoTenKH
            // 
            this.txtHoTenKH.Location = new System.Drawing.Point(420, 56);
            this.txtHoTenKH.Name = "txtHoTenKH";
            this.txtHoTenKH.Size = new System.Drawing.Size(537, 45);
            this.txtHoTenKH.TabIndex = 0;
            this.txtHoTenKH.TextChanged += new System.EventHandler(this.txtHoTenKH_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 39);
            this.label4.TabIndex = 0;
            this.label4.Text = "Thành tiền:";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số lượng mua:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên khách hàng:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThongKe);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnTiepTuc);
            this.groupBox2.Controls.Add(this.btnTinhTien);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 435);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1251, 268);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng:";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(659, 88);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(209, 83);
            this.btnThongKe.TabIndex = 2;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(930, 88);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(209, 83);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTiepTuc
            // 
            this.btnTiepTuc.Location = new System.Drawing.Point(388, 88);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new System.Drawing.Size(209, 83);
            this.btnTiepTuc.TabIndex = 1;
            this.btnTiepTuc.Text = "Tiếp tục";
            this.btnTiepTuc.UseVisualStyleBackColor = true;
            this.btnTiepTuc.Click += new System.EventHandler(this.btnTiepTuc_Click);
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(117, 88);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(209, 83);
            this.btnTinhTien.TabIndex = 0;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTongKH);
            this.groupBox3.Controls.Add(this.txtTongDoanhThu);
            this.groupBox3.Controls.Add(this.txtTongSV);
            this.groupBox3.Controls.Add(this.lblTongDT);
            this.groupBox3.Controls.Add(this.lblTongSV);
            this.groupBox3.Controls.Add(this.lblTongKH);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 703);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1251, 287);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tổng khách hàng:";
            // 
            // txtTongKH
            // 
            this.txtTongKH.Enabled = false;
            this.txtTongKH.Location = new System.Drawing.Point(415, 77);
            this.txtTongKH.Name = "txtTongKH";
            this.txtTongKH.Size = new System.Drawing.Size(537, 45);
            this.txtTongKH.TabIndex = 8;
            this.txtTongKH.TextChanged += new System.EventHandler(this.txtTongKH_TextChanged);
            // 
            // txtTongDoanhThu
            // 
            this.txtTongDoanhThu.Enabled = false;
            this.txtTongDoanhThu.Location = new System.Drawing.Point(415, 196);
            this.txtTongDoanhThu.Name = "txtTongDoanhThu";
            this.txtTongDoanhThu.Size = new System.Drawing.Size(537, 45);
            this.txtTongDoanhThu.TabIndex = 6;
            this.txtTongDoanhThu.TextChanged += new System.EventHandler(this.txtTongDoanhThu_TextChanged);
            // 
            // txtTongSV
            // 
            this.txtTongSV.Enabled = false;
            this.txtTongSV.Location = new System.Drawing.Point(415, 134);
            this.txtTongSV.Name = "txtTongSV";
            this.txtTongSV.Size = new System.Drawing.Size(537, 45);
            this.txtTongSV.TabIndex = 7;
            this.txtTongSV.TextChanged += new System.EventHandler(this.txtTongSV_TextChanged);
            // 
            // lblTongDT
            // 
            this.lblTongDT.AutoSize = true;
            this.lblTongDT.Location = new System.Drawing.Point(68, 188);
            this.lblTongDT.Name = "lblTongDT";
            this.lblTongDT.Size = new System.Drawing.Size(279, 39);
            this.lblTongDT.TabIndex = 3;
            this.lblTongDT.Text = "Tổng doanh thu:";
            this.lblTongDT.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblTongSV
            // 
            this.lblTongSV.AutoSize = true;
            this.lblTongSV.Location = new System.Drawing.Point(68, 126);
            this.lblTongSV.Name = "lblTongSV";
            this.lblTongSV.Size = new System.Drawing.Size(263, 39);
            this.lblTongSV.TabIndex = 4;
            this.lblTongSV.Text = "Tổng sinh viên:";
            this.lblTongSV.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblTongKH
            // 
            this.lblTongKH.AutoSize = true;
            this.lblTongKH.Location = new System.Drawing.Point(68, 69);
            this.lblTongKH.Name = "lblTongKH";
            this.lblTongKH.Size = new System.Drawing.Size(295, 39);
            this.lblTongKH.TabIndex = 5;
            this.lblTongKH.Text = "Tổng khách hàng";
            this.lblTongKH.Click += new System.EventHandler(this.label7_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1251, 60);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frmQLSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1251, 990);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQLSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sản phẩm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHoTenKH;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTiepTuc;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblTongDT;
        private System.Windows.Forms.Label lblTongSV;
        private System.Windows.Forms.Label lblTongKH;
        private System.Windows.Forms.TextBox txtTongDoanhThu;
        private System.Windows.Forms.TextBox txtTongSV;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.TextBox txtSoLuonMua;
        private System.Windows.Forms.CheckBox chkLaSinhVien;
        private System.Windows.Forms.TextBox txtTongKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox txtThanhTien;
    }
}

