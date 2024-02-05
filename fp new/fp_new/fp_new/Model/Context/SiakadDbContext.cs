using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.SQLite;
using System.IO;
using fp_new.Model.Entity;

namespace fp_new.Model.Context
{
    public class SiakadDbContext : IDisposable
    {
        private SQLiteConnection _conn;

        public SQLiteConnection Conn
        {
            get { return _conn ?? (_conn = GetOpenConnection()); }
        }


        private SQLiteConnection GetOpenConnection()
        {
            SQLiteConnection conn = null;

            try
            {
                //string dbName = Path.Combine(Directory.GetCurrentDirectory(), "Database", "siakad.db");

                string dbName = @"D:\Semester_3\Pemrograman Lanjut\__UAS\fp new\fp_new\fp_new\Database\siakad.db";

                string connectionString = $"Data Source={dbName}";

                conn = new SQLiteConnection(connectionString);
                conn.Open();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print($"Open Connection Error: {ex.Message}");
            }

            return conn;
        }

        public void Dispose()
        {
            if (_conn != null)
            {
                try
                {
                    if (_conn.State != ConnectionState.Closed) _conn.Close();
                }
                finally
                {
                    _conn.Dispose();
                }
            }

            GC.SuppressFinalize(this);
        }
    }
}
