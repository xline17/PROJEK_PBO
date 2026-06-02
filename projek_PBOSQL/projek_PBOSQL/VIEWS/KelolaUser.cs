using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projek_PBOSQL.VIEWS
{
    public partial class KelolaUser : Form
    {
        public KelolaUser()
        {
            InitializeComponent();
        }

        private void btnDashboardAdmin_Click(object sender, EventArgs e)
        {

        }

        private void DGV_kelUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTambahAkun_Click(object sender, EventArgs e)
        {
            var formTambah = new FormTambahAkun(controller);
            if (formTambah.ShowDialog() == DialogResult.OK)
                LoadAkun(); // refresh grid setelah akun ditambah
        }
    }
}
