using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EclipseTroller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tMain_Tick(object sender, EventArgs e)
        {
            string src = new System.Net.WebClient().DownloadString(
                "http://eclipse.no-sekai.de/projects/shana");
            this.Text = System.DateTime.Now.ToLongTimeString();
            if (src.Contains(": Shakugan no Shana Second " + txtEP.Text))
            {
                this.Text += "!!! " + this.Text;
                for (int a = 0; a < 5; a++)
                {
                    System.Media.SystemSounds.Beep.Play();
                    Application.DoEvents(); System.Threading.Thread.Sleep(1000);
                }
            }
        }
    }
}
