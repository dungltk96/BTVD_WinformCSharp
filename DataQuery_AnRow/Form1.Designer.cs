namespace DataQuery_AnRow
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
            this.btnView = new System.Windows.Forms.Button();
            this.lviDSSP = new System.Windows.Forms.ListView();
            this.maVT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenVT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.donViTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhanTram = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(389, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(652, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Truy vấn trả về nhiều dòng dữ liệu";
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(397, 204);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(644, 111);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "Xem thông tin";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // lviDSSP
            // 
            this.lviDSSP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.maVT,
            this.tenVT,
            this.donViTinh,
            this.PhanTram});
            this.lviDSSP.FullRowSelect = true;
            this.lviDSSP.GridLines = true;
            this.lviDSSP.HideSelection = false;
            this.lviDSSP.Location = new System.Drawing.Point(182, 364);
            this.lviDSSP.Name = "lviDSSP";
            this.lviDSSP.Size = new System.Drawing.Size(1096, 550);
            this.lviDSSP.TabIndex = 2;
            this.lviDSSP.UseCompatibleStateImageBehavior = false;
            this.lviDSSP.View = System.Windows.Forms.View.Details;
            // 
            // maVT
            // 
            this.maVT.Text = "Mã vật tư";
            this.maVT.Width = 170;
            // 
            // tenVT
            // 
            this.tenVT.Text = "Tên vật tư";
            this.tenVT.Width = 500;
            // 
            // donViTinh
            // 
            this.donViTinh.Text = "Đơn vị tính";
            this.donViTinh.Width = 200;
            // 
            // PhanTram
            // 
            this.PhanTram.Text = "Phần trăm";
            this.PhanTram.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1459, 1043);
            this.Controls.Add(this.lviDSSP);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.ListView lviDSSP;
        private System.Windows.Forms.ColumnHeader maVT;
        private System.Windows.Forms.ColumnHeader tenVT;
        private System.Windows.Forms.ColumnHeader donViTinh;
        private System.Windows.Forms.ColumnHeader PhanTram;
    }
}

