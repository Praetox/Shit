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
    public partial class frmTubing : Form
    {
        public frmTubing()
        {
            InitializeComponent();
        }

        private ProdInfo[] Products;

        private void frmSqTubing_Load(object sender, EventArgs e)
        {
            // Create a blank string to hold partially processed prices
            string sProdInfo = "";

            // Load price list from text file
            string sProdInfo_raw = Program.FileRead("Prices_Tubing.txt");

            // Remove excess tabulations from text file
            while (sProdInfo_raw.Contains("\t\t")) sProdInfo_raw = sProdInfo_raw.Replace("\t\t", "\t");

            // Remove carriage return characters
            sProdInfo_raw = sProdInfo_raw.Replace("\r", "");

            // Split text file into an array by newline characters
            string[] saProducts = sProdInfo_raw.Replace("\r", "").Split('\n');

            // Loop through all entries in the array
            foreach (string Product in saProducts)
            {

                // If line is not a comment...
                if (!Product.StartsWith(";") && Product.Length > 4)
                {

                    // Assume it's a product. Add it to sProdInfo.
                    sProdInfo += Product.Split('\t')[0] + "|" +
                                 Product.Split('\t')[1] + "|" +
                                 Product.Split('\t')[2] + "|" +
                                 Product.Split('\t')[3] + "\n";
                }
            }

            // Remove last newline from sProdInfo
            sProdInfo = sProdInfo.Substring(0, sProdInfo.Length - 1);

            // Create a temporary product info array
            string[] saProdInfo = sProdInfo.Split('\n');

            // Dimension the final array for product information
            Products = new ProdInfo[saProdInfo.Length];

            // Assign products to the final array
            for (int a = 0; a < saProdInfo.Length; a++)
            {
                Products[a] = new ProdInfo();
                Products[a].sType = saProdInfo[a].Split('|')[0];
                Products[a].sSize = saProdInfo[a].Split('|')[1];
                Products[a].sGauge = saProdInfo[a].Split('|')[2];
                Products[a].sPrice = saProdInfo[a].Split('|')[3];
            }

            // List all different product types into a string
            string varProductTypes = "";
            foreach (ProdInfo prod in Products)
            {
                if (!varProductTypes.Contains(prod.sType)) varProductTypes += prod.sType + "\n";
            }
            varProductTypes = varProductTypes.Substring(0, varProductTypes.Length - 1);
            string[] avarProductTypes = varProductTypes.Split('\n');

            // Load product types into the type dropdown thingy
            cb_Type.Items.Clear();
            foreach (string prod in avarProductTypes)
            {
                cb_Type.Items.Add(prod);
            }
            cb_Type.SelectedIndex = -1;
            cb_Type.SelectedIndex = 0;

            // Read taxes from general prices file
            string Tax = Program.FileRead("Prices_General.txt");

            // Chop away everything before the <tax> tag
            Tax = Tax.Substring(Tax.IndexOf("<tax>") + "<tax>".Length);

            // Chop away everything after the </tax> tag
            Tax = Tax.Substring(0, Tax.IndexOf("</tax>"));

            // Display the tax in the gui
            txt_Tax.Text = Tax;
        }

        private void cb_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            // List all different product sizes into a string
            string varProductSizes = "";

            // Read currently selected types
            string varProductType = cb_Type.SelectedItem.ToString();

            // Loop through products to find matching items
            foreach (ProdInfo prod in Products)
            {
                if (prod.sType == varProductType &&
                    !varProductSizes.Contains(prod.sSize))
                    
                    varProductSizes += prod.sSize + "\n";
            }
            varProductSizes = varProductSizes.Substring(0, varProductSizes.Length - 1);
            string[] avarProductSizes = varProductSizes.Split('\n');

            // Load product sizes into the type dropdown thingy
            cb_Size.Items.Clear();
            foreach (string prod in avarProductSizes)
            {
                cb_Size.Items.Add(prod);
            }
            cb_Size.SelectedIndex = -1;
            cb_Size.SelectedIndex = 0;
        }

        private void cb_Size_SelectedIndexChanged(object sender, EventArgs e)
        {
            // List all different product gauges into a string
            string varProductGauges = "";
            string varProductType = cb_Type.SelectedItem.ToString();
            string varProductSize = cb_Size.SelectedItem.ToString();
            foreach (ProdInfo prod in Products)
            {
                if (prod.sType == varProductType &&
                    prod.sSize == varProductSize &&
                    !varProductGauges.Contains(prod.sGauge))

                    varProductGauges += prod.sGauge + "\n";
            }
            varProductGauges = varProductGauges.Substring(0, varProductGauges.Length - 1);
            string[] avarProductGauges = varProductGauges.Split('\n');

            // Load product sizes into the type dropdown thingy
            cb_Gauge.Items.Clear();
            foreach (string prod in avarProductGauges)
            {
                cb_Gauge.Items.Add(prod);
            }
            cb_Gauge.SelectedIndex = -1;
            cb_Gauge.SelectedIndex = 0;
        }

        private void cb_Gauge_SelectedIndexChanged(object sender, EventArgs e)
        {
            string varProductType = cb_Type.SelectedItem.ToString();
            string varProductSize = cb_Size.SelectedItem.ToString();
            string varProductGauge = cb_Gauge.SelectedItem.ToString();
            txt_UnitPrice.Text = "";
            foreach (ProdInfo prod in Products)
            {
                if (prod.sType == varProductType &&
                    prod.sSize == varProductSize &&
                    prod.sGauge == varProductGauge)

                    txt_UnitPrice.Text = prod.sPrice;
            }
        }

        private void txt_UnitPrice_TextChanged(object sender, EventArgs e)
        {
            CalcTotal();
        }
        private void txt_Footage_TextChanged(object sender, EventArgs e)
        {
            CalcTotal();
        }

        private void CalcTotal()
        {
            try
            {
                double dFootage = Program.Str2Dbl(txt_Footage.Text);
                double dPrice = Program.Str2Dbl(txt_UnitPrice.Text);
                double dTotal = dFootage * dPrice;
                if (dTotal == 0) throw new Exception();
                txt_TotalPrice.Text = "" + Math.Round(dTotal, 2);
                dTotal += dTotal * Program.Str2Dbl(txt_Tax.Text);
                txt_TotalPrice_wTax.Text = "" + Math.Round(dTotal, 2);
            }
            catch
            {
                txt_TotalPrice.Text = "x";
                txt_TotalPrice_wTax.Text = "x";
            }
        }
    }

    public class ProdInfo
    {
        public string sType;
        public string sSize;
        public string sGauge;
        public string sPrice;
    }
}
