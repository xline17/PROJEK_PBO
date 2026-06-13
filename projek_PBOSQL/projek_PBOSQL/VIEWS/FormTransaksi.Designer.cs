namespace projek_PBOSQL.VIEWS
{
    partial class FormTransaksi
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
            panel1 = new Panel();
            panel2 = new Panel();
            lblTotalHarga = new Label();
            cmbToko = new ComboBox();
            flpKatalog = new FlowLayoutPanel();
            dgvKeranjang = new DataGridView();
            btnBayar = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKeranjang).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 1144);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Khaki;
            panel2.Controls.Add(lblTotalHarga);
            panel2.Controls.Add(cmbToko);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(300, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1598, 77);
            panel2.TabIndex = 1;
            // 
            // lblTotalHarga
            // 
            lblTotalHarga.AutoSize = true;
            lblTotalHarga.Location = new Point(571, 33);
            lblTotalHarga.Name = "lblTotalHarga";
            lblTotalHarga.Size = new Size(53, 25);
            lblTotalHarga.TabIndex = 1;
            lblTotalHarga.Text = "Total:";
            // 
            // cmbToko
            // 
            cmbToko.FormattingEnabled = true;
            cmbToko.Location = new Point(1037, 30);
            cmbToko.Name = "cmbToko";
            cmbToko.Size = new Size(413, 33);
            cmbToko.TabIndex = 0;
            // 
            // flpKatalog
            // 
            flpKatalog.Location = new Point(306, 83);
            flpKatalog.Name = "flpKatalog";
            flpKatalog.Size = new Size(1025, 1049);
            flpKatalog.TabIndex = 2;
            // 
            // dgvKeranjang
            // 
            dgvKeranjang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKeranjang.Location = new Point(1337, 83);
            dgvKeranjang.Name = "dgvKeranjang";
            dgvKeranjang.RowHeadersWidth = 62;
            dgvKeranjang.Size = new Size(549, 392);
            dgvKeranjang.TabIndex = 3;
            // 
            // btnBayar
            // 
            btnBayar.Location = new Point(1579, 528);
            btnBayar.Name = "btnBayar";
            btnBayar.Size = new Size(112, 34);
            btnBayar.TabIndex = 2;
            btnBayar.Text = "Bayar";
            btnBayar.UseVisualStyleBackColor = true;
            btnBayar.Click += btnBayar_Click;
            // 
            // FormTransaksi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1144);
            Controls.Add(btnBayar);
            Controls.Add(dgvKeranjang);
            Controls.Add(flpKatalog);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormTransaksi";
            Text = "FormTransaksi";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKeranjang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private FlowLayoutPanel flpKatalog;
        private Label lblTotalHarga;
        private ComboBox cmbToko;
        private DataGridView dgvKeranjang;
        private Button btnBayar;
    }
}