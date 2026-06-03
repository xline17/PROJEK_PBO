using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projek_PBOSQL.VIEWS
{
    public partial class TambahUser : Form
    {
        public TambahUser()
        {
            InitializeComponent();
        }

        private void Simpan_Click(object sender, EventArgs e)
        {
            // 1. Ambil data dari TextBox yang ADA DI FORM POP-UP INI
            string usernameInput = txtUsername.Text.Trim();
            string passwordInput = txtPassword.Text.Trim();
            string noTelpInput = txtNoTelp.Text.Trim();

            if (string.IsNullOrEmpty(usernameInput) || string.IsNullOrEmpty(passwordInput))
            {
                MessageBox.Show("Username dan Password wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Panggil Controller
            CONTROLLERS.c_KelolaUser controllerUser = new CONTROLLERS.c_KelolaUser();
            bool isBerhasil = controllerUser.TambahUser(usernameInput, passwordInput, noTelpInput, "user");

            if (isBerhasil)
            {
                MessageBox.Show("User berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 3. Set DialogResult menjadi OK agar Form Utama tahu kalau proses simpan sukses
                this.DialogResult = DialogResult.OK;
                this.Close(); // Tutup pop-up otomatis
            }
        }

        private void TambahUser_Load(object sender, EventArgs e)
        {

        }
    }
}
