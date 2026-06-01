using Npgsql;
using projek_PBOSQL.MODELS.Pengguna;
using System;
using System.Collections.Generic;
using System.Text;

namespace projek_PBOSQL.CONTROLLERS
{
    internal class c_users
    {
        private string connstring = "Host=localhost;Username=postgres;Password=bombigaul123;Database=projek_pbo";
        public object validasi_login(string username, string password)
        {
            // PERBAIKAN 1: Pastikan di dalam query teksnya "id_role" (pakai underscore)
            string query = "SELECT username, password, id_role FROM akun WHERE username = @username AND password = @password";

            using (NpgsqlConnection conn = new NpgsqlConnection(connstring))
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    conn.Open();
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // PERBAIKAN 2: Di sini juga wajib "id_role"
                            int id_role = Convert.ToInt32(reader["id_role"]);
                            string uName = reader["username"]?.ToString() ?? "";
                            string pass = reader["password"]?.ToString() ?? "";

                            // JIKA ID_ROLE = 1 adalah ADMIN
                            if (id_role == 1)
                            {
                                // PERBAIKAN 3: Sesuaikan dengan constructor Admin(string pass, string username, string role) kamu
                                return new Admin(pass, uName, "admin");
                            }
                            // JIKA ID_ROLE = 2 adalah PETANI
                            else
                            {
                                // Sesuaikan dengan constructor Petani(string pass, string username, string role) kamu
                                return new Petani(pass, uName, "petani");
                            }
                        }
                    }
                }
            }
            return null; // Login gagal jika data tidak ditemukan
        }
    }
}
