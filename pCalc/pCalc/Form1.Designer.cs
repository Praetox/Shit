namespace pCalc
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
            this.t2ndEqO2 = new System.Windows.Forms.TextBox();
            this.t2ndEqO1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.t2ndEqI = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.t2ndEqO2);
            this.groupBox1.Controls.Add(this.t2ndEqO1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.t2ndEqI);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "2nd degree equation";
            // 
            // t2ndEqO2
            // 
            this.t2ndEqO2.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t2ndEqO2.Location = new System.Drawing.Point(75, 71);
            this.t2ndEqO2.Name = "t2ndEqO2";
            this.t2ndEqO2.Size = new System.Drawing.Size(63, 23);
            this.t2ndEqO2.TabIndex = 3;
            this.t2ndEqO2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // t2ndEqO1
            // 
            this.t2ndEqO1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t2ndEqO1.Location = new System.Drawing.Point(6, 71);
            this.t2ndEqO1.Name = "t2ndEqO1";
            this.t2ndEqO1.Size = new System.Drawing.Size(63, 23);
            this.t2ndEqO1.TabIndex = 2;
            this.t2ndEqO1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Solution:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // t2ndEqI
            // 
            this.t2ndEqI.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t2ndEqI.Location = new System.Drawing.Point(6, 19);
            this.t2ndEqI.Name = "t2ndEqI";
            this.t2ndEqI.Size = new System.Drawing.Size(132, 23);
            this.t2ndEqI.TabIndex = 0;
            this.t2ndEqI.Text = "x^2+3x-4";
            this.t2ndEqI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t2ndEqI.TextChanged += new System.EventHandler(this.t2ndEqI_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox t2ndEqO2;
        private System.Windows.Forms.TextBox t2ndEqO1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t2ndEqI;
    }
}

