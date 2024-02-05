using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fp_new.Model.Entity
{
    public class Mahasiswa
    {
        public string NIM { get; set; }
        public string Nama { get; set; }
        public DateTime Tgl_Lahir { get; set; }
        public string Jenis_Kelamin { get; set; }
        public string No_HP { get; set; }
        public string Alamat { get; set; }
        public double IPK { get; set; }
        public int Jumlah_SKS { get; set; }
        public double Jumlah_Nilai { get; set; }
    }

    public class MataKuliah
    {
        public string Kode_MK { get; set; }
        public string Nama_MK { get; set; }
        public int SKS { get; set; }
    }

    public class Nilai
    {
        public string Id_Nilai { get; set; }
        public string NIM { get; set; }
        public string Kode_MK { get; set; }
        public double nilai { get; set; }
        public string NilaiHuruf { get; set; }
        public double NilaiAngka { get; set; }
        public double NilaixSks { get; set; }
    }

    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
