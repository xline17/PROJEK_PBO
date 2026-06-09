namespace projek_PBOSQL.VIEWS
{
    partial class KelolaStock
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            btnHistory = new Button();
            btnTahapan = new Button();
            button3 = new Button();
            btnKelPupuk = new Button();
            btnKelolaUser = new Button();
            logo = new PictureBox();
            btnDashboard = new Button();
            panel2 = new Panel();
            lblPeringatan = new Label();
            lblTotalStock = new Label();
            btnDetail = new Button();
            btnTambah = new Button();
            dgvPupuk = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPupuk).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnHistory);
            panel1.Controls.Add(btnTahapan);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btnKelPupuk);
            panel1.Controls.Add(btnKelolaUser);
            panel1.Controls.Add(logo);
            panel1.Controls.Add(btnDashboard);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 1144);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logout;
            pictureBox1.Location = new Point(60, 1036);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(129, 1036);
            button1.Name = "button1";
            button1.Size = new Size(91, 36);
            button1.TabIndex = 6;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnHistory
            // 
            btnHistory.Font = new Font("Helvetica", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHistory.Location = new Point(42, 764);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(215, 67);
            btnHistory.TabIndex = 5;
            btnHistory.Text = "History Transaksi";
            btnHistory.UseVisualStyleBackColor = true;
            // 
            // btnTahapan
            // 
            btnTahapan.Font = new Font("Helvetica", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTahapan.Location = new Point(42, 669);
            btnTahapan.Name = "btnTahapan";
            btnTahapan.Size = new Size(215, 67);
            btnTahapan.TabIndex = 1;
            btnTahapan.Text = "Kelola Tahapan";
            btnTahapan.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Helvetica", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(42, 575);
            button3.Name = "button3";
            button3.Size = new Size(215, 67);
            button3.TabIndex = 4;
            button3.Text = "Kelola Stock";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnKelPupuk
            // 
            btnKelPupuk.Font = new Font("Helvetica", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKelPupuk.Location = new Point(42, 469);
            btnKelPupuk.Name = "btnKelPupuk";
            btnKelPupuk.Size = new Size(215, 67);
            btnKelPupuk.TabIndex = 3;
            btnKelPupuk.Text = "Kelola Pupuk";
            btnKelPupuk.UseVisualStyleBackColor = true;
            btnKelPupuk.Click += btnKelPupuk_Click;
            // 
            // btnKelolaUser
            // 
            btnKelolaUser.Font = new Font("Helvetica", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKelolaUser.Location = new Point(42, 374);
            btnKelolaUser.Name = "btnKelolaUser";
            btnKelolaUser.Size = new Size(215, 67);
            btnKelolaUser.TabIndex = 2;
            btnKelolaUser.Text = "Kelola User";
            btnKelolaUser.UseVisualStyleBackColor = true;
            btnKelolaUser.Click += btnKelolaUser_Click;
            // 
            // logo
            // 
            logo.Image = Properties.Resources.logo_dan_teks_pojok;
            logo.Location = new Point(3, 3);
            logo.Name = "logo";
            logo.Size = new Size(297, 249);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 1;
            logo.TabStop = false;
            // 
            // btnDashboard
            // 
            btnDashboard.Font = new Font("Helvetica", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.Location = new Point(42, 272);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(215, 67);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.Ukuran_kelola_stock_Pupuk;
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Controls.Add(lblPeringatan);
            panel2.Controls.Add(lblTotalStock);
            panel2.Controls.Add(btnDetail);
            panel2.Controls.Add(btnTambah);
            panel2.Controls.Add(dgvPupuk);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(300, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1598, 1144);
            panel2.TabIndex = 1;
            // 
            // lblPeringatan
            // 
            lblPeringatan.AutoSize = true;
            lblPeringatan.Font = new Font("Helvetica", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPeringatan.Location = new Point(585, 140);
            lblPeringatan.Name = "lblPeringatan";
            lblPeringatan.Size = new Size(46, 52);
            lblPeringatan.TabIndex = 4;
            lblPeringatan.Text = "0";
            // 
            // lblTotalStock
            // 
            lblTotalStock.AutoSize = true;
            lblTotalStock.Font = new Font("Helvetica", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalStock.Location = new Point(90, 152);
            lblTotalStock.Name = "lblTotalStock";
            lblTotalStock.Size = new Size(46, 52);
            lblTotalStock.TabIndex = 3;
            lblTotalStock.Text = "0";
            // 
            // btnDetail
            // 
            btnDetail.BackColor = SystemColors.ActiveCaptionText;
            btnDetail.Font = new Font("Helvetica", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDetail.ForeColor = SystemColors.ButtonFace;
            btnDetail.Location = new Point(1226, 159);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(182, 57);
            btnDetail.TabIndex = 2;
            btnDetail.Text = "Detail";
            btnDetail.UseVisualStyleBackColor = false;
            btnDetail.Click += btnDetail_Click;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = SystemColors.ActiveCaptionText;
            btnTambah.Font = new Font("Helvetica", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambah.ForeColor = SystemColors.Control;
            btnTambah.Location = new Point(1320, 305);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(182, 43);
            btnTambah.TabIndex = 1;
            btnTambah.Text = "+ Tambah Stock";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // dgvPupuk
            // 
            dgvPupuk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPupuk.BackgroundColor = SystemColors.ControlLight;
            dgvPupuk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPupuk.Location = new Point(68, 383);
            dgvPupuk.Name = "dgvPupuk";
            dgvPupuk.RowHeadersWidth = 62;
            dgvPupuk.Size = new Size(1458, 536);
            dgvPupuk.TabIndex = 0;
            // 
            // KelolaStock
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1144);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "KelolaStock";
            Text = "KelolaStock";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPupuk).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox logo;
        private Button btnDashboard;
        private Panel panel2;
        private Button btnHistory;
        private Button btnTahapan;
        private Button button3;
        private Button btnKelPupuk;
        private Button btnKelolaUser;
        private Button btnTambah;
        private DataGridView dgvPupuk;
        private Button btnDetail;
        private Label lblPeringatan;
        private Label lblTotalStock;
        private PictureBox pictureBox1;
        private Button button1;
    }
}