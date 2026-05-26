using Npgsql;
using System;
using System.Data.SqlTypes;
namespace projek_PBOSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using Npgsql command = new NpgsqlCommand("SELECT * FROM users WHERE username = @username", connection);
            if (command == username )
        }
    }
}
