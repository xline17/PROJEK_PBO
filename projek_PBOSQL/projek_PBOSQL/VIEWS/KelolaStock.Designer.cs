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
            dgvPupuk = new DataGridView();
            btnTambah = new Button();
            btnDetail = new Button();
            lblTotalStock = new Label();
            lblPeringatan = new Label();
            panel2 = new Panel();
            btnDashboard = new Button();
            btnKelolaUser = new Button();
            btnKelPupuk = new Button();
            btnKelolaStock = new Button();
            btnTahapan = new Button();
            btnHistory = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel6 = new Panel();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            btnKelTah = new Button();
            pictureBox3 = new PictureBox();
            button3 = new Button();
            btnKelStok = new Button();
            btnKelPuk = new Button();
            btnKel = new Button();
            btndash = new Button();
            pictureBox6 = new PictureBox();
            button11 = new Button();
            pictureBox7 = new PictureBox();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPupuk).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // dgvPupuk
            // 
            dgvPupuk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPupuk.BackgroundColor = SystemColors.ControlLight;
            dgvPupuk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPupuk.Location = new Point(95, 365);
            dgvPupuk.Margin = new Padding(2, 3, 2, 3);
            dgvPupuk.Name = "dgvPupuk";
            dgvPupuk.RowHeadersWidth = 62;
            dgvPupuk.Size = new Size(1473, 718);
            dgvPupuk.TabIndex = 0;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = SystemColors.ActiveCaptionText;
            btnTambah.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambah.ForeColor = SystemColors.Control;
            btnTambah.Location = new Point(1324, 302);
            btnTambah.Margin = new Padding(2, 3, 2, 3);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(216, 54);
            btnTambah.TabIndex = 1;
            btnTambah.Text = "+ Tambah Stock";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnDetail
            // 
            btnDetail.BackColor = SystemColors.ActiveCaptionText;
            btnDetail.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDetail.ForeColor = SystemColors.ButtonFace;
            btnDetail.Location = new Point(1246, 159);
            btnDetail.Margin = new Padding(2, 3, 2, 3);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(129, 53);
            btnDetail.TabIndex = 2;
            btnDetail.Text = "Detail";
            btnDetail.UseVisualStyleBackColor = false;
            btnDetail.Click += btnDetail_Click;
            // 
            // lblTotalStock
            // 
            lblTotalStock.AutoSize = true;
            lblTotalStock.BackColor = Color.White;
            lblTotalStock.Font = new Font("Arial", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalStock.Location = new Point(105, 143);
            lblTotalStock.Margin = new Padding(2, 0, 2, 0);
            lblTotalStock.Name = "lblTotalStock";
            lblTotalStock.Size = new Size(40, 44);
            lblTotalStock.TabIndex = 3;
            lblTotalStock.Text = "0";
            // 
            // lblPeringatan
            // 
            lblPeringatan.AutoSize = true;
            lblPeringatan.BackColor = Color.White;
            lblPeringatan.Font = new Font("Arial", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPeringatan.Location = new Point(602, 143);
            lblPeringatan.Margin = new Padding(2, 0, 2, 0);
            lblPeringatan.Name = "lblPeringatan";
            lblPeringatan.Size = new Size(40, 44);
            lblPeringatan.TabIndex = 4;
            lblPeringatan.Text = "0";
            lblPeringatan.Click += lblPeringatan_Click;
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
            panel2.Location = new Point(256, 0);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1646, 1153);
            panel2.TabIndex = 1;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Black;
            btnDashboard.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(33, 217);
            btnDashboard.Margin = new Padding(2, 3, 2, 3);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(171, 53);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnKelolaUser
            // 
            btnKelolaUser.BackColor = Color.Black;
            btnKelolaUser.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKelolaUser.ForeColor = Color.White;
            btnKelolaUser.Location = new Point(33, 299);
            btnKelolaUser.Margin = new Padding(2, 3, 2, 3);
            btnKelolaUser.Name = "btnKelolaUser";
            btnKelolaUser.Size = new Size(171, 53);
            btnKelolaUser.TabIndex = 2;
            btnKelolaUser.Text = "Kelola User";
            btnKelolaUser.UseVisualStyleBackColor = false;
            // 
            // btnKelPupuk
            // 
            btnKelPupuk.BackColor = Color.Black;
            btnKelPupuk.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKelPupuk.ForeColor = Color.White;
            btnKelPupuk.Location = new Point(33, 375);
            btnKelPupuk.Margin = new Padding(2, 3, 2, 3);
            btnKelPupuk.Name = "btnKelPupuk";
            btnKelPupuk.Size = new Size(171, 53);
            btnKelPupuk.TabIndex = 3;
            btnKelPupuk.Text = "Kelola Pupuk";
            btnKelPupuk.UseVisualStyleBackColor = false;
            // 
            // btnKelolaStock
            // 
            btnKelolaStock.BackColor = Color.White;
            btnKelolaStock.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKelolaStock.Location = new Point(33, 460);
            btnKelolaStock.Margin = new Padding(2, 3, 2, 3);
            btnKelolaStock.Name = "btnKelolaStock";
            btnKelolaStock.Size = new Size(171, 53);
            btnKelolaStock.TabIndex = 4;
            btnKelolaStock.Text = "Kelola Stock";
            btnKelolaStock.UseVisualStyleBackColor = false;
            // 
            // btnTahapan
            // 
            btnTahapan.BackColor = Color.Black;
            btnTahapan.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTahapan.ForeColor = Color.White;
            btnTahapan.Location = new Point(33, 535);
            btnTahapan.Margin = new Padding(2, 3, 2, 3);
            btnTahapan.Name = "btnTahapan";
            btnTahapan.Size = new Size(171, 53);
            btnTahapan.TabIndex = 1;
            btnTahapan.Text = "Kelola Tahapan";
            btnTahapan.UseVisualStyleBackColor = false;
            // 
            // btnHistory
            // 
            btnHistory.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHistory.Location = new Point(33, 611);
            btnHistory.Margin = new Padding(2, 3, 2, 3);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(171, 53);
            btnHistory.TabIndex = 5;
            btnHistory.Text = "History Transaksi";
            btnHistory.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(103, 829);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(73, 29);
            button1.TabIndex = 6;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logout;
            pictureBox1.Location = new Point(48, 829);
            pictureBox1.Margin = new Padding(2, 3, 2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnHistory);
            panel1.Controls.Add(btnTahapan);
            panel1.Controls.Add(btnKelolaStock);
            panel1.Controls.Add(btnKelPupuk);
            panel1.Controls.Add(btnKelolaUser);
            panel1.Controls.Add(btnDashboard);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(256, 1153);
            panel1.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Controls.Add(panel3);
            panel6.Controls.Add(pictureBox6);
            panel6.Controls.Add(button11);
            panel6.Controls.Add(pictureBox7);
            panel6.Controls.Add(button12);
            panel6.Controls.Add(button13);
            panel6.Controls.Add(button14);
            panel6.Controls.Add(button15);
            panel6.Controls.Add(button16);
            panel6.Location = new Point(4, 4);
            panel6.Margin = new Padding(1);
            panel6.Name = "panel6";
            panel6.Size = new Size(240, 1153);
            panel6.TabIndex = 12;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(btnKelTah);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(btnKelStok);
            panel3.Controls.Add(btnKelPuk);
            panel3.Controls.Add(btnKel);
            panel3.Controls.Add(btndash);
            panel3.Location = new Point(8, 8);
            panel3.Margin = new Padding(1);
            panel3.Name = "panel3";
            panel3.Size = new Size(240, 1153);
            panel3.TabIndex = 12;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo_dan_teks_pojok;
            pictureBox2.Location = new Point(11, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(215, 187);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // btnKelTah
            // 
            btnKelTah.BackColor = Color.Black;
            btnKelTah.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKelTah.ForeColor = Color.White;
            btnKelTah.Location = new Point(11, 516);
            btnKelTah.Margin = new Padding(1);
            btnKelTah.Name = "btnKelTah";
            btnKelTah.Size = new Size(217, 57);
            btnKelTah.TabIndex = 8;
            btnKelTah.Text = "Kelola Tahapan";
            btnKelTah.UseVisualStyleBackColor = false;
            btnKelTah.Click += btnKelTah_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.logout;
            pictureBox3.Location = new Point(30, 829);
            pictureBox3.Margin = new Padding(1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(41, 33);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 0, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(77, 826);
            button3.Margin = new Padding(1);
            button3.Name = "button3";
            button3.Size = new Size(124, 40);
            button3.TabIndex = 6;
            button3.Text = "Logout";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnKelStok
            // 
            btnKelStok.BackColor = Color.White;
            btnKelStok.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKelStok.ForeColor = Color.Black;
            btnKelStok.Location = new Point(11, 439);
            btnKelStok.Margin = new Padding(1);
            btnKelStok.Name = "btnKelStok";
            btnKelStok.Size = new Size(217, 57);
            btnKelStok.TabIndex = 4;
            btnKelStok.Text = "Kelola Stock";
            btnKelStok.UseVisualStyleBackColor = false;
            // 
            // btnKelPuk
            // 
            btnKelPuk.BackColor = Color.Black;
            btnKelPuk.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKelPuk.ForeColor = Color.White;
            btnKelPuk.Location = new Point(11, 361);
            btnKelPuk.Margin = new Padding(1);
            btnKelPuk.Name = "btnKelPuk";
            btnKelPuk.Size = new Size(217, 57);
            btnKelPuk.TabIndex = 3;
            btnKelPuk.Text = "Kelola Pupuk";
            btnKelPuk.UseVisualStyleBackColor = false;
            btnKelPuk.Click += btnKelPuk_Click;
            // 
            // btnKel
            // 
            btnKel.BackColor = Color.Black;
            btnKel.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKel.ForeColor = Color.White;
            btnKel.Location = new Point(11, 287);
            btnKel.Margin = new Padding(1);
            btnKel.Name = "btnKel";
            btnKel.Size = new Size(217, 57);
            btnKel.TabIndex = 2;
            btnKel.Text = "Kelola User";
            btnKel.UseVisualStyleBackColor = false;
            btnKel.Click += btnKel_Click;
            // 
            // btndash
            // 
            btndash.BackColor = Color.Black;
            btndash.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndash.ForeColor = Color.White;
            btndash.Location = new Point(11, 212);
            btndash.Margin = new Padding(1);
            btndash.Name = "btndash";
            btndash.Size = new Size(217, 57);
            btndash.TabIndex = 1;
            btndash.Text = "Dashboard";
            btndash.UseVisualStyleBackColor = false;
            btndash.Click += btndash_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.logo_dan_teks_pojok;
            pictureBox6.Location = new Point(11, 21);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(215, 187);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 9;
            pictureBox6.TabStop = false;
            // 
            // button11
            // 
            button11.BackColor = Color.Black;
            button11.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button11.ForeColor = Color.White;
            button11.Location = new Point(11, 516);
            button11.Margin = new Padding(1);
            button11.Name = "button11";
            button11.Size = new Size(217, 57);
            button11.TabIndex = 8;
            button11.Text = "Kelola Tahapan";
            button11.UseVisualStyleBackColor = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.logout;
            pictureBox7.Location = new Point(30, 829);
            pictureBox7.Margin = new Padding(1);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(41, 33);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 7;
            pictureBox7.TabStop = false;
            // 
            // button12
            // 
            button12.BackColor = Color.FromArgb(192, 0, 0);
            button12.ForeColor = SystemColors.ButtonHighlight;
            button12.Location = new Point(77, 826);
            button12.Margin = new Padding(1);
            button12.Name = "button12";
            button12.Size = new Size(124, 40);
            button12.TabIndex = 6;
            button12.Text = "Logout";
            button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            button13.BackColor = Color.Black;
            button13.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button13.ForeColor = Color.White;
            button13.Location = new Point(11, 439);
            button13.Margin = new Padding(1);
            button13.Name = "button13";
            button13.Size = new Size(217, 57);
            button13.TabIndex = 4;
            button13.Text = "Kelola Stock";
            button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            button14.BackColor = Color.Black;
            button14.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button14.ForeColor = Color.White;
            button14.Location = new Point(11, 361);
            button14.Margin = new Padding(1);
            button14.Name = "button14";
            button14.Size = new Size(217, 57);
            button14.TabIndex = 3;
            button14.Text = "Kelola Pupuk";
            button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            button15.BackColor = Color.Black;
            button15.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button15.ForeColor = Color.White;
            button15.Location = new Point(11, 287);
            button15.Margin = new Padding(1);
            button15.Name = "button15";
            button15.Size = new Size(217, 57);
            button15.TabIndex = 2;
            button15.Text = "Kelola User";
            button15.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            button16.BackColor = Color.White;
            button16.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button16.ForeColor = Color.Black;
            button16.Location = new Point(11, 212);
            button16.Margin = new Padding(1);
            button16.Name = "button16";
            button16.Size = new Size(217, 57);
            button16.TabIndex = 1;
            button16.Text = "Dashboard";
            button16.UseVisualStyleBackColor = false;
            // 
            // KelolaStock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1153);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            Name = "KelolaStock";
            Text = "KelolaStock";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvPupuk).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPupuk;
        private Button btnTambah;
        private Button btnDetail;
        private Label lblTotalStock;
        private Label lblPeringatan;
        private Panel panel2;
        private Button btnDashboard;
        private Button btnKelolaUser;
        private Button btnKelPupuk;
        private Button btnKelolaStock;
        private Button btnTahapan;
        private Button btnHistory;
        private Button button1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel6;
        private PictureBox pictureBox6;
        private Button button11;
        private PictureBox pictureBox7;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Button btnKelTah;
        private PictureBox pictureBox3;
        private Button button3;
        private Button btnKelStok;
        private Button btnKelPuk;
        private Button btnKel;
        private Button btndash;
    }
}