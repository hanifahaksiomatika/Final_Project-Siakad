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
    public class MahasiswaRepository
    {
        private readonly SiakadDbContext _context;

        public MahasiswaRepository(SiakadDbContext context)
        {
            _context = context;
        }

        public int AddMahasiswa(Mahasiswa mahasiswa)
        {
            int result = 0;

            string insertQuery = "INSERT INTO Mahasiswa (NIM, Nama, Tgl_Lahir, Jenis_Kelamin, No_HP, Alamat, IPK, Jumlah_SKS) " +
                                "VALUES (@NIM, @Nama, @Tgl_Lahir, @Jenis_Kelamin, @No_HP, @Alamat, @IPK, @Jumlah_SKS)";

            using (SQLiteCommand command = new SQLiteCommand(insertQuery, _context.Conn))
            {
                command.Parameters.AddWithValue("@NIM", mahasiswa.NIM);
                command.Parameters.AddWithValue("@Nama", mahasiswa.Nama);
                command.Parameters.AddWithValue("@Tgl_Lahir", mahasiswa.Tgl_Lahir);
                command.Parameters.AddWithValue("@Jenis_Kelamin", mahasiswa.Jenis_Kelamin);
                command.Parameters.AddWithValue("@No_HP", mahasiswa.No_HP);
                command.Parameters.AddWithValue("@Alamat", mahasiswa.Alamat);
                command.Parameters.AddWithValue("@IPK", mahasiswa.IPK);
                command.Parameters.AddWithValue("@Jumlah_SKS", mahasiswa.Jumlah_SKS);

                result = command.ExecuteNonQuery();
            }

            return result;
        }

        public int UpdateMahasiswa(Mahasiswa mahasiswa)
        {
            int result = 0;

            string updateQuery = "UPDATE Mahasiswa SET Nama = @Nama, Tgl_Lahir = @Tgl_Lahir, " +
                                 "Jenis_Kelamin = @Jenis_Kelamin, No_HP = @No_HP, " +
                                 "Alamat = @Alamat, IPK = @IPK, Jumlah_SKS = @Jumlah_SKS " +
                                 "WHERE NIM = @NIM";

            using (SQLiteCommand command = new SQLiteCommand(updateQuery, _context.Conn))
            {
                command.Parameters.AddWithValue("@NIM", mahasiswa.NIM);
                command.Parameters.AddWithValue("@Nama", mahasiswa.Nama);
                command.Parameters.AddWithValue("@Tgl_Lahir", mahasiswa.Tgl_Lahir);
                command.Parameters.AddWithValue("@Jenis_Kelamin", mahasiswa.Jenis_Kelamin);
                command.Parameters.AddWithValue("@No_HP", mahasiswa.No_HP);
                command.Parameters.AddWithValue("@Alamat", mahasiswa.Alamat);
                command.Parameters.AddWithValue("@IPK", mahasiswa.IPK);
                command.Parameters.AddWithValue("@Jumlah_SKS", mahasiswa.Jumlah_SKS);

                result = command.ExecuteNonQuery();
            }

            return result;
        }

        public int DeleteMahasiswa(string nim)
        {
            int result = 0;

            string deleteQuery = "DELETE FROM Mahasiswa WHERE NIM = @NIM";

            using (SQLiteCommand command = new SQLiteCommand(deleteQuery, _context.Conn))
            {
                command.Parameters.AddWithValue("@NIM", nim);

                result = command.ExecuteNonQuery();
            }

            return result;
        }

        public List<Mahasiswa> GetMahasiswaByNama(string nama)
        {
            List<Mahasiswa> mahasiswaList = new List<Mahasiswa>();

            string selectQuery = "SELECT * FROM Mahasiswa WHERE Nama LIKE @Nama";
            using (SQLiteCommand command = new SQLiteCommand(selectQuery, _context.Conn))
            {
                command.Parameters.AddWithValue("@Nama", "%" + nama + "%");

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Mahasiswa mahasiswa = new Mahasiswa
                        {
                            NIM = reader["NIM"].ToString(),
                            Nama = reader["Nama"].ToString(),
                            Tgl_Lahir = Convert.ToDateTime(reader["Tgl_Lahir"]),
                            Jenis_Kelamin = reader["Jenis_Kelamin"].ToString(),
                            No_HP = reader["No_HP"].ToString(),
                            Alamat = reader["Alamat"].ToString(),
                            IPK = Convert.ToDouble(reader["IPK"]),
                            Jumlah_SKS = Convert.ToInt32(reader["Jumlah_SKS"])
                        };

                        mahasiswaList.Add(mahasiswa);
                    }
                }
            }

            return mahasiswaList;
        }

        public List<Mahasiswa> GetAllMahasiswa()
        {
            List<Mahasiswa> mahasiswaList = new List<Mahasiswa>();

            string selectQuery = "SELECT * FROM Mahasiswa";
            using (SQLiteCommand command = new SQLiteCommand(selectQuery, _context.Conn))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Mahasiswa mahasiswa = new Mahasiswa
                        {
                            NIM = reader["NIM"].ToString(),
                            Nama = reader["Nama"].ToString(),
                            Tgl_Lahir = Convert.ToDateTime(reader["Tgl_Lahir"]),
                            Jenis_Kelamin = reader["Jenis_Kelamin"].ToString(),
                            No_HP = reader["No_HP"].ToString(),
                            Alamat = reader["Alamat"].ToString(),
                            IPK = Convert.ToDouble(reader["IPK"]),
                            Jumlah_SKS = Convert.ToInt32(reader["Jumlah_SKS"])
                        };

                        mahasiswaList.Add(mahasiswa);
                    }
                }
            }

            return mahasiswaList;
        }
    }
}
