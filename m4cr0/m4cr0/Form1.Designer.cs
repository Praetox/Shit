namespace m4cr0
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cRecord = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cPlay = new System.Windows.Forms.Button();
            this.tRecord = new System.Windows.Forms.Timer(this.components);
            this.tScript = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cRecord);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 77);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recording";
            // 
            // cRecord
            // 
            this.cRecord.Location = new System.Drawing.Point(6, 19);
            this.cRecord.Name = "cRecord";
            this.cRecord.Size = new System.Drawing.Size(256, 52);
            this.cRecord.TabIndex = 0;
            this.cRecord.Text = "Record";
            this.cRecord.UseVisualStyleBackColor = true;
            this.cRecord.Click += new System.EventHandler(this.cRecord_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cPlay);
            this.groupBox2.Location = new System.Drawing.Point(12, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 77);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Playback";
            // 
            // cPlay
            // 
            this.cPlay.Location = new System.Drawing.Point(6, 19);
            this.cPlay.Name = "cPlay";
            this.cPlay.Size = new System.Drawing.Size(256, 52);
            this.cPlay.TabIndex = 0;
            this.cPlay.Text = "Play";
            this.cPlay.UseVisualStyleBackColor = true;
            this.cPlay.Click += new System.EventHandler(this.cPlay_Click);
            // 
            // tRecord
            // 
            this.tRecord.Interval = 1;
            this.tRecord.Tick += new System.EventHandler(this.tRecord_Tick);
            // 
            // tScript
            // 
            this.tScript.Font = new System.Drawing.Font("Lucida Console", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tScript.Location = new System.Drawing.Point(286, 12);
            this.tScript.Multiline = true;
            this.tScript.Name = "tScript";
            this.tScript.Size = new System.Drawing.Size(224, 160);
            this.tScript.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 184);
            this.Controls.Add(this.tScript);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cRecord;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cPlay;
        private System.Windows.Forms.Timer tRecord;
        private System.Windows.Forms.TextBox tScript;
    }
}

