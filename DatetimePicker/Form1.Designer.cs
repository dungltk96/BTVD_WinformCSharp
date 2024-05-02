namespace DatetimePicker
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
            this.lblDangKyThiLX = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblTuoi = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtTuoi = new System.Windows.Forms.TextBox();
            this.dtpNgayDK = new System.Windows.Forms.DateTimePicker();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDangKyThiLX
            // 
            this.lblDangKyThiLX.AutoSize = true;
            this.lblDangKyThiLX.Location = new System.Drawing.Point(60, 44);
            this.lblDangKyThiLX.Name = "lblDangKyThiLX";
            this.lblDangKyThiLX.Size = new System.Drawing.Size(544, 32);
            this.lblDangKyThiLX.TabIndex = 0;
            this.lblDangKyThiLX.Text = "Update_Đăng ký thi tuyển giấy phép lái xe";
            this.lblDangKyThiLX.Click += new System.EventHandler(this.lblDangKyThiLX_Click);
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(60, 128);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(105, 32);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Họ tên:";
            this.lblHoTen.Click += new System.EventHandler(this.lblHoTen_Click);
            // 
            // lblTuoi
            // 
            this.lblTuoi.AutoSize = true;
            this.lblTuoi.Location = new System.Drawing.Point(60, 209);
            this.lblTuoi.Name = "lblTuoi";
            this.lblTuoi.Size = new System.Drawing.Size(78, 32);
            this.lblTuoi.TabIndex = 1;
            this.lblTuoi.Text = "Tuổi:";
            this.lblTuoi.Click += new System.EventHandler(this.lblTuoi_Click);
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(60, 290);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(134, 32);
            this.lblNgaySinh.TabIndex = 2;
            this.lblNgaySinh.Text = "Ngày ĐK:";
            this.lblNgaySinh.Click += new System.EventHandler(this.lblNgaySinh_Click);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(261, 128);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(563, 38);
            this.txtHoTen.TabIndex = 3;
            // 
            // txtTuoi
            // 
            this.txtTuoi.Location = new System.Drawing.Point(261, 209);
            this.txtTuoi.Name = "txtTuoi";
            this.txtTuoi.Size = new System.Drawing.Size(563, 38);
            this.txtTuoi.TabIndex = 3;
            // 
            // dtpNgayDK
            // 
            this.dtpNgayDK.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDK.Location = new System.Drawing.Point(261, 290);
            this.dtpNgayDK.Name = "dtpNgayDK";
            this.dtpNgayDK.Size = new System.Drawing.Size(563, 38);
            this.dtpNgayDK.TabIndex = 4;
            this.dtpNgayDK.ValueChanged += new System.EventHandler(this.dtpNgaySinh_ValueChanged);
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(261, 385);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(262, 52);
            this.btnDangKy.TabIndex = 5;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 484);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chú ý";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 511);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(378, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "- Họ tên không được để trống";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 584);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "- Tuổi phải lớn hơn 17";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 659);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(495, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "- Không đăng ký thi vào ngày chủ nhật";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 867);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.dtpNgayDK);
            this.Controls.Add(this.txtTuoi);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblTuoi);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblDangKyThiLX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDangKyThiLX;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblTuoi;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtTuoi;
        private System.Windows.Forms.DateTimePicker dtpNgayDK;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider Error;
    }
}

