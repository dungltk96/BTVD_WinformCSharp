namespace ThietKeUngDungXuLyChuoi
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCountChar = new System.Windows.Forms.Button();
            this.btnCountLowerCase = new System.Windows.Forms.Button();
            this.btnCountUpperCase = new System.Windows.Forms.Button();
            this.ConvertLowerCase = new System.Windows.Forms.Button();
            this.btnConvertUppeCase = new System.Windows.Forms.Button();
            this.btnCountStringChar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnInsertString = new System.Windows.Forms.Button();
            this.btnLloacationFinal = new System.Windows.Forms.Button();
            this.btnTheCount = new System.Windows.Forms.Button();
            this.btnReversesString = new System.Windows.Forms.Button();
            this.btnLocationFirstly = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtLlocationFirstly = new System.Windows.Forms.TextBox();
            this.txtLocationFinal = new System.Windows.Forms.TextBox();
            this.txtTheCount = new System.Windows.Forms.TextBox();
            this.txtInsertString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numLocation = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLocation)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel4);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(1670, 1090);
            this.splitContainer1.SplitterDistance = 812;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCountChar);
            this.panel3.Controls.Add(this.btnCountLowerCase);
            this.panel3.Controls.Add(this.btnCountUpperCase);
            this.panel3.Controls.Add(this.ConvertLowerCase);
            this.panel3.Controls.Add(this.btnConvertUppeCase);
            this.panel3.Controls.Add(this.btnCountStringChar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 232);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(812, 858);
            this.panel3.TabIndex = 1;
            // 
            // btnCountChar
            // 
            this.btnCountChar.Location = new System.Drawing.Point(177, 721);
            this.btnCountChar.Name = "btnCountChar";
            this.btnCountChar.Size = new System.Drawing.Size(455, 79);
            this.btnCountChar.TabIndex = 0;
            this.btnCountChar.Text = "Đếm số ký tự số";
            this.btnCountChar.UseVisualStyleBackColor = true;
            this.btnCountChar.Click += new System.EventHandler(this.btnCountChar_Click);
            // 
            // btnCountLowerCase
            // 
            this.btnCountLowerCase.Location = new System.Drawing.Point(177, 594);
            this.btnCountLowerCase.Name = "btnCountLowerCase";
            this.btnCountLowerCase.Size = new System.Drawing.Size(455, 79);
            this.btnCountLowerCase.TabIndex = 0;
            this.btnCountLowerCase.Text = "Đếm số ký tự in thường";
            this.btnCountLowerCase.UseVisualStyleBackColor = true;
            this.btnCountLowerCase.Click += new System.EventHandler(this.btnCountLowerCase_Click);
            // 
            // btnCountUpperCase
            // 
            this.btnCountUpperCase.Location = new System.Drawing.Point(177, 459);
            this.btnCountUpperCase.Name = "btnCountUpperCase";
            this.btnCountUpperCase.Size = new System.Drawing.Size(455, 79);
            this.btnCountUpperCase.TabIndex = 0;
            this.btnCountUpperCase.Text = "Đếm số ký tự in hoa";
            this.btnCountUpperCase.UseVisualStyleBackColor = true;
            this.btnCountUpperCase.Click += new System.EventHandler(this.btnCountUpperCase_Click);
            // 
            // ConvertLowerCase
            // 
            this.ConvertLowerCase.Location = new System.Drawing.Point(177, 324);
            this.ConvertLowerCase.Name = "ConvertLowerCase";
            this.ConvertLowerCase.Size = new System.Drawing.Size(455, 79);
            this.ConvertLowerCase.TabIndex = 0;
            this.ConvertLowerCase.Text = "Chuyển thành chuỗi thường";
            this.ConvertLowerCase.UseVisualStyleBackColor = true;
            this.ConvertLowerCase.Click += new System.EventHandler(this.ConvertLowerCase_Click);
            // 
            // btnConvertUppeCase
            // 
            this.btnConvertUppeCase.Location = new System.Drawing.Point(177, 189);
            this.btnConvertUppeCase.Name = "btnConvertUppeCase";
            this.btnConvertUppeCase.Size = new System.Drawing.Size(455, 79);
            this.btnConvertUppeCase.TabIndex = 0;
            this.btnConvertUppeCase.Text = "Chuyển thành chuỗi hoa";
            this.btnConvertUppeCase.UseVisualStyleBackColor = true;
            this.btnConvertUppeCase.Click += new System.EventHandler(this.btnConvertUppeCase_Click);
            // 
            // btnCountStringChar
            // 
            this.btnCountStringChar.Location = new System.Drawing.Point(177, 54);
            this.btnCountStringChar.Name = "btnCountStringChar";
            this.btnCountStringChar.Size = new System.Drawing.Size(455, 79);
            this.btnCountStringChar.TabIndex = 0;
            this.btnCountStringChar.Text = "Đếm số ký tự trong chuỗi";
            this.btnCountStringChar.UseVisualStyleBackColor = true;
            this.btnCountStringChar.Click += new System.EventHandler(this.btnCountStringChar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 232);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtInput);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(812, 232);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input:";
            // 
            // txtInput
            // 
            this.txtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(3, 34);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(806, 195);
            this.txtInput.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.numLocation);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtInsertString);
            this.panel4.Controls.Add(this.txtTheCount);
            this.panel4.Controls.Add(this.txtLocationFinal);
            this.panel4.Controls.Add(this.txtLlocationFirstly);
            this.panel4.Controls.Add(this.btnInsertString);
            this.panel4.Controls.Add(this.btnLloacationFinal);
            this.panel4.Controls.Add(this.btnTheCount);
            this.panel4.Controls.Add(this.btnReversesString);
            this.panel4.Controls.Add(this.btnLocationFirstly);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 232);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(854, 858);
            this.panel4.TabIndex = 1;
            // 
            // btnInsertString
            // 
            this.btnInsertString.Location = new System.Drawing.Point(59, 594);
            this.btnInsertString.Name = "btnInsertString";
            this.btnInsertString.Size = new System.Drawing.Size(337, 79);
            this.btnInsertString.TabIndex = 0;
            this.btnInsertString.Text = "Chèn chuỗi";
            this.btnInsertString.UseVisualStyleBackColor = true;
            this.btnInsertString.Click += new System.EventHandler(this.btnInsertString_Click);
            // 
            // btnLloacationFinal
            // 
            this.btnLloacationFinal.Location = new System.Drawing.Point(59, 324);
            this.btnLloacationFinal.Name = "btnLloacationFinal";
            this.btnLloacationFinal.Size = new System.Drawing.Size(337, 79);
            this.btnLloacationFinal.TabIndex = 0;
            this.btnLloacationFinal.Text = "Vị trí xuất hiện cuối cùng";
            this.btnLloacationFinal.UseVisualStyleBackColor = true;
            this.btnLloacationFinal.Click += new System.EventHandler(this.btnLloacationFinal_Click);
            // 
            // btnTheCount
            // 
            this.btnTheCount.Location = new System.Drawing.Point(59, 459);
            this.btnTheCount.Name = "btnTheCount";
            this.btnTheCount.Size = new System.Drawing.Size(337, 79);
            this.btnTheCount.TabIndex = 0;
            this.btnTheCount.Text = "Số lần xuất hiện";
            this.btnTheCount.UseVisualStyleBackColor = true;
            this.btnTheCount.Click += new System.EventHandler(this.btnTheCount_Click);
            // 
            // btnReversesString
            // 
            this.btnReversesString.Location = new System.Drawing.Point(59, 54);
            this.btnReversesString.Name = "btnReversesString";
            this.btnReversesString.Size = new System.Drawing.Size(750, 79);
            this.btnReversesString.TabIndex = 0;
            this.btnReversesString.Text = "Đảo ngược chuỗi";
            this.btnReversesString.UseVisualStyleBackColor = true;
            this.btnReversesString.Click += new System.EventHandler(this.btnReversesString_Click);
            // 
            // btnLocationFirstly
            // 
            this.btnLocationFirstly.Location = new System.Drawing.Point(59, 189);
            this.btnLocationFirstly.Name = "btnLocationFirstly";
            this.btnLocationFirstly.Size = new System.Drawing.Size(337, 79);
            this.btnLocationFirstly.TabIndex = 0;
            this.btnLocationFirstly.Text = "Vị trí xuất hiện đầu tiên";
            this.btnLocationFirstly.UseVisualStyleBackColor = true;
            this.btnLocationFirstly.Click += new System.EventHandler(this.btnLocationFirstly_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(854, 232);
            this.panel2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtOutput);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(854, 232);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output:";
            // 
            // txtOutput
            // 
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(3, 34);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(848, 195);
            this.txtOutput.TabIndex = 0;
            // 
            // txtLlocationFirstly
            // 
            this.txtLlocationFirstly.Location = new System.Drawing.Point(470, 189);
            this.txtLlocationFirstly.Multiline = true;
            this.txtLlocationFirstly.Name = "txtLlocationFirstly";
            this.txtLlocationFirstly.Size = new System.Drawing.Size(339, 79);
            this.txtLlocationFirstly.TabIndex = 1;
            // 
            // txtLocationFinal
            // 
            this.txtLocationFinal.Location = new System.Drawing.Point(470, 324);
            this.txtLocationFinal.Multiline = true;
            this.txtLocationFinal.Name = "txtLocationFinal";
            this.txtLocationFinal.Size = new System.Drawing.Size(339, 79);
            this.txtLocationFinal.TabIndex = 1;
            // 
            // txtTheCount
            // 
            this.txtTheCount.Location = new System.Drawing.Point(470, 459);
            this.txtTheCount.Multiline = true;
            this.txtTheCount.Name = "txtTheCount";
            this.txtTheCount.Size = new System.Drawing.Size(339, 79);
            this.txtTheCount.TabIndex = 1;
            // 
            // txtInsertString
            // 
            this.txtInsertString.Location = new System.Drawing.Point(470, 594);
            this.txtInsertString.Multiline = true;
            this.txtInsertString.Name = "txtInsertString";
            this.txtInsertString.Size = new System.Drawing.Size(339, 79);
            this.txtInsertString.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 721);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vị trí";
            // 
            // numLocation
            // 
            this.numLocation.Location = new System.Drawing.Point(470, 714);
            this.numLocation.Name = "numLocation";
            this.numLocation.Size = new System.Drawing.Size(339, 38);
            this.numLocation.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1670, 1090);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Thiết kế ứng dụng xử lý chuỗi";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLocation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCountLowerCase;
        private System.Windows.Forms.Button btnCountUpperCase;
        private System.Windows.Forms.Button ConvertLowerCase;
        private System.Windows.Forms.Button btnConvertUppeCase;
        private System.Windows.Forms.Button btnCountStringChar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnInsertString;
        private System.Windows.Forms.Button btnLloacationFinal;
        private System.Windows.Forms.Button btnTheCount;
        private System.Windows.Forms.Button btnReversesString;
        private System.Windows.Forms.Button btnLocationFirstly;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnCountChar;
        private System.Windows.Forms.NumericUpDown numLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInsertString;
        private System.Windows.Forms.TextBox txtTheCount;
        private System.Windows.Forms.TextBox txtLocationFinal;
        private System.Windows.Forms.TextBox txtLlocationFirstly;
    }
}

