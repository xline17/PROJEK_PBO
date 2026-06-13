using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using projek_PBOSQL.CONTROLLERS;
using projek_PBOSQL.MODELS;

namespace projek_PBOSQL.VIEWS
{
    public partial class FormTransaksi : Form
    {
        private readonly c_Transaksi _transactionController = new c_Transaksi();
        private readonly StockContext _stockContext = new StockContext();

        // Memori Penyimpanan Keranjang Belanja menggunakan Objek List terstruktur
        private List<DetailTransaksi> _keranjangBelanja = new List<DetailTransaksi>();

        // Dictionary pembantu untuk menyimpan relasi ID Pupuk dan Nama Pupuk untuk visualisasi DataGridView
        private Dictionary<int, string> _namaPupukDict = new Dictionary<int, string>();

        private int _idAkunAktif = 1;
        public FormTransaksi()
        {
            InitializeComponent();
            LoadKatalogDanToko();
        }

        public FormTransaksi(List<DetailTransaksi> rekomendasiAnalisis)
        {
            InitializeComponent();
            LoadKatalogDanToko();

            // Ambil data rekomendasi dari memori RAM analisis, masukkan langsung ke keranjang belanja
            _keranjangBelanja = rekomendasiAnalisis;
            RefreshDataGridViewKeranjang();
        }

        private void LoadKatalogDanToko()
        {
            LoadKatalogProdukUC();
            LoadDataTokoComboBox();
        }

        // Fungsi memuat kotak-kotak User Control ke dalam FlowLayoutPanel
        private void LoadKatalogProdukUC()
        {
            flpKatalog.Controls.Clear();
            _namaPupukDict.Clear();

            // Mengambil seluruh data pupuk yang ada di database menggunakan fungsi lama kita
            List<Pupuk> daftarPupuk = _stockContext.GetAllStock();

            foreach (var pupuk in daftarPupuk)
            {
                // Iseng simpan nama ke dictionary agar DataGridView nanti bisa mendeteksi nama lewat ID Pupuk
                // *Catatan: Sesuaikan properti id_pupuk jika namanya berbeda di kelas Pupuk kamu
                // Jika di kelas Pupuk belum ada ID, ambil dari database view atau tambahkan properti IdPupuk di kelasnya
                int idPupuk = pupuk.id_pupuk; // Contoh mapping ID (Ganti dengan properti ID aslimu dari class Pupuk!)

                if (!_namaPupukDict.ContainsKey(idPupuk))
                    _namaPupukDict.Add(idPupuk, pupuk.nama_pupuk);

                // Instansiasi cetakan objek User Control
                UC_ItemPupuk cardProduk = new UC_ItemPupuk();
                cardProduk.SetDataProduk(idPupuk, pupuk.nama_pupuk, pupuk.HargaKg, pupuk.Stock);

                // 🔥 KUNCI UTAMA: Menangkap sinyal ketika tombol di dalam Card diklik
                cardProduk.OnTambahKlik = (id, nama, harga, qty) =>
                {
                    TambahKeKeranjangMemori(id, harga, qty);
                };

                // Masukkan card visual ke wadah pintar panel
                flpKatalog.Controls.Add(cardProduk);
            }
        }

        private void TambahKeKeranjangMemori(int idPupuk, double hargaKg, int qty)
        {
            MessageBox.Show($"Sinyal Masuk! ID: {idPupuk}, Qty: {qty}");
            // Cek apakah produk tersebut sudah pernah dimasukkan ke keranjang sebelumnya
            var itemAda = _keranjangBelanja.FirstOrDefault(x => x.id_pupuk == idPupuk);

            if (itemAda != null)
            {
                // Jika sudah ada, cukup tambahkan kuantitasnya saja
                itemAda.quantity += qty;
                itemAda.totalHarga = itemAda.quantity * hargaKg;
            }
            else
            {
                // Jika belum ada, buat baris objek DetailTransaksi baru
                DetailTransaksi detailBaru = new DetailTransaksi
                {
                    id_pupuk = idPupuk,
                    quantity = qty,
                    totalHarga = qty * hargaKg
                };
                _keranjangBelanja.Add(detailBaru);
            }

            RefreshDataGridViewKeranjang();
        }

        private void RefreshDataGridViewKeranjang()
        {
            // Proyeksi LINQ untuk menampilkan nama teks pupuk di gridview berdasarkan IdPupuk-nya
            dgvKeranjang.DataSource = null;
            dgvKeranjang.DataSource = _keranjangBelanja.Select(x => new
            {
                NamaProduk = _namaPupukDict.ContainsKey(x.id_pupuk) ? _namaPupukDict[x.id_pupuk] : "Pupuk Terpilih",
                JumlahKg = x.quantity,
                Subtotal = x.totalHarga
            }).ToList();

            HitungTotalAkhir();
        }

        private void HitungTotalAkhir()
        {
            double total = _keranjangBelanja.Sum(x => x.totalHarga);
            lblTotalHarga.Text = "Total: Rp " + total.ToString("N0");
        }

        private void LoadDataTokoComboBox()
        {
            // Tulis kode pengisian ComboBox Toko dari DB kamu di sini (id_toko dan nama_toko)
            // Contoh isi data statis sementara:
            Dictionary<int, string> comboSource = new Dictionary<int, string>
            {
                { 1, "KancaTani Cabang Pusat" },
            };
            cmbToko.DataSource = new BindingSource(comboSource, null);
            cmbToko.DisplayMember = "Value";
            cmbToko.ValueMember = "Key";
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            try
            {
                int idTokoTerpilih = Convert.ToInt32(cmbToko.SelectedValue);

                // Kirim List data objek murni ke Controller untuk dieksekusi oleh Stored Procedure & SQL Transaction
                bool sukses = _transactionController.ValidasiDanSimpan(_idAkunAktif, idTokoTerpilih, _keranjangBelanja);

                if (sukses)
                {
                    MessageBox.Show("Transaksi Berhasil diproses! \nKombinasi Stored Procedure + SQL Transaction sukses mengunci data, dan SQL Trigger berhasil memotong stok pupuk di PostgreSQL.",
                                    "Sistem Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reset ulang form setelah belanja selesai
                    _keranjangBelanja.Clear();
                    RefreshDataGridViewKeranjang();
                    LoadKatalogProdukUC(); // Memuat ulang katalog untuk memperbarui angka sisa stok di label card
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Transaksi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
