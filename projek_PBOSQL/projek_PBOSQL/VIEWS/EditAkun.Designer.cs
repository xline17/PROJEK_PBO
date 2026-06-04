namespace projek_PBOSQL.VIEWS
{
    partial class EditAkun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAkun));
            txtEditUsername = new TextBox();
            txtEditPass = new TextBox();
            txtEditNotelp = new TextBox();
            btnSimpanEdit = new Button();
            SuspendLayout();
            // 
            // txtEditUsername
            // 
            txtEditUsername.BorderStyle = BorderStyle.None;
            txtEditUsername.Location = new Point(30, 41);
            txtEditUsername.Name = "txtEditUsername";
            txtEditUsername.Size = new Size(230, 20);
            txtEditUsername.TabIndex = 0;
            // 
            // txtEditPass
            // 
            txtEditPass.BorderStyle = BorderStyle.None;
            txtEditPass.Location = new Point(30, 104);
            txtEditPass.Name = "txtEditPass";
            txtEditPass.Size = new Size(230, 20);
            txtEditPass.TabIndex = 1;
            // 
            // txtEditNotelp
            // 
            txtEditNotelp.BorderStyle = BorderStyle.None;
            txtEditNotelp.Location = new Point(30, 171);
            txtEditNotelp.Name = "txtEditNotelp";
            txtEditNotelp.Size = new Size(230, 20);
            txtEditNotelp.TabIndex = 2;
            // 
            // btnSimpanEdit
            // 
            btnSimpanEdit.Location = new Point(134, 212);
            btnSimpanEdit.Name = "btnSimpanEdit";
            btnSimpanEdit.Size = new Size(155, 29);
            btnSimpanEdit.TabIndex = 3;
            btnSimpanEdit.Text = "Simpan Perubahan";
            btnSimpanEdit.UseVisualStyleBackColor = true;
            btnSimpanEdit.Click += btnSimpanEdit_Click_1;
            // 
            // EditAkun
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(447, 253);
            Controls.Add(btnSimpanEdit);
            Controls.Add(txtEditNotelp);
            Controls.Add(txtEditPass);
            Controls.Add(txtEditUsername);
            Name = "EditAkun";
            Text = "EditAkun";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSimpanEdit;
        public TextBox txtEditUsername;
        public TextBox txtEditPass;
        public TextBox txtEditNotelp;
    }
}