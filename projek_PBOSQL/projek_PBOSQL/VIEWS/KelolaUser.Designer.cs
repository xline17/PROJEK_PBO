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
            btnTambahAkun = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV_kelUser).BeginInit();
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
            DGV_kelUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_kelUser.Location = new Point(191, 87);
            DGV_kelUser.Name = "DGV_kelUser";
            DGV_kelUser.RowHeadersWidth = 51;
            DGV_kelUser.Size = new Size(716, 253);
            DGV_kelUser.TabIndex = 1;
            DGV_kelUser.CellContentClick += DGV_kelUser_CellContentClick;
            // 
            // btnTambahAkun
            // 
            btnTambahAkun.BackColor = SystemColors.ActiveCaptionText;
            btnTambahAkun.ForeColor = SystemColors.ButtonFace;
            btnTambahAkun.Location = new Point(747, 43);
            btnTambahAkun.Name = "btnTambahAkun";
            btnTambahAkun.Size = new Size(160, 29);
            btnTambahAkun.TabIndex = 2;
            btnTambahAkun.Text = "Tambah Akun";
            btnTambahAkun.UseVisualStyleBackColor = false;
            btnTambahAkun.Click += btnTambahAkun_Click;
            // 
            // KelolaUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 599);
            Controls.Add(btnTambahAkun);
            Controls.Add(DGV_kelUser);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "KelolaUser";
            Text = "KancaTani";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGV_kelUser).EndInit();
            ResumeLayout(false);
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
    }
}