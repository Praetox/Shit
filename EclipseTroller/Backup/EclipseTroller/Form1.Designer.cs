namespace EclipseTroller
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
            this.components = new System.ComponentModel.Container();
            this.tMain = new System.Windows.Forms.Timer(this.components);
            this.txtEP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tMain
            // 
            this.tMain.Enabled = true;
            this.tMain.Interval = 300000;
            this.tMain.Tick += new System.EventHandler(this.tMain_Tick);
            // 
            // txtEP
            // 
            this.txtEP.Location = new System.Drawing.Point(12, 12);
            this.txtEP.Name = "txtEP";
            this.txtEP.Size = new System.Drawing.Size(100, 20);
            this.txtEP.TabIndex = 0;
            this.txtEP.Text = "14";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.txtEP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tMain;
        private System.Windows.Forms.TextBox txtEP;
    }
}

