using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RazienDB
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }

        public static string FileRead(string FName)
        {
            try
            {
                System.IO.TextReader tr = new System.IO.StreamReader(FName);
                string ret = tr.ReadToEnd(); tr.Close(); tr.Dispose();
                return ret;
            }
            catch
            {
                MessageBox.Show("Error opening file:\r\n\r\n" + FName);
                return "";
            }
        }

        public static void FileWrite(string FName, string val)
        {
            System.IO.TextWriter tw = new System.IO.StreamWriter(FName);
            tw.Write(val); tw.Flush(); tw.Close(); tw.Dispose();
        }

        public static double Str2Dbl(string val)
        {
            try
            {
                return Convert.ToDouble(val.Replace(".", ","));
            }
            catch
            {
                return 0;
            }
        }
    }
}
