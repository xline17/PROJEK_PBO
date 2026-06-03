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
            txtEditUsername = new TextBox();
            txtEditPass = new TextBox();
            btnSimpanEdit = new Button();
            txtEditTelp = new TextBox();
            PbEdit = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV_kelUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbEdit).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnHistori);
            panel1.Controls.Add(btnKelolaTahapan);
            panel1.Controls.Add(btnKelolaPupuk);
            panel1.Controls.Add(btnkelolaUser);
            panel1.Controls.Add(btnDashboardAdmin);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(185, 598);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logo_dan_teks_pojok;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 158);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnHistori
            // 
            btnHistori.BackColor = Color.Black;
            btnHistori.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnHistori.ForeColor = Color.White;
            btnHistori.Location = new Point(11, 459);
            btnHistori.Margin = new Padding(3, 4, 3, 4);
            btnHistori.Name = "btnHistori";
            btnHistori.Size = new Size(166, 51);
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
            btnKelolaTahapan.Location = new Point(10, 386);
            btnKelolaTahapan.Margin = new Padding(3, 4, 3, 4);
            btnKelolaTahapan.Name = "btnKelolaTahapan";
            btnKelolaTahapan.Size = new Size(166, 51);
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
            btnKelolaPupuk.Location = new Point(10, 316);
            btnKelolaPupuk.Margin = new Padding(3, 4, 3, 4);
            btnKelolaPupuk.Name = "btnKelolaPupuk";
            btnKelolaPupuk.Size = new Size(166, 51);
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
            btnkelolaUser.Location = new Point(10, 182);
            btnkelolaUser.Margin = new Padding(3, 4, 3, 4);
            btnkelolaUser.Name = "btnkelolaUser";
            btnkelolaUser.Size = new Size(166, 51);
            btnkelolaUser.TabIndex = 2;
            btnkelolaUser.Text = "Dashboard";
            btnkelolaUser.TextAlign = ContentAlignment.MiddleLeft;
            btnkelolaUser.UseVisualStyleBackColor = false;
            // 
            // btnDashboardAdmin
            // 
            btnDashboardAdmin.BackColor = Color.White;
            btnDashboardAdmin.BackgroundImageLayout = ImageLayout.Stretch;
            btnDashboardAdmin.FlatAppearance.BorderSize = 0;
            btnDashboardAdmin.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboardAdmin.ForeColor = Color.Black;
            btnDashboardAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboardAdmin.Location = new Point(9, 248);
            btnDashboardAdmin.Margin = new Padding(0);
            btnDashboardAdmin.Name = "btnDashboardAdmin";
            btnDashboardAdmin.RightToLeft = RightToLeft.No;
            btnDashboardAdmin.Size = new Size(166, 51);
            btnDashboardAdmin.TabIndex = 1;
            btnDashboardAdmin.Text = "Kelola User";
            btnDashboardAdmin.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboardAdmin.UseVisualStyleBackColor = false;
            btnDashboardAdmin.Click += btnDashboardAdmin_Click;
            // 
            // DGV_kelUser
            // 
            DGV_kelUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_kelUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_kelUser.Columns.AddRange(new DataGridViewColumn[] { btnEditCol, btnHapusCol });
            DGV_kelUser.Location = new Point(191, 52);
            DGV_kelUser.Name = "DGV_kelUser";
            DGV_kelUser.RowHeadersWidth = 51;
            DGV_kelUser.Size = new Size(716, 253);
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
            btnTambahAkun.ForeColor = SystemColors.ButtonFace;
            btnTambahAkun.Location = new Point(747, 17);
            btnTambahAkun.Name = "btnTambahAkun";
            btnTambahAkun.Size = new Size(160, 29);
            btnTambahAkun.TabIndex = 2;
            btnTambahAkun.Text = "Tambah Akun";
            btnTambahAkun.UseVisualStyleBackColor = false;
            btnTambahAkun.Click += btnTambahAkun_Click;
            // 
            // txtEditUsername
            // 
            txtEditUsername.BorderStyle = BorderStyle.None;
            txtEditUsername.Location = new Point(335, 358);
            txtEditUsername.Name = "txtEditUsername";
            txtEditUsername.Size = new Size(236, 20);
            txtEditUsername.TabIndex = 5;
            txtEditUsername.Visible = false;
            txtEditUsername.TextChanged += txtEditUsername_TextChanged_1;
            // 
            // txtEditPass
            // 
            txtEditPass.BorderStyle = BorderStyle.None;
            txtEditPass.Location = new Point(335, 420);
            txtEditPass.Name = "txtEditPass";
            txtEditPass.Size = new Size(236, 20);
            txtEditPass.TabIndex = 6;
            txtEditPass.Visible = false;
            // 
            // btnSimpanEdit
            // 
            btnSimpanEdit.Location = new Point(459, 531);
            btnSimpanEdit.Name = "btnSimpanEdit";
            btnSimpanEdit.Size = new Size(170, 29);
            btnSimpanEdit.TabIndex = 4;
            btnSimpanEdit.Text = "Simpan Perubahan";
            btnSimpanEdit.UseVisualStyleBackColor = true;
            btnSimpanEdit.Visible = false;
            // 
            // txtEditTelp
            // 
            txtEditTelp.BorderStyle = BorderStyle.None;
            txtEditTelp.Location = new Point(335, 489);
            txtEditTelp.Name = "txtEditTelp";
            txtEditTelp.Size = new Size(236, 20);
            txtEditTelp.TabIndex = 7;
            txtEditTelp.Visible = false;
            // 
            // PbEdit
            // 
            PbEdit.BackgroundImage = (Image)resources.GetObject("PbEdit.BackgroundImage");
            PbEdit.Location = new Point(309, 316);
            PbEdit.Name = "PbEdit";
            PbEdit.Size = new Size(465, 257);
            PbEdit.TabIndex = 8;
            PbEdit.TabStop = false;
            PbEdit.Visible = false;
            PbEdit.Click += PbEdit_Click_1;
            // 
            // KelolaUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 599);
            Controls.Add(btnSimpanEdit);
            Controls.Add(btnTambahAkun);
            Controls.Add(txtEditUsername);
            Controls.Add(txtEditPass);
            Controls.Add(txtEditTelp);
            Controls.Add(PbEdit);
            Controls.Add(DGV_kelUser);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "KelolaUser";
            Text = "KancaTani";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGV_kelUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbEdit).EndInit();
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
        private TextBox txtEditUsername;
        private TextBox txtEditPass;
        private Button btnSimpanEdit;
        private TextBox txtEditTelp;
        private PictureBox PbEdit;
    }
}