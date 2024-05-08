namespace TestConnectSQLAndVS
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
            this.btnOpenConnect = new System.Windows.Forms.Button();
            this.btnDisableConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenConnect
            // 
            this.btnOpenConnect.Location = new System.Drawing.Point(242, 258);
            this.btnOpenConnect.Name = "btnOpenConnect";
            this.btnOpenConnect.Size = new System.Drawing.Size(308, 111);
            this.btnOpenConnect.TabIndex = 0;
            this.btnOpenConnect.Text = "Mở kết nối";
            this.btnOpenConnect.UseVisualStyleBackColor = true;
            this.btnOpenConnect.Click += new System.EventHandler(this.btnOpenConnect_Click);
            // 
            // btnDisableConnect
            // 
            this.btnDisableConnect.Location = new System.Drawing.Point(640, 258);
            this.btnDisableConnect.Name = "btnDisableConnect";
            this.btnDisableConnect.Size = new System.Drawing.Size(308, 111);
            this.btnDisableConnect.TabIndex = 0;
            this.btnDisableConnect.Text = "Ngắt kết nối";
            this.btnDisableConnect.UseVisualStyleBackColor = true;
            this.btnDisableConnect.Click += new System.EventHandler(this.btnDisableConnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 712);
            this.Controls.Add(this.btnDisableConnect);
            this.Controls.Add(this.btnOpenConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenConnect;
        private System.Windows.Forms.Button btnDisableConnect;
    }
}

