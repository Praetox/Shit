using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HTTP_DL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void cmdDL_Click(object sender, EventArgs e)
        {
            Download(txtLink.Text);
        }
        private void cmdClipDL_Click(object sender, EventArgs e)
        {
            Download(Clipboard.GetText());
        }

        private void Download(string url)
        {
            try
            {
                string[] afName = url.Split('/');
                string fName = afName[afName.GetUpperBound(0)];
                System.Net.WebClient wc = new System.Net.WebClient();
                wc.DownloadProgressChanged += new System.Net.DownloadProgressChangedEventHandler(wc_DownloadProgressChanged);
                wc.DownloadFileAsync(new Uri(url), fName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Whoops...\r\n\r\n" + ex.Message);
            }
        }
        private void wc_DownloadProgressChanged(object sender, System.Net.DownloadProgressChangedEventArgs e)
        {
            this.Text = "Downloading (" +
                Math.Round((((double)100 / (double)e.TotalBytesToReceive) * (double)e.BytesReceived), 2) + "%)";
            if (e.TotalBytesToReceive == e.BytesReceived) this.Text = "Praetox HTTP Downloader";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.NoneEnabled;
        }
    }
}