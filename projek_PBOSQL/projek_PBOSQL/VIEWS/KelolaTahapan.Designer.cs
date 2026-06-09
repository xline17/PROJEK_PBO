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
            panelSideBar = new Panel();
            button1 = new Button();
            btnKelolaStock = new Button();
            btnkelolaTahapan = new Button();
            btnkelolaPupuk = new Button();
            btnkelolaUser = new Button();
            btnDashboardAdmin = new Button();
            pictureBox1 = new PictureBox();
            panelMainContent = new Panel();
            dataGridView1 = new DataGridView();
            id_fase = new DataGridViewTextBoxColumn();
            nama_fase = new DataGridViewTextBoxColumn();
            umur_min = new DataGridViewTextBoxColumn();
            umur_max = new DataGridViewTextBoxColumn();
            nama_tanaman = new DataGridViewTextBoxColumn();
            panelSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMainContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelSideBar
            // 
            panelSideBar.Controls.Add(button1);
            panelSideBar.Controls.Add(btnKelolaStock);
            panelSideBar.Controls.Add(btnkelolaTahapan);
            panelSideBar.Controls.Add(btnkelolaPupuk);
            panelSideBar.Controls.Add(btnkelolaUser);
            panelSideBar.Controls.Add(btnDashboardAdmin);
            panelSideBar.Controls.Add(pictureBox1);
            panelSideBar.Dock = DockStyle.Left;
            panelSideBar.Location = new Point(0, 0);
            panelSideBar.Name = "panelSideBar";
            panelSideBar.Size = new Size(162, 749);
            panelSideBar.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(33, 387);
            button1.Name = "button1";
            button1.Size = new Size(91, 28);
            button1.TabIndex = 7;
            button1.Text = "LOG OUT";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnKelolaStock
            // 
            btnKelolaStock.BackColor = Color.Black;
            btnKelolaStock.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnKelolaStock.ForeColor = Color.White;
            btnKelolaStock.Location = new Point(9, 293);
            btnKelolaStock.Name = "btnKelolaStock";
            btnKelolaStock.Size = new Size(145, 38);
            btnKelolaStock.TabIndex = 3;
            btnKelolaStock.Text = "Kelola Stock";
            btnKelolaStock.TextAlign = ContentAlignment.MiddleLeft;
            btnKelolaStock.UseVisualStyleBackColor = false;
            btnKelolaStock.Click += btnKelolaStock_Click;
            // 
            // btnkelolaTahapan
            // 
            btnkelolaTahapan.BackColor = Color.White;
            btnkelolaTahapan.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnkelolaTahapan.ForeColor = Color.Black;
            btnkelolaTahapan.Location = new Point(9, 343);
            btnkelolaTahapan.Name = "btnkelolaTahapan";
            btnkelolaTahapan.Size = new Size(145, 38);
            btnkelolaTahapan.TabIndex = 0;
            btnkelolaTahapan.Text = "Kelola Tahapan";
            btnkelolaTahapan.TextAlign = ContentAlignment.MiddleLeft;
            btnkelolaTahapan.UseVisualStyleBackColor = false;
            btnkelolaTahapan.Click += btnkelolaTahapan_Click;
            // 
            // btnkelolaPupuk
            // 
            btnkelolaPupuk.BackColor = Color.Black;
            btnkelolaPupuk.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnkelolaPupuk.ForeColor = Color.White;
            btnkelolaPupuk.Location = new Point(9, 242);
            btnkelolaPupuk.Name = "btnkelolaPupuk";
            btnkelolaPupuk.Size = new Size(145, 38);
            btnkelolaPupuk.TabIndex = 0;
            btnkelolaPupuk.Text = "Kelola Pupuk";
            btnkelolaPupuk.TextAlign = ContentAlignment.MiddleLeft;
            btnkelolaPupuk.UseVisualStyleBackColor = false;
            btnkelolaPupuk.Click += btnkelolaPupuk_Click;
            // 
            // btnkelolaUser
            // 
            btnkelolaUser.BackColor = Color.Black;
            btnkelolaUser.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnkelolaUser.ForeColor = Color.White;
            btnkelolaUser.Location = new Point(9, 193);
            btnkelolaUser.Name = "btnkelolaUser";
            btnkelolaUser.Size = new Size(145, 38);
            btnkelolaUser.TabIndex = 0;
            btnkelolaUser.Text = "Kelola User";
            btnkelolaUser.TextAlign = ContentAlignment.MiddleLeft;
            btnkelolaUser.UseVisualStyleBackColor = false;
            btnkelolaUser.Click += btnkelolaUser_Click;
            // 
            // btnDashboardAdmin
            // 
            btnDashboardAdmin.BackColor = Color.Black;
            btnDashboardAdmin.BackgroundImageLayout = ImageLayout.Stretch;
            btnDashboardAdmin.FlatAppearance.BorderSize = 0;
            btnDashboardAdmin.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboardAdmin.ForeColor = Color.White;
            btnDashboardAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboardAdmin.Location = new Point(9, 144);
            btnDashboardAdmin.Margin = new Padding(0);
            btnDashboardAdmin.Name = "btnDashboardAdmin";
            btnDashboardAdmin.RightToLeft = RightToLeft.No;
            btnDashboardAdmin.Size = new Size(145, 38);
            btnDashboardAdmin.TabIndex = 0;
            btnDashboardAdmin.Text = "Dashboard";
            btnDashboardAdmin.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboardAdmin.UseVisualStyleBackColor = false;
            btnDashboardAdmin.Click += btnDashboardAdmin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.logo_dan_teks_pojok;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 122);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panelMainContent
            // 
            panelMainContent.BackColor = Color.White;
            panelMainContent.Controls.Add(dataGridView1);
            panelMainContent.Dock = DockStyle.Fill;
            panelMainContent.Location = new Point(162, 0);
            panelMainContent.Name = "panelMainContent";
            panelMainContent.Size = new Size(1208, 749);
            panelMainContent.TabIndex = 2;
            panelMainContent.Paint += panelMainContent_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id_fase, nama_fase, umur_min, umur_max, nama_tanaman });
            dataGridView1.Location = new Point(21, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(544, 315);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // id_fase
            // 
            id_fase.HeaderText = "id_fase";
            id_fase.Name = "id_fase";
            // 
            // nama_fase
            // 
            nama_fase.HeaderText = "nama_fase";
            nama_fase.Name = "nama_fase";
            // 
            // umur_min
            // 
            umur_min.HeaderText = "umur_min";
            umur_min.Name = "umur_min";
            // 
            // umur_max
            // 
            umur_max.HeaderText = "umur_max";
            umur_max.Name = "umur_max";
            // 
            // nama_tanaman
            // 
            nama_tanaman.HeaderText = "nama_tanaman";
            nama_tanaman.Name = "nama_tanaman";
            // 
            // KelolaTahapan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1370, 749);
            Controls.Add(panelMainContent);
            Controls.Add(panelSideBar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "KelolaTahapan";
            Text = "KelolaTahapan";
            WindowState = FormWindowState.Maximized;
            Load += KelolaTahapan_Load;
            panelSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMainContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideBar;
        private Button btnKelolaStock;
        private Button btnkelolaTahapan;
        private Button btnkelolaPupuk;
        private Button btnkelolaUser;
        private Button btnDashboardAdmin;
        private PictureBox pictureBox1;
        private Panel panelMainContent;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id_fase;
        private DataGridViewTextBoxColumn nama_fase;
        private DataGridViewTextBoxColumn umur_min;
        private DataGridViewTextBoxColumn umur_max;
        private DataGridViewTextBoxColumn nama_tanaman;
    }
}