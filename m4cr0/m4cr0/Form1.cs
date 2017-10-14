using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace m4cr0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, IntPtr dwExtraInfo);
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, IntPtr dwExtraInfo);
        public const uint MOUSEEVENTF_LEFTDOWN = 0x02;
        public const uint MOUSEEVENTF_LEFTUP = 0x04;
        public const uint MOUSEEVENTF_RIGHTDOWN = 0x08;
        public const uint MOUSEEVENTF_RIGHTUP = 0x10;
        public const uint KEYEVENTF_KEYDOWN = 0x00;
        public const uint KEYEVENTF_EXTENDEDKEY = 0x01;
        public const uint KEYEVENTF_KEYUP = 0x02;

        long RecStart; long tOfs; string TheScript = ""; Point LastPos; int LastBtn; bool[] Keystates = new bool[256];

        public long Tick()
        {
            return System.DateTime.Now.Ticks / 10000;
        }

        private void cRecord_Click(object sender, EventArgs e)
        {
            if (cRecord.Text == "Record")
            {
                cRecord.Text = "Stop";
                tOfs = -1; RecStart = Tick(); TheScript = ""; tScript.Text = "";
                tRecord.Start();
            }
            else
            {
                cRecord.Text = "Record";
                tRecord.Stop();
                TheScript = TheScript.Substring(0, TheScript.Length - 2);
                TheScript = TheScript.Substring(0, TheScript.LastIndexOf("\n"));
                tScript.Text = TheScript.Replace("\n", "\r\n");
            }
        }

        private void cPlay_Click(object sender, EventArgs e)
        {
            LastBtn = 0;
            string[] sScript = tScript.Text.Replace("\r", "").Split('\n');
            for (int a = 0; a < sScript.GetUpperBound(0); a++)
            {
                long SleepLen = 0; long tItrStart = Tick();
                if (sScript[a].StartsWith("M:"))
                {
                    sScript[a] = sScript[a].Substring(2);
                    string[] sCmd = sScript[a].Split(',');
                    int[] iCmd = new int[sCmd.GetUpperBound(0) + 1];
                    for (int b = 0; b <= iCmd.GetUpperBound(0); b++)
                        iCmd[b] = Convert.ToInt16(sCmd[b]);
                    Cursor.Position = new Point(iCmd[0], iCmd[1]);
                    if (LastBtn != iCmd[2])
                    {
                        switch (iCmd[2])
                        {
                            case 0:
                                switch (LastBtn)
                                {
                                    case 1:
                                        mouse_event(MOUSEEVENTF_LEFTUP, (uint)0, (uint)0, (uint)0, (IntPtr)0);
                                        break;
                                    case 2:
                                        mouse_event(MOUSEEVENTF_RIGHTUP, (uint)0, (uint)0, (uint)0, (IntPtr)0);
                                        break;
                                    case 3:
                                        mouse_event(MOUSEEVENTF_LEFTUP, (uint)0, (uint)0, (uint)0, (IntPtr)0);
                                        mouse_event(MOUSEEVENTF_RIGHTUP, (uint)0, (uint)0, (uint)0, (IntPtr)0);
                                        break;
                                }
                                break;
                            case 1:
                                mouse_event(MOUSEEVENTF_LEFTDOWN, (uint)0, (uint)0, (uint)0, (IntPtr)0);
                                break;
                            case 2:
                                mouse_event(MOUSEEVENTF_RIGHTDOWN, (uint)0, (uint)0, (uint)0, (IntPtr)0);
                                break;
                            case 3:
                                mouse_event(MOUSEEVENTF_LEFTDOWN, (uint)0, (uint)0, (uint)0, (IntPtr)0);
                                mouse_event(MOUSEEVENTF_RIGHTDOWN, (uint)0, (uint)0, (uint)0, (IntPtr)0);
                                break;
                        }
                        LastBtn = iCmd[2];
                    }
                    SleepLen = iCmd[3];
                }
                else if (sScript[a].StartsWith("K:"))
                {
                    sScript[a] = sScript[a].Substring(2);
                    string[] sCmd = sScript[a].Split(',');
                    int[] iCmd = new int[sCmd.GetUpperBound(0) + 1];
                    for (int b = 0; b <= iCmd.GetUpperBound(0); b++)
                        iCmd[b] = Convert.ToInt16(sCmd[b]);
                    if (iCmd[1] == 1)
                    {
                        keybd_event((byte)iCmd[0], 0x45, KEYEVENTF_KEYDOWN, (IntPtr)0);
                    }
                    else
                    {
                        keybd_event((byte)iCmd[0], 0x45, KEYEVENTF_KEYUP, (IntPtr)0);
                    }
                    SleepLen = iCmd[2];
                }
                Application.DoEvents();
                SleepLen -= Tick() - tItrStart; if (SleepLen <= 0) SleepLen = 1;
                System.Threading.Thread.Sleep((int)SleepLen);
            }
        }

        private void tRecord_Tick(object sender, EventArgs e)
        {
            if (tOfs == -1) tOfs = Tick();
            bool ResetOfs = false; bool LButton = false, RButton = false; int cBtn = 0;
            bool DummyRun = false; if (Tick() - RecStart <= 250) DummyRun = true;
            
            if (GetAsyncKeyState(1)!=0) LButton = true;
            //if (GetAsyncKeyState(Keys.MButton)!=0) MButton = true;
            if (GetAsyncKeyState(2)!=0) RButton = true;
            if (LButton) cBtn += 1; if (RButton) cBtn += 2;
            Point cPos = Cursor.Position;
            if (LastPos != cPos)
            {
                LastPos = cPos;
                if (!DummyRun) ResetOfs = true;
                if (!DummyRun) TheScript += "M: " + cPos.X + "," + cPos.Y + "," + cBtn + "," + (Tick() - tOfs) + "\n";
            }
            if (LastBtn != cBtn)
            {
                LastBtn = cBtn;
                if (!DummyRun) ResetOfs = true;
                if (!DummyRun) TheScript += "M: " + cPos.X + "," + cPos.Y + "," + cBtn + "," + (Tick() - tOfs) + "\n";
            }

            for (int a = 4; a <= 255; a++)
            {
                if (GetAsyncKeyState(a) == 0)
                {
                    if (Keystates[a])
                    {
                        Keystates[a] = false;
                        if (!DummyRun) ResetOfs = true;
                        if (!DummyRun) TheScript += "K:" + a + ",0," + (Tick() - tOfs) + "\n";
                    }
                }
                else
                {
                    if (!Keystates[a])
                    {
                        Keystates[a] = true;
                        if (!DummyRun) ResetOfs = true;
                        if (!DummyRun) TheScript += "K:" + a + ",1," + (Tick() - tOfs) + "\n";
                    }
                }
            }
            if (ResetOfs) tOfs = Tick();
            tScript.Text = TheScript.Replace("\n", "\r\n"); tScript.SelectionStart = tScript.Text.Length; tScript.ScrollToCaret();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("" + Tick());
        }
    }
}