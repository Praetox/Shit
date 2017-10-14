namespace SQLite
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
            this.tDB = new System.Windows.Forms.TextBox();
            this.cOpenDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tDB
            // 
            this.tDB.Location = new System.Drawing.Point(12, 14);
            this.tDB.Name = "tDB";
            this.tDB.Size = new System.Drawing.Size(163, 20);
            this.tDB.TabIndex = 0;
            this.tDB.Text = "db";
            // 
            // cOpenDB
            // 
            this.cOpenDB.Location = new System.Drawing.Point(181, 12);
            this.cOpenDB.Name = "cOpenDB";
            this.cOpenDB.Size = new System.Drawing.Size(99, 23);
            this.cOpenDB.TabIndex = 2;
            this.cOpenDB.Text = "Open DB";
            this.cOpenDB.UseVisualStyleBackColor = true;
            this.cOpenDB.Click += new System.EventHandler(this.cOpenDB_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 269);
            this.Controls.Add(this.cOpenDB);
            this.Controls.Add(this.tDB);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tDB;
        private System.Windows.Forms.Button cOpenDB;
    }
}

