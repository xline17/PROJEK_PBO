using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projek_PBOSQL.VIEWS
{
    public partial class EditAkun : Form
    {
        public int IdAkunTerpilih;
        public EditAkun()
        {
            InitializeComponent();
        }

        private void btnSimpanEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEditUsername.Text) || string.IsNullOrWhiteSpace(txtEditNotelp.Text))
            {
                MessageBox.Show("Username dan Nomor Telepon tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                CONTROLLERS.c_KelolaUser controllerUser = new CONTROLLERS.c_KelolaUser();

                bool isEditBerhasil = controllerUser.EditUser(IdAkunTerpilih, txtEditUsername.Text.Trim(), txtEditNotelp.Text.Trim(), txtEditPass.Text.Trim());

                if (isEditBerhasil)
                {
                    MessageBox.Show("Data akun berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK; // Memberitahu form utama kalau edit berhasil
                    this.Close(); // Tutup pop-up
                }
                else
                {
                    MessageBox.Show("Gagal memperbarui data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSimpanEdit_Click_1(object sender, EventArgs e)
        {
            
        
            // 1. VALIDASI INPUT (Username dan No Telp tidak boleh kosong)
            if (string.IsNullOrWhiteSpace(txtEditUsername.Text) || string.IsNullOrWhiteSpace(txtEditNotelp.Text))
            {
                MessageBox.Show("Username dan Nomor Telepon tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ambil data yang diketik user di form pop-up
            string usernameBaru = txtEditUsername.Text.Trim();
            string noTelpBaru = txtEditNotelp.Text.Trim();
            string passwordBaru = txtEditPass.Text.Trim(); // Bisa kosong kalau user tidak mau ganti password

            try
            {
                // 2. INISIALISASI CONTROLLER
                CONTROLLERS.c_KelolaUser controllerUser = new CONTROLLERS.c_KelolaUser();

                // 3. PANGGIL FUNGSI EDIT DARI CONTROLLER
                // Kita kirimkan IdAkunTerpilih (variabel tanpa {get;set;} yang barusan diperbaiki) beserta data barunya
                bool isEditBerhasil = controllerUser.EditUser(IdAkunTerpilih, usernameBaru, noTelpBaru, passwordBaru);

                // 4. CEK HASIL EKSEKUSI DATABASE
                if (isEditBerhasil)
                {
                    MessageBox.Show($"Data akun '{usernameBaru}' berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Set DialogResult menjadi OK agar Form Utama (KelolaUser) tahu kalau data sukses diubah
                    this.DialogResult = DialogResult.OK;

                    // Tutup form pop-up secara otomatis
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Gagal memperbarui data akun. Pastikan data sesuai.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan sistem saat menyimpan: " + ex.Message, "Error Aplikasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
    

