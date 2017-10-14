namespace RazienDB
{
    partial class frmShearing
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txt_Area_Feet = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_Area_Inches = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_Width_Inches = new System.Windows.Forms.TextBox();
            this.txt_Width_Feet = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Length_Inches = new System.Windows.Forms.TextBox();
            this.txt_Length_Feet = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_Gauge = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txt_Cuts = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txt_Labour = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txt_TotalPrice_wTax = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txt_TotalPrice = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.txt_Tax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txt_Area_Feet);
            this.groupBox5.Location = new System.Drawing.Point(330, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(100, 45);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sq. ft.";
            // 
            // txt_Area_Feet
            // 
            this.txt_Area_Feet.Location = new System.Drawing.Point(6, 19);
            this.txt_Area_Feet.Name = "txt_Area_Feet";
            this.txt_Area_Feet.Size = new System.Drawing.Size(88, 20);
            this.txt_Area_Feet.TabIndex = 1;
            this.txt_Area_Feet.TabStop = false;
            this.txt_Area_Feet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_Area_Inches);
            this.groupBox4.Location = new System.Drawing.Point(224, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(100, 45);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Area";
            // 
            // txt_Area_Inches
            // 
            this.txt_Area_Inches.Location = new System.Drawing.Point(6, 19);
            this.txt_Area_Inches.Name = "txt_Area_Inches";
            this.txt_Area_Inches.Size = new System.Drawing.Size(88, 20);
            this.txt_Area_Inches.TabIndex = 1;
            this.txt_Area_Inches.TabStop = false;
            this.txt_Area_Inches.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_Width_Inches);
            this.groupBox3.Controls.Add(this.txt_Width_Feet);
            this.groupBox3.Location = new System.Drawing.Point(118, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(100, 45);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Width";
            // 
            // txt_Width_Inches
            // 
            this.txt_Width_Inches.Location = new System.Drawing.Point(53, 19);
            this.txt_Width_Inches.Name = "txt_Width_Inches";
            this.txt_Width_Inches.Size = new System.Drawing.Size(41, 20);
            this.txt_Width_Inches.TabIndex = 2;
            this.txt_Width_Inches.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Width_Inches.TextChanged += new System.EventHandler(this.txt_Width_Inches_TextChanged);
            // 
            // txt_Width_Feet
            // 
            this.txt_Width_Feet.Location = new System.Drawing.Point(6, 19);
            this.txt_Width_Feet.Name = "txt_Width_Feet";
            this.txt_Width_Feet.Size = new System.Drawing.Size(41, 20);
            this.txt_Width_Feet.TabIndex = 1;
            this.txt_Width_Feet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Width_Feet.TextChanged += new System.EventHandler(this.txt_Width_Feet_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Length_Inches);
            this.groupBox2.Controls.Add(this.txt_Length_Feet);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(100, 45);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Length";
            // 
            // txt_Length_Inches
            // 
            this.txt_Length_Inches.Location = new System.Drawing.Point(53, 19);
            this.txt_Length_Inches.Name = "txt_Length_Inches";
            this.txt_Length_Inches.Size = new System.Drawing.Size(41, 20);
            this.txt_Length_Inches.TabIndex = 2;
            this.txt_Length_Inches.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Length_Inches.TextChanged += new System.EventHandler(this.txt_Length_Inches_TextChanged);
            // 
            // txt_Length_Feet
            // 
            this.txt_Length_Feet.Location = new System.Drawing.Point(6, 19);
            this.txt_Length_Feet.Name = "txt_Length_Feet";
            this.txt_Length_Feet.Size = new System.Drawing.Size(41, 20);
            this.txt_Length_Feet.TabIndex = 1;
            this.txt_Length_Feet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Length_Feet.TextChanged += new System.EventHandler(this.txt_Length_Feet_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_Gauge);
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 159);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gauge";
            // 
            // cb_Gauge
            // 
            this.cb_Gauge.FormattingEnabled = true;
            this.cb_Gauge.Location = new System.Drawing.Point(6, 19);
            this.cb_Gauge.Name = "cb_Gauge";
            this.cb_Gauge.Size = new System.Drawing.Size(88, 134);
            this.cb_Gauge.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txt_Cuts);
            this.groupBox6.Location = new System.Drawing.Point(118, 63);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(100, 45);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Cuts";
            // 
            // txt_Cuts
            // 
            this.txt_Cuts.Location = new System.Drawing.Point(6, 19);
            this.txt_Cuts.Name = "txt_Cuts";
            this.txt_Cuts.Size = new System.Drawing.Size(88, 20);
            this.txt_Cuts.TabIndex = 1;
            this.txt_Cuts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Cuts.TextChanged += new System.EventHandler(this.txt_Cuts_TextChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txt_Labour);
            this.groupBox7.Location = new System.Drawing.Point(224, 63);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(100, 45);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Labour";
            // 
            // txt_Labour
            // 
            this.txt_Labour.Location = new System.Drawing.Point(6, 19);
            this.txt_Labour.Name = "txt_Labour";
            this.txt_Labour.Size = new System.Drawing.Size(88, 20);
            this.txt_Labour.TabIndex = 1;
            this.txt_Labour.TabStop = false;
            this.txt_Labour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txt_TotalPrice_wTax);
            this.groupBox8.Location = new System.Drawing.Point(330, 114);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(100, 45);
            this.groupBox8.TabIndex = 10;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Total price +tax";
            // 
            // txt_TotalPrice_wTax
            // 
            this.txt_TotalPrice_wTax.Location = new System.Drawing.Point(6, 19);
            this.txt_TotalPrice_wTax.Name = "txt_TotalPrice_wTax";
            this.txt_TotalPrice_wTax.Size = new System.Drawing.Size(88, 20);
            this.txt_TotalPrice_wTax.TabIndex = 1;
            this.txt_TotalPrice_wTax.TabStop = false;
            this.txt_TotalPrice_wTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txt_TotalPrice);
            this.groupBox9.Location = new System.Drawing.Point(224, 114);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(100, 45);
            this.groupBox9.TabIndex = 9;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Total price";
            // 
            // txt_TotalPrice
            // 
            this.txt_TotalPrice.Location = new System.Drawing.Point(6, 19);
            this.txt_TotalPrice.Name = "txt_TotalPrice";
            this.txt_TotalPrice.Size = new System.Drawing.Size(88, 20);
            this.txt_TotalPrice.TabIndex = 1;
            this.txt_TotalPrice.TabStop = false;
            this.txt_TotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.txt_Tax);
            this.groupBox10.Location = new System.Drawing.Point(330, 63);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(100, 45);
            this.groupBox10.TabIndex = 8;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Tax";
            // 
            // txt_Tax
            // 
            this.txt_Tax.Location = new System.Drawing.Point(6, 19);
            this.txt_Tax.Name = "txt_Tax";
            this.txt_Tax.Size = new System.Drawing.Size(88, 20);
            this.txt_Tax.TabIndex = 1;
            this.txt_Tax.TabStop = false;
            this.txt_Tax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tip: Use the tab key on the keyboard to change between fields.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmShearing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 247);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmShearing";
            this.Text = "RazienDB - Shearing";
            this.Load += new System.EventHandler(this.frmShearing_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txt_Area_Feet;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_Area_Inches;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_Width_Inches;
        private System.Windows.Forms.TextBox txt_Width_Feet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_Length_Inches;
        private System.Windows.Forms.TextBox txt_Length_Feet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txt_Cuts;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txt_Labour;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txt_TotalPrice_wTax;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox txt_TotalPrice;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox txt_Tax;
        private System.Windows.Forms.ListBox cb_Gauge;
        private System.Windows.Forms.Label label1;
    }
}