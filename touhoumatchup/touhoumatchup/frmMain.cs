using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace touhoumatchup {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }

        private void listBox1_DragOver(object sender, DragEventArgs e) {
            e.Effect = DragDropEffects.All;
        }
        private void listBox1_DragDrop(object sender, DragEventArgs e) {
            string[] files  = (string[])e.Data.GetData(DataFormats.FileDrop);
            Array.Sort(files);
            for (int a = 0; a < files.Length; a++) {
                files[a] = files[a].Substring(0, files[a].LastIndexOf("\\"));
                files[a] = files[a].Substring(files[a].LastIndexOf("\\") + 1);
                listBox1.Items.Add(files[a]);
            }
        }
        private void listBox2_DragOver(object sender, DragEventArgs e) {
            e.Effect = DragDropEffects.All;
        }
        private void listBox2_DragDrop(object sender, DragEventArgs e) {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            Array.Sort(files);
            for (int a = 0; a < files.Length; a++) {
                files[a] = files[a].Substring(files[a].LastIndexOf("\\") + 1);
                listBox2.Items.Add(files[a]);
            }
        }
        private void listBox1_KeyDown(object sender, KeyEventArgs e) {
            int mvSteps = 0;
            if (e.Control && e.KeyCode == Keys.Up) mvSteps = -1;
            if (e.Control && e.KeyCode == Keys.Down) mvSteps = +1;
            if (e.Control && e.KeyCode == Keys.Home) mvSteps = -9001;
            if (e.Control && e.KeyCode == Keys.End) mvSteps = +9001;
            if (mvSteps == 0) return;
            object oldObj = listBox1.SelectedItem;
            int oldPos = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(oldPos);
            oldPos += mvSteps;
            if (oldPos < 0) oldPos = 0;
            if (oldPos > listBox1.Items.Count)
                oldPos = listBox1.Items.Count;
            listBox1.Items.Insert(oldPos, oldObj);
            listBox1.SelectedIndex = oldPos;
            e.Handled = true;
        }

        private void listBox2_KeyDown(object sender, KeyEventArgs e) {
            int mvSteps = 0;
            if (e.Control && e.KeyCode == Keys.Up) mvSteps = -1;
            if (e.Control && e.KeyCode == Keys.Down) mvSteps = +1;
            if (e.Control && e.KeyCode == Keys.Home) mvSteps = -9001;
            if (e.Control && e.KeyCode == Keys.End) mvSteps = +9001;
            if (mvSteps == 0) return;
            object oldObj = listBox2.SelectedItem;
            int oldPos = listBox2.SelectedIndex;
            listBox2.Items.RemoveAt(oldPos);
            oldPos += mvSteps;
            if (oldPos < 0) oldPos = 0;
            if (oldPos > listBox2.Items.Count)
                oldPos = listBox2.Items.Count;
            listBox2.Items.Insert(oldPos, oldObj);
            listBox2.SelectedIndex = oldPos;
            e.Handled = true;
        }
    }
}
