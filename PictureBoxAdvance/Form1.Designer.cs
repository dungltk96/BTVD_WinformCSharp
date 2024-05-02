namespace PictureBoxAdvance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picHaTa = new System.Windows.Forms.PictureBox();
            this.picNangTa = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.chkMusic = new System.Windows.Forms.CheckBox();
            this.lblDs = new System.Windows.Forms.Label();
            this.lblKD = new System.Windows.Forms.Label();
            this.btnClick = new System.Windows.Forms.Button();
            this.lblCout = new System.Windows.Forms.Label();
            this.btnOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picHaTa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNangTa)).BeginInit();
            this.SuspendLayout();
            // 
            // picHaTa
            // 
            this.picHaTa.Image = ((System.Drawing.Image)(resources.GetObject("picHaTa.Image")));
            this.picHaTa.Location = new System.Drawing.Point(35, 62);
            this.picHaTa.Name = "picHaTa";
            this.picHaTa.Size = new System.Drawing.Size(279, 215);
            this.picHaTa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHaTa.TabIndex = 0;
            this.picHaTa.TabStop = false;
            // 
            // picNangTa
            // 
            this.picNangTa.Image = ((System.Drawing.Image)(resources.GetObject("picNangTa.Image")));
            this.picNangTa.Location = new System.Drawing.Point(35, 62);
            this.picNangTa.Name = "picNangTa";
            this.picNangTa.Size = new System.Drawing.Size(279, 215);
            this.picNangTa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNangTa.TabIndex = 0;
            this.picNangTa.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(32, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(138, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nhập tên của bạn vào đây:";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(35, 36);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(279, 20);
            this.txtInput.TabIndex = 2;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // chkMusic
            // 
            this.chkMusic.AutoSize = true;
            this.chkMusic.Location = new System.Drawing.Point(231, 12);
            this.chkMusic.Name = "chkMusic";
            this.chkMusic.Size = new System.Drawing.Size(54, 17);
            this.chkMusic.TabIndex = 3;
            this.chkMusic.Text = "Music";
            this.chkMusic.UseVisualStyleBackColor = true;
            this.chkMusic.CheckedChanged += new System.EventHandler(this.chkMusic_CheckedChanged);
            // 
            // lblDs
            // 
            this.lblDs.AutoSize = true;
            this.lblDs.Location = new System.Drawing.Point(32, 331);
            this.lblDs.Name = "lblDs";
            this.lblDs.Size = new System.Drawing.Size(57, 13);
            this.lblDs.TabIndex = 4;
            this.lblDs.Text = "Design by:";
            // 
            // lblKD
            // 
            this.lblKD.AutoSize = true;
            this.lblKD.Location = new System.Drawing.Point(32, 356);
            this.lblKD.Name = "lblKD";
            this.lblKD.Size = new System.Drawing.Size(53, 13);
            this.lblKD.TabIndex = 4;
            this.lblKD.Text = "Kim Dung";
            // 
            // btnClick
            // 
            this.btnClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClick.ForeColor = System.Drawing.Color.Red;
            this.btnClick.Location = new System.Drawing.Point(30, 283);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(284, 37);
            this.btnClick.TabIndex = 5;
            this.btnClick.TabStop = false;
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // lblCout
            // 
            this.lblCout.BackColor = System.Drawing.Color.Yellow;
            this.lblCout.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCout.Location = new System.Drawing.Point(110, 331);
            this.lblCout.Name = "lblCout";
            this.lblCout.Size = new System.Drawing.Size(204, 38);
            this.lblCout.TabIndex = 4;
            this.lblCout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(175, 380);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(75, 23);
            this.btnOut.TabIndex = 6;
            this.btnOut.Text = "Thoát";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(354, 415);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.lblCout);
            this.Controls.Add(this.lblKD);
            this.Controls.Add(this.lblDs);
            this.Controls.Add(this.chkMusic);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picNangTa);
            this.Controls.Add(this.picHaTa);
            this.Name = "Form1";
            this.Text = "Nâng hạ tạ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHaTa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNangTa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picHaTa;
        private System.Windows.Forms.PictureBox picNangTa;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.CheckBox chkMusic;
        private System.Windows.Forms.Label lblDs;
        private System.Windows.Forms.Label lblKD;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Label lblCout;
        private System.Windows.Forms.Button btnOut;
    }
}

