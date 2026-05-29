using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projek_PBOSQL.VIEWS
{
    public partial class ADMIN : Form
    {
        public ADMIN()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDashboardAdmin_Click(object sender, EventArgs e)
        {

        }

        private void ADMIN_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            projek_PBOSQL.VIEWS.KelolaUser kelolauserForm = new projek_PBOSQL.VIEWS.KelolaUser();
            kelolauserForm.Show();
            this.Hide();
        }

        private void btnkelolaPupuk_Click(object sender, EventArgs e)
        {

        }

        private void btnkelolaTahapan_Click(object sender, EventArgs e)
        {

        }

        private void btnhistoriTransaksi_Click(object sender, EventArgs e)
        {

        }

    }
}
