namespace fp_new.View
{
    partial class frmMatkul
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
            lblUser = new Label();
            label2 = new Label();
            label1 = new Label();
            lvwMatkul = new ListView();
            btnNilai = new Button();
            btnMatkul = new Button();
            btnLogout = new Button();
            btnHapus = new Button();
            btnUpdate = new Button();
            btnTambah = new Button();
            btnDashboard = new Button();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(784, 37);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(13, 20);
            lblUser.TabIndex = 19;
            lblUser.Text = " ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(735, 37);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 18;
            label2.Text = "user :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(401, 16);
            label1.Name = "label1";
            label1.Size = new Size(90, 27);
            label1.TabIndex = 17;
            label1.Text = "Siakad";
            // 
            // lvwMatkul
            // 
            lvwMatkul.Location = new Point(139, 65);
            lvwMatkul.Name = "lvwMatkul";
            lvwMatkul.Size = new Size(731, 436);
            lvwMatkul.TabIndex = 16;
            lvwMatkul.UseCompatibleStateImageBehavior = false;
            // 
            // btnNilai
            // 
            btnNilai.Location = new Point(12, 156);
            btnNilai.Name = "btnNilai";
            btnNilai.Size = new Size(111, 29);
            btnNilai.TabIndex = 15;
            btnNilai.Text = "Nilai";
            btnNilai.UseVisualStyleBackColor = true;
            btnNilai.Click += btnNilai_Click;
            // 
            // btnMatkul
            // 
            btnMatkul.BackColor = SystemColors.ActiveCaption;
            btnMatkul.Location = new Point(12, 110);
            btnMatkul.Name = "btnMatkul";
            btnMatkul.Size = new Size(111, 29);
            btnMatkul.TabIndex = 14;
            btnMatkul.Text = "Mata Kuliah";
            btnMatkul.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(12, 455);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(111, 29);
            btnLogout.TabIndex = 13;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(401, 507);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(102, 29);
            btnHapus.TabIndex = 12;
            btnHapus.Text = "Hapus Data";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(268, 507);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(113, 29);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update Data";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(139, 507);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(111, 29);
            btnTambah.TabIndex = 10;
            btnTambah.Text = "Tambah Data";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(12, 65);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(111, 29);
            btnDashboard.TabIndex = 20;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // frmMatkul
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 553);
            Controls.Add(btnDashboard);
            Controls.Add(lblUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lvwMatkul);
            Controls.Add(btnNilai);
            Controls.Add(btnMatkul);
            Controls.Add(btnLogout);
            Controls.Add(btnHapus);
            Controls.Add(btnUpdate);
            Controls.Add(btnTambah);
            Name = "frmMatkul";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMatkul";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUser;
        private Label label2;
        private Label label1;
        private ListView lvwMatkul;
        private Button btnNilai;
        private Button btnMatkul;
        private Button btnLogout;
        private Button btnHapus;
        private Button btnUpdate;
        private Button btnTambah;
        private Button btnDashboard;
    }
}