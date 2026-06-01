using Npgsql;
using projek_PBOSQL.MODELS.Pengguna;
using projek_PBOSQL.VIEWS;
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
            projek_PBOSQL.CONTROLLERS.c_users userController = new projek_PBOSQL.CONTROLLERS.c_users();

            // Memanggil fungsi validasi dari controller
            dynamic adminLogedIn = userController.validasi_login(textBox1.Text, textBox2.Text);

            if (adminLogedIn != null)
            {
                // Memastikan objek yang dikembalikan adalah instansi dari class Admin
                if (adminLogedIn is Admin admin)
                {
                    MessageBox.Show("Login Berhasil sebagai Admin!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // PANGGIL FORM ADMIN KAMU DI SINI
                    // (Ganti 'FormAdminDashboard' dengan nama Class Form Admin milikmu yang asli)
                    ADMIN admin_form = new ADMIN();
                    admin_form.Show();

                    this.Hide(); // Menyembunyikan Form Login agar tidak menumpuk
                }
            }
            else
            {
                // Jika userLogin mengembalikan null (tidak ditemukan di DB)
                MessageBox.Show("Username atau Password salah!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
