using fp_new.Model.Entity;
using fp_new.Model.Context;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fp_new.Model.Repository
{
    public class MataKuliahRepository
    {
        private readonly SiakadDbContext _context;

        public MataKuliahRepository(SiakadDbContext context)
        {
            _context = context;
        }

        public int AddMataKuliah(MataKuliah mataKuliah)
        {
            int result = 0;

            string insertQuery = "INSERT INTO MataKuliah (Kode_MK, Nama_MK, SKS) " +
                                "VALUES (@Kode_MK, @Nama_MK, @SKS)";

            using (SQLiteCommand command = new SQLiteCommand(insertQuery, _context.Conn))
            {
                command.Parameters.AddWithValue("@Kode_MK", mataKuliah.Kode_MK);
                command.Parameters.AddWithValue("@Nama_MK", mataKuliah.Nama_MK);
                command.Parameters.AddWithValue("@SKS", mataKuliah.SKS);

                result = command.ExecuteNonQuery();
            }

            return result;
        }

        public int UpdateMataKuliah(MataKuliah mataKuliah)
        {
            int result = 0;

            string updateQuery = "UPDATE MataKuliah SET Nama_MK = @Nama_MK, SKS = @SKS " +
                                 "WHERE Kode_MK = @Kode_MK";

            using (SQLiteCommand command = new SQLiteCommand(updateQuery, _context.Conn))
            {
                command.Parameters.AddWithValue("@Kode_MK", mataKuliah.Kode_MK);
                command.Parameters.AddWithValue("@Nama_MK", mataKuliah.Nama_MK);
                command.Parameters.AddWithValue("@SKS", mataKuliah.SKS);

                result = command.ExecuteNonQuery();
            }

            return result;
        }

        public int DeleteMataKuliah(string kodeMK)
        {
            int result = 0;

            string deleteQuery = "DELETE FROM MataKuliah WHERE Kode_MK = @Kode_MK";

            using (SQLiteCommand command = new SQLiteCommand(deleteQuery, _context.Conn))
            {
                command.Parameters.AddWithValue("@Kode_MK", kodeMK);

                result = command.ExecuteNonQuery();
            }

            return result;
        }

        public List<MataKuliah> GetMataKuliahByNama(string namaMK)
        {
            List<MataKuliah> mataKuliahList = new List<MataKuliah>();

            string selectQuery = "SELECT * FROM MataKuliah WHERE Nama_MK LIKE @Nama_MK";
            using (SQLiteCommand command = new SQLiteCommand(selectQuery, _context.Conn))
            {
                command.Parameters.AddWithValue("@Nama_MK", "%" + namaMK + "%");

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        MataKuliah mataKuliah = new MataKuliah
                        {
                            Kode_MK = reader["Kode_MK"].ToString(),
                            Nama_MK = reader["Nama_MK"].ToString(),
                            SKS = Convert.ToInt32(reader["SKS"])
                        };

                        mataKuliahList.Add(mataKuliah);
                    }
                }
            }

            return mataKuliahList;
        }

        public List<MataKuliah> GetAllMataKuliah()
        {
            List<MataKuliah> mataKuliahList = new List<MataKuliah>();

            string selectQuery = "SELECT * FROM MataKuliah";
            using (SQLiteCommand command = new SQLiteCommand(selectQuery, _context.Conn))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        MataKuliah mataKuliah = new MataKuliah
                        {
                            Kode_MK = reader["Kode_MK"].ToString(),
                            Nama_MK = reader["Nama_MK"].ToString(),
                            SKS = Convert.ToInt32(reader["SKS"])
                        };

                        mataKuliahList.Add(mataKuliah);
                    }
                }
            }

            return mataKuliahList;
        }
    }
}
