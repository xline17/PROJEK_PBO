namespace projek_PBOSQL.VIEWS
{
    partial class KelolaTahapan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KelolaTahapan));
            panelMainContent = new Panel();
            dataGridView1 = new DataGridView();
            id_fase = new DataGridViewTextBoxColumn();
            nama_fase = new DataGridViewTextBoxColumn();
            umur_min = new DataGridViewTextBoxColumn();
            umur_max = new DataGridViewTextBoxColumn();
            nama_tanaman = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnKelolaTahapan = new Button();
            pictureBox2 = new PictureBox();
            btnLogout = new Button();
            btnKelolaStock = new Button();
            btnKelolaPupuk = new Button();
            btnUser = new Button();
            btnDashboard = new Button();
            panelMainContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelMainContent
            // 
            panelMainContent.BackColor = Color.White;
            panelMainContent.Controls.Add(dataGridView1);
            panelMainContent.Location = new Point(247, 0);
            panelMainContent.Margin = new Padding(3, 4, 3, 4);
            panelMainContent.Name = "panelMainContent";
            panelMainContent.Size = new Size(1381, 999);
            panelMainContent.TabIndex = 2;
            panelMainContent.Paint += panelMainContent_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id_fase, nama_fase, umur_min, umur_max, nama_tanaman });
            dataGridView1.Location = new Point(24, 36);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(622, 420);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // id_fase
            // 
            id_fase.HeaderText = "id_fase";
            id_fase.MinimumWidth = 6;
            id_fase.Name = "id_fase";
            id_fase.Width = 125;
            // 
            // nama_fase
            // 
            nama_fase.HeaderText = "nama_fase";
            nama_fase.MinimumWidth = 6;
            nama_fase.Name = "nama_fase";
            nama_fase.Width = 125;
            // 
            // umur_min
            // 
            umur_min.HeaderText = "umur_min";
            umur_min.MinimumWidth = 6;
            umur_min.Name = "umur_min";
            umur_min.Width = 125;
            // 
            // umur_max
            // 
            umur_max.HeaderText = "umur_max";
            umur_max.MinimumWidth = 6;
            umur_max.Name = "umur_max";
            umur_max.Width = 125;
            // 
            // nama_tanaman
            // 
            nama_tanaman.HeaderText = "nama_tanaman";
            nama_tanaman.MinimumWidth = 6;
            nama_tanaman.Name = "nama_tanaman";
            nama_tanaman.Width = 125;
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
            panel1.Size = new Size(240, 999);
            panel1.TabIndex = 11;
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
            btnKelolaTahapan.BackColor = Color.White;
            btnKelolaTahapan.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKelolaTahapan.ForeColor = Color.Black;
            btnKelolaTahapan.Location = new Point(11, 516);
            btnKelolaTahapan.Margin = new Padding(1);
            btnKelolaTahapan.Name = "btnKelolaTahapan";
            btnKelolaTahapan.Size = new Size(217, 57);
            btnKelolaTahapan.TabIndex = 8;
            btnKelolaTahapan.Text = "Kelola Tahapan";
            btnKelolaTahapan.UseVisualStyleBackColor = false;
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
            btnKelolaStock.Click += btnKelolaStock_Click_1;
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
            btnUser.BackColor = Color.Black;
            btnUser.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUser.ForeColor = Color.White;
            btnUser.Location = new Point(11, 287);
            btnUser.Margin = new Padding(1);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(217, 57);
            btnUser.TabIndex = 2;
            btnUser.Text = "Kelola User";
            btnUser.UseVisualStyleBackColor = false;
            btnUser.Click += btnUser_Click;
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
            // KelolaTahapan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1566, 999);
            Controls.Add(panel1);
            Controls.Add(panelMainContent);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "KelolaTahapan";
            Text = "KelolaTahapan";
            WindowState = FormWindowState.Maximized;
            Load += KelolaTahapan_Load;
            panelMainContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMainContent;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id_fase;
        private DataGridViewTextBoxColumn nama_fase;
        private DataGridViewTextBoxColumn umur_min;
        private DataGridViewTextBoxColumn umur_max;
        private DataGridViewTextBoxColumn nama_tanaman;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnKelolaTahapan;
        private PictureBox pictureBox2;
        private Button btnLogout;
        private Button btnKelolaStock;
        private Button btnKelolaPupuk;
        private Button btnUser;
        private Button btnDashboard;
    }
}