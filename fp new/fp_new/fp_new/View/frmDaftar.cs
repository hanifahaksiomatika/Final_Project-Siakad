using fp_new.Controller;
using fp_new.Model.Context;
using fp_new.Model.Repository;
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
    public partial class frmDaftar : Form
    {
        private readonly UserController _userC;

        public frmDaftar()
        {
            InitializeComponent();
            _userC = new UserController(new UserRepository(new SiakadDbContext()));
        }

        private void btnDAFTAR_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string role = cbRole.SelectedItem.ToString();

            // Validasi input
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Username, password, dan role harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Cek apakah username sudah digunakan
            bool isUsernameExists = _userC.IsUsernameExists(username);

            if (isUsernameExists)
            {
                MessageBox.Show("Username sudah digunakan, pilih username lain!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Buat objek User
            User newUser = new User
            {
                Username = username,
                Password = password,
                Role = role
            };

            try
            {
                // Tambahkan user baru
                bool result = _userC.CreateUser(newUser);

                if (result = true)
                {
                    MessageBox.Show("Pendaftaran berhasil! Silakan login.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Pendaftaran gagal!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblMasuk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
