using Npgsql;
using projek_PBOSQL.MODELS.Pengguna;
using System;
using System.Data.SqlTypes;
namespace projek_PBOSQL
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin123")
            {
                Admin admin = new Admin(textBox2.Text, textBox1.Text, "Admin");
                MessageBox.Show("Login berhasil! Selamat datang, " + admin.Username);
                //Form2 form2 = new Form2();
                //form2.Show();
                //this.Hide();
            }
            else if (textBox1.Text == "petani" && textBox2.Text == "petani123")
            {
                Petani petani = new Petani(textBox2.Text, textBox1.Text, "Petani");
                MessageBox.Show("Login berhasil! Selamat datang, " + petani.Username);
                //Form3 form3 = new Form3();
                //form3.Show();
                //this.Hide();
            }
            else
            {
                MessageBox.Show("Login gagal! Pastikan username dan password benar.");
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
