namespace ThemDuLieu_DB
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
            this.btnThemVTu = new System.Windows.Forms.Button();
            this.txtPhanTram = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenVT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaVT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsvDanhSachVT = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(586, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm vật tư";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThemVTu);
            this.groupBox1.Controls.Add(this.txtPhanTram);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDonViTinh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTenVT);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaVT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(79, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(803, 620);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin:";
            // 
            // btnThemVTu
            // 
            this.btnThemVTu.Location = new System.Drawing.Point(320, 459);
            this.btnThemVTu.Name = "btnThemVTu";
            this.btnThemVTu.Size = new System.Drawing.Size(356, 111);
            this.btnThemVTu.TabIndex = 2;
            this.btnThemVTu.Text = "Thêm vật tư";
            this.btnThemVTu.UseVisualStyleBackColor = true;
            this.btnThemVTu.Click += new System.EventHandler(this.btnThemVTu_Click);
            // 
            // txtPhanTram
            // 
            this.txtPhanTram.Location = new System.Drawing.Point(225, 379);
            this.txtPhanTram.Name = "txtPhanTram";
            this.txtPhanTram.Size = new System.Drawing.Size(534, 38);
            this.txtPhanTram.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Phần trăm:";
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Location = new System.Drawing.Point(225, 285);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(534, 38);
            this.txtDonViTinh.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Đơn vị tính:";
            // 
            // txtTenVT
            // 
            this.txtTenVT.Location = new System.Drawing.Point(225, 192);
            this.txtTenVT.Name = "txtTenVT";
            this.txtTenVT.Size = new System.Drawing.Size(534, 38);
            this.txtTenVT.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên vật tư:";
            // 
            // txtMaVT
            // 
            this.txtMaVT.Location = new System.Drawing.Point(225, 102);
            this.txtMaVT.Name = "txtMaVT";
            this.txtMaVT.Size = new System.Drawing.Size(534, 38);
            this.txtMaVT.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã vật tư:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsvDanhSachVT);
            this.groupBox2.Location = new System.Drawing.Point(954, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(803, 620);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách vật tư:";
            // 
            // lsvDanhSachVT
            // 
            this.lsvDanhSachVT.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvDanhSachVT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvDanhSachVT.FullRowSelect = true;
            this.lsvDanhSachVT.GridLines = true;
            this.lsvDanhSachVT.HideSelection = false;
            this.lsvDanhSachVT.Location = new System.Drawing.Point(3, 34);
            this.lsvDanhSachVT.Name = "lsvDanhSachVT";
            this.lsvDanhSachVT.Size = new System.Drawing.Size(797, 583);
            this.lsvDanhSachVT.TabIndex = 0;
            this.lsvDanhSachVT.UseCompatibleStateImageBehavior = false;
            this.lsvDanhSachVT.View = System.Windows.Forms.View.Details;
            this.lsvDanhSachVT.SelectedIndexChanged += new System.EventHandler(this.lsvDanhSachVT_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã vật tư";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên vật tư";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn vị tính";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Phần trăm";
            this.columnHeader4.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1804, 1068);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThemVTu;
        private System.Windows.Forms.TextBox txtPhanTram;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenVT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaVT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lsvDanhSachVT;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

