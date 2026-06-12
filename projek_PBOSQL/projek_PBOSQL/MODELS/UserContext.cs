using Npgsql;
using projek_PBOSQL.HELPERS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace projek_PBOSQL.MODELS
{
    internal class UserContext
    {
        private string connstring = "Host=localhost;Username=postgres;Password=1111;Database=KancaTani";

        // Ambil semua akun → untuk isi grid
        public DataTable GetAllAkun()
        {
            string query = "SELECT id_akun, username, password, no_telp FROM Akun ORDER BY id_akun";

            using (NpgsqlConnection conn = new NpgsqlConnection(connstring))
            {
                conn.Open();
                using (var adapter = new NpgsqlDataAdapter(query, conn))
                {
                    var table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }

        public bool TambahUser(string username, string password, string noTelp, string idRoleString)
        {
            bool status = false;
            NpgsqlConnection conn = ConnectDB.GetConn();

            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = "INSERT INTO akun (username, password, no_telp, id_role) VALUES (@username, @password, @no_telp, @id_role)";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@no_telp", noTelp);

                int idRoleInteger = int.Parse(idRoleString);
                cmd.Parameters.AddWithValue("@id_role", idRoleInteger);

                int barisTersimpan = cmd.ExecuteNonQuery();
                if (barisTersimpan > 0)
                {
                    status = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return status;
        }

        public bool HapusUser(int idAkun)
        {
            bool status = false;
            NpgsqlConnection conn = ConnectDB.GetConn();
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "DELETE FROM akun WHERE id_akun = @id_akun";
                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_akun", idAkun);
                int barisTerhapus = cmd.ExecuteNonQuery();
                if (barisTerhapus > 0)
                {
                    status = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return status;
        }

        public bool EditUser(int idAkun, string username, string password, string noTelp)
        {
            bool status = false;
            string query = "SELECT sp_edit_akun(@id, @username, @password, @no_telp)";

            try
            {
                // 1. Ambil objek koneksi database kamu
                NpgsqlConnection conn = ConnectDB.GetConn();

                // 2. KODE PENYELAMAT: Cek status koneksi sebelum dibuka!
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open(); // Hanya dibuka jika posisinya sedang tertutup
                }
                else if (conn.State == System.Data.ConnectionState.Broken)
                {
                    conn.Close();
                    conn.Open(); // Reset jika koneksinya rusak di tengah jalan
                }

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idAkun);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@no_telp", noTelp);
                    cmd.Parameters.AddWithValue("@password", password);

                    // Ambil return BOOLEAN dari fungsi PostgreSQL
                    status = (bool)cmd.ExecuteScalar();
                }

                // 3. KODE WAJIB: Setelah selesai dipakai, tutup atau lepas koneksinya
                // Agar fungsi TampilkanDataUser() di form utama tidak bergantian error saat merefresh tabel
                conn.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error Database: " + ex.Message);
                status = false;
            }

            return status;
        }

        public int UserSummary()
        {
            int totalUser = 0;
            string Query = @"SELECT COUNT(*) FROM akun";

            try
            {
                using (var conn = ConnectDB.GetConn())
                {
                    using (var cmd = new NpgsqlCommand(Query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            totalUser = Convert.ToInt32(result);
                        }
                    }
                } // conn otomatis ditutup karena using
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal memuat ringkasan card user: " + ex.Message);
            }

            return totalUser;
        }



    }
}

    