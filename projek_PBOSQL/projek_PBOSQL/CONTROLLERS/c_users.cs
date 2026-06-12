using Npgsql;
using projek_PBOSQL.MODELS;
using projek_PBOSQL.MODELS.Pengguna;
using System;
using System.Collections.Generic;
using System.Text;

namespace projek_PBOSQL.CONTROLLERS
{
    internal class c_users
    {
        private string connstring = "Host=localhost;Username=postgres;Password=1111;Database=KancaTani";

        public object validasi_login(string username, string password)
        {
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
                            int id_role = Convert.ToInt32(reader["id_role"]);
                            string uName = reader["username"]?.ToString() ?? "";
                            string pass = reader["password"]?.ToString() ?? "";

                            if (id_role == 1)
                            {
                                return new Admin(pass, uName, "admin");
                            }
                            else
                            {
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
