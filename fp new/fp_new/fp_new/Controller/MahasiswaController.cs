using fp_new.Model.Context;
using fp_new.Model.Entity;
using fp_new.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fp_new.Controller
{
    public class MahasiswaController
    {
        private MahasiswaRepository _repository;

        public MahasiswaController(SiakadDbContext context)
        {
            _repository = new MahasiswaRepository(context);
        }

        public int TambahMahasiswa(Mahasiswa mahasiswa)
        {
            int result = 0;

            // Validasi input
            if (string.IsNullOrEmpty(mahasiswa.NIM))
            {
                MessageBox.Show("NIM harus diisi !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(mahasiswa.Nama))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            result = _repository.AddMahasiswa(mahasiswa);

            if (result > 0)
            {
                MessageBox.Show("Data mahasiswa berhasil disimpan !", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data mahasiswa gagal disimpan !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }

        public int UpdateMahasiswa(Mahasiswa mahasiswa)
        {
            int result = 0;

            if (string.IsNullOrEmpty(mahasiswa.NIM))
            {
                MessageBox.Show("NIM harus diisi !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            result = _repository.UpdateMahasiswa(mahasiswa);

            if (result > 0)
            {
                MessageBox.Show("Data mahasiswa berhasil diupdate !", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data mahasiswa gagal diupdate !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }

        public int HapusMahasiswa(string nim)
        {
            int result = 0;

            if (string.IsNullOrEmpty(nim))
            {
                MessageBox.Show("NIM harus diisi !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            result = _repository.DeleteMahasiswa(nim);

            if (result > 0)
            {
                MessageBox.Show("Data mahasiswa berhasil dihapus !", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data mahasiswa gagal dihapus !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }

        public List<Mahasiswa> CariMahasiswaByNama(string nama)
        {
            List<Mahasiswa> mahasiswaList = _repository.GetMahasiswaByNama(nama);
            return mahasiswaList;
        }

        public List<Mahasiswa> TampilkanSemuaMahasiswa()
        {
            List<Mahasiswa> mahasiswaList = _repository.GetAllMahasiswa();
            return mahasiswaList;
        }
    }
}
