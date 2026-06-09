using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;

namespace projek_PBOSQL.VIEWS
{
    public partial class ADMIN : Form
    {
        public ADMIN()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDashboardAdmin_Click(object sender, EventArgs e)
        {

        }

        private void ADMIN_Load(object sender, EventArgs e)
        {
            UpdateTotalTransaksi();
            UpdateTotalStockPupuk();
            UpdateTotalJenisPupuk();
        }

        private void UpdateTotalTransaksi()
        {
            try
            {
                CONTROLLERS.c_Dashboard totalTransaksi = new CONTROLLERS.c_Dashboard();
                long jumlah = totalTransaksi.ttltransaksi();
                lblTotalTransaksi.Text = jumlah.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat total transaksi: " + ex.Message);
            }
        }

        private void UpdateTotalStockPupuk()
        {
            try
            {
                CONTROLLERS.c_Dashboard totalStockPupuk = new CONTROLLERS.c_Dashboard();
                long jumlah = totalStockPupuk.ttlStokPupuk(); // Garis merah akan hilang
                lblTotalStokPupuk.Text = jumlah.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat total stok: " + ex.Message);
            }
        }

        private void UpdateTotalJenisPupuk()
        {
            try
            {
                CONTROLLERS.c_Dashboard totalJenisPupuk = new CONTROLLERS.c_Dashboard();
                long jumlah = totalJenisPupuk.ttlJenisPupuk(); // Garis merah akan hilang
                lblTotalJenisPupuk.Text = jumlah.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat total stok: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            projek_PBOSQL.VIEWS.KelolaUser kelolauserForm = new projek_PBOSQL.VIEWS.KelolaUser();
            kelolauserForm.Show();
            this.Hide();
        }

        private void btnkelolaPupuk_Click(object sender, EventArgs e)
        {
            projek_PBOSQL.VIEWS.KelolaPupuk kelolapupukForm = new projek_PBOSQL.VIEWS.KelolaPupuk();
            kelolapupukForm.Show();
            this.Hide();
        }

        private void btnkelolaTahapan_Click(object sender, EventArgs e)
        {
            projek_PBOSQL.VIEWS.KelolaTahapan kelolaTahapanForm = new projek_PBOSQL.VIEWS.KelolaTahapan();
            kelolaTahapanForm.Show();
            this.Hide();
        }

        private void btnhistoriTransaksi_Click(object sender, EventArgs e)
        {

        }

        private void panelSideBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnKelolaStock_Click(object sender, EventArgs e)
        {
            projek_PBOSQL.VIEWS.KelolaStock stock = new projek_PBOSQL.VIEWS.KelolaStock();
            stock.Show();
            this.Hide();
        }
    }
}
