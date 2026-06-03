using projek_PBOSQL.MODELS.Pengguna;
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

            // SESUAIKAN LOGIKA RADIO BUTTON DENGAN ISI ID_ROLE DATABASE
            string roleInput = "";
            if (RbAdmin.Checked)
            {
                roleInput = "1"; // 1 berarti Admin sesuai database Anda
            }
            else if (RbPetani.Checked)
            {
                roleInput = "2"; // 2 berarti Petani sesuai database Anda
            }
            else
            {
                MessageBox.Show("Silakan pilih Role terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(usernameInput) || string.IsNullOrEmpty(passwordInput))
            {
                MessageBox.Show("Username dan Password wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. Panggil Controller
                CONTROLLERS.c_KelolaUser controllerUser = new CONTROLLERS.c_KelolaUser();

                // Mengirimkan nilai roleInput ("1" atau "2") ke fungsi TambahUser Anda
                bool isBerhasil = controllerUser.TambahUser(usernameInput, passwordInput, noTelpInput, roleInput);

                if (isBerhasil)
                {
                    MessageBox.Show("User berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TambahUser_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
