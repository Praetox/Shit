using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SQLite
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        SQLiteConnection DB;
        Random rnd = new Random();
        public static string[] DBStruct = new string[] { "id", "hash", "tags" };

        private void fnRecreate()
        {
            if (DB != null) { DB.Close(); DB.Dispose(); }
            if (System.IO.File.Exists(tDB.Text + ".db"))
                System.IO.File.Delete(tDB.Text + ".db");
            SQLiteConnection.CreateFile(tDB.Text + ".db");
            SQLiteConnection.CompressFile(tDB.Text + ".db");
            DB = new SQLiteConnection("Data source=" + tDB.Text + ".db");
            DB.Open();

            using (SQLiteCommand DBc = DB.CreateCommand())
            {
                DBc.CommandText = "CREATE TABLE 'dickbutt' (" +
                    "'id' unsigned bigint(20), " +
                    "'hash' varchar(32), " +
                    "'tags' text)";
                DBc.ExecuteNonQuery();
            }
        }

        private void cOpenDB_Click(object sender, EventArgs e)
        {
            long ltStart = Tick();
            fnRecreate();

            long ltTable = Tick();
            using (SQLiteTransaction dbTrs = DB.BeginTransaction())
            {
                using (SQLiteCommand DBc = DB.CreateCommand())
                {
                    DBc.CommandText = "INSERT INTO 'dickbutt' (id, hash, tags) VALUES (?, ?, ?)";
                    SQLiteParameter dbParam1 = DBc.CreateParameter();
                    SQLiteParameter dbParam2 = DBc.CreateParameter();
                    SQLiteParameter dbParam3 = DBc.CreateParameter();
                    DBc.Parameters.Add(dbParam1);
                    DBc.Parameters.Add(dbParam2);
                    DBc.Parameters.Add(dbParam3);
                    for (int a = 1; a < 100000; a++)
                    {
                        dbParam1.Value = a;
                        dbParam2.Value = "HAHAHA";
                        dbParam3.Value = "DISREGARD THAT";
                        if (a == 683) dbParam2.Value = "watwat";
                        if (a == 1337) dbParam2.Value = "omglol";
                        DBc.ExecuteNonQuery();
                    }
                }
                dbTrs.Commit();
            }
            using (SQLiteCommand DBc = DB.CreateCommand())
            {
                DBc.CommandText = "DELETE FROM 'dickbutt' WHERE id = '3'";
                DBc.ExecuteNonQuery();
            }
            using (SQLiteCommand DBc = DB.CreateCommand())
            {
                DBc.CommandText = "INSERT INTO 'dickbutt' (hash, tags) VALUES ('wat', 'wut')";
                DBc.ExecuteNonQuery();
            }


            long ltInsert = Tick();
            /*using (SQLiteCommand DBr = DB.CreateCommand())
            {
                using (SQLiteTransaction dbTrs = DB.BeginTransaction())
                {
                    using (SQLiteCommand DBw = DB.CreateCommand())
                    {
                        DBr.CommandText = "SELECT * FROM 'dickbutt'";
                        DBw.CommandText = "UPDATE 'dickbutt' SET id = ? WHERE id = ?";
                        SQLiteParameter dbParam1 = DBw.CreateParameter();
                        SQLiteParameter dbParam2 = DBw.CreateParameter();
                        DBw.Parameters.Add(dbParam1);
                        DBw.Parameters.Add(dbParam2);
                        using (SQLiteDataReader rd = DBr.ExecuteReader())
                        {
                            int iCount = 0;
                            while (rd.Read())
                            {
                                iCount++;
                                dbParam1.Value = iCount;
                                dbParam2.Value = rd.GetValue(0).ToString();
                                DBw.ExecuteNonQuery();
                            }
                        }
                    }
                    dbTrs.Commit();
                }
            }*/
            
            // Correct cleanup code
            /*string sTempDB = Environment.ExpandEnvironmentVariables("%temp%\\tmp.db");
            System.IO.File.Copy(tDB.Text + ".db", sTempDB, true);
            SQLiteConnection DBt = new SQLiteConnection("Data source=" + sTempDB);
            DBt.Open();
            fnRecreate();
            using (SQLiteCommand DBtc = DBt.CreateCommand())
            {
                using (SQLiteTransaction dbTrs = DB.BeginTransaction())
                {
                    using (SQLiteCommand DBc = DB.CreateCommand())
                    {
                        DBtc.CommandText = "SELECT * FROM 'dickbutt'";
                        DBc.CommandText = "INSERT INTO 'dickbutt' (id, hash, tags) VALUES (?, ?, ?)";
                        SQLiteParameter dbParam1 = DBc.CreateParameter();
                        SQLiteParameter dbParam2 = DBc.CreateParameter();
                        SQLiteParameter dbParam3 = DBc.CreateParameter();
                        DBc.Parameters.Add(dbParam1);
                        DBc.Parameters.Add(dbParam2);
                        DBc.Parameters.Add(dbParam3);
                        using (SQLiteDataReader rd = DBtc.ExecuteReader())
                        {
                            int iCount = 0;
                            while (rd.Read())
                            {
                                iCount++;
                                dbParam1.Value = iCount;
                                dbParam2.Value = rd.GetValue(1).ToString();
                                dbParam3.Value = rd.GetValue(2).ToString();
                                DBc.ExecuteNonQuery();
                            }
                        }
                    }
                    dbTrs.Commit();
                }
            }
            DBt.Close(); System.IO.File.Delete(sTempDB);*/
            /*using (SQLiteCommand DBc = DB.CreateCommand())
            {
                DBc.CommandText = "ALTER TABLE 'dickbutt' " +
                    "RENAME TO 'dickbutt_old'";
                DBc.ExecuteNonQuery();
            }
            using (SQLiteCommand DBc = DB.CreateCommand())
            {
                DBc.CommandText = "CREATE TABLE 'dickbutt' (" + DBConstruct + ")";
                DBc.ExecuteNonQuery();
            }
            using (SQLiteCommand DBct = DB.CreateCommand())
            {
                using (SQLiteTransaction dbTrs = DB.BeginTransaction())
                {
                    using (SQLiteCommand DBc = DB.CreateCommand())
                    {
                        DBct.CommandText = "SELECT * FROM 'dickbutt_old'";
                        DBc.CommandText = "INSERT INTO 'dickbutt' ('hash', 'tags') VALUES (?, ?)";
                        SQLiteParameter dbParam1 = DBc.CreateParameter();
                        SQLiteParameter dbParam2 = DBc.CreateParameter();
                        DBc.Parameters.Add(dbParam1);
                        DBc.Parameters.Add(dbParam2);
                        using (SQLiteDataReader rd = DBct.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                dbParam1.Value = rd.GetValue(1).ToString();
                                dbParam2.Value = rd.GetValue(2).ToString();
                                DBc.ExecuteNonQuery();
                            }
                        }
                    }
                    dbTrs.Commit();
                }
            }
            using (SQLiteCommand DBc = DB.CreateCommand())
            {
                DBc.CommandText = "DROP TABLE 'dickbutt_old'";
                DBc.ExecuteNonQuery();
            }*/


            long ltCleanup = Tick();
            string wat = "";
            using (SQLiteCommand DBc = DB.CreateCommand())
            {
                DBc.CommandText = "SELECT * FROM 'dickbutt'";
                using (SQLiteDataReader rd = DBc.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        string wheee =
                            rd.GetValue(0).ToString() + " - " +
                            rd.GetValue(1).ToString() + " - " +
                            rd.GetValue(2).ToString() + "\r\n";
                        if (rd.GetValue(1).ToString().Contains("mglo"))
                            wat = "Identified omglol @ " + rd.GetValue(0).ToString() + "\n\n" + wat;
                        if (rd.GetValue(1).ToString().Contains("atwa"))
                            wat = "Identified watwat @ " + rd.GetValue(0).ToString() + "\n\n" + wat;
                        if (wat.Length < 1000) wat += wheee;
                    }
                }
            }
            /*string wat = "";
            using (SQLiteCommand DBc = DB.CreateCommand())
            {
                DBc.CommandText = "SELECT * FROM 'dickbutt' WHERE hash != 'HAHAHA'";
                using (SQLiteDataReader rd = DBc.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        string wheee =
                            rd.GetValue(0).ToString() + " - " +
                            rd.GetValue(1).ToString() + " - " +
                            rd.GetValue(2).ToString() + "\r\n";
                        if (rd.GetValue(1).ToString().Contains("mglo"))
                            wat = "Identified omglol @ " + rd.GetValue(0).ToString() + "\n\n" + wat;
                        if (rd.GetValue(1).ToString().Contains("atwa"))
                            wat = "Identified watwat @ " + rd.GetValue(0).ToString() + "\n\n" + wat;
                        if (wat.Length < 1000) wat += wheee;
                    }
                }
            }*/


            long ltSelect = Tick();
            MessageBox.Show(
                "Table: " + (ltTable - ltStart) + "\r\n" +
                "Insert: " + (ltInsert - ltTable) + "\r\n" +
                "Cleanup: " + (ltCleanup - ltInsert) + "\r\n" +
                "Select: " + (ltSelect - ltCleanup) + "\r\n" +
                "\r\n" +
                wat);
        }

        string rand(int cnt, bool hex)
        {
            string ret = "";
            int iMax = 26; if (hex) iMax = 15;
            for (int a = 0; a < cnt; a++)
            {
                int iRnd = rnd.Next(iMax);
                if (hex) ret += iRnd.ToString("X");
                if (!hex) ret += (char)(iRnd + 97);
            }
            return ret;
        }

        public static long Tick()
        {
            return System.DateTime.Now.Ticks / 10000;
        }
    }
}
