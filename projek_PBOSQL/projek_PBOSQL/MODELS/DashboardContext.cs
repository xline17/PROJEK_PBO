using Npgsql;
using projek_PBOSQL.HELPERS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Npgsql;
using projek_PBOSQL.HELPERS;

namespace projek_PBOSQL.MODELS
{
    internal class DashboardContext
    {
        public DataTable GetTransaksi()
        {
            var dt = new DataTable();

            string query = "SELECT * FROM v_historyTansaksi";

            try
            {
                using (var conn = ConnectDB.GetConn())
                using (var cmd = new NpgsqlCommand(query, conn))
                using (var adapter = new NpgsqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal mengambil aktivitas terbaru: " + ex.Message);
            }
            return dt;
        }
    }
}
