namespace Picturebbox
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
            this.picOff = new System.Windows.Forms.PictureBox();
            this.picOnl = new System.Windows.Forms.PictureBox();
            this.btnOnOff = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOnl)).BeginInit();
            this.SuspendLayout();
            // 
            // picOff
            // 
            this.picOff.Image = ((System.Drawing.Image)(resources.GetObject("picOff.Image")));
            this.picOff.Location = new System.Drawing.Point(210, 104);
            this.picOff.Name = "picOff";
            this.picOff.Size = new System.Drawing.Size(337, 415);
            this.picOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOff.TabIndex = 0;
            this.picOff.TabStop = false;
            // 
            // picOnl
            // 
            this.picOnl.Image = ((System.Drawing.Image)(resources.GetObject("picOnl.Image")));
            this.picOnl.Location = new System.Drawing.Point(210, 104);
            this.picOnl.Name = "picOnl";
            this.picOnl.Size = new System.Drawing.Size(337, 415);
            this.picOnl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOnl.TabIndex = 0;
            this.picOnl.TabStop = false;
            // 
            // btnOnOff
            // 
            this.btnOnOff.Location = new System.Drawing.Point(198, 576);
            this.btnOnOff.Name = "btnOnOff";
            this.btnOnOff.Size = new System.Drawing.Size(374, 70);
            this.btnOnOff.TabIndex = 1;
            this.btnOnOff.UseVisualStyleBackColor = true;
            this.btnOnOff.Click += new System.EventHandler(this.btnOnOff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 738);
            this.Controls.Add(this.btnOnOff);
            this.Controls.Add(this.picOnl);
            this.Controls.Add(this.picOff);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOnl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picOff;
        private System.Windows.Forms.PictureBox picOnl;
        private System.Windows.Forms.Button btnOnOff;
    }
}

