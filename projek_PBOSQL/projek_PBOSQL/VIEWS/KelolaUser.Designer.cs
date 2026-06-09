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
            btnHistori = new Button();
            btnKelolaTahapan = new Button();
            btnKelolaPupuk = new Button();
            btnkelolaUser = new Button();
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
            panel1.Controls.Add(btnHistori);
            panel1.Controls.Add(btnKelolaTahapan);
            panel1.Controls.Add(btnKelolaPupuk);
            panel1.Controls.Add(btnkelolaUser);
            panel1.Controls.Add(btnDashboardAdmin);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 1200);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(44, 669);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(130, 46);
            button1.TabIndex = 6;
            button1.Text = "LOG OUT";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logo_dan_teks_pojok;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, 19);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(231, 200);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnHistori
            // 
            btnHistori.BackColor = Color.Black;
            btnHistori.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnHistori.ForeColor = Color.White;
            btnHistori.Location = new Point(14, 574);
            btnHistori.Margin = new Padding(4, 5, 4, 5);
            btnHistori.Name = "btnHistori";
            btnHistori.Size = new Size(208, 64);
            btnHistori.TabIndex = 5;
            btnHistori.Text = "Histori Transaksi";
            btnHistori.TextAlign = ContentAlignment.MiddleLeft;
            btnHistori.UseVisualStyleBackColor = false;
            // 
            // btnKelolaTahapan
            // 
            btnKelolaTahapan.BackColor = Color.Black;
            btnKelolaTahapan.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnKelolaTahapan.ForeColor = Color.White;
            btnKelolaTahapan.Location = new Point(12, 484);
            btnKelolaTahapan.Margin = new Padding(4, 5, 4, 5);
            btnKelolaTahapan.Name = "btnKelolaTahapan";
            btnKelolaTahapan.Size = new Size(208, 64);
            btnKelolaTahapan.TabIndex = 4;
            btnKelolaTahapan.Text = "Kelola Tahapan";
            btnKelolaTahapan.TextAlign = ContentAlignment.MiddleLeft;
            btnKelolaTahapan.UseVisualStyleBackColor = false;
            // 
            // btnKelolaPupuk
            // 
            btnKelolaPupuk.BackColor = Color.Black;
            btnKelolaPupuk.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnKelolaPupuk.ForeColor = Color.White;
            btnKelolaPupuk.Location = new Point(12, 395);
            btnKelolaPupuk.Margin = new Padding(4, 5, 4, 5);
            btnKelolaPupuk.Name = "btnKelolaPupuk";
            btnKelolaPupuk.Size = new Size(208, 64);
            btnKelolaPupuk.TabIndex = 3;
            btnKelolaPupuk.Text = "Kelola Pupuk";
            btnKelolaPupuk.TextAlign = ContentAlignment.MiddleLeft;
            btnKelolaPupuk.UseVisualStyleBackColor = false;
            // 
            // btnkelolaUser
            // 
            btnkelolaUser.BackColor = Color.Black;
            btnkelolaUser.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnkelolaUser.ForeColor = Color.White;
            btnkelolaUser.Location = new Point(12, 226);
            btnkelolaUser.Margin = new Padding(4, 5, 4, 5);
            btnkelolaUser.Name = "btnkelolaUser";
            btnkelolaUser.Size = new Size(208, 64);
            btnkelolaUser.TabIndex = 2;
            btnkelolaUser.Text = "Dashboard";
            btnkelolaUser.TextAlign = ContentAlignment.MiddleLeft;
            btnkelolaUser.UseVisualStyleBackColor = false;
            btnkelolaUser.Click += btnkelolaUser_Click;
            // 
            // btnDashboardAdmin
            // 
            btnDashboardAdmin.BackColor = Color.White;
            btnDashboardAdmin.BackgroundImageLayout = ImageLayout.Stretch;
            btnDashboardAdmin.FlatAppearance.BorderSize = 0;
            btnDashboardAdmin.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboardAdmin.ForeColor = Color.Black;
            btnDashboardAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboardAdmin.Location = new Point(11, 310);
            btnDashboardAdmin.Margin = new Padding(0);
            btnDashboardAdmin.Name = "btnDashboardAdmin";
            btnDashboardAdmin.RightToLeft = RightToLeft.No;
            btnDashboardAdmin.Size = new Size(208, 64);
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
            DGV_kelUser.Location = new Point(9, 194);
            DGV_kelUser.Margin = new Padding(4);
            DGV_kelUser.Name = "DGV_kelUser";
            DGV_kelUser.RowHeadersWidth = 51;
            DGV_kelUser.Size = new Size(1668, 506);
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
            btnTambahAkun.Location = new Point(1426, 111);
            btnTambahAkun.Margin = new Padding(4);
            btnTambahAkun.Name = "btnTambahAkun";
            btnTambahAkun.Size = new Size(236, 62);
            btnTambahAkun.TabIndex = 2;
            btnTambahAkun.Text = "Tambah Akun";
            btnTambahAkun.UseVisualStyleBackColor = false;
            btnTambahAkun.Click += btnTambahAkun_Click;
            // 
            // btnSimpanEdit
            // 
            btnSimpanEdit.Location = new Point(574, 664);
            btnSimpanEdit.Margin = new Padding(4);
            btnSimpanEdit.Name = "btnSimpanEdit";
            btnSimpanEdit.Size = new Size(212, 36);
            btnSimpanEdit.TabIndex = 4;
            btnSimpanEdit.Text = "Simpan Perubahan";
            btnSimpanEdit.UseVisualStyleBackColor = true;
            btnSimpanEdit.Visible = false;
            // 
            // txtEditTelp
            // 
            txtEditTelp.BorderStyle = BorderStyle.None;
            txtEditTelp.Location = new Point(419, 611);
            txtEditTelp.Margin = new Padding(4);
            txtEditTelp.Name = "txtEditTelp";
            txtEditTelp.Size = new Size(294, 24);
            txtEditTelp.TabIndex = 7;
            txtEditTelp.Visible = false;
            // 
            // PbEdit
            // 
            PbEdit.BackgroundImage = (Image)resources.GetObject("PbEdit.BackgroundImage");
            PbEdit.Location = new Point(386, 395);
            PbEdit.Margin = new Padding(4);
            PbEdit.Name = "PbEdit";
            PbEdit.Size = new Size(581, 321);
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
            panel2.Location = new Point(230, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1690, 1200);
            panel2.TabIndex = 9;
            // 
            // KelolaUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1200);
            Controls.Add(panel2);
            Controls.Add(btnSimpanEdit);
            Controls.Add(txtEditTelp);
            Controls.Add(PbEdit);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
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
        private Button btnkelolaUser;
        private Button btnKelolaPupuk;
        private Button btnKelolaTahapan;
        private Button btnHistori;
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