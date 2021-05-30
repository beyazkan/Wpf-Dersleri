using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.library
{
    public class DBConnection
    {
        public static string dbPath = @"Data Source=" + Environment.CurrentDirectory + "\\Database\\kitap.db;Version=3;New=False;Compress=True;Read Only=False;";

        public static string connectionState;

        public static void connectionTest()
        {
            using (SQLiteConnection conn = new SQLiteConnection(dbPath))
            {
                if(conn.State == ConnectionState.Closed)
                {
                    try
                    {
                        conn.Open();
                        connectionState = "Veritabanına Bağlandı.";
                    }
                    catch (Exception)
                    {
                        connectionState = "Veritabanı Bağlantı Hatası...";
                    }
                }
                else
                {
                    connectionState = "Veritabanına Bağlandı.";
                }
            } 
        }
    }
}
