using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using fp_new.Controller;
using fp_new.Model.Context;
using fp_new.Model.Entity;

namespace fp_new.View
{
    public partial class frmMhs : Form
    {
        private List<Mahasiswa> ListOfMhs = new List<Mahasiswa>();
        private MahasiswaController _mhsC;

        public frmMhs()
        {
            InitializeComponent();
            InisialisasiListView();
            using (var context = new SiakadDbContext())
            {
                _mhsC = new MahasiswaController(context);
            }
            LoadDataMahasiswa();
        }

        private void InisialisasiListView()
        {
            lvwMhs.View = System.Windows.Forms.View.Details;
            lvwMhs.FullRowSelect = true;
            lvwMhs.GridLines = true;
            lvwMhs.Columns.Add("No.", 35, HorizontalAlignment.Center);
            lvwMhs.Columns.Add("NIM", 91, HorizontalAlignment.Center);
            lvwMhs.Columns.Add("Nama", 288, HorizontalAlignment.Left);
            lvwMhs.Columns.Add("Jenis Kelamin", 118, HorizontalAlignment.Center);
            lvwMhs.Columns.Add("Jumlah SKS", 115, HorizontalAlignment.Center);
            lvwMhs.Columns.Add("IPK", 80, HorizontalAlignment.Center);
        }

        private void LoadDataMahasiswa()
        {
            try
            {
                // Kosongkan listview
                lvwMhs.Items.Clear();

                // Panggil method TampilkanSemuaMahasiswa dan tampung datanya ke dalam collection
                ListOfMhs = _mhsC.TampilkanSemuaMahasiswa();

                // Ekstrak objek mhs dari collection
                foreach (var mhs in ListOfMhs)
                {
                    var noUrut = lvwMhs.Items.Count + 1;
                    var item = new ListViewItem(noUrut.ToString());
                    item.SubItems.Add(mhs.NIM);
                    item.SubItems.Add(mhs.Nama);
                    item.SubItems.Add(mhs.Jenis_Kelamin);
                    item.SubItems.Add(mhs.Jumlah_SKS.ToString());
                    item.SubItems.Add(mhs.IPK.ToString());

                    // Tampilkan data mhs ke listview
                    lvwMhs.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in LoadDataMahasiswa: {ex.Message}");
                // Atau gunakan MessageBox untuk menampilkan pesan kesalahan
            }
        }

        private void OnCreateEventHandler(Mahasiswa mhs)
        {
            // tambahkan objek mhs yang baru ke dalam collection
            ListOfMhs.Add(mhs);
            int noUrut = lvwMhs.Items.Count + 1;
            // tampilkan data mhs yg baru ke list view
            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(mhs.NIM);
            item.SubItems.Add(mhs.Nama);
            item.SubItems.Add(mhs.Jenis_Kelamin);
            item.SubItems.Add(mhs.Jumlah_SKS.ToString());
            item.SubItems.Add(mhs.IPK.ToString());
            lvwMhs.Items.Add(item);
        }

        private void OnUpdateEventHandler(Mahasiswa mhs)
        {
            // ambil index data mhs yang edit
            int index = lvwMhs.SelectedIndices[0];
            // update informasi mhs di listview
            ListViewItem itemRow = lvwMhs.Items[index];
            itemRow.SubItems[1].Text = mhs.NIM;
            itemRow.SubItems[2].Text = mhs.Nama;
            itemRow.SubItems[3].Text = mhs.Jenis_Kelamin;
            itemRow.SubItems[4].Text = mhs.Jumlah_SKS.ToString();
            itemRow.SubItems[5].Text = mhs.IPK.ToString();
        }

        private void btnNilai_Click(object sender, EventArgs e)
        {
            frmNilai frmN = new frmNilai();
            frmN.ShowDialog();
        }

        private void frmMhs_Load(object sender, EventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            frmEntryMhs frmEM = new frmEntryMhs("Tambah Data Mahasiswa", _mhsC);
            frmEM.OnCreate += OnCreateEventHandler;
            frmEM.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lvwMhs.SelectedItems.Count > 0)
            {
                // ambil objek mhs yang mau diedit dari collection
                Mahasiswa mhs = ListOfMhs[lvwMhs.SelectedIndices[0]];
                // buat objek form entry data mahasiswa
                frmEntryMhs frmEM = new frmEntryMhs("Edit Data Mahasiswa", mhs, _mhsC);
                // mendaftarkan method event handler untuk merespon event OnUpdate
                frmEM.OnUpdate += OnUpdateEventHandler;
                // tampilkan form entry mahasiswa
                frmEM.ShowDialog();
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (lvwMhs.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data mahasiswa ingin dihapus ? ", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (konfirmasi == DialogResult.Yes)
                {
                    // Ambil objek mhs yang mau dihapus dari koleksi
                    Mahasiswa mhs = ListOfMhs[lvwMhs.SelectedIndices[0]];
                    // Panggil operasi CRUD
                    var result = _mhsC.HapusMahasiswa(mhs.NIM); // Anggap Npm sebagai identifikasi
                    if (result >= 0) // Periksa apakah operasi penghapusan berhasil
                    {
                        LoadDataMahasiswa();
                    }
                    else
                    {
                        MessageBox.Show("Data mahasiswa gagal dihapus !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else // Data belum dipilih
            {
                MessageBox.Show("Data mahasiswa belum dipilih !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnMatkul_Click(object sender, EventArgs e)
        {
            frmMatkul frmM = new frmMatkul();
            frmM.ShowDialog();
        }
    }
}
