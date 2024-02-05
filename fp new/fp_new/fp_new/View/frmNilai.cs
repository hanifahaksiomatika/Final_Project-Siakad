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
    public partial class frmNilai : Form
    {
        private List<Nilai> ListOfNilai = new List<Nilai>();
        private NilaiController _nilaiC;

        public frmNilai()
        {
            InitializeComponent();
            InisialisasiListView();
            using (var context = new SiakadDbContext())
            {
                _nilaiC = new NilaiController(new NilaiRepository(context));
            }
            LoadDataNilai();
        }

        private void InisialisasiListView()
        {
            // Sesuaikan dengan kolom yang ingin ditampilkan
            lvwNilai.View = System.Windows.Forms.View.Details;
            lvwNilai.FullRowSelect = true;
            lvwNilai.GridLines = true;
            lvwNilai.Columns.Add("No.", 35, HorizontalAlignment.Center);
            lvwNilai.Columns.Add("ID Nilai", 200, HorizontalAlignment.Center);
            lvwNilai.Columns.Add("NIM", 120, HorizontalAlignment.Center);
            lvwNilai.Columns.Add("Kode MK", 150, HorizontalAlignment.Center);
            lvwNilai.Columns.Add("Nilai", 50, HorizontalAlignment.Center);
            lvwNilai.Columns.Add("Nilai Huruf", 120, HorizontalAlignment.Center);
        }

        private void OnCreateEventHandler(Nilai nilai)
        {
            ListOfNilai.Add(nilai);
            int noUrut = lvwNilai.Items.Count + 1;
            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(nilai.Id_Nilai.ToString());
            item.SubItems.Add(nilai.NIM);
            item.SubItems.Add(nilai.Kode_MK);
            item.SubItems.Add(nilai.nilai.ToString());
            item.SubItems.Add(nilai.NilaiHuruf);
            lvwNilai.Items.Add(item);
        }

        private void OnUpdateEventHandler(Nilai nilai)
        {
            int index = lvwNilai.SelectedIndices[0];
            ListViewItem itemRow = lvwNilai.Items[index];
            itemRow.SubItems[1].Text = nilai.Id_Nilai.ToString();
            itemRow.SubItems[2].Text = nilai.NIM;
            itemRow.SubItems[3].Text = nilai.Kode_MK;
            itemRow.SubItems[4].Text = nilai.nilai.ToString();
            itemRow.SubItems[5].Text = nilai.NilaiHuruf;
        }

        private void LoadDataNilai()
        {
            try
            {
                lvwNilai.Items.Clear();
                ListOfNilai = _nilaiC.TampilkanSemuaNilai();

                foreach (var nilai in ListOfNilai)
                {
                    var noUrut = lvwNilai.Items.Count + 1;
                    var item = new ListViewItem(noUrut.ToString());
                    item.SubItems.Add(nilai.Id_Nilai.ToString());
                    item.SubItems.Add(nilai.NIM);
                    item.SubItems.Add(nilai.Kode_MK);
                    item.SubItems.Add(nilai.nilai.ToString());
                    item.SubItems.Add(nilai.NilaiHuruf);
                    lvwNilai.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in LoadDataNilai: {ex.Message}");
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            frmEntryNilai frmEN = new frmEntryNilai("Tambah Data Nilai", _nilaiC);
            frmEN.OnCreate += OnCreateEventHandler;
            frmEN.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lvwNilai.SelectedItems.Count > 0)
            {
                Nilai nilai = ListOfNilai[lvwNilai.SelectedIndices[0]];
                frmEntryNilai frmEN = new frmEntryNilai("Edit Data Nilai", nilai, _nilaiC);
                frmEN.OnUpdate += OnUpdateEventHandler;
                frmEN.ShowDialog();
            }
            else
            {
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (lvwNilai.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data nilai ingin dihapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (konfirmasi == DialogResult.Yes)
                {
                    Nilai nilai = ListOfNilai[lvwNilai.SelectedIndices[0]];
                    if (nilai != null)
                    {
                        var result = _nilaiC.HapusNilai(nilai.Id_Nilai);
                        if (result >= 0)
                        {
                            LoadDataNilai();
                        }
                        else
                        {
                            MessageBox.Show("Data nilai gagal dihapus !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Objek nilai bernilai null !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                MessageBox.Show("Data nilai belum dipilih !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMatkul_Click(object sender, EventArgs e)
        {
            frmMatkul frmMK = new frmMatkul();
            frmMK.ShowDialog();
            this.Close();
        }
    }
}
