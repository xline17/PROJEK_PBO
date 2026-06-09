using Npgsql;
using projek_PBOSQL.HELPERS;
using System;
using System.Collections.Generic;
using System.Text;

namespace projek_PBOSQL.MODELS
{
    internal class KelolaTahapanContext
    {
        public List<KelolaTahapan> GetAllTahapan()
        {
            List<KelolaTahapan> list = new List<KelolaTahapan>();

            string query = @"SELECT * FROM v_tahapan";
                     
            try
            {
                using (var conn = ConnectDB.GetConn())
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    //cmd.Parameters.AddWithValue("@includeAll", includeInactive);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // 2. Mapping data dengan cara GetOrdinal mirip gaya kating
                            KelolaTahapan kelolatahapan = new KelolaTahapan
                            {
                                id_fase = reader.GetInt32(reader.GetOrdinal("id_fase")),
                                nama_fase = reader.GetString(reader.GetOrdinal("nama_fase")),
                                umur_min_hst = reader.GetInt32(reader.GetOrdinal("umur_min_hst")),
                                umur_max_hst = reader.GetInt32(reader.GetOrdinal("umur_max_hst")),
                                id_tanaman = reader.GetInt32(reader.GetOrdinal("id_tanaman"))
                            };

                            // 3. Masukkan objek ke dalam list
                            list.Add(kelolatahapan);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal mengambil data pupuk: " + ex.Message);
            }
            return list;
        }
    }
}
