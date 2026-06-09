namespace projek_PBOSQL.VIEWS
{
    partial class KelolaPupuk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KelolaPupuk));
            panel1 = new Panel();
            btnKelolaTahapan = new Button();
            pictureBox2 = new PictureBox();
            btnLogout = new Button();
            btnHistory = new Button();
            btnKelolaStock = new Button();
            btnKelolaPupuk = new Button();
            btnUser = new Button();
            btnDashboard = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnTambah = new Button();
            lblJenisPupuk = new Label();
            lblTotalStock = new Label();
            chkTampilkanSemua = new CheckBox();
            dgvPupuk = new DataGridView();
            id_pupuk = new DataGridViewTextBoxColumn();
            nama_pupuk = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPupuk).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btnKelolaTahapan);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnHistory);
            panel1.Controls.Add(btnKelolaStock);
            panel1.Controls.Add(btnKelolaPupuk);
            panel1.Controls.Add(btnUser);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 1144);
            panel1.TabIndex = 0;
            // 
            // btnKelolaTahapan
            // 
            btnKelolaTahapan.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKelolaTahapan.Location = new Point(14, 645);
            btnKelolaTahapan.Margin = new Padding(2);
            btnKelolaTahapan.Name = "btnKelolaTahapan";
            btnKelolaTahapan.Size = new Size(272, 72);
            btnKelolaTahapan.TabIndex = 8;
            btnKelolaTahapan.Text = "Kelola Tahapan";
            btnKelolaTahapan.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logout;
            pictureBox2.Location = new Point(52, 1044);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(192, 0, 0);
            btnLogout.ForeColor = SystemColors.ButtonHighlight;
            btnLogout.Location = new Point(118, 1052);
            btnLogout.Margin = new Padding(2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(112, 34);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnHistory
            // 
            btnHistory.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHistory.Location = new Point(14, 741);
            btnHistory.Margin = new Padding(2);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(272, 72);
            btnHistory.TabIndex = 5;
            btnHistory.Text = "History Transaksi";
            btnHistory.UseVisualStyleBackColor = true;
            // 
            // btnKelolaStock
            // 
            btnKelolaStock.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKelolaStock.Location = new Point(14, 548);
            btnKelolaStock.Margin = new Padding(2);
            btnKelolaStock.Name = "btnKelolaStock";
            btnKelolaStock.Size = new Size(272, 72);
            btnKelolaStock.TabIndex = 4;
            btnKelolaStock.Text = "Kelola Stock";
            btnKelolaStock.UseVisualStyleBackColor = true;
            btnKelolaStock.Click += btnKelolaStock_Click;
            // 
            // btnKelolaPupuk
            // 
            btnKelolaPupuk.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKelolaPupuk.Location = new Point(14, 452);
            btnKelolaPupuk.Margin = new Padding(2);
            btnKelolaPupuk.Name = "btnKelolaPupuk";
            btnKelolaPupuk.Size = new Size(272, 72);
            btnKelolaPupuk.TabIndex = 3;
            btnKelolaPupuk.Text = "Kelola Pupuk";
            btnKelolaPupuk.UseVisualStyleBackColor = true;
            // 
            // btnUser
            // 
            btnUser.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUser.Location = new Point(14, 358);
            btnUser.Margin = new Padding(2);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(272, 72);
            btnUser.TabIndex = 2;
            btnUser.Text = "Kelola User";
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += btnUser_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.Location = new Point(14, 265);
            btnDashboard.Margin = new Padding(2);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(272, 72);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.logo_dan_teks_pojok;
            pictureBox1.Location = new Point(2, 12);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(282, 236);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.Ukuran_Kelola_Pupuk;
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnTambah);
            panel2.Controls.Add(lblJenisPupuk);
            panel2.Controls.Add(lblTotalStock);
            panel2.Controls.Add(chkTampilkanSemua);
            panel2.Controls.Add(dgvPupuk);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(300, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1598, 1144);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 0, 0);
            btnDelete.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(1183, 953);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(142, 55);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 192, 128);
            btnUpdate.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = SystemColors.ButtonHighlight;
            btnUpdate.Location = new Point(1348, 953);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(158, 55);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.FromArgb(0, 192, 192);
            btnTambah.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambah.ForeColor = SystemColors.ButtonHighlight;
            btnTambah.Location = new Point(1257, 368);
            btnTambah.Margin = new Padding(2);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(249, 52);
            btnTambah.TabIndex = 4;
            btnTambah.Text = "+ Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // lblJenisPupuk
            // 
            lblJenisPupuk.AutoSize = true;
            lblJenisPupuk.BackColor = Color.Transparent;
            lblJenisPupuk.Font = new Font("Arial", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJenisPupuk.Location = new Point(881, 209);
            lblJenisPupuk.Margin = new Padding(2, 0, 2, 0);
            lblJenisPupuk.Name = "lblJenisPupuk";
            lblJenisPupuk.Size = new Size(0, 61);
            lblJenisPupuk.TabIndex = 3;
            // 
            // lblTotalStock
            // 
            lblTotalStock.AutoSize = true;
            lblTotalStock.BackColor = Color.Transparent;
            lblTotalStock.Font = new Font("Arial", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalStock.Location = new Point(110, 209);
            lblTotalStock.Margin = new Padding(2, 0, 2, 0);
            lblTotalStock.Name = "lblTotalStock";
            lblTotalStock.Size = new Size(0, 61);
            lblTotalStock.TabIndex = 2;
            // 
            // chkTampilkanSemua
            // 
            chkTampilkanSemua.AutoSize = true;
            chkTampilkanSemua.BackColor = Color.Transparent;
            chkTampilkanSemua.Location = new Point(77, 902);
            chkTampilkanSemua.Margin = new Padding(2);
            chkTampilkanSemua.Name = "chkTampilkanSemua";
            chkTampilkanSemua.Size = new Size(176, 29);
            chkTampilkanSemua.TabIndex = 1;
            chkTampilkanSemua.Text = "Tampilkan Semua";
            chkTampilkanSemua.UseVisualStyleBackColor = false;
            chkTampilkanSemua.CheckedChanged += chkTampilkanSemua_CheckedChanged;
            // 
            // dgvPupuk
            // 
            dgvPupuk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPupuk.BackgroundColor = SystemColors.ControlLight;
            dgvPupuk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPupuk.Columns.AddRange(new DataGridViewColumn[] { id_pupuk, nama_pupuk, status });
            dgvPupuk.Location = new Point(77, 452);
            dgvPupuk.Margin = new Padding(2);
            dgvPupuk.Name = "dgvPupuk";
            dgvPupuk.RowHeadersWidth = 62;
            dgvPupuk.Size = new Size(1446, 446);
            dgvPupuk.TabIndex = 0;
            // 
            // id_pupuk
            // 
            id_pupuk.HeaderText = "ID";
            id_pupuk.MinimumWidth = 8;
            id_pupuk.Name = "id_pupuk";
            id_pupuk.ReadOnly = true;
            // 
            // nama_pupuk
            // 
            nama_pupuk.HeaderText = "Nama Pupuk";
            nama_pupuk.MinimumWidth = 8;
            nama_pupuk.Name = "nama_pupuk";
            nama_pupuk.ReadOnly = true;
            // 
            // status
            // 
            status.HeaderText = "Status";
            status.MinimumWidth = 8;
            status.Name = "status";
            status.ReadOnly = true;
            // 
            // KelolaPupuk
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1144);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "KelolaPupuk";
            Text = "KelolaPupuk";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPupuk).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnDashboard;
        private PictureBox pictureBox1;
        private Button btnHistory;
        private Button btnKelolaStock;
        private Button btnKelolaPupuk;
        private Button btnUser;
        private DataGridView dgvPupuk;
        private CheckBox chkTampilkanSemua;
        private DataGridViewTextBoxColumn id_pupuk;
        private DataGridViewTextBoxColumn nama_pupuk;
        private DataGridViewTextBoxColumn status;
        private Label lblTotalStock;
        private Label lblJenisPupuk;
        private Button btnTambah;
        private Button btnDelete;
        private Button btnUpdate;
        private PictureBox pictureBox2;
        private Button btnLogout;
        private Button btnKelolaTahapan;
    }
}