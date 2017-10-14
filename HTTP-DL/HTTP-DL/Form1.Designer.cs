namespace HTTP_DL
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.cmdDL = new System.Windows.Forms.Button();
            this.cmdClipDL = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLink);
            this.groupBox1.ForeColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 44);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Download from";
            // 
            // txtLink
            // 
            this.txtLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLink.ForeColor = System.Drawing.Color.White;
            this.txtLink.Location = new System.Drawing.Point(6, 19);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(256, 20);
            this.txtLink.TabIndex = 0;
            // 
            // cmdDL
            // 
            this.cmdDL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdDL.ForeColor = System.Drawing.Color.LightBlue;
            this.cmdDL.Location = new System.Drawing.Point(12, 72);
            this.cmdDL.Name = "cmdDL";
            this.cmdDL.Size = new System.Drawing.Size(268, 23);
            this.cmdDL.TabIndex = 1;
            this.cmdDL.Text = "Download entered link";
            this.cmdDL.UseVisualStyleBackColor = false;
            this.cmdDL.Click += new System.EventHandler(this.cmdDL_Click);
            // 
            // cmdClipDL
            // 
            this.cmdClipDL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdClipDL.ForeColor = System.Drawing.Color.LightBlue;
            this.cmdClipDL.Location = new System.Drawing.Point(12, 101);
            this.cmdClipDL.Name = "cmdClipDL";
            this.cmdClipDL.Size = new System.Drawing.Size(268, 59);
            this.cmdClipDL.TabIndex = 2;
            this.cmdClipDL.Text = "Download the link on clipboard";
            this.cmdClipDL.UseVisualStyleBackColor = false;
            this.cmdClipDL.Click += new System.EventHandler(this.cmdClipDL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(292, 173);
            this.Controls.Add(this.cmdClipDL);
            this.Controls.Add(this.cmdDL);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Praetox HTTP Downloader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Button cmdDL;
        private System.Windows.Forms.Button cmdClipDL;
    }
}

