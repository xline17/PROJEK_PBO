using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projek_PBOSQL.VIEWS
{
    public partial class LOGINPETANI : Form
    {
        public LOGINPETANI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "Host=localhost;Port=5432;Username=postgres;Password=12345;Database=projek_pbo";

            string query = "SELECT username, password,id_role from akun WHERE username = @username AND password = @password OR  id_role = 2";

            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", textBox1.Text);
                    cmd.Parameters.AddWithValue("@password", textBox2.Text);
                    try
                    {
                        conn.Open();

                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader != null && reader.HasRows)
                            {
                                MessageBox.Show("Login Berhasil!");

                                projek_PBOSQL.VIEWS.PETANI petaniForm = new projek_PBOSQL.VIEWS.PETANI();
                                petaniForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Username atau Password User salah!");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}
