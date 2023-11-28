namespace apimaatjes
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.strAandeel = new System.Windows.Forms.Button();
            this.txtDbInfo = new System.Windows.Forms.TextBox();
            this.DBlbl = new System.Windows.Forms.Label();
            this.txtApiInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dbFetchtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 60);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(650, 211);
            this.textBox1.TabIndex = 0;
            // 
            // strAandeel
            // 
            this.strAandeel.Location = new System.Drawing.Point(192, 320);
            this.strAandeel.Name = "strAandeel";
            this.strAandeel.Size = new System.Drawing.Size(75, 23);
            this.strAandeel.TabIndex = 1;
            this.strAandeel.Text = "aandelen";
            this.strAandeel.UseVisualStyleBackColor = true;
            this.strAandeel.Click += new System.EventHandler(this.strAandeel_Click);
            // 
            // txtDbInfo
            // 
            this.txtDbInfo.Location = new System.Drawing.Point(273, 297);
            this.txtDbInfo.Multiline = true;
            this.txtDbInfo.Name = "txtDbInfo";
            this.txtDbInfo.ReadOnly = true;
            this.txtDbInfo.Size = new System.Drawing.Size(188, 114);
            this.txtDbInfo.TabIndex = 2;
            this.txtDbInfo.TextChanged += new System.EventHandler(this.txtDbInfo_TextChanged);
            // 
            // DBlbl
            // 
            this.DBlbl.AutoSize = true;
            this.DBlbl.Location = new System.Drawing.Point(328, 278);
            this.DBlbl.Name = "DBlbl";
            this.DBlbl.Size = new System.Drawing.Size(50, 16);
            this.DBlbl.TabIndex = 3;
            this.DBlbl.Text = "DB info";
            // 
            // txtApiInfo
            // 
            this.txtApiInfo.Location = new System.Drawing.Point(467, 297);
            this.txtApiInfo.Multiline = true;
            this.txtApiInfo.Name = "txtApiInfo";
            this.txtApiInfo.ReadOnly = true;
            this.txtApiInfo.Size = new System.Drawing.Size(188, 114);
            this.txtApiInfo.TabIndex = 4;
            this.txtApiInfo.TextChanged += new System.EventHandler(this.txtApiInfo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(523, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "api info";
            // 
            // dbFetchtxt
            // 
            this.dbFetchtxt.Location = new System.Drawing.Point(12, 297);
            this.dbFetchtxt.Multiline = true;
            this.dbFetchtxt.Name = "dbFetchtxt";
            this.dbFetchtxt.ReadOnly = true;
            this.dbFetchtxt.Size = new System.Drawing.Size(188, 114);
            this.dbFetchtxt.TabIndex = 6;
            this.dbFetchtxt.TextChanged += new System.EventHandler(this.dbFetchtxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "DB fetch info";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dbFetchtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtApiInfo);
            this.Controls.Add(this.DBlbl);
            this.Controls.Add(this.txtDbInfo);
            this.Controls.Add(this.strAandeel);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button strAandeel;
        private System.Windows.Forms.TextBox txtDbInfo;
        private System.Windows.Forms.Label DBlbl;
        private System.Windows.Forms.TextBox txtApiInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dbFetchtxt;
        private System.Windows.Forms.Label label2;
    }
}

