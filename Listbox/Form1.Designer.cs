namespace Listbox
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.grbListbox = new System.Windows.Forms.GroupBox();
            this.lstDanhSach = new System.Windows.Forms.ListBox();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.btnChonSoLe = new System.Windows.Forms.Button();
            this.btnChonSoChan = new System.Windows.Forms.Button();
            this.btnBinhPhuong = new System.Windows.Forms.Button();
            this.btnTang2 = new System.Windows.Forms.Button();
            this.btnXoaPTChon = new System.Windows.Forms.Button();
            this.btnXoaDauCuoi = new System.Windows.Forms.Button();
            this.btnTongDS = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.btnNhap = new System.Windows.Forms.Button();
            this.grbListbox.SuspendLayout();
            this.grbChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số:";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(250, 71);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(715, 45);
            this.txtInput.TabIndex = 1;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // grbListbox
            // 
            this.grbListbox.Controls.Add(this.lstDanhSach);
            this.grbListbox.Location = new System.Drawing.Point(55, 258);
            this.grbListbox.Name = "grbListbox";
            this.grbListbox.Size = new System.Drawing.Size(535, 893);
            this.grbListbox.TabIndex = 3;
            this.grbListbox.TabStop = false;
            this.grbListbox.Text = "Hiển thị danh sách:";
            // 
            // lstDanhSach
            // 
            this.lstDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDanhSach.FormattingEnabled = true;
            this.lstDanhSach.ItemHeight = 38;
            this.lstDanhSach.Location = new System.Drawing.Point(3, 41);
            this.lstDanhSach.Name = "lstDanhSach";
            this.lstDanhSach.Size = new System.Drawing.Size(529, 849);
            this.lstDanhSach.TabIndex = 0;
            // 
            // grbChucNang
            // 
            this.grbChucNang.Controls.Add(this.btnChonSoLe);
            this.grbChucNang.Controls.Add(this.btnChonSoChan);
            this.grbChucNang.Controls.Add(this.btnBinhPhuong);
            this.grbChucNang.Controls.Add(this.btnTang2);
            this.grbChucNang.Controls.Add(this.btnXoaPTChon);
            this.grbChucNang.Controls.Add(this.btnXoaDauCuoi);
            this.grbChucNang.Controls.Add(this.btnTongDS);
            this.grbChucNang.Location = new System.Drawing.Point(620, 258);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(688, 893);
            this.grbChucNang.TabIndex = 4;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Chức năng:";
            // 
            // btnChonSoLe
            // 
            this.btnChonSoLe.Location = new System.Drawing.Point(22, 747);
            this.btnChonSoLe.Name = "btnChonSoLe";
            this.btnChonSoLe.Size = new System.Drawing.Size(640, 79);
            this.btnChonSoLe.TabIndex = 0;
            this.btnChonSoLe.Text = "Chọn số lẻ";
            this.btnChonSoLe.UseVisualStyleBackColor = true;
            // 
            // btnChonSoChan
            // 
            this.btnChonSoChan.Location = new System.Drawing.Point(22, 634);
            this.btnChonSoChan.Name = "btnChonSoChan";
            this.btnChonSoChan.Size = new System.Drawing.Size(640, 79);
            this.btnChonSoChan.TabIndex = 0;
            this.btnChonSoChan.Text = "Chọn số chẵn ";
            this.btnChonSoChan.UseVisualStyleBackColor = true;
            this.btnChonSoChan.Click += new System.EventHandler(this.btnChonSoChan_Click);
            // 
            // btnBinhPhuong
            // 
            this.btnBinhPhuong.Location = new System.Drawing.Point(22, 521);
            this.btnBinhPhuong.Name = "btnBinhPhuong";
            this.btnBinhPhuong.Size = new System.Drawing.Size(640, 79);
            this.btnBinhPhuong.TabIndex = 0;
            this.btnBinhPhuong.Text = "Thay bằng bình phương";
            this.btnBinhPhuong.UseVisualStyleBackColor = true;
            // 
            // btnTang2
            // 
            this.btnTang2.Location = new System.Drawing.Point(6, 403);
            this.btnTang2.Name = "btnTang2";
            this.btnTang2.Size = new System.Drawing.Size(640, 79);
            this.btnTang2.TabIndex = 0;
            this.btnTang2.Text = "Tăng mỗi phần tử lên 2";
            this.btnTang2.UseVisualStyleBackColor = true;
            // 
            // btnXoaPTChon
            // 
            this.btnXoaPTChon.Location = new System.Drawing.Point(22, 295);
            this.btnXoaPTChon.Name = "btnXoaPTChon";
            this.btnXoaPTChon.Size = new System.Drawing.Size(640, 79);
            this.btnXoaPTChon.TabIndex = 0;
            this.btnXoaPTChon.Text = "Xóa phần tử đang chọn";
            this.btnXoaPTChon.UseVisualStyleBackColor = true;
            // 
            // btnXoaDauCuoi
            // 
            this.btnXoaDauCuoi.Location = new System.Drawing.Point(22, 182);
            this.btnXoaDauCuoi.Name = "btnXoaDauCuoi";
            this.btnXoaDauCuoi.Size = new System.Drawing.Size(640, 79);
            this.btnXoaDauCuoi.TabIndex = 0;
            this.btnXoaDauCuoi.Text = "Xóa phần tử đầu và cuối";
            this.btnXoaDauCuoi.UseVisualStyleBackColor = true;
            // 
            // btnTongDS
            // 
            this.btnTongDS.Location = new System.Drawing.Point(22, 69);
            this.btnTongDS.Name = "btnTongDS";
            this.btnTongDS.Size = new System.Drawing.Size(640, 79);
            this.btnTongDS.TabIndex = 0;
            this.btnTongDS.Text = "Tổng danh sách";
            this.btnTongDS.UseVisualStyleBackColor = true;
            this.btnTongDS.Click += new System.EventHandler(this.btnTongDS_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Location = new System.Drawing.Point(325, 1200);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(640, 79);
            this.btnKetThuc.TabIndex = 0;
            this.btnKetThuc.Text = "Kết thúc";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(1030, 71);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(207, 65);
            this.btnNhap.TabIndex = 5;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1363, 1311);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.grbChucNang);
            this.Controls.Add(this.grbListbox);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listbox";
            this.grbListbox.ResumeLayout(false);
            this.grbChucNang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.GroupBox grbListbox;
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.Button btnChonSoChan;
        private System.Windows.Forms.Button btnBinhPhuong;
        private System.Windows.Forms.Button btnXoaPTChon;
        private System.Windows.Forms.Button btnXoaDauCuoi;
        private System.Windows.Forms.Button btnTongDS;
        private System.Windows.Forms.Button btnChonSoLe;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.ListBox lstDanhSach;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnTang2;
    }
}

