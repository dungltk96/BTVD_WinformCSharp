namespace Checkbox_Radiobtn
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
            this.lblNoiDung = new System.Windows.Forms.Label();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radMauDen = new System.Windows.Forms.RadioButton();
            this.radMauXanhDuong = new System.Windows.Forms.RadioButton();
            this.radMauXanhLa = new System.Windows.Forms.RadioButton();
            this.radMauDo = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkChuGachChan = new System.Windows.Forms.CheckBox();
            this.chkChuNghieng = new System.Windows.Forms.CheckBox();
            this.chkChuDam = new System.Windows.Forms.CheckBox();
            this.ltbHienThi = new System.Windows.Forms.Label();
            this.lblOutPut = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.AutoSize = true;
            this.lblNoiDung.Location = new System.Drawing.Point(26, 28);
            this.lblNoiDung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new System.Drawing.Size(73, 16);
            this.lblNoiDung.TabIndex = 0;
            this.lblNoiDung.Text = "Nội dung:";
            this.lblNoiDung.Click += new System.EventHandler(this.lblNoiDung_Click);
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(119, 25);
            this.txtNoiDung.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(543, 22);
            this.txtNoiDung.TabIndex = 1;
            this.txtNoiDung.TextChanged += new System.EventHandler(this.txtNoiDung_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.radMauDen);
            this.groupBox1.Controls.Add(this.radMauXanhDuong);
            this.groupBox1.Controls.Add(this.radMauXanhLa);
            this.groupBox1.Controls.Add(this.radMauDo);
            this.groupBox1.Location = new System.Drawing.Point(29, 77);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(284, 271);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Màu chữ";
            // 
            // radMauDen
            // 
            this.radMauDen.AutoSize = true;
            this.radMauDen.Location = new System.Drawing.Point(42, 226);
            this.radMauDen.Margin = new System.Windows.Forms.Padding(4);
            this.radMauDen.Name = "radMauDen";
            this.radMauDen.Size = new System.Drawing.Size(84, 20);
            this.radMauDen.TabIndex = 1;
            this.radMauDen.TabStop = true;
            this.radMauDen.Text = "Màu đen";
            this.radMauDen.UseVisualStyleBackColor = true;
            this.radMauDen.CheckedChanged += new System.EventHandler(this.radMauDen_CheckedChanged);
            // 
            // radMauXanhDuong
            // 
            this.radMauXanhDuong.AutoSize = true;
            this.radMauXanhDuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.radMauXanhDuong.Location = new System.Drawing.Point(42, 169);
            this.radMauXanhDuong.Margin = new System.Windows.Forms.Padding(4);
            this.radMauXanhDuong.Name = "radMauXanhDuong";
            this.radMauXanhDuong.Size = new System.Drawing.Size(137, 20);
            this.radMauXanhDuong.TabIndex = 1;
            this.radMauXanhDuong.TabStop = true;
            this.radMauXanhDuong.Text = "Màu xanh dương";
            this.radMauXanhDuong.UseVisualStyleBackColor = true;
            this.radMauXanhDuong.CheckedChanged += new System.EventHandler(this.radMauXanhDuong_CheckedChanged);
            // 
            // radMauXanhLa
            // 
            this.radMauXanhLa.AutoSize = true;
            this.radMauXanhLa.ForeColor = System.Drawing.Color.Green;
            this.radMauXanhLa.Location = new System.Drawing.Point(42, 111);
            this.radMauXanhLa.Margin = new System.Windows.Forms.Padding(4);
            this.radMauXanhLa.Name = "radMauXanhLa";
            this.radMauXanhLa.Size = new System.Drawing.Size(107, 20);
            this.radMauXanhLa.TabIndex = 1;
            this.radMauXanhLa.TabStop = true;
            this.radMauXanhLa.Text = "Màu xanh lá";
            this.radMauXanhLa.UseVisualStyleBackColor = true;
            this.radMauXanhLa.CheckedChanged += new System.EventHandler(this.radMauXanhLa_CheckedChanged);
            // 
            // radMauDo
            // 
            this.radMauDo.AutoSize = true;
            this.radMauDo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radMauDo.Location = new System.Drawing.Point(42, 53);
            this.radMauDo.Margin = new System.Windows.Forms.Padding(4);
            this.radMauDo.Name = "radMauDo";
            this.radMauDo.Size = new System.Drawing.Size(76, 20);
            this.radMauDo.TabIndex = 0;
            this.radMauDo.TabStop = true;
            this.radMauDo.Text = "Màu đỏ";
            this.radMauDo.UseVisualStyleBackColor = true;
            this.radMauDo.CheckedChanged += new System.EventHandler(this.radMauDo_CheckedChanged_1);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.chkChuGachChan);
            this.groupBox2.Controls.Add(this.chkChuNghieng);
            this.groupBox2.Controls.Add(this.chkChuDam);
            this.groupBox2.Location = new System.Drawing.Point(379, 77);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(284, 271);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Tag = "";
            this.groupBox2.Text = "Định dạng chữ";
            // 
            // chkChuGachChan
            // 
            this.chkChuGachChan.AutoSize = true;
            this.chkChuGachChan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkChuGachChan.Location = new System.Drawing.Point(24, 169);
            this.chkChuGachChan.Margin = new System.Windows.Forms.Padding(4);
            this.chkChuGachChan.Name = "chkChuGachChan";
            this.chkChuGachChan.Size = new System.Drawing.Size(99, 17);
            this.chkChuGachChan.TabIndex = 0;
            this.chkChuGachChan.Text = "Chữ gạch chân";
            this.chkChuGachChan.UseVisualStyleBackColor = true;
            this.chkChuGachChan.CheckedChanged += new System.EventHandler(this.chkChuGachChan_CheckedChanged);
            // 
            // chkChuNghieng
            // 
            this.chkChuNghieng.AutoSize = true;
            this.chkChuNghieng.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkChuNghieng.Location = new System.Drawing.Point(24, 111);
            this.chkChuNghieng.Margin = new System.Windows.Forms.Padding(4);
            this.chkChuNghieng.Name = "chkChuNghieng";
            this.chkChuNghieng.Size = new System.Drawing.Size(86, 17);
            this.chkChuNghieng.TabIndex = 0;
            this.chkChuNghieng.Text = "Chữ nghiêng";
            this.chkChuNghieng.UseVisualStyleBackColor = true;
            this.chkChuNghieng.CheckedChanged += new System.EventHandler(this.chkChuNghieng_CheckedChanged);
            // 
            // chkChuDam
            // 
            this.chkChuDam.AutoSize = true;
            this.chkChuDam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkChuDam.Location = new System.Drawing.Point(24, 53);
            this.chkChuDam.Margin = new System.Windows.Forms.Padding(4);
            this.chkChuDam.Name = "chkChuDam";
            this.chkChuDam.Size = new System.Drawing.Size(76, 17);
            this.chkChuDam.TabIndex = 0;
            this.chkChuDam.Text = "Chữ đậm";
            this.chkChuDam.UseVisualStyleBackColor = true;
            this.chkChuDam.CheckedChanged += new System.EventHandler(this.chkChuDam_CheckedChanged);
            // 
            // ltbHienThi
            // 
            this.ltbHienThi.AutoSize = true;
            this.ltbHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbHienThi.Location = new System.Drawing.Point(21, 406);
            this.ltbHienThi.Name = "ltbHienThi";
            this.ltbHienThi.Size = new System.Drawing.Size(85, 25);
            this.ltbHienThi.TabIndex = 4;
            this.ltbHienThi.Text = "Hiển thị";
            // 
            // lblOutPut
            // 
            this.lblOutPut.BackColor = System.Drawing.Color.LightGray;
            this.lblOutPut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutPut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutPut.Location = new System.Drawing.Point(128, 379);
            this.lblOutPut.Name = "lblOutPut";
            this.lblOutPut.Size = new System.Drawing.Size(397, 52);
            this.lblOutPut.TabIndex = 5;
            this.lblOutPut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOutPut.Click += new System.EventHandler(this.lblOutPut_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSize = true;
            this.btnThoat.Location = new System.Drawing.Point(547, 393);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(122, 38);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 457);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblOutPut);
            this.Controls.Add(this.ltbHienThi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.lblNoiDung);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm định dạng chuỗi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNoiDung;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radMauDo;
        private System.Windows.Forms.RadioButton radMauDen;
        private System.Windows.Forms.RadioButton radMauXanhDuong;
        private System.Windows.Forms.RadioButton radMauXanhLa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkChuGachChan;
        private System.Windows.Forms.CheckBox chkChuNghieng;
        private System.Windows.Forms.CheckBox chkChuDam;
        private System.Windows.Forms.Label ltbHienThi;
        private System.Windows.Forms.Label lblOutPut;
        private System.Windows.Forms.Button btnThoat;
    }
}

