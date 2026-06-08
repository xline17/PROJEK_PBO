using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using projek_PBOSQL.CONTROLLERS;
using projek_PBOSQL.MODELS;
using projek_PBOSQL.Interface;


namespace projek_PBOSQL.VIEWS
{
    public partial class KelolaStock : Form
    {
        private readonly c_Stock _stockcontext = new c_Stock();
        public KelolaStock()
        {
            InitializeComponent();
            TampilkanDataPupuk();
            MuatRingkasanCard();
        }

        private void TampilkanDataPupuk()
        {
            try
            {
                var daftarPupuk = _stockcontext.GetAllStock();

                // KUNCI PERBAIKAN: Hapus semua kolom lama agar tidak menumpuk ke kanan
                dgvPupuk.DataSource = null;
                dgvPupuk.Columns.Clear();

                // Biarkan DataSource membuat kolom yang fresh dan bersih
                dgvPupuk.DataSource = daftarPupuk;

                // Baru setelah itu rapikan judul atasnya (Header)
                if (dgvPupuk.Columns.Count > 0)
                {
                    dgvPupuk.Columns["nama_pupuk"].HeaderText = "Nama Pupuk";
                    dgvPupuk.Columns["Stock"].HeaderText = "Stok (Kg)";
                    dgvPupuk.Columns["HargaKg"].HeaderText = "Harga Per Kg";

                    // Sembunyikan kolom ID atau status jika ikut terbawa dari database
                    if (dgvPupuk.Columns["id_pupuk"] != null) dgvPupuk.Columns["id_pupuk"].Visible = false;
                    if (dgvPupuk.Columns["status"] != null) dgvPupuk.Columns["status"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
        }

        private void MuatRingkasanCard()
        {
            try
            {
                var summary = _stockcontext.LabelRingkasan();
                lblTotalStock.Text = $"{summary.totalStok:N0} Kg";
                lblPeringatan.Text = $"{summary.stockRendah} Jenis";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat info ringkasan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnTambah_Click(object sender, EventArgs e)
        {
            TambahStock formPopUp = new TambahStock();

            // Jika user sukses klik simpan di dalam pop-up
            if (formPopUp.ShowDialog() == DialogResult.OK)
            {
                // Segarkan data DataGridView utama pengadaan stok kamu
                TampilkanDataPupuk();
            }
        }
        private void btnDetail_Click(object sender, EventArgs e)
        {
            DetailRestock restock = new DetailRestock();
            restock.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            projek_PBOSQL.VIEWS.ADMIN admin = new projek_PBOSQL.VIEWS.ADMIN();
            admin.Show();
            this.Hide();
        }

        private void btnKelolaUser_Click(object sender, EventArgs e)
        {
            projek_PBOSQL.VIEWS.KelolaUser user = new projek_PBOSQL.VIEWS.KelolaUser();
            user.Show();
            this.Hide();
        }

        private void btnKelPupuk_Click(object sender, EventArgs e)
        {
            projek_PBOSQL.VIEWS.KelolaPupuk pupuk = new projek_PBOSQL.VIEWS.KelolaPupuk();
            pupuk.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            projek_PBOSQL.VIEWS.ROLE role = new projek_PBOSQL.VIEWS.ROLE();
            role.Show();
            this.Hide();
        }
    }
}
