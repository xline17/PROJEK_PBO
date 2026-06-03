using Npgsql;
using projek_PBOSQL.MODELS.Pengguna;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace projek_PBOSQL.CONTROLLERS
{
    internal class c_KelolaUser
    {
        private string connstring = "Host=localhost;Username=postgres;Password=Faris23;Database=KancaTani";

        // Ambil semua akun → untuk isi grid
        public DataTable GetAllAkun()
        {
            string query = "SELECT username, password, no_telp FROM \"Akun\" ORDER BY username";

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

        // Tambah akun baru
        public bool TambahUser(string username, string password, string noTelp, string role = "user")
        {
            // Asumsi: ada kolom 'role' di tabel "Akun" untuk membedakan Admin/User/Petani
            string query = "INSERT INTO \"Akun\" (username, password, no_telp, role) VALUES (@username, @password, @no_telp, @role)";

            using (NpgsqlConnection conn = new NpgsqlConnection(connstring))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@no_telp", noTelp);
                        cmd.Parameters.AddWithValue("@role", role); // Menyimpan role sebagai 'user'

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Gagal menambah user: " + ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    return false;
                }
            }
        }


    }
}
    

