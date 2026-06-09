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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KelolaStock));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            btnHistory = new Button();
            btnTahapan = new Button();
            btnKelolaStock = new Button();
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
            panel1.Controls.Add(btnKelolaStock);
            panel1.Controls.Add(btnKelPupuk);
            panel1.Controls.Add(btnKelolaUser);
            panel1.Controls.Add(logo);
            panel1.Controls.Add(btnDashboard);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(210, 449);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logout;
            pictureBox1.Location = new Point(42, 622);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(90, 622);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(64, 22);
            button1.TabIndex = 6;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnHistory
            // 
            btnHistory.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHistory.Location = new Point(29, 458);
            btnHistory.Margin = new Padding(2, 2, 2, 2);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(150, 40);
            btnHistory.TabIndex = 5;
            btnHistory.Text = "History Transaksi";
            btnHistory.UseVisualStyleBackColor = true;
            // 
            // btnTahapan
            // 
            btnTahapan.BackColor = Color.Black;
            btnTahapan.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTahapan.ForeColor = Color.White;
            btnTahapan.Location = new Point(29, 401);
            btnTahapan.Margin = new Padding(2, 2, 2, 2);
            btnTahapan.Name = "btnTahapan";
            btnTahapan.Size = new Size(150, 40);
            btnTahapan.TabIndex = 1;
            btnTahapan.Text = "Kelola Tahapan";
            btnTahapan.UseVisualStyleBackColor = false;
            // 
            // btnKelolaStock
            // 
            btnKelolaStock.BackColor = Color.White;
            btnKelolaStock.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKelolaStock.Location = new Point(29, 345);
            btnKelolaStock.Margin = new Padding(2, 2, 2, 2);
            btnKelolaStock.Name = "btnKelolaStock";
            btnKelolaStock.Size = new Size(150, 40);
            btnKelolaStock.TabIndex = 4;
            btnKelolaStock.Text = "Kelola Stock";
            btnKelolaStock.UseVisualStyleBackColor = false;
            // 
            // btnKelPupuk
            // 
            btnKelPupuk.BackColor = Color.Black;
            btnKelPupuk.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKelPupuk.ForeColor = Color.White;
            btnKelPupuk.Location = new Point(29, 281);
            btnKelPupuk.Margin = new Padding(2, 2, 2, 2);
            btnKelPupuk.Name = "btnKelPupuk";
            btnKelPupuk.Size = new Size(150, 40);
            btnKelPupuk.TabIndex = 3;
            btnKelPupuk.Text = "Kelola Pupuk";
            btnKelPupuk.UseVisualStyleBackColor = false;
            btnKelPupuk.Click += btnKelPupuk_Click;
            // 
            // btnKelolaUser
            // 
            btnKelolaUser.BackColor = Color.Black;
            btnKelolaUser.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKelolaUser.ForeColor = Color.White;
            btnKelolaUser.Location = new Point(29, 224);
            btnKelolaUser.Margin = new Padding(2, 2, 2, 2);
            btnKelolaUser.Name = "btnKelolaUser";
            btnKelolaUser.Size = new Size(150, 40);
            btnKelolaUser.TabIndex = 2;
            btnKelolaUser.Text = "Kelola User";
            btnKelolaUser.UseVisualStyleBackColor = false;
            btnKelolaUser.Click += btnKelolaUser_Click;
            // 
            // logo
            // 
            logo.Image = Properties.Resources.logo_dan_teks_pojok;
            logo.Location = new Point(2, 2);
            logo.Margin = new Padding(2, 2, 2, 2);
            logo.Name = "logo";
            logo.Size = new Size(208, 149);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 1;
            logo.TabStop = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Black;
            btnDashboard.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(29, 163);
            btnDashboard.Margin = new Padding(2, 2, 2, 2);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(150, 40);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
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
            panel2.Location = new Point(210, 0);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(749, 449);
            panel2.TabIndex = 1;
            // 
            // lblPeringatan
            // 
            lblPeringatan.AutoSize = true;
            lblPeringatan.Font = new Font("Arial", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPeringatan.Location = new Point(410, 84);
            lblPeringatan.Margin = new Padding(2, 0, 2, 0);
            lblPeringatan.Name = "lblPeringatan";
            lblPeringatan.Size = new Size(32, 35);
            lblPeringatan.TabIndex = 4;
            lblPeringatan.Text = "0";
            // 
            // lblTotalStock
            // 
            lblTotalStock.AutoSize = true;
            lblTotalStock.Font = new Font("Arial", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalStock.Location = new Point(63, 91);
            lblTotalStock.Margin = new Padding(2, 0, 2, 0);
            lblTotalStock.Name = "lblTotalStock";
            lblTotalStock.Size = new Size(32, 35);
            lblTotalStock.TabIndex = 3;
            lblTotalStock.Text = "0";
            // 
            // btnDetail
            // 
            btnDetail.BackColor = SystemColors.ActiveCaptionText;
            btnDetail.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDetail.ForeColor = SystemColors.ButtonFace;
            btnDetail.Location = new Point(858, 95);
            btnDetail.Margin = new Padding(2, 2, 2, 2);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(127, 34);
            btnDetail.TabIndex = 2;
            btnDetail.Text = "Detail";
            btnDetail.UseVisualStyleBackColor = false;
            btnDetail.Click += btnDetail_Click;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = SystemColors.ActiveCaptionText;
            btnTambah.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambah.ForeColor = SystemColors.Control;
            btnTambah.Location = new Point(924, 183);
            btnTambah.Margin = new Padding(2, 2, 2, 2);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(127, 26);
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
            dgvPupuk.Location = new Point(48, 230);
            dgvPupuk.Margin = new Padding(2, 2, 2, 2);
            dgvPupuk.Name = "dgvPupuk";
            dgvPupuk.RowHeadersWidth = 62;
            dgvPupuk.Size = new Size(1021, 322);
            dgvPupuk.TabIndex = 0;
            // 
            // KelolaStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 449);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
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
        private Button btnKelolaStock;
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