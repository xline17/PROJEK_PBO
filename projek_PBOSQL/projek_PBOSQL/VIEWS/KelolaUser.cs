using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projek_PBOSQL.VIEWS
{
    public partial class KelolaUser : Form
    {
        int idAkunTerpilih = 0;
        public KelolaUser()
        {
            InitializeComponent();
            TampilkanDataUser();

        }

        private void TampilkanDataUser()
        {
            try
            {
                CONTROLLERS.c_KelolaUser controllerUser = new CONTROLLERS.c_KelolaUser();
                DataTable dt = controllerUser.GetAllAkun();

                if (dt != null && dt.Rows.Count > 0)
                {
                    DGV_kelUser.DataSource = dt;
                    DGV_kelUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    DGV_kelUser.Columns["id_akun"].DisplayIndex = 0;
                    DGV_kelUser.Columns["username"].DisplayIndex = 1;
                    DGV_kelUser.Columns["password"].DisplayIndex = 2;
                    DGV_kelUser.Columns["no_telp"].DisplayIndex = 3;
                    DGV_kelUser.Columns["btnEditCol"].DisplayIndex = 4;
                    DGV_kelUser.Columns["btnHapusCol"].DisplayIndex = 5;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data user: " + ex.Message);
            }
        }


        private void btnDashboardAdmin_Click(object sender, EventArgs e)
        {

        }

        private void DGV_kelUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // 1. AMBIL ID DAN USERNAME DARI BARIS YANG DIKLIK
                // id_akun diambil sebagai int untuk dikirim ke controller, username diambil hanya untuk teks konfirmasi
                int idTerpilih = Convert.ToInt32(DGV_kelUser.Rows[e.RowIndex].Cells["id_akun"].Value);
                string usernameTerpilih = DGV_kelUser.Rows[e.RowIndex].Cells["username"].Value.ToString();

                string noTelpTerpilih = DGV_kelUser.Rows[e.RowIndex].Cells["no_telp"].Value.ToString();

                // 2. CEK APAKAH TOMBOL HAPUS DIKLIK
                if (DGV_kelUser.Columns[e.ColumnIndex].Name == "btnHapusCol" || DGV_kelUser.Columns[e.ColumnIndex].HeaderText == "Aksi2")
                {
                    // Konfirmasi tetap pakai nama username agar user tidak bingung melihat angka ID
                    DialogResult konfirmasi = MessageBox.Show($"Apakah Anda yakin ingin menghapus akun '{usernameTerpilih}' secara permanen?",
                        "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (konfirmasi == DialogResult.Yes)
                    {
                        try
                        {
                            CONTROLLERS.c_KelolaUser controllerUser = new CONTROLLERS.c_KelolaUser();

                            // SEKARANG KITA KIRIM idTerpilih (int) BUKAN STRING USERNAME LAGI
                            bool isHapusBerhasil = controllerUser.HapusUser(idTerpilih);

                            if (isHapusBerhasil)
                            {
                                MessageBox.Show($"Akun '{usernameTerpilih}' berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                TampilkanDataUser(); // Refresh tabel
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Terjadi kesalahan sistem: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (DGV_kelUser.Columns[e.ColumnIndex].Name == "btnEditCol" || DGV_kelUser.Columns[e.ColumnIndex].HeaderText == "Aksi")
                {
                    // Simpan ID yang dipilih ke variabel global agar bisa dipakai tombol Simpan nanti
                    idAkunTerpilih = idTerpilih;

                    // ===================================================================
                    // SAKLAR MANUAL: Munculkan gambar Figma & semua komponen inputan kamu
                    // ===================================================================
                    PbEdit.Visible = true;
                    txtEditUsername.Visible = true;
                    txtEditTelp.Visible = true;
                    txtEditPass.Visible = true;
                    btnSimpanEdit.Visible = true; // Ini tombol simpan yang ada di bawah desain Figma kamu
                                                  // ===================================================================

                    // Lempar datanya langsung "turun" ke TextBox edit buatanmu di bawah DGV
                    txtEditUsername.Text = usernameTerpilih;
                    txtEditTelp.Text = noTelpTerpilih;
                    txtEditPass.Text = ""; // Selalu kosongkan kolom password demi privasi

                    // Opsional: Beri fokus kursor langsung ke textbox username biar user bisa langsung ngetik
                    txtEditUsername.Focus();
                }
            }
        }





        private void btnTambahAkun_Click(object sender, EventArgs e)
        {
            VIEWS.TambahUser popUp = new VIEWS.TambahUser();

            // 2. Tampilkan sebagai Dialog Pop-up (Aplikasi di belakangnya tidak bisa diklik sebelum pop-up ditutup)
            if (popUp.ShowDialog() == DialogResult.OK)
            {
                // 3. Jika tombol simpan di pop-up berhasil diklik (menghasilkan DialogResult.OK)
                // Maka otomatis refresh DataGridView di Form Utama ini
                CONTROLLERS.c_KelolaUser controllerUser = new CONTROLLERS.c_KelolaUser();
                DGV_kelUser.DataSource = controllerUser.GetAllAkun();
            }

        }

        private void txtEditUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void PbEdit_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void PbEdit_Click_1(object sender, EventArgs e)
        {

        }

        private void txtEditUsername_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
