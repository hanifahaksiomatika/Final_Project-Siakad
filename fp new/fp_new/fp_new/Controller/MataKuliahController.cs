using fp_new.Model.Entity;
using fp_new.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fp_new.Controller
{
    public class MataKuliahController
    {
        private readonly MataKuliahRepository _repository;

        public MataKuliahController(MataKuliahRepository repository)
        {
            _repository = repository;
        }

        public int TambahMataKuliah(MataKuliah mataKuliah)
        {
            int result = 0;
            try
            {
                result = _repository.AddMataKuliah(mataKuliah);
                if (result > 0)
                {
                    MessageBox.Show("Data mata kuliah berhasil disimpan !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data mata kuliah gagal disimpan !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        public int UpdateMataKuliah(MataKuliah mataKuliah)
        {
            int result = 0;
            try
            {
                result = _repository.UpdateMataKuliah(mataKuliah);
                if (result > 0)
                {
                    MessageBox.Show("Data mata kuliah berhasil diupdate !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data mata kuliah gagal diupdate !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        public int HapusMataKuliah(string kodeMK)
        {
            int result = 0;
            try
            {
                result = _repository.DeleteMataKuliah(kodeMK);
                if (result > 0)
                {
                    MessageBox.Show("Data mata kuliah berhasil dihapus !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data mata kuliah gagal dihapus !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        public List<MataKuliah> CariMataKuliahByNama(string namaMK)
        {
            List<MataKuliah> mataKuliahList = new List<MataKuliah>();
            try
            {
                mataKuliahList = _repository.GetMataKuliahByNama(namaMK);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return mataKuliahList;
        }

        public List<MataKuliah> TampilkanSemuaMataKuliah()
        {
            List<MataKuliah> mataKuliahList = new List<MataKuliah>();
            try
            {
                mataKuliahList = _repository.GetAllMataKuliah();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return mataKuliahList;
        }
    }
}
