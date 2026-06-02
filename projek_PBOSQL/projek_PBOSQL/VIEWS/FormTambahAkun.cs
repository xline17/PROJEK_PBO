using System;
using System.Drawing;
using System.Windows.Forms;
using projek_PBOSQL.CONTROLLERS;
using projek_PBOSQL.MODELS.Pengguna;

namespace projek_PBOSQL.VIEWS
{
    public partial class FormTambahAkun : Form
    {
        private c_users controller;

        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtNoTelp;
        private Button btnSimpan;
        private Button btnBatal;

        public FormTambahAkun(c_users ctrl)
        {
            controller = ctrl;
            BuildUI();
        }

        private void BuildUI()
        {
            this.Text = "Tambah Akun Baru";
            this.Size = new Size(360, 280);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.BackColor = Color.White;
            this.Font = new Font("Segoe UI", 9.5F);

            // Label & TextBox Username
            AddLabel("Username", 20);
            txtUsername = AddTextBox(45);

            // Label & TextBox Password
            AddLabel("Password", 85);
            txtPassword = AddTextBox(110);
            txtPassword.PasswordChar = '●';

            // Label & TextBox No Telp
            AddLabel("No. Telepon", 150);
            txtNoTelp = AddTextBox(175);

            // Tombol
            btnSimpan = new Button
            {
                Text = "Simpan",
                Location = new Point(160, 215),
                Size = new Size(85, 32),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(30, 80, 180),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnSimpan.FlatAppearance.BorderSize = 0;
            btnSimpan.Click += BtnSimpan_Click;

            btnBatal = new Button
            {
                Text = "Batal",
                Location = new Point(255, 215),
                Size = new Size(75, 32),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(240, 240, 240),
                ForeColor = Color.FromArgb(60, 60, 60),
                Font = new Font("Segoe UI", 9F),
                Cursor = Cursors.Hand
            };
            btnBatal.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnBatal.Click += (s, e) => { this.DialogResult = DialogResult.Cancel; this.Close(); };

            this.Controls.AddRange(new Control[] { btnSimpan, btnBatal });
        }

        private void AddLabel(string text, int top)
        {
            this.Controls.Add(new Label
            {
                Text = text,
                Location = new Point(20, top),
                AutoSize = true,
                ForeColor = Color.FromArgb(70, 70, 70),
                Font = new Font("Segoe UI", 8.5F, FontStyle.Bold)
            });
        }

        private TextBox AddTextBox(int top)
        {
            var txt = new TextBox
            {
                Location = new Point(20, top),
                Width = 310,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.FromArgb(248, 249, 250),
                Font = new Font("Segoe UI", 9.5F)
            };
            this.Controls.Add(txt);
            return txt;
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string noTelp = txtNoTelp.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(noTelp))
            {
                MessageBox.Show("Semua field wajib diisi.", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var akun = new AkunModel(username, password, noTelp);
                bool berhasil = controller.TambahAkun(akun);

                if (berhasil)
                {
                    MessageBox.Show($"Akun '{username}' berhasil ditambahkan!", "Sukses",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambah akun:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}