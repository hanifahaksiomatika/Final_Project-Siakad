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
    public partial class frmMatkul : Form
    {
        private List<MataKuliah> ListOfMatkul = new List<MataKuliah>();
        private MataKuliahController _matkulC;

        public frmMatkul()
        {
            InitializeComponent();
            InisialisasiListView();
            using (var context = new SiakadDbContext())
            {
                _matkulC = new MataKuliahController(new MataKuliahRepository(context));
            }
            LoadDataMataKuliah();
        }

        private void InisialisasiListView()
        {
            // Sesuaikan dengan kolom yang ingin ditampilkan
            lvwMatkul.View = System.Windows.Forms.View.Details;
            lvwMatkul.FullRowSelect = true;
            lvwMatkul.GridLines = true;
            lvwMatkul.Columns.Add("No.", 35, HorizontalAlignment.Center);
            lvwMatkul.Columns.Add("Kode MK", 120, HorizontalAlignment.Center);
            lvwMatkul.Columns.Add("Nama MK", 200, HorizontalAlignment.Left);
            lvwMatkul.Columns.Add("SKS", 50, HorizontalAlignment.Center);
        }

        private void LoadDataMataKuliah()
        {
            try
            {
                lvwMatkul.Items.Clear();
                ListOfMatkul = _matkulC.TampilkanSemuaMataKuliah();

                foreach (var matkul in ListOfMatkul)
                {
                    var noUrut = lvwMatkul.Items.Count + 1;
                    var item = new ListViewItem(noUrut.ToString());
                    item.SubItems.Add(matkul.Kode_MK);
                    item.SubItems.Add(matkul.Nama_MK);
                    item.SubItems.Add(matkul.SKS.ToString());
                    lvwMatkul.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in LoadDataMataKuliah: {ex.Message}");
            }
        }

        private void OnCreateEventHandler(MataKuliah matkul)
        {
            ListOfMatkul.Add(matkul);
            int noUrut = lvwMatkul.Items.Count + 1;
            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(matkul.Kode_MK);
            item.SubItems.Add(matkul.Nama_MK);
            item.SubItems.Add(matkul.SKS.ToString());
            lvwMatkul.Items.Add(item);
        }

        private void OnUpdateEventHandler(MataKuliah matkul)
        {
            int index = lvwMatkul.SelectedIndices[0];
            ListViewItem itemRow = lvwMatkul.Items[index];
            itemRow.SubItems[1].Text = matkul.Kode_MK;
            itemRow.SubItems[2].Text = matkul.Nama_MK;
            itemRow.SubItems[3].Text = matkul.SKS.ToString();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            frmEntryMatkul frmEM = new frmEntryMatkul("Tambah Data Mata Kuliah", _matkulC);
            frmEM.OnCreate += OnCreateEventHandler;
            frmEM.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lvwMatkul.SelectedItems.Count > 0)
            {
                MataKuliah matkul = ListOfMatkul[lvwMatkul.SelectedIndices[0]];
                frmEntryMatkul frmEM = new frmEntryMatkul("Edit Data Mata Kuliah", matkul, _matkulC);
                frmEM.OnUpdate += OnUpdateEventHandler;
                frmEM.ShowDialog();
            }
            else
            {
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (lvwMatkul.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data mata kuliah ingin dihapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (konfirmasi == DialogResult.Yes)
                {
                    MataKuliah matkul = ListOfMatkul[lvwMatkul.SelectedIndices[0]];
                    var result = _matkulC.HapusMataKuliah(matkul.Kode_MK);
                    if (result >= 0)
                    {
                        LoadDataMataKuliah();
                    }
                    else
                    {
                        MessageBox.Show("Data mata kuliah gagal dihapus !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                MessageBox.Show("Data mata kuliah belum dipilih !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNilai_Click(object sender, EventArgs e)
        {
            frmNilai frmN = new frmNilai();
            frmN.ShowDialog();
            this.Close();
        }
    }
}
