using Npgsql;
using projek_PBOSQL.HELPERS;
using projek_PBOSQL.MODELS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace projek_PBOSQL.CONTROLLERS
{
    internal class c_Dashboard
    {
        private string connstring = "Host=localhost;Username=postgres;Password=1111;Database=KancaTani";
        private readonly DashboardContext _dash = new DashboardContext();
        public DataTable GetTransaksi()
        {
            return _dash.GetTransaksi();
        }
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
            return total; 
        }
        public long ttlStokPupuk()
        {
            long totalStok = 0; 
            string query = "SELECT SUM(stock) FROM stock_pupuk;";

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
            string query = "SELECT COUNT(*) FROM pupuk WHERE status = 'Aktif'";

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
