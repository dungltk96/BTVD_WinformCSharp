namespace DeleteData
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
            this.cboChonMon = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lsvListMon = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelYesPara = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelNoPara = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(610, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "XÓA DỮ LIỆU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lựa chọn nhóm món ăn:";
            // 
            // cboChonMon
            // 
            this.cboChonMon.FormattingEnabled = true;
            this.cboChonMon.Location = new System.Drawing.Point(415, 123);
            this.cboChonMon.Name = "cboChonMon";
            this.cboChonMon.Size = new System.Drawing.Size(654, 39);
            this.cboChonMon.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lsvListMon);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(31, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(858, 623);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách món ăn:";
            // 
            // lsvListMon
            // 
            this.lsvListMon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lsvListMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvListMon.FullRowSelect = true;
            this.lsvListMon.GridLines = true;
            this.lsvListMon.HideSelection = false;
            this.lsvListMon.Location = new System.Drawing.Point(3, 34);
            this.lsvListMon.Name = "lsvListMon";
            this.lsvListMon.Size = new System.Drawing.Size(852, 586);
            this.lsvListMon.TabIndex = 0;
            this.lsvListMon.UseCompatibleStateImageBehavior = false;
            this.lsvListMon.View = System.Windows.Forms.View.Details;
            this.lsvListMon.SelectedIndexChanged += new System.EventHandler(this.lsvListMon_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(391, 125);
            this.button1.TabIndex = 4;
            this.button1.Text = "Xóa không dùng para";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnDelYesPara
            // 
            this.btnDelYesPara.Location = new System.Drawing.Point(112, 382);
            this.btnDelYesPara.Name = "btnDelYesPara";
            this.btnDelYesPara.Size = new System.Drawing.Size(391, 125);
            this.btnDelYesPara.TabIndex = 4;
            this.btnDelYesPara.Text = "Xóa có dùng para";
            this.btnDelYesPara.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelNoPara);
            this.groupBox2.Controls.Add(this.btnDelYesPara);
            this.groupBox2.Location = new System.Drawing.Point(906, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(629, 601);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng:";
            // 
            // btnDelNoPara
            // 
            this.btnDelNoPara.Location = new System.Drawing.Point(112, 146);
            this.btnDelNoPara.Name = "btnDelNoPara";
            this.btnDelNoPara.Size = new System.Drawing.Size(391, 125);
            this.btnDelNoPara.TabIndex = 4;
            this.btnDelNoPara.Text = "Xóa không dùng para";
            this.btnDelNoPara.UseVisualStyleBackColor = true;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã món";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã nhóm";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên món ăn";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Đơn vị tính";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Giá món ăn";
            this.columnHeader5.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 922);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboChonMon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboChonMon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lsvListMon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDelYesPara;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDelNoPara;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

