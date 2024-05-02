namespace CheckedListbox
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
            this.chkListItem = new System.Windows.Forms.CheckedListBox();
            this.lblDSSP = new System.Windows.Forms.Label();
            this.lsvListItemSelected = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkListItem
            // 
            this.chkListItem.CheckOnClick = true;
            this.chkListItem.FormattingEnabled = true;
            this.chkListItem.Items.AddRange(new object[] {
            "Hạt thông",
            "Hạt chia",
            "Hạt macca",
            "Hạt điều",
            "Hạt dẻ cười",
            "Hạt óc chó",
            "Hạt bí",
            "Hạt hạnh nhân"});
            this.chkListItem.Location = new System.Drawing.Point(54, 114);
            this.chkListItem.Name = "chkListItem";
            this.chkListItem.Size = new System.Drawing.Size(454, 424);
            this.chkListItem.TabIndex = 0;
            this.chkListItem.SelectedIndexChanged += new System.EventHandler(this.chkListItem_SelectedIndexChanged);
            // 
            // lblDSSP
            // 
            this.lblDSSP.AutoSize = true;
            this.lblDSSP.Location = new System.Drawing.Point(48, 55);
            this.lblDSSP.Name = "lblDSSP";
            this.lblDSSP.Size = new System.Drawing.Size(280, 32);
            this.lblDSSP.TabIndex = 1;
            this.lblDSSP.Text = "Danh sách sản phẩm";
            // 
            // lsvListItemSelected
            // 
            this.lsvListItemSelected.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lsvListItemSelected.FullRowSelect = true;
            this.lsvListItemSelected.GridLines = true;
            this.lsvListItemSelected.HideSelection = false;
            this.lsvListItemSelected.Location = new System.Drawing.Point(545, 114);
            this.lsvListItemSelected.Name = "lsvListItemSelected";
            this.lsvListItemSelected.Size = new System.Drawing.Size(700, 686);
            this.lsvListItemSelected.TabIndex = 3;
            this.lsvListItemSelected.UseCompatibleStateImageBehavior = false;
            this.lsvListItemSelected.View = System.Windows.Forms.View.Details;
            this.lsvListItemSelected.SelectedIndexChanged += new System.EventHandler(this.lsvListItemSelected_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 98;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mặt hàng";
            this.columnHeader2.Width = 367;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(136, 585);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(267, 86);
            this.btnView.TabIndex = 4;
            this.btnView.Text = "Xem";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 868);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.lsvListItemSelected);
            this.Controls.Add(this.lblDSSP);
            this.Controls.Add(this.chkListItem);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chkListItem;
        private System.Windows.Forms.Label lblDSSP;
        private System.Windows.Forms.ListView lsvListItemSelected;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnView;
    }
}

