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
    public class NilaiRepository
    {
        private readonly SiakadDbContext _context;

        public NilaiRepository(SiakadDbContext context)
        {
            _context = context;
        }

        //public void HitungIPKdanJumlahSKS(string nim)
        //{
            //try
            //{
                //List<Nilai> nilaiList = GetNilaiByNIM(nim);

                //int jumlahSKS = 0;
                //int totalNilai = 0;

                //foreach (var nilai in nilaiList)
                //{
                    //int nilaiNumerik = KonversiNilaiHuruf(nilai.NilaiHuruf);
                    //int nilaiPerMataKuliah = nilaiNumerik * nilai.MataKuliah.SKS;
                    //totalNilai += nilaiPerMataKuliah;
                    //jumlahSKS += nilai.MataKuliah.SKS;
                //}

                //double ipk = (double)totalNilai / jumlahSKS;

                //UpdateJumlahSKSdanIPK(nim, jumlahSKS, ipk);
            //}
            //catch (Exception ex)
            //{
                //Console.WriteLine($"Error in HitungIPKdanJumlahSKS: {ex.Message}");
                // Handle the exception as needed.
            //}
        //}

        //public void UpdateJumlahSKSdanIPK(string nim, int jumlahSKS, double ipk)
        //{
            //try
            //{
                //string updateQuery = "UPDATE Mahasiswa SET Jumlah_SKS = @Jumlah_SKS, IPK = @IPK WHERE NIM = @NIM";

                //using (SQLiteCommand command = new SQLiteCommand(updateQuery, _context.Conn))
                //{
                    //command.Parameters.AddWithValue("@Jumlah_SKS", jumlahSKS);
                    //command.Parameters.AddWithValue("@IPK", ipk);
                    //command.Parameters.AddWithValue("@NIM", nim);

                    //command.ExecuteNonQuery();
                //}
            //}
            //catch (Exception ex)
            //{
                //Console.WriteLine($"Error in UpdateJumlahSKSdanIPK: {ex.Message}");
                // Handle the exception as needed.
            //}
        //}

        //public int KonversiNilaiHuruf(string nilaiHuruf)
        //{
            //switch (nilaiHuruf.ToUpper())
            //{
                //case "A":
                    //return 4;
                //case "B":
                    //return 3;
                //case "C":
                    //return 2;
                //case "D":
                    //return 1;
                //case "E":
                    //return 0;
                //default:
                    //return 0;
            //}
        //}

        public string GenerateUniqueId()
        {
            // Mendapatkan timestamp saat ini sebagai bagian dari ID
            string timestampPart = DateTime.Now.ToString("yyyyMMddHHmmss");

            // Membuat bagian acak dari ID dengan panjang tertentu
            string randomPart = GenerateRandomString(3); // Sesuaikan panjang ID yang diinginkan

            // Menggabungkan kedua bagian untuk membentuk ID_Nilai
            string idNilai = timestampPart + randomPart;

            return idNilai;
        }

        private string GenerateRandomString(int length)
        {
            // Membuat karakter acak untuk digunakan dalam ID
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();

            // Memilih karakter acak sebanyak length
            string randomString = new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());

            return randomString;
        }

        public int AddNilai(Nilai nilai)
        {
            int result = 0;

            // Generate new Id_Nilai using custom method
            nilai.Id_Nilai = GenerateUniqueId();

            string insertQuery = "INSERT INTO Nilai (ID_Nilai, NIM, Kode_MK, nilai, NilaiHuruf) " +
                                "VALUES (@Id_Nilai, @NIM, @Kode_MK, @nilai, @NilaiHuruf)";

            using (SQLiteCommand command = new SQLiteCommand(insertQuery, _context.Conn))
            {
                command.Parameters.AddWithValue("@Id_Nilai", nilai.Id_Nilai);
                command.Parameters.AddWithValue("@NIM", nilai.NIM);
                command.Parameters.AddWithValue("@Kode_MK", nilai.Kode_MK);
                command.Parameters.AddWithValue("@nilai", nilai.nilai);
                command.Parameters.AddWithValue("@NilaiHuruf", nilai.NilaiHuruf);

                result = command.ExecuteNonQuery();
            }

            return result;
        }

        public int UpdateNilai(Nilai nilai)
        {
            int result = 0;

            string updateQuery = "UPDATE Nilai SET NIM = @NIM, Kode_MK = @Kode_MK, " +
                                 "nilai = @nilai, NilaiHuruf = @NilaiHuruf " +
                                 "WHERE Id_Nilai = @Id_Nilai";

            using (SQLiteCommand command = new SQLiteCommand(updateQuery, _context.Conn))
            {
                command.Parameters.AddWithValue("@Id_Nilai", nilai.Id_Nilai);
                command.Parameters.AddWithValue("@NIM", nilai.NIM);
                command.Parameters.AddWithValue("@Kode_MK", nilai.Kode_MK);
                command.Parameters.AddWithValue("@nilai", nilai.nilai);
                command.Parameters.AddWithValue("@NilaiHuruf", nilai.NilaiHuruf);

                result = command.ExecuteNonQuery();
            }

            return result;
        }

        public int DeleteNilai(string idNilai)
        {
            int result = 0;

            string deleteQuery = "DELETE FROM Nilai WHERE Id_Nilai = @Id_Nilai";

            using (SQLiteCommand command = new SQLiteCommand(deleteQuery, _context.Conn))
            {
                command.Parameters.AddWithValue("@Id_Nilai", idNilai);

                result = command.ExecuteNonQuery();
            }

            return result;
        }

        public List<Nilai> GetNilaiByNIM(string nim)
        {
            List<Nilai> nilaiList = new List<Nilai>();

            string selectQuery = "SELECT * FROM Nilai WHERE NIM = @NIM";
            using (SQLiteCommand command = new SQLiteCommand(selectQuery, _context.Conn))
            {
                command.Parameters.AddWithValue("@NIM", nim);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Nilai nilai = new Nilai
                        {
                            Id_Nilai = reader["Id_Nilai"].ToString(),
                            NIM = reader["NIM"].ToString(),
                            Kode_MK = reader["Kode_MK"].ToString(),
                            nilai = Convert.ToDouble(reader["nilai"]),
                            NilaiHuruf = reader["NilaiHuruf"].ToString()
                        };

                        nilaiList.Add(nilai);
                    }
                }
            }

            return nilaiList;
        }

        public List<Nilai> GetAllNilai()
        {
            List<Nilai> nilaiList = new List<Nilai>();

            string selectQuery = "SELECT * FROM Nilai";
            using (SQLiteCommand command = new SQLiteCommand(selectQuery, _context.Conn))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Nilai nilai = new Nilai
                        {
                            Id_Nilai = reader["Id_Nilai"].ToString(),
                            NIM = reader["NIM"].ToString(),
                            Kode_MK = reader["Kode_MK"].ToString(),
                            nilai = Convert.ToDouble(reader["nilai"]),
                            NilaiHuruf = reader["NilaiHuruf"].ToString()
                        };

                        nilaiList.Add(nilai);
                    }
                }
            }

            return nilaiList;
        }
    }
}
