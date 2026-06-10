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
            DGV_kelUser = new DataGridView();
            btnEditCol = new DataGridViewButtonColumn();
            btnHapusCol = new DataGridViewButtonColumn();
            btnTambahAkun = new Button();
            panel2 = new Panel();
            lblUser = new Label();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnKelolaTahapan = new Button();
            pictureBox2 = new PictureBox();
            btnLogout = new Button();
            btnKelolaStock = new Button();
            btnKelolaPupuk = new Button();
            btnUser = new Button();
            btnDashboard = new Button();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)DGV_kelUser).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // DGV_kelUser
            // 
            DGV_kelUser.AllowUserToAddRows = false;
            DGV_kelUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_kelUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_kelUser.Columns.AddRange(new DataGridViewColumn[] { btnEditCol, btnHapusCol });
            DGV_kelUser.Location = new Point(283, 196);
            DGV_kelUser.Name = "DGV_kelUser";
            DGV_kelUser.RowHeadersWidth = 51;
            DGV_kelUser.Size = new Size(1570, 868);
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
            btnTambahAkun.Location = new Point(1626, 125);
            btnTambahAkun.Name = "btnTambahAkun";
            btnTambahAkun.Size = new Size(227, 65);
            btnTambahAkun.TabIndex = 2;
            btnTambahAkun.Text = "Tambah Akun";
            btnTambahAkun.UseVisualStyleBackColor = false;
            btnTambahAkun.Click += btnTambahAkun_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(btnTambahAkun);
            panel2.Controls.Add(DGV_kelUser);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1898, 1149);
            panel2.TabIndex = 9;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Arial", 22F, FontStyle.Bold);
            lblUser.ForeColor = Color.White;
            lblUser.Location = new Point(107, 64);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(40, 44);
            lblUser.TabIndex = 4;
            lblUser.Text = "0";
            lblUser.Click += lblUser_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(25, 14);
            label1.Name = "label1";
            label1.Size = new Size(197, 50);
            label1.TabIndex = 3;
            label1.Text = "Total User";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnKelolaTahapan);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnKelolaStock);
            panel1.Controls.Add(btnKelolaPupuk);
            panel1.Controls.Add(btnUser);
            panel1.Controls.Add(btnDashboard);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 1149);
            panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_dan_teks_pojok;
            pictureBox1.Location = new Point(11, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 187);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // btnKelolaTahapan
            // 
            btnKelolaTahapan.BackColor = Color.Black;
            btnKelolaTahapan.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKelolaTahapan.ForeColor = Color.White;
            btnKelolaTahapan.Location = new Point(11, 516);
            btnKelolaTahapan.Margin = new Padding(1);
            btnKelolaTahapan.Name = "btnKelolaTahapan";
            btnKelolaTahapan.Size = new Size(217, 57);
            btnKelolaTahapan.TabIndex = 8;
            btnKelolaTahapan.Text = "Kelola Tahapan";
            btnKelolaTahapan.UseVisualStyleBackColor = false;
            btnKelolaTahapan.Click += btnKelolaTahapan_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logout;
            pictureBox2.Location = new Point(30, 829);
            pictureBox2.Margin = new Padding(1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(192, 0, 0);
            btnLogout.ForeColor = SystemColors.ButtonHighlight;
            btnLogout.Location = new Point(77, 826);
            btnLogout.Margin = new Padding(1);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(124, 40);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnKelolaStock
            // 
            btnKelolaStock.BackColor = Color.Black;
            btnKelolaStock.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKelolaStock.ForeColor = Color.White;
            btnKelolaStock.Location = new Point(11, 439);
            btnKelolaStock.Margin = new Padding(1);
            btnKelolaStock.Name = "btnKelolaStock";
            btnKelolaStock.Size = new Size(217, 57);
            btnKelolaStock.TabIndex = 4;
            btnKelolaStock.Text = "Kelola Stock";
            btnKelolaStock.UseVisualStyleBackColor = false;
            btnKelolaStock.Click += btnKelolaStock_Click;
            // 
            // btnKelolaPupuk
            // 
            btnKelolaPupuk.BackColor = Color.Black;
            btnKelolaPupuk.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKelolaPupuk.ForeColor = Color.White;
            btnKelolaPupuk.Location = new Point(11, 361);
            btnKelolaPupuk.Margin = new Padding(1);
            btnKelolaPupuk.Name = "btnKelolaPupuk";
            btnKelolaPupuk.Size = new Size(217, 57);
            btnKelolaPupuk.TabIndex = 3;
            btnKelolaPupuk.Text = "Kelola Pupuk";
            btnKelolaPupuk.UseVisualStyleBackColor = false;
            btnKelolaPupuk.Click += btnKelolaPupuk_Click_1;
            // 
            // btnUser
            // 
            btnUser.BackColor = Color.White;
            btnUser.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUser.ForeColor = Color.Black;
            btnUser.Location = new Point(11, 287);
            btnUser.Margin = new Padding(1);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(217, 57);
            btnUser.TabIndex = 2;
            btnUser.Text = "Kelola User";
            btnUser.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Black;
            btnDashboard.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(11, 212);
            btnDashboard.Margin = new Padding(1);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(217, 57);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(lblUser);
            panel3.Location = new Point(283, 21);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 124);
            panel3.TabIndex = 5;
            // 
            // KelolaUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1898, 1149);
            Controls.Add(panel1);
            Controls.Add(panel2);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "KelolaUser";
            Text = "KancaTani";
            WindowState = FormWindowState.Maximized;
            Load += KelolaUser_Load;
            ((System.ComponentModel.ISupportInitialize)DGV_kelUser).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView DGV_kelUser;
        private Button btnTambahAkun;
        private DataGridViewButtonColumn btnEditCol;
        private DataGridViewButtonColumn btnHapusCol;
        private Panel panel2;
        private Panel panel1;
        private Button btnKelolaTahapan;
        private PictureBox pictureBox2;
        private Button btnLogout;
        private Button btnKelolaStock;
        private Button btnKelolaPupuk;
        private Button btnUser;
        private Button btnDashboard;
        private PictureBox pictureBox1;
        private Label label1;
        private Label lblUser;
        private Panel panel3;
    }
}