using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace Lithursday
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public static string Story;
        public static string Header;
        public static string ThreadURL;
        public static int CurrentPost = 0;
        public static int TotalPosts = -1;
        public static int PostDelay = -1;
        public static int PostLen = 2000;
        public static long LastPost = -1337;
        public static bool intPoster = false;

        #region Random functions
        ///<summary>
        /// Returns system clock in miliseconds
        ///</summary>
        public long Tick()
        {
            return System.DateTime.Now.Ticks / 10000;
        }
        #endregion
        #region File and array manipulation
        /// <summary>
        /// Converts string into unicode byte array
        /// </summary>
        private byte[] CnvToAByt(string src)
        {
            int iRet = 0;
            Encoder enc = System.Text.Encoding.UTF8.GetEncoder();
            char[] buf1 = src.ToCharArray();
            byte[] buf2 = new byte[src.Length * 4];
            enc.GetBytes(buf1, 0, buf1.Length, buf2, 0, true);
            for (iRet = 0; iRet < buf2.Length; iRet++)
            {
                if (buf2[iRet] == 0) break;
            }
            byte[] ret = new byte[iRet];
            for (int a = 0; a < ret.Length; a++)
            {
                ret[a] = buf2[a];
            }
            return ret;
        }
        /// <summary>
        /// Converts unicode byte array to string
        /// </summary>
        private string CnvToStr(byte[] src)
        {
            int buf2l = 0;
            Decoder dec = System.Text.Encoding.UTF8.GetDecoder();
            char[] buf1 = new char[src.Length];
            dec.GetChars(src, 0, src.Length, buf1, 0);
            for (buf2l = 0; buf2l < buf1.Length; buf2l++)
            {
                if (buf1[buf2l] == 0) break;
            }
            char[] buf2 = new char[buf2l];
            for (int a = 0; a < buf2.Length; a++)
            {
                buf2[a] = buf1[a];
            }
            string lol = new string(buf2);
            return lol;
        }
        /// <summary>
        /// Reads sFile, works with norwegian letters ae oo aa
        /// </summary>
        private string FileRead(string sFile)
        {
            try
            {
                System.IO.FileStream fs = new System.IO.FileStream
                    (sFile, System.IO.FileMode.Open);
                byte[] buf = new byte[fs.Length];
                fs.Read(buf, 0, Convert.ToInt32(fs.Length));
                fs.Flush(); fs.Close(); fs.Dispose();
                return CnvToStr(buf);
            }
            catch { return ""; }
        }
        /// <summary>
        /// Writes sVal to sFile, works with norwegian letters ae oo aa
        /// </summary>
        /// <param name="sFile">Target file</param>
        /// <param name="sVal">The string to write</param>
        /// <param name="bAppend">Append instead of overwrite</param>
        private void FileWrite(string sFile, string Data, bool bAppend)
        {
            byte[] buf = CnvToAByt(Data);
            System.IO.FileMode AccessType = System.IO.FileMode.Create;
            if (bAppend) AccessType = System.IO.FileMode.Append;
            System.IO.FileStream fs = new System.IO.FileStream(sFile, AccessType);
            fs.Write(buf, 0, buf.Length);
            fs.Flush(); fs.Close(); fs.Dispose();
        }
        public void FileWrite(string sFile, string sVal)
        {
            FileWrite(sFile, sVal, false);
        }
        /// <summary>
        /// Sorts vl[] alphabetically, ignores letters other than 0-9 a-z
        /// </summary>
        public string[] SortStringArrayAlphabetically(string[] vl)
        {
            for (int a = vl.GetUpperBound(0); a >= 0; a--)
            {
                for (int b = 0; b < a; b++) //changed "b <= a" to "b < a"
                {
                    if (string.Compare(vl[b], vl[b + 1], true) > 0)
                    {
                        //Swap values
                        string tmp = vl[b].ToString();
                        vl[b] = vl[b + 1];
                        vl[b + 1] = tmp;
                    }
                }
            }
            return vl;
        }
        #endregion

        private void cmd_Path_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Supported document formats (*.txt)|*.txt";
            fd.ShowDialog();
            if (fd.FileName != "") txt_Path.Text = fd.FileName;
            RecalcVals();
        }
        private void txt_Header_TextChanged(object sender, EventArgs e)
        {
            tRefreshInfo.Stop();
            tRefreshInfo.Start();
        }
        private void txt_Postdelay_TextChanged(object sender, EventArgs e)
        {
            tRefreshInfo.Stop();
            tRefreshInfo.Start();
        }
        private void tRefreshInfo_Tick(object sender, EventArgs e)
        {
            tRefreshInfo.Stop();
            RecalcVals();
        }

        private void RecalcVals()
        {
            if (System.IO.File.Exists(txt_Path.Text))
            {
                try
                {
                    Header = txt_Header.Text;
                    ThreadURL = txt_URL.Text;
                    CurrentPost = Convert.ToInt32(txt_StartFrom.Text);
                    PostDelay = Convert.ToInt32(txt_Postdelay.Text);
                    lbl_NeededPosts.Text = "777";
                    lbl_NeededPosts2.Text = "777";

                    string sStory = FileRead(txt_Path.Text).Replace("\r", "").Replace("\n", "\r\n");
                    while (sStory.Contains("\r\n\r\n\r\n"))
                    {
                        sStory = sStory.Replace("\r\n\r\n\r\n", "\r\n\r\n");
                    }
                    lbl_StoryLength.Text = "" + sStory.Length;
                    Story = sStory;

                    TotalPosts = -1;
                    while (GetNextPage() != "<END>")
                    {
                        TotalPosts++;
                    }

                    Story = sStory;
                    lbl_NeededPosts.Text = "" + TotalPosts;
                    lbl_TimeNeeded.Text = "" + Math.Round((double)(TotalPosts * PostDelay) / 60, 1) + " min";
                    lbl_NeededPosts2.Text = lbl_NeededPosts.Text;
                    lbl_TimeNeeded2.Text = lbl_TimeNeeded.Text;
                    lbl_StoryLength2.Text = lbl_StoryLength.Text;
                }
                catch
                {
                    lbl_StoryLength.Text = "Invalid config!";
                    lbl_NeededPosts.Text = "Invalid config!";
                    lbl_TimeNeeded.Text = "Invalid config!";
                    lbl_StoryLength2.Text = "Invalid config!";
                    lbl_NeededPosts2.Text = "Invalid config!";
                    lbl_TimeNeeded2.Text = "Invalid config!";
                }
            }
        }
        private string GetNextPage()
        {
            if (Story.Length > 0)
            {
                string tsStory = Story;
                string tsHeader = Header.
                    Replace("%i1", "" + CurrentPost).
                    Replace("%i2", "" + Convert.ToInt32(lbl_NeededPosts2.Text));
                if (tsHeader != "") tsStory = tsHeader + "\r\n" + tsStory;

                if (tsStory.Length > PostLen)
                {
                    tsStory = tsStory.Substring(0, PostLen);
                    int iSpace = tsStory.LastIndexOf(" ");
                    tsStory = tsStory.Substring(0, iSpace);

                    int iHeaderLen = tsHeader.Length;
                    if (iHeaderLen != 0) iHeaderLen += 2;
                    Story = Story.Substring(iSpace - iHeaderLen + 1);
                }
                else
                {
                    Story = "";
                }

                return tsStory;
            }
            else
            {
                return "<END>";
            }
        }

        private void cmd_Activate_Click(object sender, EventArgs e)
        {
            if (CurrentPost != 1)
            {
                for (int a = 1; a < CurrentPost; a++)
                {
                    GetNextPage();
                }
            }
            while (pPosting.Top > pConfig.Top+10)
            {
                pPosting.Top-=10;
                Application.DoEvents();
                System.Threading.Thread.Sleep(10);
            }
            pPosting.Top = pConfig.Top;
        }

        private void cmd_TogglePosting_Click(object sender, EventArgs e)
        {
            if (cmd_TogglePosting.Text == "S T A R T")
            {
                cmd_TogglePosting.Text = "P A U S E";
                tPoster.Start();
            }
            else
            {
                cmd_TogglePosting.Text = "S T A R T";
                tPoster.Stop();
            }
        }

        private void tPoster_Tick(object sender, EventArgs e)
        {
            if (intPoster) return; intPoster = true;
            
            long SinceLastPost = Tick() - LastPost;
            if (SinceLastPost < 0) SinceLastPost = -SinceLastPost;
            if (SinceLastPost == -1337) LastPost = Tick() - (PostDelay * 1000) + 1;
            if (SinceLastPost > (PostDelay * 10 * 1000)) LastPost = Tick();
            lbl_NextPost.Text = "Next post in " + (PostDelay-(SinceLastPost/1000)) + " seconds";

            if (SinceLastPost >= PostDelay * 1000)
            {
                lbl_NextPost.Text = "Posting ...";

                string ThisPost = GetNextPage();
                string tsHeader = Header.
                    Replace("%i1", "" + CurrentPost).
                    Replace("%i2", "" + Convert.ToInt32(lbl_NeededPosts2.Text));
                int iHeaderLen = tsHeader.Length;
                if (iHeaderLen != 0) iHeaderLen += 2;
                CurrentPost++;
                
                string Formdata =
                    "-----------------------------7d83992a850774" + "\r\n" +
                    "Content-Disposition: form-data; name=\"resto\"" + "\r\n" +
                    "\r\n" +
                    ThreadURL + "\r\n" +
                    "-----------------------------7d83992a850774" + "\r\n" +
                    "Content-Disposition: form-data; name=\"com\"" + "\r\n" +
                    "\r\n" +
                    ThisPost + "\r\n" +
                    "-----------------------------7d83992a850774" + "\r\n" +
                    "Content-Disposition: form-data; name=\"pwd\"" + "\r\n" +
                    "\r\n" +
                    "lolwut" + "\r\n" +
                    "-----------------------------7d83992a850774" + "\r\n" +
                    "Content-Disposition: form-data; name=\"mode\"" + "\r\n" +
                    "\r\n" +
                    "regist" + "\r\n" +
                    "-----------------------------7d83992a850774--" + "\r\n";
                string ReqStr =
                    "POST /b/imgboard.php HTTP/1.1" + "\r\n" +
                    "Accept: */*" + "\r\n" +
                    "Referer: http://img.4chan.org/b/res/" + ThreadURL + ".html" + "\r\n" +
                    "Content-Type: multipart/form-data; boundary=---------------------------7d83992a850774" + "\r\n" +
                    "Host: dat.4chan.org" + "\r\n" +
                    "Content-Length: " + Formdata.Length + "\r\n" +
                    "\r\n" + Formdata + "\r\n";
                Uri URI = new Uri("http://dat.4chan.org/b/imgboard.php");
                Socket sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint RHost = new IPEndPoint(Dns.GetHostEntry(URI.Host).AddressList[0], URI.Port);
                lbl_NextPost.Text = "Connecting..."; Application.DoEvents();
                sck.Connect(RHost);
                lbl_NextPost.Text = "Sending..."; Application.DoEvents();
                sck.Send(System.Text.Encoding.ASCII.GetBytes(ReqStr));
                sck.Close(10000);

                //Clipboard.Clear(); Clipboard.SetText(wb.DocumentText);
                lbl_NextPost.Text = "Posted !"; Application.DoEvents();
                
                LastPost = Tick();
                lbl_Posted_Chars.Text = "" +
                    (Convert.ToInt32(lbl_Posted_Chars.Text) +
                    (ThisPost.Length - iHeaderLen));
                lbl_Left_Chars.Text = "" +
                    (Convert.ToInt32(lbl_StoryLength2.Text) -
                    Convert.ToInt32(lbl_Posted_Chars.Text));
                lbl_Posted_Posts.Text = "" + (CurrentPost-1);
                lbl_Left_Posts.Text = "" +
                    (Convert.ToInt32(lbl_NeededPosts2.Text) -
                    (CurrentPost-1));
                lbl_Posted_Time.Text = "" +
                    Math.Round(((Convert.ToDouble(lbl_Posted_Time.Text.Split(' ')[0]
                    .Replace(".", ","))*60) + PostDelay) / 60, 1) + " min";
                lbl_Left_Time.Text = "" +
                    Math.Round((double)((Convert.ToInt32(lbl_NeededPosts2.Text) -
                    (CurrentPost-1)) * PostDelay) / 60, 1) + " min";
            }

            intPoster = false;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
