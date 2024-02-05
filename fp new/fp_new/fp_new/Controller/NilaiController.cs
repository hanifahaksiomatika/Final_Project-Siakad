using fp_new.Model.Entity;
using fp_new.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fp_new.Controller
{
    public class NilaiController
    {
        private readonly NilaiRepository _repository;

        public NilaiController(NilaiRepository repository)
        {
            _repository = repository;
        }

        public int InputNilai(Nilai nilai)
        {
            int result = 0;
            try
            {
                // Generate new Id_Nilai using custom method
                nilai.Id_Nilai = _repository.GenerateUniqueId();

                result = _repository.AddNilai(nilai);
                if (result > 0)
                {
                    MessageBox.Show("Data nilai berhasil disimpan !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data nilai gagal disimpan !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        public int UpdateNilai(Nilai nilai)
        {
            int result = 0;
            try
            {
                result = _repository.UpdateNilai(nilai);
                if (result > 0)
                {
                    MessageBox.Show("Data nilai berhasil diupdate !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data nilai gagal diupdate !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        public int HapusNilai(string idNilai)
        {
            int result = 0;
            try
            {
                result = _repository.DeleteNilai(idNilai);
                if (result > 0)
                {
                    MessageBox.Show("Data nilai berhasil dihapus !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data nilai gagal dihapus !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }


        public List<Nilai> TampilkanNilaiMahasiswa(string nim)
        {
            List<Nilai> nilaiList = new List<Nilai>();
            try
            {
                nilaiList = _repository.GetNilaiByNIM(nim);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
            return nilaiList;
        }

        public List<Nilai> TampilkanSemuaNilai()
        {
            List<Nilai> nilaiList = new List<Nilai>();
            try
            {
                nilaiList = _repository.GetAllNilai();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return nilaiList;
        }
    }
}
