using fp_new.Controller;
using fp_new.Model.Context;
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
    public partial class frmLogin : Form
    {
        private UserController _userC;


        public frmLogin()
        {
            InitializeComponent();
            _userC = new UserController(new UserRepository(new SiakadDbContext()));
        }

        private void btnMASUK_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // Validasi input
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan password harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Validasi user
            bool isValidUser = _userC.ValidateUser(username, password);

            if (isValidUser)
            {
                // Jika username dan password benar, lanjut ke frmMhs
                frmMhs frmMhs = new frmMhs();
                this.Hide();
                frmMhs.ShowDialog();
                this.Close();
            }
            else
            {
                // Jika username atau password salah, tampilkan notifikasi
                MessageBox.Show("Username atau password salah!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void lblDaftar_Click(object sender, EventArgs e)
        {
            frmDaftar frmD = new frmDaftar();
            frmD.ShowDialog();
        }
    }
}
