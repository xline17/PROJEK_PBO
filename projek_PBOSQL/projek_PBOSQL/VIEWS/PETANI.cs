using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using projek_PBOSQL.CONTROLLERS;

namespace projek_PBOSQL.VIEWS
{
    public partial class PETANI : Form
    {
        private readonly c_Analisis _controller = new c_Analisis();
        public PETANI()
        {
            InitializeComponent();
            LoadDataTanamanToComboBox();
            cmbFase.SelectedIndex = 0;
        }

        private void LoadDataTanamanToComboBox()
        {
            try
            {
                var listTanaman = _controller.GetAllTanaman();

                cmbTanaman.DisplayMember = "nama_tanaman";
                cmbTanaman.ValueMember = "id_tanaman";
                cmbTanaman.DataSource = listTanaman;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat daftar tanaman: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void HitungTotalBiayaRekomendasi()
        {
            double totalBiaya = 0;

            foreach (DataGridViewRow row in dgvRekomendasi.Rows)
            {
                if (row.IsNewRow) continue;
                if (row.Cells[4].Value != null)
                {
                    string nilaiString = row.Cells[4].Value.ToString();

                    if (double.TryParse(nilaiString, out double hasilKonversi))
                    {
                        totalBiaya += hasilKonversi;
                    }
                }
            }
            lblTotalBiaya.Text = "Total Estimasi Biaya: Rp " + totalBiaya.ToString("N0");
        }
        private void btnTransaksi_Click(object sender, EventArgs e)
        {

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {

        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbTanaman.SelectedValue == null)
                {
                    MessageBox.Show("Silakan pilih komoditas tanaman terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idTanamanTerpilih = Convert.ToInt32(cmbTanaman.SelectedValue);
                string inputLuas = txtLuasLahan.Text.Trim(); 

                string faseTerpilih = cmbFase.SelectedItem != null ? cmbFase.SelectedItem.ToString().Trim() : "Semua Fase";

                DataTable tabelHasil = _controller.JalankanAnalisis(idTanamanTerpilih, inputLuas, faseTerpilih);

                if (tabelHasil != null && tabelHasil.Rows.Count > 0)
                {
                    // Pasang ke DataGridView
                    dgvRekomendasi.DataSource = tabelHasil;

                    // Panggilan fungsi hitung total setelah data sukses tampil
                    HitungTotalBiayaRekomendasi();
                }
                else
                {
                    MessageBox.Show("Data rekomendasi tidak ditemukan untuk parameter tersebut.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvRekomendasi.DataSource = null;
                    lblTotalBiaya.Text = "Total Estimasi Biaya: Rp 0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
