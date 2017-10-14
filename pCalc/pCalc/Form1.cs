using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void t2ndEqI_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sv3 = t2ndEqI.Text;
                string sv1 = sv3.Substring(0, sv3.IndexOf("x^2")); sv3 = sv3.Substring(sv3.IndexOf("x^2") + 3);
                string sv2 = sv3.Substring(0, sv3.IndexOf("x")); sv3 = sv3.Substring(sv3.IndexOf("x") + 1);
                if (sv1 == "") sv1 = "1"; if (sv1 == "-" || sv1 == "+") sv1 += "1"; double v1 = Convert.ToDouble(sv1);
                if (sv2 == "") sv2 = "1"; if (sv2 == "-" || sv2 == "+") sv2 += "1"; double v2 = Convert.ToDouble(sv2);
                if (sv3 == "") sv3 = "1"; if (sv3 == "-" || sv3 == "+") sv3 += "1"; double v3 = Convert.ToDouble(sv3);
                //MessageBox.Show("Values:  " + sv1 + "  " + sv2 + "  " + sv3);
                double ret1a = (-v1) + Math.Sqrt(Math.Pow(v2, (double)2) - (double)4 * v1 * v3);
                double ret1 = ret1a / ((double)2 * v1);
                double ret2a = (-v1) - Math.Sqrt(Math.Pow(v2, (double)2) - (double)4 * v1 * v3);
                double ret2 = ret2a / ((double)2 * v1);
                //MessageBox.Show("" + (-v1) + "\r\n" + ((-v1) - Math.Sqrt(25)));
                MessageBox.Show("" + ret1a + "  " + ret2a);
                t2ndEqO1.Text = "" + ret1; t2ndEqO2.Text = "" + ret2;
            }
            catch { t2ndEqO1.Text = ""; t2ndEqO2.Text = ""; }
        }
    }
}