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
    public partial class frmEntryMatkul : Form
    {
        public delegate void CreateUpdateEventHandler(MataKuliah matkul);
        public event CreateUpdateEventHandler OnCreate;
        public event CreateUpdateEventHandler OnUpdate;
        private MataKuliahController _matkulC;
        private bool isNewData = true;
        private MataKuliah matkul;

        public frmEntryMatkul()
        {
            InitializeComponent();
        }

        public frmEntryMatkul(string title, MataKuliahController _matkulC)
            : this()
        {
            this.Text = title;
            this._matkulC = _matkulC;
        }

        public frmEntryMatkul(string title, MataKuliah obj, MataKuliahController matkulController)
            : this()
        {
            this.Text = title;
            this._matkulC = matkulController;
            isNewData = false;
            matkul = obj;

            txtKodeMK.Text = matkul.Kode_MK;
            txtNamaMK.Text = matkul.Nama_MK;
            txtSKS.Text = matkul.SKS.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isNewData) matkul = new MataKuliah();

            matkul.Kode_MK = txtKodeMK.Text;
            matkul.Nama_MK = txtNamaMK.Text;

            if (int.TryParse(txtSKS.Text, out int sks))
            {
                matkul.SKS = sks;

                int result = 0;

                if (isNewData)
                {
                    result = _matkulC.TambahMataKuliah(matkul);

                    if (result > 0)
                    {
                        OnCreate(matkul);
                        ClearForm();
                    }
                }
                else
                {
                    result = _matkulC.UpdateMataKuliah(matkul);

                    if (result > 0)
                    {
                        OnUpdate(matkul);
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("SKS harus berupa angka.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearForm()
        {
            txtKodeMK.Clear();
            txtNamaMK.Clear();
            txtSKS.Clear();
            txtKodeMK.Focus();
        }
    }
}
