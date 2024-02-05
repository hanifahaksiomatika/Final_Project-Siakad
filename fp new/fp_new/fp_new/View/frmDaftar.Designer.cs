namespace fp_new.View
{
    partial class frmDaftar
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
            lblMasuk = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            btnDAFTAR = new Button();
            label4 = new Label();
            cbRole = new ComboBox();
            SuspendLayout();
            // 
            // lblMasuk
            // 
            lblMasuk.AutoSize = true;
            lblMasuk.Location = new Point(192, 271);
            lblMasuk.Name = "lblMasuk";
            lblMasuk.Size = new Size(51, 20);
            lblMasuk.TabIndex = 11;
            lblMasuk.Text = "Masuk";
            lblMasuk.Click += lblMasuk_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 129);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 10;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 74);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 9;
            label1.Text = "Username";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(160, 126);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(197, 27);
            txtPassword.TabIndex = 8;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(160, 71);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(197, 27);
            txtUsername.TabIndex = 7;
            // 
            // btnDAFTAR
            // 
            btnDAFTAR.Location = new Point(169, 229);
            btnDAFTAR.Name = "btnDAFTAR";
            btnDAFTAR.Size = new Size(94, 29);
            btnDAFTAR.TabIndex = 6;
            btnDAFTAR.Text = "DAFTAR";
            btnDAFTAR.UseVisualStyleBackColor = true;
            btnDAFTAR.Click += btnDAFTAR_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 179);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 12;
            label4.Text = "Role";
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Admin" });
            cbRole.Location = new Point(160, 176);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(197, 28);
            cbRole.TabIndex = 13;
            // 
            // frmDaftar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 303);
            Controls.Add(cbRole);
            Controls.Add(label4);
            Controls.Add(lblMasuk);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnDAFTAR);
            Name = "frmDaftar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDaftar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMasuk;
        private Label label2;
        private Label label1;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Button btnDAFTAR;
        private Label label4;
        private ComboBox cbRole;
    }
}