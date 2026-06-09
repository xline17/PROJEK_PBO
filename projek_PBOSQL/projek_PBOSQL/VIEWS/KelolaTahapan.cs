using projek_PBOSQL.MODELS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projek_PBOSQL.VIEWS
{
    public partial class KelolaTahapan : Form
    {
        public KelolaTahapan()
        {
            InitializeComponent();
        }

        private void btnDashboardAdmin_Click(object sender, EventArgs e)
        {
            projek_PBOSQL.VIEWS.ADMIN adminForm = new projek_PBOSQL.VIEWS.ADMIN();
            adminForm.Show();
            this.Hide();
        }

        private void btnkelolaUser_Click(object sender, EventArgs e)
        {
            projek_PBOSQL.VIEWS.KelolaUser kelolauserForm = new projek_PBOSQL.VIEWS.KelolaUser();
            kelolauserForm.Show();
            this.Hide();
        }

        private void btnkelolaPupuk_Click(object sender, EventArgs e)
        {
            projek_PBOSQL.VIEWS.KelolaPupuk kelolapupukForm = new projek_PBOSQL.VIEWS.KelolaPupuk();
            kelolapupukForm.Show();
            this.Hide();
        }

        private void btnKelolaStock_Click(object sender, EventArgs e)
        {
            projek_PBOSQL.VIEWS.KelolaStock stock = new projek_PBOSQL.VIEWS.KelolaStock();
            stock.Show();
            this.Hide();
        }

        private void btnkelolaTahapan_Click(object sender, EventArgs e)
        {

        }

        private void btnhistoriTransaksi_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelMainContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void KelolaTahapan_Load(object sender, EventArgs e)
        {
            
        }
    }
}
