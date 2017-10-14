using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace myMood
{
    public partial class frmMain : Form
    {
        string DownloadedPics = "\r\n"; string raw = ""; string OldPic = "";
        string Website = "http://mymood.awardspace.com/";

        public frmMain()
        {
            InitializeComponent();
        }

        ///<summary>
        /// Splits msg by delim, returns bit part
        ///</summary>
        public static string Split(string msg, string delim, int part)
        {
            for (int a = 0; a < part; a++)
            {
                msg = msg.Substring(msg.IndexOf(delim) + delim.Length);
            }
            if (msg.IndexOf(delim) == -1) return msg;
            return msg.Substring(0, msg.IndexOf(delim));
        }
        ///<summary>
        /// Splits msg by delim, returns string array
        ///</summary>
        public static string[] aSplit(string msg, string delim)
        {
            int spt = 0; string[] ret = new string[Countword(msg, delim) + 1];
            while (msg.Contains(delim))
            {
                ret[spt] = msg.Substring(0, msg.IndexOf(delim)); spt++;
                msg = msg.Substring(msg.IndexOf(delim) + delim.Length);
            }
            ret[spt] = msg;
            return ret;
        }
        ///<summary>
        /// Counts occurrences of delim within msg
        ///</summary>
        public static int Countword(string msg, string delim)
        {
            int ret = 0;
            while (msg.Contains(delim))
            {
                msg = msg.Substring(msg.IndexOf(delim) + delim.Length); ret++;
            }
            return ret;
        }
        /// <summary>
        /// This function returns false and makes regkey if not exist.
        /// </summary>
        private bool Reg_DoesExist(string regPath)
        {
            try
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser;
                key = key.OpenSubKey(regPath, true);
                long lol = key.SubKeyCount;
                return true;
            }
            catch
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser;
                key.CreateSubKey(regPath);
                return false;
            }
        }
        /// <summary>
        /// Changes app title to vl. If null, defaults to app title.
        /// </summary>
        private void lg(string vl)
        {
            Font FontSmall = new Font(FontFamily.GenericSansSerif, 8);
            Font FontLarge = new Font(FontFamily.GenericSansSerif, 16);

            if (vl != "") { this.Text = vl; }
            if (vl == "") { this.Text = "myMood Client v" + Application.ProductVersion; }
            Application.DoEvents();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Show(); lg("Loading...");
            raw = new System.Net.WebClient().DownloadString(Website + "moods.html").Replace
                ("\n", "\r\n").Replace("\r\n\n", "\r\n");
            string[] saMoods = aSplit(Split(Split(raw, "<moodnames>\r\n", 1), "\r\n</moodnames>", 0), "\r\n");
            foreach (string vl in saMoods)
            {
                cmbMood.Items.Add(vl);
            }
            Reg_DoesExist("Software\\Praetox Technologies\\myMood");
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser;
            key = key.OpenSubKey("Software\\Praetox Technologies\\myMood", true);
            if (key.GetValue("Username") != null)
                txtUser.Text = key.GetValue("Username").ToString();
            key.Close();
            if (new System.Net.WebClient().DownloadString(Website + "cVersion.php" + 
                "?u=" + txtUser.Text + 
                "&cv=" + Application.ProductVersion
                ).IndexOf("<VERSION>" + Application.ProductVersion + "</VERSION") == -1)
                MessageBox.Show(
                    "Your version of the myMood client is outdated!" + "\r\n" +
                    "\r\n" +
                    "Please download the new version from the myMood website:" + "\r\n" +
                    Website);
            lg("");
        }

        private void cmbMood_SelectedIndexChanged(object sender, EventArgs e)
        {
            picPreview.Image = null; Application.DoEvents();
            txtMood.Text = ""; txtColor.Text = ""; txtImage.Text = "";
            string ThisMood = cmbMood.Items[cmbMood.SelectedIndex].ToString();
            if (raw.IndexOf("<mood_" + ThisMood + ">") == -1)
            {
                lg("Not in raw!");
                return;
            }
            else
            {
                string PicName = Split(Split(Split(raw, "<mood_" + ThisMood + ">", 1), "%avatar=", 1), "%", 0) + ".png";
                try
                {
                    SetPic(PicName);
                    txtMood.Text = Split(Split(Split(raw, "<mood_" + ThisMood + ">", 1),
                        "%text=", 1), "%", 0);
                    txtColor.Text = Split(Split(Split(raw, "<mood_" + ThisMood + ">", 1),
                        "%color=", 1), "%", 0);
                    txtImage.Text = PicName.Substring(0, PicName.Length - 4);
                    lg("");
                }
                catch (Exception ex)
                {
                    try
                    {
                        lg("Could not load!" + "\r\n" + ex.Message.Substring(0, 40));
                        MessageBox.Show(
                            "Whoops... Seems like an error occurred." + "\r\n\r\n" +
                            ex.Message);
                    }
                    catch
                    {
                        lg("Could not load!");
                        MessageBox.Show("That's some error you've got there. How'd you do that? o.O");
                    }
                }
            }
        }

        private void SetPic(string PicName)
        {
            if (PicName == OldPic) return; OldPic = PicName;
            lg("Loading " + PicName + "...");
            if (PicName.Substring(PicName.Length - 4) != ".png") PicName += ".png";
            if (DownloadedPics.IndexOf("\r\n" + PicName + "\r\n") == -1)
            {
                string PicUrl = Website + "getpic.php?i=" + PicName;
                new System.Net.WebClient().DownloadFile(PicUrl, PicName);
                DownloadedPics = DownloadedPics + PicName + "\r\n";
            }
            picPreview.Load(PicName);
            lg("");
        }
        private void SetMood()
        {
            int ColR = 255; int ColG = 255; int ColB = 255;
            try
            {
                ColR = Convert.ToInt32(Split(txtColor.Text, ",", 0));
                ColG = Convert.ToInt32(Split(txtColor.Text, ",", 1));
                ColB = Convert.ToInt32(Split(txtColor.Text, ",", 2));
            }
            catch { }
            if (ColR > 255) ColR = 255; if (ColG > 255) ColG = 255; if (ColB > 255) ColB = 255;
            new System.Net.WebClient().DownloadString(Website + "chMood.php?" +
                "user=" + txtUser.Text + "&" +
                "size=100,100&" +
                "val1=myMood:&" +
                "col1=255,255,255&" +
                "loc1=27,7&" +
                "val2=" + txtMood.Text + "&" +
                "col2=" + ColR + "," + ColG + "," + ColB + "&" +
                "loc2=" + (pre2.Left - picPreview.Left) + "," + (pre2.Top - picPreview.Top) + "&" +
                "bgcol=0,0,0&" +
                "bgpic=" + txtImage.Text + "&" +
                "bgloc=0,0&" +
                "bgmod=0");
            Reg_DoesExist("Software\\Praetox Technologies\\myMood");
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser;
            key = key.OpenSubKey("Software\\Praetox Technologies\\myMood", true);
            key.SetValue("Username", txtUser.Text);
            key.Close();
        }

        private void txtMood_TextChanged(object sender, EventArgs e)
        {
            pre2.Width = (txtMood.Text.Length * 7) + 1;
            pre2.Height = 10;
            pre2.Left = (picPreview.Left + (picPreview.Width - pre2.Width) / 2)+1;
            pre2.Top = picPreview.Top + 80 - 1;
            txtColor_TextChanged(new object(), new EventArgs());
        }
        private void txtColor_TextChanged(object sender, EventArgs e)
        {
            int ColR = 255; int ColG = 255; int ColB = 255;
            try
            {
                ColR = Convert.ToInt32(Split(txtColor.Text, ",", 0));
                ColG = Convert.ToInt32(Split(txtColor.Text, ",", 1));
                ColB = Convert.ToInt32(Split(txtColor.Text, ",", 2));
            }
            catch { }
            if (ColR > 255) ColR = 255; if (ColG > 255) ColG = 255; if (ColB > 255) ColB = 255; 
            pre2.BackColor = Color.FromArgb(ColR, ColG, ColB);
        }

        private void tSetPic_Tick(object sender, EventArgs e)
        {
            if (txtImage.Text == "") return;
            if (txtImage.Text != OldPic) SetPic(txtImage.Text);
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            TheLink.Text = Website + "i.php?u=" + txtUser.Text;
        }

        private void TheLink_Click(object sender, EventArgs e)
        {
            Clipboard.Clear(); Clipboard.SetText(TheLink.Text);
        }

        private void cmdSet1_Click(object sender, EventArgs e)
        {
            SetMood();
        }
        private void cmdSet2_Click(object sender, EventArgs e)
        {
            SetMood();
        }

        private void txtImage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SetPic(txtImage.Text);
        }
    }
}