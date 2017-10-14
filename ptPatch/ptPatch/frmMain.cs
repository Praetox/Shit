using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ptPatch
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region [GUI] PatchFile
        private void PatchFile_Unpatched_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "All files (*.*)|*.*";
            fd.ShowDialog();
            if (fd.FileName != "")
            {
                PatchFile_Unpatched.Text = fd.FileName;
                PatchFile_Unpatched.SelectionLength = 0;
                PatchFile_Unpatched.SelectionStart = PatchFile_Unpatched.Text.Length;
                PatchFile_Unpatched.ScrollToCaret();

                string ptn0 = fd.FileName;
                string ptn1 = ptn0.Substring(0, ptn0.LastIndexOf("."));
                string ptn2 = ptn0.Substring(ptn0.LastIndexOf(".") + 1);
                PatchFile_Patched.Text = ptn1 + "_p." + ptn2;
                PatchFile_Patched.SelectionLength = 0;
                PatchFile_Patched.SelectionStart = PatchFile_Patched.Text.Length;
                PatchFile_Patched.ScrollToCaret();

                string ptn = fd.FileName;
                ptn = ptn.Substring(0, ptn.LastIndexOf("."));
                PatchFile_Patch.Text = ptn + ".ptp";
                PatchFile_Patch.SelectionLength = 0;
                PatchFile_Patch.SelectionStart = PatchFile_Patch.Text.Length;
                PatchFile_Patch.ScrollToCaret();
            }
        }
        private void PatchFile_Patch_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Patch (*.ptp)|*.ptp";
            fd.ShowDialog();
            if (fd.FileName != "")
            {
                PatchFile_Patch.Text = fd.FileName;
                PatchFile_Patch.SelectionLength = 0;
                PatchFile_Patch.SelectionStart = PatchFile_Patch.Text.Length;
                PatchFile_Patch.ScrollToCaret();
            }
        }
        private void PatchFile_Patched_Browse_Click(object sender, EventArgs e)
        {
            string srctyp = PatchFile_Unpatched.Text;
            srctyp = srctyp.Substring(srctyp.LastIndexOf(".") + 1);
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter =
                "All files (*.*)|*.*|" +
                srctyp + "-file (*." + srctyp + ")|*." + srctyp;
            fd.FilterIndex = 2;
            fd.ShowDialog();
            if (fd.FileName != "")
            {
                PatchFile_Patched.Text = fd.FileName;
                PatchFile_Patched.SelectionLength = 0;
                PatchFile_Patched.SelectionStart = PatchFile_Patched.Text.Length;
                PatchFile_Patched.ScrollToCaret();
            }
        }
        #endregion
        #region [GUI] CreatePatch
        private void CreatePatch_Unpatched_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "All files (*.*)|*.*";
            fd.ShowDialog();
            if (fd.FileName != "")
            {
                CreatePatch_Unpatched.Text = fd.FileName;
                CreatePatch_Unpatched.SelectionLength = 0;
                CreatePatch_Unpatched.SelectionStart = CreatePatch_Unpatched.Text.Length;
                CreatePatch_Unpatched.ScrollToCaret();

                string ptn = fd.FileName;
                ptn = ptn.Substring(0, ptn.LastIndexOf("."));
                CreatePatch_Patch.Text = ptn + ".ptp";
                CreatePatch_Patch.SelectionLength = 0;
                CreatePatch_Patch.SelectionStart = CreatePatch_Patch.Text.Length;
                CreatePatch_Patch.ScrollToCaret();
            }
        }
        private void CreatePatch_Patched_Browse_Click(object sender, EventArgs e)
        {
            string srctyp = CreatePatch_Unpatched.Text;
            srctyp = srctyp.Substring(srctyp.LastIndexOf(".") + 1);
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter =
                "All files (*.*)|*.*|" +
                srctyp + "-file (*." + srctyp + ")|*." + srctyp;
            fd.FilterIndex = 2;
            fd.ShowDialog();
            if (fd.FileName != "")
            {
                CreatePatch_Patched.Text = fd.FileName;
                CreatePatch_Patched.SelectionLength = 0;
                CreatePatch_Patched.SelectionStart = CreatePatch_Patched.Text.Length;
                CreatePatch_Patched.ScrollToCaret();
            }
        }
        private void CreatePatch_Patch_Browse_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "Patch (*.ptp)|*.ptp";
            fd.ShowDialog();
            if (fd.FileName != "")
            {
                CreatePatch_Patch.Text = fd.FileName;
                CreatePatch_Patch.SelectionLength = 0;
                CreatePatch_Patch.SelectionStart = CreatePatch_Patch.Text.Length;
                CreatePatch_Patch.ScrollToCaret();
            }
        }
        #endregion

        private byte[] StrToByt(string vl)
        {
            byte[] ret = new byte[vl.Length];
            for (int a = 0; a < ret.Length; a++)
            {
                ret[a] = (byte)vl[a];
            }
            return ret;
        }
        private static long Tick()
        {
            return System.DateTime.Now.Ticks / 10000;
        }
        private void lg(string vl)
        {
            this.Text = "ptPatch | " + vl; Application.DoEvents();
        }

        private void CreatePatch_Execute_Click(object sender, EventArgs e)
        {
            long Tick1 = Tick(); lg("Creating patch...");
            CreatePatch_Execute.Enabled = false; Application.DoEvents();
            FileStream fs1 = new FileStream(CreatePatch_Unpatched.Text, FileMode.Open);
            FileStream fs2 = new FileStream(CreatePatch_Patched.Text, FileMode.Open);
            if (fs1.Length != fs2.Length)
            {
                MessageBox.Show(
                    "The files are of different lengths!" + "\r\n" +
                    "File 1: " + fs1.Length + " bytes" + "\r\n" +
                    "File 2: " + fs2.Length + " bytes" + "\r\n" +
                    "\r\n" +
                    "Patching operations cannot continue.");
                fs1.Close(); fs1.Dispose(); fs2.Close(); fs2.Dispose();
                CreatePatch_Execute.Enabled = true; return;
            }
            FileStream fs3 = new FileStream(CreatePatch_Patch.Text, FileMode.Create);
            BinaryReader bs1 = new BinaryReader(fs1);
            BinaryReader bs2 = new BinaryReader(fs2);
            BinaryWriter bs3 = new BinaryWriter(fs3);

            int chunklim = 0; int lastgui = 0;
            for (UInt64 a = 0; a < (UInt64)fs1.Length; a++)
            {
                lastgui++; if (lastgui >= 100000)
                {
                    lastgui = 0;
                    lg("Creating patch | %" + Math.Round(100 / (double)fs1.Length * (double)a, 1));
                }

                byte bf1 = bs1.ReadByte();
                byte bf2 = bs2.ReadByte();
                if (bf1 != bf2)
                {
                    chunklim = 0;
                    bs3.Write(StrToByt((a + 1).ToString("X") + " "));
                    while (true)
                    {
                        string sbvl = bf2.ToString("X");
                        while (sbvl.Length < 2) sbvl = "0" + sbvl;
                        bs3.Write(StrToByt(sbvl));
                        chunklim++; if (chunklim > 256) break;
                        if (a < (UInt64)fs1.Length-1)
                        {
                            a++; lastgui++;
                            bf1 = bs1.ReadByte();
                            bf2 = bs2.ReadByte();
                            if (bf1 == bf2)
                            {
                                a--; lastgui--;
                                fs1.Seek(-1, SeekOrigin.Current);
                                fs2.Seek(-1, SeekOrigin.Current);
                                break;
                            }
                        }
                        else { break; }
                    }
                    bs3.Write(StrToByt("\n"));
                }
            }
            fs1.Close(); fs1.Dispose();
            fs2.Close(); fs2.Dispose();
            bs3.Flush(); fs3.Close(); fs3.Dispose();
            CreatePatch_Execute.Enabled = true;
            lg("Completed in " + (Tick() - Tick1) + "ms");
        }

        private void PatchFile_Execute_Click(object sender, EventArgs e)
        {
            long Tick1 = Tick(); lg("Patching file...");
            PatchFile_Execute.Enabled = false; Application.DoEvents();
            if (File.Exists(PatchFile_Patched.Text)) File.Delete(PatchFile_Patched.Text);
            File.Copy(PatchFile_Unpatched.Text, PatchFile_Patched.Text);
            FileStream fs1 = new FileStream(PatchFile_Patched.Text, FileMode.Open);
            FileStream fs2 = new FileStream(PatchFile_Patch.Text, FileMode.Open);
            BinaryWriter bs1 = new BinaryWriter(fs1);
            TextReader bs2 = new StreamReader(fs2);

            int lastgui = 0;
            string[] chunks = bs2.ReadToEnd().Split('\n');
            for (int a = 0; a < chunks.Length - 1; a++)
            {
                lastgui++; if (lastgui >= 100000)
                {
                    lastgui = 0;
                    lg("Patching file | %" + Math.Round(100 / (double)fs1.Length * (double)fs1.Position, 1));
                }

                string sBytes = chunks[a].Split(' ')[1];
                bs1.Seek(Convert.ToInt32(chunks[a].Split(' ')[0], 16) - 1, SeekOrigin.Begin);
                while (sBytes != "")
                {
                    lastgui++;
                    bs1.Write(Convert.ToByte(sBytes.Substring(0, 2), 16));
                    if (sBytes.Length > 2)
                    {
                        sBytes = sBytes.Substring(2);
                    }
                    else
                    {
                        sBytes = "";
                    }
                }
            }
            bs1.Flush(); fs1.Close(); fs1.Dispose();
            fs2.Close(); fs2.Dispose();
            PatchFile_Execute.Enabled = true; Application.DoEvents();
            lg("Completed in " + (Tick() - Tick1) + "ms");
        }
    }
}
