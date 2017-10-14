namespace myMood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdSet1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMood = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pre2 = new System.Windows.Forms.Label();
            this.cmdSet2 = new System.Windows.Forms.Button();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMood = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TheLink = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdSet1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbMood);
            this.groupBox1.ForeColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 46);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pre-defined";
            // 
            // cmdSet1
            // 
            this.cmdSet1.ForeColor = System.Drawing.Color.Black;
            this.cmdSet1.Location = new System.Drawing.Point(171, 17);
            this.cmdSet1.Name = "cmdSet1";
            this.cmdSet1.Size = new System.Drawing.Size(73, 23);
            this.cmdSet1.TabIndex = 2;
            this.cmdSet1.Text = "Set mood!";
            this.cmdSet1.UseVisualStyleBackColor = true;
            this.cmdSet1.Click += new System.EventHandler(this.cmdSet1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mood:";
            // 
            // cmbMood
            // 
            this.cmbMood.FormattingEnabled = true;
            this.cmbMood.Location = new System.Drawing.Point(49, 19);
            this.cmbMood.Name = "cmbMood";
            this.cmbMood.Size = new System.Drawing.Size(116, 21);
            this.cmbMood.TabIndex = 0;
            this.cmbMood.SelectedIndexChanged += new System.EventHandler(this.cmbMood_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pre2);
            this.groupBox2.Controls.Add(this.cmdSet2);
            this.groupBox2.Controls.Add(this.txtColor);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.picPreview);
            this.groupBox2.Controls.Add(this.txtImage);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtMood);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.ForeColor = System.Drawing.Color.LightBlue;
            this.groupBox2.Location = new System.Drawing.Point(12, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 125);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Custom";
            // 
            // pre2
            // 
            this.pre2.BackColor = System.Drawing.Color.Black;
            this.pre2.ForeColor = System.Drawing.Color.Black;
            this.pre2.Location = new System.Drawing.Point(190, 96);
            this.pre2.Name = "pre2";
            this.pre2.Size = new System.Drawing.Size(17, 17);
            this.pre2.TabIndex = 10;
            // 
            // cmdSet2
            // 
            this.cmdSet2.ForeColor = System.Drawing.Color.Black;
            this.cmdSet2.Location = new System.Drawing.Point(49, 96);
            this.cmdSet2.Name = "cmdSet2";
            this.cmdSet2.Size = new System.Drawing.Size(89, 23);
            this.cmdSet2.TabIndex = 9;
            this.cmdSet2.Text = "Set mood!";
            this.cmdSet2.UseVisualStyleBackColor = true;
            this.cmdSet2.Click += new System.EventHandler(this.cmdSet2_Click);
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(49, 45);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(89, 20);
            this.txtColor.TabIndex = 8;
            this.txtColor.Text = "255,255,255";
            this.txtColor.TextChanged += new System.EventHandler(this.txtColor_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Color:";
            // 
            // picPreview
            // 
            this.picPreview.Location = new System.Drawing.Point(144, 19);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(100, 100);
            this.picPreview.TabIndex = 6;
            this.picPreview.TabStop = false;
            // 
            // txtImage
            // 
            this.txtImage.Location = new System.Drawing.Point(49, 71);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(89, 20);
            this.txtImage.TabIndex = 5;
            this.txtImage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtImage_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Image:";
            // 
            // txtMood
            // 
            this.txtMood.Location = new System.Drawing.Point(49, 19);
            this.txtMood.Name = "txtMood";
            this.txtMood.Size = new System.Drawing.Size(89, 20);
            this.txtMood.TabIndex = 3;
            this.txtMood.TextChanged += new System.EventHandler(this.txtMood_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mood:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtUser);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.ForeColor = System.Drawing.Color.LightBlue;
            this.groupBox3.Location = new System.Drawing.Point(12, 68);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 45);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "myMood account";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(49, 19);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(195, 20);
            this.txtUser.TabIndex = 5;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "User:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Your myMood link:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(12, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(250, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Click the link to copy it.";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TheLink
            // 
            this.TheLink.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TheLink.ForeColor = System.Drawing.Color.LightBlue;
            this.TheLink.Location = new System.Drawing.Point(12, 312);
            this.TheLink.Name = "TheLink";
            this.TheLink.Size = new System.Drawing.Size(250, 13);
            this.TheLink.TabIndex = 5;
            this.TheLink.Text = "http://mymood.awardspace.com/i.php?u=";
            this.TheLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TheLink.Click += new System.EventHandler(this.TheLink_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::myMood.Properties.Resources.myMood;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 50);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(274, 341);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TheLink);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.LightBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Praetox | myMood";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdSet1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMood;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMood;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdSet2;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label pre2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label TheLink;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

