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
    public partial class frmShearing : Form
    {
        public frmShearing()
        {
            InitializeComponent();
        }

        string[] GaugePricelist;

        private void frmShearing_Load(object sender, EventArgs e)
        {
            // Create a blank string to hold partially processed prices
            string sGauges = "";

            // Load price list from text file
            string Gauges_raw = Program.FileRead("Prices_Shearing_Gauges.txt");

            // Remove excess tabulations from text file
            while (Gauges_raw.Contains("\t\t")) Gauges_raw = Gauges_raw.Replace("\t\t", "\t");

            // Remove carriage return characters
            Gauges_raw = Gauges_raw.Replace("\r", "");

            // Split text file into an array by newline characters
            string[] aGauges = Gauges_raw.Replace("\r", "").Split('\n');

            // Loop through all entries in the array
            foreach (string Gauge in aGauges)
            {

                // If line is not a comment...
                if (!Gauge.StartsWith(";") && Gauge.Length > 4)
                {

                    // Assume it's a gauge price. Add it to sGauges
                    sGauges += Gauge.Split('\t')[0] + "|" +
                               Gauge.Split('\t')[1] + "|" +
                               Gauge.Split('\t')[2] + "\n";
                }
            }

            // Remove last newline from sGauges
            sGauges = sGauges.Substring(0, sGauges.Length - 1);

            // Dimension and assign the final array for prices
            GaugePricelist = sGauges.Split('\n');

            // Load elements into the gauge dropdown thingy
            cb_Gauge.Items.Clear();
            foreach (string Gauge in GaugePricelist)
            {
                cb_Gauge.Items.Add(Gauge.Split('|')[0]);
            }

            // Read taxes from general prices file
            string Tax = Program.FileRead("Prices_General.txt");

            // Chop away everything before the <tax> tag
            Tax = Tax.Substring(Tax.IndexOf("<tax>") + "<tax>".Length);

            // Chop away everything after the </tax> tag
            Tax = Tax.Substring(0, Tax.IndexOf("</tax>"));

            // Display the tax in the gui
            txt_Tax.Text = Tax;
        }

        private void txt_Length_Feet_TextChanged(object sender, EventArgs e)
        {
            CalcArea();
        }
        private void txt_Length_Inches_TextChanged(object sender, EventArgs e)
        {
            CalcArea();
        }
        private void txt_Width_Feet_TextChanged(object sender, EventArgs e)
        {
            CalcArea();
        }
        private void txt_Width_Inches_TextChanged(object sender, EventArgs e)
        {
            CalcArea();
        }

        private void CalcArea()
        {
            // Stop the program from crashing if a field is empty
            try
            {

                // Convert fields into variables supporting decimal numbers
                double dLngthFeet = Program.Str2Dbl(txt_Length_Feet.Text);
                double dLngthInch = Program.Str2Dbl(txt_Length_Inches.Text);
                double dWidthFeet = Program.Str2Dbl(txt_Width_Feet.Text);
                double dWidthInch = Program.Str2Dbl(txt_Width_Inches.Text);

                // Calculate sides in inches
                double dLngth = (dLngthFeet * 12) + dLngthInch;
                double dWidth = (dWidthFeet * 12) + dWidthInch;

                // Calculate area in inches and feet
                double dAreaI = dLngth * dWidth;
                double dAreaF = dAreaI / (12 * 12);

                // Display resulting numbers, rounded with 4 decimals
                txt_Area_Inches.Text = "" + Math.Round(dAreaI, 4);
                txt_Area_Feet.Text = "" + Math.Round(dAreaF, 4);
            }
            catch
            {

                // If a field was empty, change area fields to x
                txt_Area_Inches.Text = "x";
                txt_Area_Feet.Text = "x";
            }
        }

        private void cb_Gauge_TextChanged(object sender, EventArgs e)
        {
            CalcTotalPrice();
        }
        private void txt_Cuts_TextChanged(object sender, EventArgs e)
        {
            CalcTotalPrice();
        }

        private void CalcTotalPrice()
        {
            // Stop the program from crashing if a field is empty
            try
            {
                // Dimension some needed variables
                double dTotal = 0;
                double dLabr = 0;

                // Read gauge prices from the gauge array
                double dCut1 = Program.Str2Dbl(GaugePricelist[cb_Gauge.SelectedIndex].Split('|')[1]);
                double dCut2 = Program.Str2Dbl(GaugePricelist[cb_Gauge.SelectedIndex].Split('|')[2]);

                // Convert fields into variables supporting decimal numbers
                double dCuts = Program.Str2Dbl(txt_Cuts.Text);

                // Count up the total price for cuts
                if (dCuts > 0)
                {
                    dCuts--;
                    dLabr += dCut1;
                    if (dCuts > 0)
                    {
                        dLabr += (dCut2 * dCuts);
                    }
                }

                // Display labour on the gui
                txt_Labour.Text = "" + dLabr;

                // Add labour to the total price...
                dTotal += dLabr;

                // ...and display in the total price box.
                txt_TotalPrice.Text = "" + dTotal;

                // Now we add taxes to the total price dvariable...
                dTotal += dTotal * Program.Str2Dbl(txt_Tax.Text);

                // And, finally, we display the total price with taxes.
                txt_TotalPrice_wTax.Text = "" + dTotal;
            }
            catch
            {

                // If a field was empty, change area fields to x
                txt_TotalPrice.Text = "x";
                txt_TotalPrice_wTax.Text = "x";
            }
        }
    }
}