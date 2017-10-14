using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace titledump {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e) {
            comboBox1.SelectedIndex = 0;
        }
        private void button1_Click(object sender, EventArgs e) {
            Process[] prc = Process.GetProcessesByName(comboBox1.Text);
            if (prc.Length == 0) {
                MessageBox.Show("Could not dump title:" + "\r\n\r\n" +
                    "Target application not found!"); return;
            }
            string var = prc[0].MainWindowTitle;
            textBox1.Text += var + "\r\n";
        }
        private void button2_Click(object sender, EventArgs e) {
            textBox1.Text = "";
        }
        private void button3_Click(object sender, EventArgs e) {
            Clipboard.Clear();
            Clipboard.SetText("[spoiler=title dumps][code]" +
                textBox1.Text + "[/code][/spoiler]\r\n.");
        }
    }
}
