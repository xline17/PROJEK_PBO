using Npgsql;
using projek_PBOSQL.MODELS.Pengguna;
using System;
using System.Data.SqlTypes;
namespace projek_PBOSQL
{
    public partial class LOGINADMIN : Form
    {
        public LOGINADMIN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "Host=localhost;Port=5432;Username=postgres;Password=12345;Database=projek_pbo";

            string query = "SELECT username, password, id_role from akun WHERE username = @username AND password = @password AND id_role = 1";

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

                                projek_PBOSQL.VIEWS.ADMIN adminForm = new projek_PBOSQL.VIEWS.ADMIN();
                                adminForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Username atau Password Admin salah!");
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
                
        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
