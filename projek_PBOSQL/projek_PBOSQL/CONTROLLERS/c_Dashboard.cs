using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

namespace projek_PBOSQL.CONTROLLERS
{
    internal class c_Dashboard
    {
        private string connstring = "Host=localhost;Username=postgres;Password=bombigaul123;Database=projek_pbo";

        public long ttltransaksi()
        {
            long total = 0;
            string query = "SELECT COUNT(*) FROM transaksi";

            using (NpgsqlConnection conn = new NpgsqlConnection(connstring))
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        // Menambahkan tanda tanya (?) setelah object agar mengizinkan nilai null (menghilangkan warning)
                        object? result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            total = Convert.ToInt64(result);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
            return total; // WAJIB ada return karena fungsinya menghasilkan data long
        }
        public long ttlStokPupuk()
        {
            long totalStok = 0; // Pastikan ini bertipe long
            string query = "SELECT COALESCE(SUM(stock), 0) FROM stock_pupuk";

            using (NpgsqlConnection conn = new NpgsqlConnection(connstring))
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        object? result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            // Gunakan ToInt64 agar sesuai dengan tipe kembalian fungsi (long)
                            totalStok = Convert.ToInt64(result);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error hitung stok: " + ex.Message);
                    }
                }
            }
            return totalStok;
        }

        public long ttlJenisPupuk()
        {
            long totalJenis = 0;
            string query = "SELECT COUNT(*) FROM pupuk WHERE status = 'active'";

            using (NpgsqlConnection conn = new NpgsqlConnection(connstring))
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        object? result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                           
                            totalJenis = Convert.ToInt64(result);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error hitung stok: " + ex.Message);
                    }
                }
            }
            return totalJenis;
        }
    }
}
