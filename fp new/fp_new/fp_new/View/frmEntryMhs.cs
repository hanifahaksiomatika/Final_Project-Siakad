using fp_new.Controller;
using fp_new.Model.Entity;
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
    public partial class frmEntryMhs : Form
    {
        public delegate void CreateUpdateEventHandler(Mahasiswa mhs);
        public event CreateUpdateEventHandler OnCreate;
        public event CreateUpdateEventHandler OnUpdate;
        private MahasiswaController _mhsC;
        private bool isNewData = true;
        private Mahasiswa mhs;

        public frmEntryMhs()
        {
            InitializeComponent();
        }

        public frmEntryMhs(string title, MahasiswaController _mhsC)
         : this()
        {
            // ganti text/judul form
            this.Text = title;
            this._mhsC = _mhsC;
        }

        public frmEntryMhs(string title, Mahasiswa obj, MahasiswaController _mhsC)
         : this()
        {
            // ganti text/judul form
            this.Text = title;
            this._mhsC = _mhsC;
            isNewData = false; // set status edit data
            mhs = obj; // set objek mhs yang akan diedit
                       // untuk edit data, tampilkan data lama
            txtNIM.Text = mhs.NIM;
            txtNama.Text = mhs.Nama;
            dateTglLahir.Text = mhs.Tgl_Lahir.ToString();
            cboxKelamin.Text = mhs.Jenis_Kelamin;
            txtNoHP.Text = mhs.No_HP;
            txtAlamat.Text = mhs.Alamat;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // jika data baru, inisialisasi objek mahasiswa
            if (isNewData) mhs = new Mahasiswa();
            // set nilai property objek mahasiswa yg diambil dari TextBox
            mhs.NIM = txtNIM.Text;
            mhs.Nama = txtNama.Text;
            mhs.Tgl_Lahir = dateTglLahir.Value;
            mhs.Jenis_Kelamin = cboxKelamin.SelectedItem?.ToString();
            mhs.No_HP = txtNoHP.Text;
            mhs.Alamat = txtAlamat.Text;

            int result = 0;
            if (isNewData) // tambah data baru, panggil method Create
            {
                // panggil operasi CRUD
                result = _mhsC.TambahMahasiswa(mhs);
                if (result > 0) // tambah data berhasil
                {
                    OnCreate(mhs); // panggil event OnCreate
                                   // reset form input, utk persiapan input data berikutnya
                    txtNIM.Clear();
                    txtNama.Clear();
                    dateTglLahir.Format = DateTimePickerFormat.Custom;
                    dateTglLahir.CustomFormat = " ";
                    cboxKelamin.SelectedIndex = -1;
                    txtNoHP.Clear();
                    txtAlamat.Clear();
                    txtNIM.Focus();
                }
            }
            else // edit data, panggil method Update
            {
                // panggil operasi CRUD
                result = _mhsC.UpdateMahasiswa(mhs);
                if (result > 0)
                {
                    OnUpdate(mhs); // panggil event OnUpdate
                    this.Close();
                }
            }
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
