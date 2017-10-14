namespace RazienDB
{
    partial class frmMain
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
            this.cmdShearing = new System.Windows.Forms.Button();
            this.cmdSqTubing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdShearing
            // 
            this.cmdShearing.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdShearing.Location = new System.Drawing.Point(12, 12);
            this.cmdShearing.Name = "cmdShearing";
            this.cmdShearing.Size = new System.Drawing.Size(184, 77);
            this.cmdShearing.TabIndex = 0;
            this.cmdShearing.Text = "Shearing";
            this.cmdShearing.UseVisualStyleBackColor = true;
            this.cmdShearing.Click += new System.EventHandler(this.cmdShearing_Click);
            // 
            // cmdSqTubing
            // 
            this.cmdSqTubing.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSqTubing.Location = new System.Drawing.Point(202, 12);
            this.cmdSqTubing.Name = "cmdSqTubing";
            this.cmdSqTubing.Size = new System.Drawing.Size(184, 77);
            this.cmdSqTubing.TabIndex = 1;
            this.cmdSqTubing.Text = "Tubing";
            this.cmdSqTubing.UseVisualStyleBackColor = true;
            this.cmdSqTubing.Click += new System.EventHandler(this.cmdSqTubing_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 101);
            this.Controls.Add(this.cmdSqTubing);
            this.Controls.Add(this.cmdShearing);
            this.Name = "frmMain";
            this.Text = "RazienDB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdShearing;
        private System.Windows.Forms.Button cmdSqTubing;


    }
}

