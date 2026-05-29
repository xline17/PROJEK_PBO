namespace projek_PBOSQL.VIEWS
{
    partial class ADMIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADMIN));
            panelSideBar = new Panel();
            btnhistoriTransaksi = new Button();
            btnkelolaTahapan = new Button();
            btnkelolaPupuk = new Button();
            btnkelolaUser = new Button();
            btnDashboardAdmin = new Button();
            pictureBox1 = new PictureBox();
            panelMainContent = new Panel();
            panelSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelSideBar
            // 
            panelSideBar.Controls.Add(btnhistoriTransaksi);
            panelSideBar.Controls.Add(btnkelolaTahapan);
            panelSideBar.Controls.Add(btnkelolaPupuk);
            panelSideBar.Controls.Add(btnkelolaUser);
            panelSideBar.Controls.Add(btnDashboardAdmin);
            panelSideBar.Controls.Add(pictureBox1);
            panelSideBar.Dock = DockStyle.Left;
            panelSideBar.Location = new Point(0, 0);
            panelSideBar.Name = "panelSideBar";
            panelSideBar.Size = new Size(162, 450);
            panelSideBar.TabIndex = 0;
            // 
            // btnhistoriTransaksi
            // 
            btnhistoriTransaksi.BackColor = Color.Black;
            btnhistoriTransaksi.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnhistoriTransaksi.ForeColor = Color.White;
            btnhistoriTransaksi.Location = new Point(9, 345);
            btnhistoriTransaksi.Name = "btnhistoriTransaksi";
            btnhistoriTransaksi.Size = new Size(145, 38);
            btnhistoriTransaksi.TabIndex = 0;
            btnhistoriTransaksi.Text = "Histori Transaksi";
            btnhistoriTransaksi.TextAlign = ContentAlignment.MiddleLeft;
            btnhistoriTransaksi.UseVisualStyleBackColor = false;
            btnhistoriTransaksi.Click += btnhistoriTransaksi_Click;
            // 
            // btnkelolaTahapan
            // 
            btnkelolaTahapan.BackColor = Color.Black;
            btnkelolaTahapan.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnkelolaTahapan.ForeColor = Color.White;
            btnkelolaTahapan.Location = new Point(9, 291);
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
            btnkelolaPupuk.Location = new Point(9, 238);
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
            btnkelolaUser.Location = new Point(9, 186);
            btnkelolaUser.Name = "btnkelolaUser";
            btnkelolaUser.Size = new Size(145, 38);
            btnkelolaUser.TabIndex = 0;
            btnkelolaUser.Text = "Kelola User";
            btnkelolaUser.TextAlign = ContentAlignment.MiddleLeft;
            btnkelolaUser.UseVisualStyleBackColor = false;
            btnkelolaUser.Click += button1_Click;
            // 
            // btnDashboardAdmin
            // 
            btnDashboardAdmin.BackColor = Color.White;
            btnDashboardAdmin.BackgroundImageLayout = ImageLayout.Stretch;
            btnDashboardAdmin.FlatAppearance.BorderSize = 0;
            btnDashboardAdmin.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboardAdmin.ForeColor = Color.Black;
            btnDashboardAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboardAdmin.Location = new Point(9, 136);
            btnDashboardAdmin.Margin = new Padding(0);
            btnDashboardAdmin.Name = "btnDashboardAdmin";
            btnDashboardAdmin.RightToLeft = RightToLeft.No;
            btnDashboardAdmin.Size = new Size(145, 38);
            btnDashboardAdmin.TabIndex = 0;
            btnDashboardAdmin.Text = "Dashboard";
            btnDashboardAdmin.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboardAdmin.UseVisualStyleBackColor = false;
            btnDashboardAdmin.Click += buttonDashboardAdmin_Click;
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
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panelMainContent
            // 
            panelMainContent.BackColor = Color.White;
            panelMainContent.Dock = DockStyle.Fill;
            panelMainContent.Location = new Point(162, 0);
            panelMainContent.Name = "panelMainContent";
            panelMainContent.Size = new Size(638, 450);
            panelMainContent.TabIndex = 1;
            // 
            // ADMIN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(panelMainContent);
            Controls.Add(panelSideBar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ADMIN";
            Text = "KancaTani";
            Load += ADMIN_Load;
            panelSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideBar;
        private PictureBox pictureBox1;
        private Panel panelMainContent;
        private Button btnDashboardAdmin;
        private Button btnkelolaPupuk;
        private Button btnkelolaUser;
        private Button btnhistoriTransaksi;
        private Button btnkelolaTahapan;
    }
}