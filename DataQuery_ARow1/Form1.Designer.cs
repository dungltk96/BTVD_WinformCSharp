namespace DataQuery_ARow1
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
            this.txtMaVtu = new System.Windows.Forms.TextBox();
            this.btnNotParam = new System.Windows.Forms.Button();
            this.btnYesParam = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenVTu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhanTram = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(417, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(627, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Truy vấn một dòng dữ liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập mã VTu:";
            // 
            // txtMaVtu
            // 
            this.txtMaVtu.Location = new System.Drawing.Point(350, 187);
            this.txtMaVtu.Name = "txtMaVtu";
            this.txtMaVtu.Size = new System.Drawing.Size(709, 41);
            this.txtMaVtu.TabIndex = 2;
            // 
            // btnNotParam
            // 
            this.btnNotParam.Location = new System.Drawing.Point(113, 299);
            this.btnNotParam.Name = "btnNotParam";
            this.btnNotParam.Size = new System.Drawing.Size(441, 140);
            this.btnNotParam.TabIndex = 3;
            this.btnNotParam.Text = "Không dùng Parameter";
            this.btnNotParam.UseVisualStyleBackColor = true;
            this.btnNotParam.Click += new System.EventHandler(this.btnNotParam_Click);
            // 
            // btnYesParam
            // 
            this.btnYesParam.Location = new System.Drawing.Point(694, 299);
            this.btnYesParam.Name = "btnYesParam";
            this.btnYesParam.Size = new System.Drawing.Size(441, 140);
            this.btnYesParam.TabIndex = 3;
            this.btnYesParam.Text = "Có dùng Parameter";
            this.btnYesParam.UseVisualStyleBackColor = true;
            this.btnYesParam.Click += new System.EventHandler(this.btnYesParam_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 520);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 36);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên vật tư:";
            // 
            // txtTenVTu
            // 
            this.txtTenVTu.Location = new System.Drawing.Point(350, 520);
            this.txtTenVTu.Name = "txtTenVTu";
            this.txtTenVTu.Size = new System.Drawing.Size(709, 41);
            this.txtTenVTu.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 642);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 36);
            this.label4.TabIndex = 1;
            this.label4.Text = "Đơn vị tính";
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Location = new System.Drawing.Point(350, 642);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(709, 41);
            this.txtDonViTinh.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 762);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 36);
            this.label5.TabIndex = 1;
            this.label5.Text = "Phần trăm";
            // 
            // txtPhanTram
            // 
            this.txtPhanTram.Location = new System.Drawing.Point(350, 762);
            this.txtPhanTram.Name = "txtPhanTram";
            this.txtPhanTram.Size = new System.Drawing.Size(709, 41);
            this.txtPhanTram.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1536, 1044);
            this.Controls.Add(this.btnYesParam);
            this.Controls.Add(this.btnNotParam);
            this.Controls.Add(this.txtPhanTram);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDonViTinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenVTu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaVtu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaVtu;
        private System.Windows.Forms.Button btnNotParam;
        private System.Windows.Forms.Button btnYesParam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenVTu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhanTram;
    }
}

