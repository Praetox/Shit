using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace touhourematch {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            listBox1.Items.Clear();
            string[] vars = Clipboard.GetText().Replace("\r", "").Trim('\n').Split('\n');
            for (int a = 0; a < vars.Length; a++) {
                listBox1.Items.Add(vars[a]);
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            string[] varsa = new string[listBox1.Items.Count];
            for (int a = 0; a < varsa.Length; a++) {
                varsa[a] = listBox1.Items[a].ToString();
                varsa[a] = varsa[a].Substring(0, varsa[a].IndexOf(" "));
            }
            listBox2.Items.Clear();
            string[] vars = Clipboard.GetText().Replace("\r", "").Trim('\n').Split('\n');
            for (int a = 0; a < varsa.Length; a++) {
                bool badd = false;
                for (int b = 0; b < vars.Length; b++) {
                    if (varsa[a] == vars[b].Substring(0, vars[b].IndexOf(" "))) {
                        listBox2.Items.Add(vars[b]);
                        badd = true;
                    }
                }
                if (!badd) listBox2.Items.Add("----- YOU FUCKED UP, GODDAMN RETARD");
            }
        }
    }
}
