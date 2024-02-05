namespace fp_new.View
{
    partial class frmNilai
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
            btnDashboard = new Button();
            lblUser = new Label();
            label2 = new Label();
            label1 = new Label();
            lvwNilai = new ListView();
            btnNilai = new Button();
            btnMatkul = new Button();
            btnLogout = new Button();
            btnHapus = new Button();
            btnUpdate = new Button();
            btnTambah = new Button();
            SuspendLayout();
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = SystemColors.ControlLight;
            btnDashboard.Location = new Point(12, 65);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(111, 29);
            btnDashboard.TabIndex = 32;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(784, 37);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(13, 20);
            lblUser.TabIndex = 31;
            lblUser.Text = " ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(735, 37);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 30;
            label2.Text = "user :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(401, 16);
            label1.Name = "label1";
            label1.Size = new Size(90, 27);
            label1.TabIndex = 29;
            label1.Text = "Siakad";
            // 
            // lvwNilai
            // 
            lvwNilai.Location = new Point(139, 65);
            lvwNilai.Name = "lvwNilai";
            lvwNilai.Size = new Size(731, 436);
            lvwNilai.TabIndex = 28;
            lvwNilai.UseCompatibleStateImageBehavior = false;
            // 
            // btnNilai
            // 
            btnNilai.BackColor = SystemColors.ActiveCaption;
            btnNilai.Location = new Point(12, 155);
            btnNilai.Name = "btnNilai";
            btnNilai.Size = new Size(111, 29);
            btnNilai.TabIndex = 27;
            btnNilai.Text = "Nilai";
            btnNilai.UseVisualStyleBackColor = false;
            // 
            // btnMatkul
            // 
            btnMatkul.Location = new Point(12, 109);
            btnMatkul.Name = "btnMatkul";
            btnMatkul.Size = new Size(111, 29);
            btnMatkul.TabIndex = 26;
            btnMatkul.Text = "Mata Kuliah";
            btnMatkul.UseVisualStyleBackColor = true;
            btnMatkul.Click += btnMatkul_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(12, 455);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(111, 29);
            btnLogout.TabIndex = 25;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(401, 507);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(102, 29);
            btnHapus.TabIndex = 24;
            btnHapus.Text = "Hapus Data";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(268, 507);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(113, 29);
            btnUpdate.TabIndex = 23;
            btnUpdate.Text = "Update Data";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(139, 507);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(111, 29);
            btnTambah.TabIndex = 22;
            btnTambah.Text = "Tambah Data";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // frmNilai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 553);
            Controls.Add(btnDashboard);
            Controls.Add(lblUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lvwNilai);
            Controls.Add(btnNilai);
            Controls.Add(btnMatkul);
            Controls.Add(btnLogout);
            Controls.Add(btnHapus);
            Controls.Add(btnUpdate);
            Controls.Add(btnTambah);
            Name = "frmNilai";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmNilai";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDashboard;
        private Label lblUser;
        private Label label2;
        private Label label1;
        private ListView lvwNilai;
        private Button btnNilai;
        private Button btnMatkul;
        private Button btnLogout;
        private Button btnHapus;
        private Button btnUpdate;
        private Button btnTambah;
    }
}