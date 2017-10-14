namespace RazienDB
{
    partial class frmTubing
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
            this.cb_Type = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_UnitPrice = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.txt_Tax = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txt_TotalPrice = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txt_TotalPrice_wTax = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txt_Footage = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_Size = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_Gauge = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_Type);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(82, 250);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product type";
            // 
            // cb_Type
            // 
            this.cb_Type.FormattingEnabled = true;
            this.cb_Type.Location = new System.Drawing.Point(6, 19);
            this.cb_Type.Name = "cb_Type";
            this.cb_Type.Size = new System.Drawing.Size(70, 225);
            this.cb_Type.TabIndex = 1;
            this.cb_Type.SelectedIndexChanged += new System.EventHandler(this.cb_Type_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_UnitPrice);
            this.groupBox4.Location = new System.Drawing.Point(330, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(100, 45);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Price per unit";
            // 
            // txt_UnitPrice
            // 
            this.txt_UnitPrice.Location = new System.Drawing.Point(6, 19);
            this.txt_UnitPrice.Name = "txt_UnitPrice";
            this.txt_UnitPrice.Size = new System.Drawing.Size(88, 20);
            this.txt_UnitPrice.TabIndex = 1;
            this.txt_UnitPrice.TabStop = false;
            this.txt_UnitPrice.TextChanged += new System.EventHandler(this.txt_UnitPrice_TextChanged);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.txt_Tax);
            this.groupBox10.Location = new System.Drawing.Point(330, 166);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(100, 45);
            this.groupBox10.TabIndex = 7;
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
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txt_TotalPrice);
            this.groupBox9.Location = new System.Drawing.Point(330, 115);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(100, 45);
            this.groupBox9.TabIndex = 6;
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
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txt_TotalPrice_wTax);
            this.groupBox8.Location = new System.Drawing.Point(330, 217);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(100, 45);
            this.groupBox8.TabIndex = 8;
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
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txt_Footage);
            this.groupBox5.Location = new System.Drawing.Point(330, 63);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(100, 45);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Footage";
            // 
            // txt_Footage
            // 
            this.txt_Footage.Location = new System.Drawing.Point(6, 19);
            this.txt_Footage.Name = "txt_Footage";
            this.txt_Footage.Size = new System.Drawing.Size(88, 20);
            this.txt_Footage.TabIndex = 1;
            this.txt_Footage.TextChanged += new System.EventHandler(this.txt_Footage_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_Size);
            this.groupBox2.Location = new System.Drawing.Point(100, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(118, 250);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Size";
            // 
            // cb_Size
            // 
            this.cb_Size.FormattingEnabled = true;
            this.cb_Size.Location = new System.Drawing.Point(6, 19);
            this.cb_Size.Name = "cb_Size";
            this.cb_Size.Size = new System.Drawing.Size(106, 225);
            this.cb_Size.TabIndex = 1;
            this.cb_Size.SelectedIndexChanged += new System.EventHandler(this.cb_Size_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_Gauge);
            this.groupBox3.Location = new System.Drawing.Point(224, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(100, 250);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gauge";
            // 
            // cb_Gauge
            // 
            this.cb_Gauge.FormattingEnabled = true;
            this.cb_Gauge.Location = new System.Drawing.Point(6, 19);
            this.cb_Gauge.Name = "cb_Gauge";
            this.cb_Gauge.Size = new System.Drawing.Size(88, 225);
            this.cb_Gauge.TabIndex = 1;
            this.cb_Gauge.SelectedIndexChanged += new System.EventHandler(this.cb_Gauge_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tip: Use the tab key on the keyboard to change between fields.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmTubing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 287);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTubing";
            this.Text = "RazienDB - Tubing";
            this.Load += new System.EventHandler(this.frmSqTubing_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_UnitPrice;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox txt_Tax;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox txt_TotalPrice;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txt_TotalPrice_wTax;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txt_Footage;
        private System.Windows.Forms.ListBox cb_Type;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox cb_Size;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox cb_Gauge;
        private System.Windows.Forms.Label label1;
    }
}