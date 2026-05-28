using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projek_PBOSQL.VIEWS
{
    public partial class ROLE : Form
    {
        public ROLE()
        {
            InitializeComponent();
        }

        private void ROLE_Load(object sender, EventArgs e)
        {
            var koneksi = projek_PBOSQL.HELPERS.ConnectDB.GetConn();

            if (koneksi != null && koneksi.State == System.Data.ConnectionState.Open)
            {
                // Tampilkan notifikasi jika berhasil tersambung
                MessageBox.Show("Koneksi ke PostgreSQL Berhasil!", "Sukses Hubungkan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Jangan lupa tutup kembali setelah dites agar tidak boros resource data
                koneksi.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LOGINADMIN login = new LOGINADMIN();
            login.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LOGINPETANI login1 = new LOGINPETANI();
            login1.Show();
            this.Hide();
        }
    }
}