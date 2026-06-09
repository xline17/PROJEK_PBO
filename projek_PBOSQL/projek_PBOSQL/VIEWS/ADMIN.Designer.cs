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
            btnKelolaStock = new Button();
            btnLogOut = new Button();
            btnkelolaTahapan = new Button();
            btnkelolaPupuk = new Button();
            btnkelolaUser = new Button();
            btnDashboardAdmin = new Button();
            pictureBox1 = new PictureBox();
            panelMainContent = new Panel();
            panel3 = new Panel();
            lblTotalJenisPupuk = new Label();
            lblJenisPupuk = new Label();
            panel2 = new Panel();
            lblTotalStokPupuk = new Label();
            label2 = new Label();
            panel1 = new Panel();
            lblTotalTransaksi = new Label();
            label1 = new Label();
            panelSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMainContent.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelSideBar
            // 
            panelSideBar.Controls.Add(btnKelolaStock);
            panelSideBar.Controls.Add(btnLogOut);
            panelSideBar.Controls.Add(btnkelolaTahapan);
            panelSideBar.Controls.Add(btnkelolaPupuk);
            panelSideBar.Controls.Add(btnkelolaUser);
            panelSideBar.Controls.Add(btnDashboardAdmin);
            panelSideBar.Controls.Add(pictureBox1);
            panelSideBar.Dock = DockStyle.Left;
            panelSideBar.Location = new Point(0, 0);
            panelSideBar.Name = "panelSideBar";
            panelSideBar.Size = new Size(162, 449);
            panelSideBar.TabIndex = 0;
            panelSideBar.Paint += panelSideBar_Paint;
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
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Red;
            btnLogOut.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(36, 490);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(91, 28);
            btnLogOut.TabIndex = 2;
            btnLogOut.Text = "LOG OUT";
            btnLogOut.UseVisualStyleBackColor = false;
            // 
            // btnkelolaTahapan
            // 
            btnkelolaTahapan.BackColor = Color.Black;
            btnkelolaTahapan.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnkelolaTahapan.ForeColor = Color.White;
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
            btnDashboardAdmin.Location = new Point(9, 144);
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
            panelMainContent.Controls.Add(panel3);
            panelMainContent.Controls.Add(panel2);
            panelMainContent.Controls.Add(panel1);
            panelMainContent.Dock = DockStyle.Fill;
            panelMainContent.Location = new Point(162, 0);
            panelMainContent.Name = "panelMainContent";
            panelMainContent.Size = new Size(797, 449);
            panelMainContent.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Controls.Add(lblTotalJenisPupuk);
            panel3.Controls.Add(lblJenisPupuk);
            panel3.ForeColor = Color.Transparent;
            panel3.Location = new Point(465, 19);
            panel3.Name = "panel3";
            panel3.Size = new Size(205, 102);
            panel3.TabIndex = 2;
            // 
            // lblTotalJenisPupuk
            // 
            lblTotalJenisPupuk.AutoSize = true;
            lblTotalJenisPupuk.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold);
            lblTotalJenisPupuk.ForeColor = Color.White;
            lblTotalJenisPupuk.Location = new Point(71, 39);
            lblTotalJenisPupuk.Name = "lblTotalJenisPupuk";
            lblTotalJenisPupuk.Size = new Size(40, 47);
            lblTotalJenisPupuk.TabIndex = 1;
            lblTotalJenisPupuk.Text = "0";
            // 
            // lblJenisPupuk
            // 
            lblJenisPupuk.AutoSize = true;
            lblJenisPupuk.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblJenisPupuk.ForeColor = Color.White;
            lblJenisPupuk.Location = new Point(35, 6);
            lblJenisPupuk.Name = "lblJenisPupuk";
            lblJenisPupuk.Size = new Size(152, 20);
            lblJenisPupuk.TabIndex = 0;
            lblJenisPupuk.Text = "TOTAL JENIS PUPUK";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(lblTotalStokPupuk);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(240, 19);
            panel2.Name = "panel2";
            panel2.Size = new Size(205, 102);
            panel2.TabIndex = 1;
            // 
            // lblTotalStokPupuk
            // 
            lblTotalStokPupuk.AutoSize = true;
            lblTotalStokPupuk.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold);
            lblTotalStokPupuk.ForeColor = Color.White;
            lblTotalStokPupuk.Location = new Point(59, 39);
            lblTotalStokPupuk.Name = "lblTotalStokPupuk";
            lblTotalStokPupuk.Size = new Size(40, 47);
            lblTotalStokPupuk.TabIndex = 1;
            lblTotalStokPupuk.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(29, 10);
            label2.Name = "label2";
            label2.Size = new Size(149, 20);
            label2.TabIndex = 0;
            label2.Text = "TOTAL STOK PUPUK";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(lblTotalTransaksi);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(15, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(205, 102);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // lblTotalTransaksi
            // 
            lblTotalTransaksi.AutoSize = true;
            lblTotalTransaksi.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalTransaksi.ForeColor = Color.White;
            lblTotalTransaksi.Location = new Point(77, 39);
            lblTotalTransaksi.Name = "lblTotalTransaksi";
            lblTotalTransaksi.Size = new Size(40, 47);
            lblTotalTransaksi.TabIndex = 1;
            lblTotalTransaksi.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 10);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 0;
            label1.Text = "TOTAL TRANSAKSI";
            label1.Click += label1_Click;
            // 
            // ADMIN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(959, 449);
            Controls.Add(panelMainContent);
            Controls.Add(panelSideBar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ADMIN";
            Text = "KancaTani";
            WindowState = FormWindowState.Maximized;
            Load += ADMIN_Load;
            panelSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMainContent.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideBar;
        private PictureBox pictureBox1;
        private Panel panelMainContent;
        private Button btnDashboardAdmin;
        private Button btnkelolaPupuk;
        private Button btnkelolaUser;
        private Button btnkelolaTahapan;
        private Button btnLogOut;
        private Panel panel1;
        private Label label1;
        private Label lblTotalTransaksi;
        private Panel panel2;
        private Label label2;
        private Label lblTotalStokPupuk;
        private Panel panel3;
        private Label lblJenisPupuk;
        private Label lblTotalJenisPupuk;
        private Button btnKelolaStock;
    }
}