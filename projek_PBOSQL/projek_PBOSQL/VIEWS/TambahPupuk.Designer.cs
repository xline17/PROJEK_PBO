namespace projek_PBOSQL.VIEWS
{
    partial class TambahPupuk
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
            txtNamaPupuk = new TextBox();
            txtHarga = new TextBox();
            btnSimpan = new Button();
            btnBatal = new Button();
            SuspendLayout();
            // 
            // txtNamaPupuk
            // 
            txtNamaPupuk.Location = new Point(281, 203);
            txtNamaPupuk.Multiline = true;
            txtNamaPupuk.Name = "txtNamaPupuk";
            txtNamaPupuk.Size = new Size(270, 46);
            txtNamaPupuk.TabIndex = 0;
            // 
            // txtHarga
            // 
            txtHarga.Location = new Point(281, 294);
            txtHarga.Multiline = true;
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(270, 46);
            txtHarga.TabIndex = 1;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.DodgerBlue;
            btnSimpan.Font = new Font("Helvetica", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpan.ForeColor = SystemColors.ButtonHighlight;
            btnSimpan.Location = new Point(439, 375);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(112, 34);
            btnSimpan.TabIndex = 2;
            btnSimpan.Text = "SIMPAN";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.Red;
            btnBatal.Font = new Font("Helvetica", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBatal.ForeColor = SystemColors.ButtonHighlight;
            btnBatal.Location = new Point(281, 375);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(112, 34);
            btnBatal.TabIndex = 3;
            btnBatal.Text = "BATAL";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // TambahPupuk
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.formAddPupuk;
            ClientSize = new Size(800, 507);
            Controls.Add(btnBatal);
            Controls.Add(btnSimpan);
            Controls.Add(txtHarga);
            Controls.Add(txtNamaPupuk);
            Name = "TambahPupuk";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TambahPupuk";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNamaPupuk;
        private TextBox txtHarga;
        private Button btnSimpan;
        private Button btnBatal;
    }
}