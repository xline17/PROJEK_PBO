namespace projek_PBOSQL.VIEWS
{
    partial class KelolaUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KelolaUser));
            panel1 = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            btnKelolaTahapan = new Button();
            btnKelolaPupuk = new Button();
            btnKelolaUser = new Button();
            btnDashboardAdmin = new Button();
            DGV_kelUser = new DataGridView();
            btnEditCol = new DataGridViewButtonColumn();
            btnHapusCol = new DataGridViewButtonColumn();
            btnTambahAkun = new Button();
            btnSimpanEdit = new Button();
            txtEditTelp = new TextBox();
            PbEdit = new PictureBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV_kelUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbEdit).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnKelolaTahapan);
            panel1.Controls.Add(btnKelolaPupuk);
            panel1.Controls.Add(btnKelolaUser);
            panel1.Controls.Add(btnDashboardAdmin);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(161, 473);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(32, 334);
            button1.Name = "button1";
            button1.Size = new Size(91, 28);
            button1.TabIndex = 6;
            button1.Text = "LOG OUT";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logo_dan_teks_pojok;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, 11);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 120);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnKelolaTahapan
            // 
            btnKelolaTahapan.BackColor = Color.Black;
            btnKelolaTahapan.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnKelolaTahapan.ForeColor = Color.White;
            btnKelolaTahapan.Location = new Point(8, 290);
            btnKelolaTahapan.Name = "btnKelolaTahapan";
            btnKelolaTahapan.Size = new Size(146, 38);
            btnKelolaTahapan.TabIndex = 4;
            btnKelolaTahapan.Text = "Kelola Tahapan";
            btnKelolaTahapan.TextAlign = ContentAlignment.MiddleLeft;
            btnKelolaTahapan.UseVisualStyleBackColor = false;
            btnKelolaTahapan.Click += btnKelolaTahapan_Click;
            // 
            // btnKelolaPupuk
            // 
            btnKelolaPupuk.BackColor = Color.Black;
            btnKelolaPupuk.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnKelolaPupuk.ForeColor = Color.White;
            btnKelolaPupuk.Location = new Point(8, 237);
            btnKelolaPupuk.Name = "btnKelolaPupuk";
            btnKelolaPupuk.Size = new Size(146, 38);
            btnKelolaPupuk.TabIndex = 3;
            btnKelolaPupuk.Text = "Kelola Pupuk";
            btnKelolaPupuk.TextAlign = ContentAlignment.MiddleLeft;
            btnKelolaPupuk.UseVisualStyleBackColor = false;
            btnKelolaPupuk.Click += btnKelolaPupuk_Click;
            // 
            // btnKelolaUser
            // 
            btnKelolaUser.BackColor = Color.Black;
            btnKelolaUser.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnKelolaUser.ForeColor = Color.White;
            btnKelolaUser.Location = new Point(8, 136);
            btnKelolaUser.Name = "btnKelolaUser";
            btnKelolaUser.Size = new Size(146, 38);
            btnKelolaUser.TabIndex = 2;
            btnKelolaUser.Text = "Dashboard";
            btnKelolaUser.TextAlign = ContentAlignment.MiddleLeft;
            btnKelolaUser.UseVisualStyleBackColor = false;
            btnKelolaUser.Click += btnkelolaUser_Click;
            // 
            // btnDashboardAdmin
            // 
            btnDashboardAdmin.BackColor = Color.White;
            btnDashboardAdmin.BackgroundImageLayout = ImageLayout.Stretch;
            btnDashboardAdmin.FlatAppearance.BorderSize = 0;
            btnDashboardAdmin.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboardAdmin.ForeColor = Color.Black;
            btnDashboardAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboardAdmin.Location = new Point(8, 186);
            btnDashboardAdmin.Margin = new Padding(0);
            btnDashboardAdmin.Name = "btnDashboardAdmin";
            btnDashboardAdmin.RightToLeft = RightToLeft.No;
            btnDashboardAdmin.Size = new Size(146, 38);
            btnDashboardAdmin.TabIndex = 1;
            btnDashboardAdmin.Text = "Kelola User";
            btnDashboardAdmin.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboardAdmin.UseVisualStyleBackColor = false;
            btnDashboardAdmin.Click += btnDashboardAdmin_Click;
            // 
            // DGV_kelUser
            // 
            DGV_kelUser.AllowUserToAddRows = false;
            DGV_kelUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_kelUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_kelUser.Columns.AddRange(new DataGridViewColumn[] { btnEditCol, btnHapusCol });
            DGV_kelUser.Location = new Point(6, 116);
            DGV_kelUser.Margin = new Padding(3, 2, 3, 2);
            DGV_kelUser.Name = "DGV_kelUser";
            DGV_kelUser.RowHeadersWidth = 51;
            DGV_kelUser.Size = new Size(1168, 304);
            DGV_kelUser.TabIndex = 1;
            DGV_kelUser.CellContentClick += DGV_kelUser_CellContentClick;
            // 
            // btnEditCol
            // 
            btnEditCol.HeaderText = "";
            btnEditCol.MinimumWidth = 6;
            btnEditCol.Name = "btnEditCol";
            btnEditCol.Text = "Edit";
            btnEditCol.UseColumnTextForButtonValue = true;
            // 
            // btnHapusCol
            // 
            btnHapusCol.HeaderText = "";
            btnHapusCol.MinimumWidth = 6;
            btnHapusCol.Name = "btnHapusCol";
            btnHapusCol.Text = "Hapus";
            btnHapusCol.UseColumnTextForButtonValue = true;
            // 
            // btnTambahAkun
            // 
            btnTambahAkun.BackColor = SystemColors.ActiveCaptionText;
            btnTambahAkun.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTambahAkun.ForeColor = SystemColors.ButtonFace;
            btnTambahAkun.Location = new Point(998, 67);
            btnTambahAkun.Margin = new Padding(3, 2, 3, 2);
            btnTambahAkun.Name = "btnTambahAkun";
            btnTambahAkun.Size = new Size(165, 37);
            btnTambahAkun.TabIndex = 2;
            btnTambahAkun.Text = "Tambah Akun";
            btnTambahAkun.UseVisualStyleBackColor = false;
            btnTambahAkun.Click += btnTambahAkun_Click;
            // 
            // btnSimpanEdit
            // 
            btnSimpanEdit.Location = new Point(402, 398);
            btnSimpanEdit.Margin = new Padding(3, 2, 3, 2);
            btnSimpanEdit.Name = "btnSimpanEdit";
            btnSimpanEdit.Size = new Size(148, 22);
            btnSimpanEdit.TabIndex = 4;
            btnSimpanEdit.Text = "Simpan Perubahan";
            btnSimpanEdit.UseVisualStyleBackColor = true;
            btnSimpanEdit.Visible = false;
            // 
            // txtEditTelp
            // 
            txtEditTelp.BorderStyle = BorderStyle.None;
            txtEditTelp.Location = new Point(293, 367);
            txtEditTelp.Margin = new Padding(3, 2, 3, 2);
            txtEditTelp.Name = "txtEditTelp";
            txtEditTelp.Size = new Size(206, 16);
            txtEditTelp.TabIndex = 7;
            txtEditTelp.Visible = false;
            // 
            // PbEdit
            // 
            PbEdit.BackgroundImage = (Image)resources.GetObject("PbEdit.BackgroundImage");
            PbEdit.Location = new Point(270, 237);
            PbEdit.Margin = new Padding(3, 2, 3, 2);
            PbEdit.Name = "PbEdit";
            PbEdit.Size = new Size(407, 193);
            PbEdit.TabIndex = 8;
            PbEdit.TabStop = false;
            PbEdit.Visible = false;
            PbEdit.Click += PbEdit_Click_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnTambahAkun);
            panel2.Controls.Add(DGV_kelUser);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(161, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(809, 473);
            panel2.TabIndex = 9;
            // 
            // KelolaUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 473);
            Controls.Add(panel2);
            Controls.Add(btnSimpanEdit);
            Controls.Add(txtEditTelp);
            Controls.Add(PbEdit);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "KelolaUser";
            Text = "KancaTani";
            WindowState = FormWindowState.Maximized;
            Load += KelolaUser_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGV_kelUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbEdit).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnDashboardAdmin;
        private Button btnKelolaUser;
        private Button btnKelolaPupuk;
        private Button btnKelolaTahapan;
        private PictureBox pictureBox1;
        private DataGridView DGV_kelUser;
        private Button btnTambahAkun;
        private DataGridViewButtonColumn btnEditCol;
        private DataGridViewButtonColumn btnHapusCol;
        private Button btnSimpanEdit;
        private TextBox txtEditTelp;
        private PictureBox PbEdit;
        private Panel panel2;
        private Button button1;
    }
}