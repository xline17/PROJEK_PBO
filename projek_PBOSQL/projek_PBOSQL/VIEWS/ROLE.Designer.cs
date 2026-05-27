namespace projek_PBOSQL.VIEWS
{
    partial class ROLE
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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.DarkGreen;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(475, 207);
            button1.Name = "button1";
            button1.Size = new Size(205, 55);
            button1.TabIndex = 0;
            button1.Text = "ADMIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.DarkGreen;
            button2.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(475, 271);
            button2.Name = "button2";
            button2.Size = new Size(205, 55);
            button2.TabIndex = 1;
            button2.Text = "PETANI";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // ROLE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FORM_ROLE;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "ROLE";
            Text = "ROLE";
            Load += ROLE_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
    }
}