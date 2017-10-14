using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RazienDB
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmdShearing_Click(object sender, EventArgs e)
        {
            new frmShearing().Show();
        }

        private void cmdSqTubing_Click(object sender, EventArgs e)
        {
            new frmTubing().Show();
        }
    }
}
