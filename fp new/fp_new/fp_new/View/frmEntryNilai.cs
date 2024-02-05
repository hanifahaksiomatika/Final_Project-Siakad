using fp_new.Controller;
using fp_new.Model.Context;
using fp_new.Model.Entity;
using fp_new.Model.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fp_new.View
{
    public partial class frmEntryNilai : Form
    {
        public delegate void CreateUpdateEventHandlerNilai(Nilai nilai);
        public event CreateUpdateEventHandlerNilai OnCreate;
        public event CreateUpdateEventHandlerNilai OnUpdate;
        private NilaiController _nilaiC;
        private MataKuliahController _matkulC;
        private List<MataKuliah> daftarMataKuliah;
        private bool isNewDataNilai = true;
        private Nilai nilai;

        public frmEntryNilai()
        {
            InitializeComponent();
            using (var context = new SiakadDbContext())
            {
                _nilaiC = new NilaiController(new NilaiRepository(context));
                _matkulC = new MataKuliahController(new MataKuliahRepository(context));
            }
            daftarMataKuliah = _matkulC.TampilkanSemuaMataKuliah();
            LoadMataKuliahComboBox();
        }

        private void LoadMataKuliahComboBox()
        {
            cboxMK.DataSource = daftarMataKuliah;
            cboxMK.DisplayMember = "Nama_MK";
            cboxMK.ValueMember = "Kode_MK";
            cboxMK.SelectedIndex = -1;
        }

        public frmEntryNilai(string title, NilaiController nilaiController)
            : this()
        {
            this.Text = title;
            this._nilaiC = nilaiController;
        }

        public frmEntryNilai(string title, Nilai obj, NilaiController nilaiController)
            : this(title, nilaiController)
        {
            this.Text = title;
            this._nilaiC = nilaiController;
            isNewDataNilai = false;
            nilai = obj;

            txtNIM.Text = nilai.NIM;
            cboxMK.SelectedValue = nilai.Kode_MK;
            txtNilai.Text = nilai.nilai.ToString();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (isNewDataNilai)
            {
                nilai = new Nilai();
            }

            // Menggunakan ID_Nilai dari TextBox jika tidak kosong, jika kosong, biarkan NilaiController menangani ID_Nilai.
            //if (!string.IsNullOrEmpty(txtID.Text))
            //{
            //nilai.Id_Nilai = txtID.Text;
            //}

            nilai.NIM = txtNIM.Text;
            nilai.Kode_MK = cboxMK.SelectedValue?.ToString();
            nilai.nilai = Convert.ToInt32(txtNilai.Text);

            // Menambahkan logika untuk menentukan nilai huruf
            string nilaiHuruf = HitungNilaiHuruf(Convert.ToInt32(nilai.nilai));
            nilai.NilaiHuruf = nilaiHuruf;

            int result = 0;
            if (isNewDataNilai)
            {
                result = _nilaiC.InputNilai(nilai);
                if (result > 0)
                {
                    OnCreate?.Invoke(nilai);
                    MessageBox.Show("Data nilai berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetForm();
                }
                else
                {
                    MessageBox.Show("Data nilai gagal disimpan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                result = _nilaiC.UpdateNilai(nilai);
                if (result > 0)
                {
                    OnUpdate?.Invoke(nilai);
                    MessageBox.Show("Data nilai berhasil diupdate!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Data nilai gagal diupdate!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private string HitungNilaiHuruf(int nilaiNumerik)
        {
            if (nilaiNumerik >= 0 && nilaiNumerik <= 20)
            {
                return "E";
            }
            else if (nilaiNumerik >= 21 && nilaiNumerik <= 40)
            {
                return "D";
            }
            else if (nilaiNumerik >= 41 && nilaiNumerik <= 60)
            {
                return "C";
            }
            else if (nilaiNumerik >= 61 && nilaiNumerik <= 80)
            {
                return "B";
            }
            else if (nilaiNumerik >= 81 && nilaiNumerik <= 100)
            {
                return "A";
            }
            else
            {
                return ""; // Nilai di luar rentang yang ditentukan
            }
        }

        private void ResetForm()
        {
            txtNIM.Clear();
            cboxMK.SelectedIndex = -1;
            txtNilai.Clear();
            txtNIM.Focus();
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
