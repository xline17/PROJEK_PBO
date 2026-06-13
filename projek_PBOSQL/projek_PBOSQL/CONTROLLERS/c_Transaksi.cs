using System;
using System.Collections.Generic;
using System.Text;
using projek_PBOSQL.MODELS;

namespace projek_PBOSQL.CONTROLLERS
{
    internal class c_Transaksi
    {
        private readonly TransaksiContext _transaksiContext = new TransaksiContext();
        public bool ValidasiDanSimpan(int id_akun, int id_toko, List<DetailTransaksi> daftarBelanja)
        {
            // Validasi Bisnis Aturan Aplikasi
            if (daftarBelanja == null || daftarBelanja.Count == 0)
            {
                throw new Exception("Gagal Checkout! Keranjang belanja kosong.");
            }

            if (id_toko <= 0)
            {
                throw new Exception("Silakan pilih cabang toko terlebih dahulu!");
            }

            // Jika validasi lolos, lemparkan ke lapisan model data
            return _transaksiContext.EksekusiTransaksiProsedur(id_akun, id_toko, daftarBelanja);
        }
    }
}
