namespace DatetimePickerAdvance
{
    partial class frmĐK
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
            this.grbDK = new System.Windows.Forms.GroupBox();
            this.lblNgayDK = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.dtpDK = new System.Windows.Forms.DateTimePicker();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbDK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDK
            // 
            this.grbDK.Controls.Add(this.lblNgayDK);
            this.grbDK.Controls.Add(this.lblAge);
            this.grbDK.Controls.Add(this.btnRegister);
            this.grbDK.Controls.Add(this.dtpDK);
            this.grbDK.Controls.Add(this.txtAge);
            this.grbDK.Controls.Add(this.txtPhone);
            this.grbDK.Controls.Add(this.lblPhone);
            this.grbDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDK.Location = new System.Drawing.Point(97, 62);
            this.grbDK.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.grbDK.Name = "grbDK";
            this.grbDK.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.grbDK.Size = new System.Drawing.Size(1091, 572);
            this.grbDK.TabIndex = 0;
            this.grbDK.TabStop = false;
            this.grbDK.Text = "Thông tin đăng ký";
            // 
            // lblNgayDK
            // 
            this.lblNgayDK.AutoSize = true;
            this.lblNgayDK.Location = new System.Drawing.Point(60, 310);
            this.lblNgayDK.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblNgayDK.Name = "lblNgayDK";
            this.lblNgayDK.Size = new System.Drawing.Size(150, 36);
            this.lblNgayDK.TabIndex = 0;
            this.lblNgayDK.Text = "Ngày ĐK:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(60, 198);
            this.lblAge.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(87, 36);
            this.lblAge.TabIndex = 0;
            this.lblAge.Text = "Tuổi:";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(502, 424);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(306, 72);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Đăng ký";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // dtpDK
            // 
            this.dtpDK.CustomFormat = "dd/MM/yyyy";
            this.dtpDK.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDK.Location = new System.Drawing.Point(337, 298);
            this.dtpDK.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dtpDK.Name = "dtpDK";
            this.dtpDK.Size = new System.Drawing.Size(636, 41);
            this.dtpDK.TabIndex = 3;
            this.dtpDK.ValueChanged += new System.EventHandler(this.dtpDK_ValueChanged);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(337, 196);
            this.txtAge.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(636, 41);
            this.txtAge.TabIndex = 2;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(337, 86);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(636, 41);
            this.txtPhone.TabIndex = 1;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(60, 86);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(168, 36);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "Điện thoại:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmĐK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1306, 718);
            this.Controls.Add(this.grbDK);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "frmĐK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký xem phim";
            this.grbDK.ResumeLayout(false);
            this.grbDK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDK;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.DateTimePicker dtpDK;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblNgayDK;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

