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
            txtEditUsername.Location = new Point(27, 42);
            txtEditUsername.Margin = new Padding(4, 4, 4, 4);
            txtEditUsername.Name = "txtEditUsername";
            txtEditUsername.Size = new Size(240, 24);
            txtEditUsername.TabIndex = 0;
            // 
            // txtEditPass
            // 
            txtEditPass.BorderStyle = BorderStyle.None;
            txtEditPass.Location = new Point(27, 103);
            txtEditPass.Margin = new Padding(4, 4, 4, 4);
            txtEditPass.Name = "txtEditPass";
            txtEditPass.Size = new Size(240, 24);
            txtEditPass.TabIndex = 1;
            // 
            // txtEditNotelp
            // 
            txtEditNotelp.BorderStyle = BorderStyle.None;
            txtEditNotelp.Location = new Point(27, 170);
            txtEditNotelp.Margin = new Padding(4, 4, 4, 4);
            txtEditNotelp.Name = "txtEditNotelp";
            txtEditNotelp.Size = new Size(240, 24);
            txtEditNotelp.TabIndex = 2;
            // 
            // btnSimpanEdit
            // 
            btnSimpanEdit.Location = new Point(153, 222);
            btnSimpanEdit.Margin = new Padding(4, 4, 4, 4);
            btnSimpanEdit.Name = "btnSimpanEdit";
            btnSimpanEdit.Size = new Size(194, 36);
            btnSimpanEdit.TabIndex = 3;
            btnSimpanEdit.Text = "Simpan Perubahan";
            btnSimpanEdit.UseVisualStyleBackColor = true;
            btnSimpanEdit.Click += btnSimpanEdit_Click_1;
            // 
            // EditAkun
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(457, 291);
            Controls.Add(btnSimpanEdit);
            Controls.Add(txtEditNotelp);
            Controls.Add(txtEditPass);
            Controls.Add(txtEditUsername);
            Margin = new Padding(4, 4, 4, 4);
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