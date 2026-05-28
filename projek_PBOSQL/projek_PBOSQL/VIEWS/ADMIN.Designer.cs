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
            pictureBox2 = new PictureBox();
            buttonDashboardAdmin = new Button();
            pictureBox1 = new PictureBox();
            panelMainContent = new Panel();
            panelSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelSideBar
            // 
            panelSideBar.BackgroundImage = Properties.Resources.BG_DASHBOARD_ADMIN;
            panelSideBar.Controls.Add(pictureBox2);
            panelSideBar.Controls.Add(buttonDashboardAdmin);
            panelSideBar.Controls.Add(pictureBox1);
            panelSideBar.Dock = DockStyle.Left;
            panelSideBar.Location = new Point(0, 0);
            panelSideBar.Name = "panelSideBar";
            panelSideBar.Size = new Size(142, 450);
            panelSideBar.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.icon_dashboard;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(17, 143);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(23, 23);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // buttonDashboardAdmin
            // 
            buttonDashboardAdmin.BackColor = Color.ForestGreen;
            buttonDashboardAdmin.BackgroundImageLayout = ImageLayout.Stretch;
            buttonDashboardAdmin.FlatAppearance.BorderSize = 0;
            buttonDashboardAdmin.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDashboardAdmin.ForeColor = Color.White;
            buttonDashboardAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDashboardAdmin.Location = new Point(9, 136);
            buttonDashboardAdmin.Margin = new Padding(0);
            buttonDashboardAdmin.Name = "buttonDashboardAdmin";
            buttonDashboardAdmin.RightToLeft = RightToLeft.No;
            buttonDashboardAdmin.Size = new Size(124, 38);
            buttonDashboardAdmin.TabIndex = 0;
            buttonDashboardAdmin.Text = "Dashboard";
            buttonDashboardAdmin.TextAlign = ContentAlignment.MiddleRight;
            buttonDashboardAdmin.UseVisualStyleBackColor = false;
            buttonDashboardAdmin.Click += buttonDashboardAdmin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.logo_dan_teks_pojok;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 113);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panelMainContent
            // 
            panelMainContent.BackColor = Color.White;
            panelMainContent.Dock = DockStyle.Fill;
            panelMainContent.Location = new Point(142, 0);
            panelMainContent.Name = "panelMainContent";
            panelMainContent.Size = new Size(658, 450);
            panelMainContent.TabIndex = 1;
            // 
            // ADMIN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            BackgroundImage = Properties.Resources.BG_DASHBOARD_ADMIN;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(panelMainContent);
            Controls.Add(panelSideBar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ADMIN";
            Text = "KancaTani";
            panelSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideBar;
        private PictureBox pictureBox1;
        private Panel panelMainContent;
        private Button buttonDashboardAdmin;
        private PictureBox pictureBox2;
    }
}