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
        public KelolaUser()
        {
            InitializeComponent();
        }

        private void btnDashboardAdmin_Click(object sender, EventArgs e)
        {

        }

        private void DGV_kelUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

    }
}
