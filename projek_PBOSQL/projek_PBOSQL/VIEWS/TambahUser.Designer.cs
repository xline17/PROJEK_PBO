namespace projek_PBOSQL.VIEWS
{
    partial class TambahUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TambahUser));
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtNoTelp = new TextBox();
            Simpan = new Button();
            RbAdmin = new RadioButton();
            RbPetani = new RadioButton();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Location = new Point(97, 38);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(259, 20);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Location = new Point(97, 98);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(259, 20);
            txtPassword.TabIndex = 1;
            // 
            // txtNoTelp
            // 
            txtNoTelp.BackColor = Color.White;
            txtNoTelp.BorderStyle = BorderStyle.None;
            txtNoTelp.Location = new Point(97, 162);
            txtNoTelp.Name = "txtNoTelp";
            txtNoTelp.Size = new Size(259, 20);
            txtNoTelp.TabIndex = 2;
            // 
            // Simpan
            // 
            Simpan.Location = new Point(178, 252);
            Simpan.Name = "Simpan";
            Simpan.Size = new Size(94, 30);
            Simpan.TabIndex = 3;
            Simpan.Text = "Simpan";
            Simpan.UseVisualStyleBackColor = true;
            Simpan.Click += Simpan_Click;
            // 
            // RbAdmin
            // 
            RbAdmin.AutoSize = true;
            RbAdmin.BackColor = Color.White;
            RbAdmin.Location = new Point(97, 224);
            RbAdmin.Name = "RbAdmin";
            RbAdmin.Size = new Size(74, 24);
            RbAdmin.TabIndex = 4;
            RbAdmin.TabStop = true;
            RbAdmin.Text = "Admin";
            RbAdmin.UseVisualStyleBackColor = false;
            // 
            // RbPetani
            // 
            RbPetani.AutoSize = true;
            RbPetani.BackColor = Color.White;
            RbPetani.Location = new Point(282, 224);
            RbPetani.Name = "RbPetani";
            RbPetani.Size = new Size(70, 24);
            RbPetani.TabIndex = 5;
            RbPetani.TabStop = true;
            RbPetani.Text = "Petani";
            RbPetani.UseVisualStyleBackColor = false;
            // 
            // TambahUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(432, 292);
            Controls.Add(RbPetani);
            Controls.Add(RbAdmin);
            Controls.Add(Simpan);
            Controls.Add(txtNoTelp);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TambahUser";
            Text = "TambahUser";
            Load += TambahUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtNoTelp;
        private Button Simpan;
        private RadioButton RbAdmin;
        private RadioButton RbPetani;
    }
}