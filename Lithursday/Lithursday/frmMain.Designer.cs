namespace Lithursday
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmd_Path_Browse = new System.Windows.Forms.Button();
            this.txt_Path = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_Header_Len = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_StartFrom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_URL = new System.Windows.Forms.TextBox();
            this.txt_Postdelay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Header = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmd_Activate = new System.Windows.Forms.Button();
            this.lbl_TimeNeeded = new System.Windows.Forms.Label();
            this.lbl_NeededPosts = new System.Windows.Forms.Label();
            this.lbl_StoryLength = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tRefreshInfo = new System.Windows.Forms.Timer(this.components);
            this.tPoster = new System.Windows.Forms.Timer(this.components);
            this.pConfig = new System.Windows.Forms.Panel();
            this.pPosting = new System.Windows.Forms.Panel();
            this.cmd_TogglePosting = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lbl_NextPost = new System.Windows.Forms.Label();
            this.lbl_Left_Time = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lbl_Posted_Time = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_Left_Posts = new System.Windows.Forms.Label();
            this.lbl_Left_Chars = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lbl_Posted_Posts = new System.Windows.Forms.Label();
            this.lbl_Posted_Chars = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbl_TimeNeeded2 = new System.Windows.Forms.Label();
            this.lbl_NeededPosts2 = new System.Windows.Forms.Label();
            this.lbl_StoryLength2 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pConfig.SuspendLayout();
            this.pPosting.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmd_Path_Browse);
            this.groupBox1.Controls.Add(this.txt_Path);
            this.groupBox1.ForeColor = System.Drawing.Color.Azure;
            this.groupBox1.Location = new System.Drawing.Point(3, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 45);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Path to book (*.txt)";
            // 
            // cmd_Path_Browse
            // 
            this.cmd_Path_Browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.cmd_Path_Browse.ForeColor = System.Drawing.Color.Azure;
            this.cmd_Path_Browse.Location = new System.Drawing.Point(499, 19);
            this.cmd_Path_Browse.Name = "cmd_Path_Browse";
            this.cmd_Path_Browse.Size = new System.Drawing.Size(75, 20);
            this.cmd_Path_Browse.TabIndex = 1;
            this.cmd_Path_Browse.Text = "Select";
            this.cmd_Path_Browse.UseVisualStyleBackColor = false;
            this.cmd_Path_Browse.Click += new System.EventHandler(this.cmd_Path_Browse_Click);
            // 
            // txt_Path
            // 
            this.txt_Path.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.txt_Path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Path.ForeColor = System.Drawing.Color.Azure;
            this.txt_Path.Location = new System.Drawing.Point(6, 19);
            this.txt_Path.Name = "txt_Path";
            this.txt_Path.Size = new System.Drawing.Size(487, 20);
            this.txt_Path.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_Header_Len);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_StartFrom);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_URL);
            this.groupBox2.Controls.Add(this.txt_Postdelay);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_Header);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.Color.Azure;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(580, 105);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configuration";
            // 
            // lbl_Header_Len
            // 
            this.lbl_Header_Len.Location = new System.Drawing.Point(499, 21);
            this.lbl_Header_Len.Name = "lbl_Header_Len";
            this.lbl_Header_Len.Size = new System.Drawing.Size(75, 13);
            this.lbl_Header_Len.TabIndex = 12;
            this.lbl_Header_Len.Text = "618; 375";
            this.lbl_Header_Len.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.ForeColor = System.Drawing.Color.Azure;
            this.textBox5.Location = new System.Drawing.Point(218, 71);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(275, 20);
            this.textBox5.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(499, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Something";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_StartFrom
            // 
            this.txt_StartFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.txt_StartFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_StartFrom.ForeColor = System.Drawing.Color.Azure;
            this.txt_StartFrom.Location = new System.Drawing.Point(87, 45);
            this.txt_StartFrom.Name = "txt_StartFrom";
            this.txt_StartFrom.Size = new System.Drawing.Size(125, 20);
            this.txt_StartFrom.TabIndex = 9;
            this.txt_StartFrom.Text = "1";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(499, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Thread URL";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_URL
            // 
            this.txt_URL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.txt_URL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_URL.ForeColor = System.Drawing.Color.Azure;
            this.txt_URL.Location = new System.Drawing.Point(218, 45);
            this.txt_URL.Name = "txt_URL";
            this.txt_URL.Size = new System.Drawing.Size(275, 20);
            this.txt_URL.TabIndex = 7;
            this.txt_URL.Text = "http://img.4chan.org/b/res/52533619.html";
            // 
            // txt_Postdelay
            // 
            this.txt_Postdelay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.txt_Postdelay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Postdelay.ForeColor = System.Drawing.Color.Azure;
            this.txt_Postdelay.Location = new System.Drawing.Point(87, 71);
            this.txt_Postdelay.Name = "txt_Postdelay";
            this.txt_Postdelay.Size = new System.Drawing.Size(125, 20);
            this.txt_Postdelay.TabIndex = 6;
            this.txt_Postdelay.Text = "60";
            this.txt_Postdelay.TextChanged += new System.EventHandler(this.txt_Postdelay_TextChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Post delay";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Start at post";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_Header
            // 
            this.txt_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.txt_Header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Header.ForeColor = System.Drawing.Color.Azure;
            this.txt_Header.Location = new System.Drawing.Point(87, 19);
            this.txt_Header.Name = "txt_Header";
            this.txt_Header.Size = new System.Drawing.Size(406, 20);
            this.txt_Header.TabIndex = 2;
            this.txt_Header.Text = "%i1/%i2";
            this.txt_Header.TextChanged += new System.EventHandler(this.txt_Header_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Header";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmd_Activate);
            this.groupBox3.Controls.Add(this.lbl_TimeNeeded);
            this.groupBox3.Controls.Add(this.lbl_NeededPosts);
            this.groupBox3.Controls.Add(this.lbl_StoryLength);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.ForeColor = System.Drawing.Color.Azure;
            this.groupBox3.Location = new System.Drawing.Point(3, 197);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(580, 120);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Information";
            // 
            // cmd_Activate
            // 
            this.cmd_Activate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.cmd_Activate.ForeColor = System.Drawing.Color.Azure;
            this.cmd_Activate.Location = new System.Drawing.Point(456, 19);
            this.cmd_Activate.Name = "cmd_Activate";
            this.cmd_Activate.Size = new System.Drawing.Size(118, 95);
            this.cmd_Activate.TabIndex = 10;
            this.cmd_Activate.Text = "Start posting";
            this.cmd_Activate.UseVisualStyleBackColor = false;
            this.cmd_Activate.Click += new System.EventHandler(this.cmd_Activate_Click);
            // 
            // lbl_TimeNeeded
            // 
            this.lbl_TimeNeeded.Location = new System.Drawing.Point(112, 42);
            this.lbl_TimeNeeded.Name = "lbl_TimeNeeded";
            this.lbl_TimeNeeded.Size = new System.Drawing.Size(100, 13);
            this.lbl_TimeNeeded.TabIndex = 9;
            this.lbl_TimeNeeded.Text = "?";
            // 
            // lbl_NeededPosts
            // 
            this.lbl_NeededPosts.Location = new System.Drawing.Point(112, 29);
            this.lbl_NeededPosts.Name = "lbl_NeededPosts";
            this.lbl_NeededPosts.Size = new System.Drawing.Size(338, 13);
            this.lbl_NeededPosts.TabIndex = 8;
            this.lbl_NeededPosts.Text = "?";
            // 
            // lbl_StoryLength
            // 
            this.lbl_StoryLength.Location = new System.Drawing.Point(112, 16);
            this.lbl_StoryLength.Name = "lbl_StoryLength";
            this.lbl_StoryLength.Size = new System.Drawing.Size(100, 13);
            this.lbl_StoryLength.TabIndex = 7;
            this.lbl_StoryLength.Text = "?";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Estimated time";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total posts needed";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total story length";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(3, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 16);
            this.label9.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(3, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 16);
            this.label10.TabIndex = 13;
            // 
            // tRefreshInfo
            // 
            this.tRefreshInfo.Interval = 1000;
            this.tRefreshInfo.Tick += new System.EventHandler(this.tRefreshInfo_Tick);
            // 
            // tPoster
            // 
            this.tPoster.Interval = 250;
            this.tPoster.Tick += new System.EventHandler(this.tPoster_Tick);
            // 
            // pConfig
            // 
            this.pConfig.Controls.Add(this.groupBox2);
            this.pConfig.Controls.Add(this.label10);
            this.pConfig.Controls.Add(this.groupBox1);
            this.pConfig.Controls.Add(this.groupBox3);
            this.pConfig.Controls.Add(this.label9);
            this.pConfig.Location = new System.Drawing.Point(12, 12);
            this.pConfig.Name = "pConfig";
            this.pConfig.Size = new System.Drawing.Size(586, 320);
            this.pConfig.TabIndex = 14;
            // 
            // pPosting
            // 
            this.pPosting.Controls.Add(this.cmd_TogglePosting);
            this.pPosting.Controls.Add(this.label15);
            this.pPosting.Controls.Add(this.groupBox6);
            this.pPosting.Location = new System.Drawing.Point(12, 353);
            this.pPosting.Name = "pPosting";
            this.pPosting.Size = new System.Drawing.Size(586, 320);
            this.pPosting.TabIndex = 15;
            // 
            // cmd_TogglePosting
            // 
            this.cmd_TogglePosting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.cmd_TogglePosting.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_TogglePosting.Location = new System.Drawing.Point(3, 48);
            this.cmd_TogglePosting.Name = "cmd_TogglePosting";
            this.cmd_TogglePosting.Size = new System.Drawing.Size(580, 143);
            this.cmd_TogglePosting.TabIndex = 5;
            this.cmd_TogglePosting.Text = "S T A R T";
            this.cmd_TogglePosting.UseVisualStyleBackColor = false;
            this.cmd_TogglePosting.Click += new System.EventHandler(this.cmd_TogglePosting_Click);
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(580, 42);
            this.label15.TabIndex = 4;
            this.label15.Text = "Posting mode enabled";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lbl_NextPost);
            this.groupBox6.Controls.Add(this.lbl_Left_Time);
            this.groupBox6.Controls.Add(this.label24);
            this.groupBox6.Controls.Add(this.lbl_Posted_Time);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.lbl_Left_Posts);
            this.groupBox6.Controls.Add(this.lbl_Left_Chars);
            this.groupBox6.Controls.Add(this.label25);
            this.groupBox6.Controls.Add(this.label26);
            this.groupBox6.Controls.Add(this.lbl_Posted_Posts);
            this.groupBox6.Controls.Add(this.lbl_Posted_Chars);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.lbl_TimeNeeded2);
            this.groupBox6.Controls.Add(this.lbl_NeededPosts2);
            this.groupBox6.Controls.Add(this.lbl_StoryLength2);
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.ForeColor = System.Drawing.Color.Azure;
            this.groupBox6.Location = new System.Drawing.Point(3, 197);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(580, 120);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Information";
            // 
            // lbl_NextPost
            // 
            this.lbl_NextPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NextPost.Location = new System.Drawing.Point(6, 61);
            this.lbl_NextPost.Name = "lbl_NextPost";
            this.lbl_NextPost.Size = new System.Drawing.Size(568, 56);
            this.lbl_NextPost.TabIndex = 28;
            this.lbl_NextPost.Text = "Next post in 0 seconds";
            this.lbl_NextPost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Left_Time
            // 
            this.lbl_Left_Time.Location = new System.Drawing.Point(461, 46);
            this.lbl_Left_Time.Name = "lbl_Left_Time";
            this.lbl_Left_Time.Size = new System.Drawing.Size(100, 15);
            this.lbl_Left_Time.TabIndex = 27;
            this.lbl_Left_Time.Text = "0";
            // 
            // label24
            // 
            this.label24.Location = new System.Drawing.Point(380, 46);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(75, 15);
            this.label24.TabIndex = 26;
            this.label24.Text = "Time left";
            // 
            // lbl_Posted_Time
            // 
            this.lbl_Posted_Time.Location = new System.Drawing.Point(274, 46);
            this.lbl_Posted_Time.Name = "lbl_Posted_Time";
            this.lbl_Posted_Time.Size = new System.Drawing.Size(100, 15);
            this.lbl_Posted_Time.TabIndex = 25;
            this.lbl_Posted_Time.Text = "0";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(193, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 15);
            this.label14.TabIndex = 24;
            this.label14.Text = "Time used";
            // 
            // lbl_Left_Posts
            // 
            this.lbl_Left_Posts.Location = new System.Drawing.Point(461, 31);
            this.lbl_Left_Posts.Name = "lbl_Left_Posts";
            this.lbl_Left_Posts.Size = new System.Drawing.Size(100, 15);
            this.lbl_Left_Posts.TabIndex = 20;
            this.lbl_Left_Posts.Text = "0";
            // 
            // lbl_Left_Chars
            // 
            this.lbl_Left_Chars.Location = new System.Drawing.Point(461, 16);
            this.lbl_Left_Chars.Name = "lbl_Left_Chars";
            this.lbl_Left_Chars.Size = new System.Drawing.Size(100, 15);
            this.lbl_Left_Chars.TabIndex = 19;
            this.lbl_Left_Chars.Text = "0";
            // 
            // label25
            // 
            this.label25.Location = new System.Drawing.Point(380, 31);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(75, 15);
            this.label25.TabIndex = 17;
            this.label25.Text = "Posts left";
            // 
            // label26
            // 
            this.label26.Location = new System.Drawing.Point(380, 16);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(75, 15);
            this.label26.TabIndex = 16;
            this.label26.Text = "Chars left";
            // 
            // lbl_Posted_Posts
            // 
            this.lbl_Posted_Posts.Location = new System.Drawing.Point(274, 31);
            this.lbl_Posted_Posts.Name = "lbl_Posted_Posts";
            this.lbl_Posted_Posts.Size = new System.Drawing.Size(100, 15);
            this.lbl_Posted_Posts.TabIndex = 14;
            this.lbl_Posted_Posts.Text = "0";
            // 
            // lbl_Posted_Chars
            // 
            this.lbl_Posted_Chars.Location = new System.Drawing.Point(274, 16);
            this.lbl_Posted_Chars.Name = "lbl_Posted_Chars";
            this.lbl_Posted_Chars.Size = new System.Drawing.Size(100, 15);
            this.lbl_Posted_Chars.TabIndex = 13;
            this.lbl_Posted_Chars.Text = "0";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(193, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 15);
            this.label16.TabIndex = 11;
            this.label16.Text = "Posts posted";
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(193, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 15);
            this.label17.TabIndex = 10;
            this.label17.Text = "Chars posted";
            // 
            // lbl_TimeNeeded2
            // 
            this.lbl_TimeNeeded2.Location = new System.Drawing.Point(87, 46);
            this.lbl_TimeNeeded2.Name = "lbl_TimeNeeded2";
            this.lbl_TimeNeeded2.Size = new System.Drawing.Size(100, 15);
            this.lbl_TimeNeeded2.TabIndex = 9;
            this.lbl_TimeNeeded2.Text = "0";
            // 
            // lbl_NeededPosts2
            // 
            this.lbl_NeededPosts2.Location = new System.Drawing.Point(87, 31);
            this.lbl_NeededPosts2.Name = "lbl_NeededPosts2";
            this.lbl_NeededPosts2.Size = new System.Drawing.Size(100, 15);
            this.lbl_NeededPosts2.TabIndex = 8;
            this.lbl_NeededPosts2.Text = "0";
            // 
            // lbl_StoryLength2
            // 
            this.lbl_StoryLength2.Location = new System.Drawing.Point(87, 16);
            this.lbl_StoryLength2.Name = "lbl_StoryLength2";
            this.lbl_StoryLength2.Size = new System.Drawing.Size(100, 15);
            this.lbl_StoryLength2.TabIndex = 7;
            this.lbl_StoryLength2.Text = "0";
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(6, 46);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(75, 15);
            this.label21.TabIndex = 6;
            this.label21.Text = "Total time";
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(6, 31);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(75, 15);
            this.label22.TabIndex = 5;
            this.label22.Text = "Total posts";
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(6, 16);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(75, 15);
            this.label23.TabIndex = 4;
            this.label23.Text = "Total chars";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(610, 341);
            this.Controls.Add(this.pPosting);
            this.Controls.Add(this.pConfig);
            this.ForeColor = System.Drawing.Color.Azure;
            this.Name = "frmMain";
            this.Text = "Lithursday poster";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.pConfig.ResumeLayout(false);
            this.pPosting.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmd_Path_Browse;
        private System.Windows.Forms.TextBox txt_Path;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_StartFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_URL;
        private System.Windows.Forms.TextBox txt_Postdelay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_Header_Len;
        private System.Windows.Forms.Label lbl_TimeNeeded;
        private System.Windows.Forms.Label lbl_NeededPosts;
        private System.Windows.Forms.Label lbl_StoryLength;
        private System.Windows.Forms.Timer tRefreshInfo;
        private System.Windows.Forms.Timer tPoster;
        private System.Windows.Forms.Panel pConfig;
        private System.Windows.Forms.Panel pPosting;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lbl_NeededPosts2;
        private System.Windows.Forms.Label lbl_StoryLength2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button cmd_TogglePosting;
        private System.Windows.Forms.Button cmd_Activate;
        private System.Windows.Forms.Label lbl_Left_Posts;
        private System.Windows.Forms.Label lbl_Left_Chars;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lbl_Posted_Posts;
        private System.Windows.Forms.Label lbl_Posted_Chars;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbl_Left_Time;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lbl_Posted_Time;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_TimeNeeded2;
        private System.Windows.Forms.Label lbl_NextPost;
    }
}

