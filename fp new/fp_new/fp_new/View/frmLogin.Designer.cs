namespace fp_new.View
{
    partial class frmLogin
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
            btnMASUK = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lblDaftar = new Label();
            SuspendLayout();
            // 
            // btnMASUK
            // 
            btnMASUK.Location = new Point(175, 195);
            btnMASUK.Name = "btnMASUK";
            btnMASUK.Size = new Size(94, 29);
            btnMASUK.TabIndex = 0;
            btnMASUK.Text = "MASUK";
            btnMASUK.UseVisualStyleBackColor = true;
            btnMASUK.Click += btnMASUK_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(156, 89);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(197, 27);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(156, 144);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(197, 27);
            txtPassword.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 92);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 3;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 147);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // lblDaftar
            // 
            lblDaftar.AutoSize = true;
            lblDaftar.Location = new Point(195, 251);
            lblDaftar.Name = "lblDaftar";
            lblDaftar.Size = new Size(51, 20);
            lblDaftar.TabIndex = 5;
            lblDaftar.Text = "Daftar";
            lblDaftar.Click += lblDaftar_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 303);
            Controls.Add(lblDaftar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnMASUK);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMASUK;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private Label lblDaftar;
    }
}