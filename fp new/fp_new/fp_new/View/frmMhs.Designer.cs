namespace fp_new.View
{
    partial class frmMhs
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
            btnTambah = new Button();
            btnUpdate = new Button();
            btnHapus = new Button();
            btnLogout = new Button();
            btnMatkul = new Button();
            btnNilai = new Button();
            lvwMhs = new ListView();
            label1 = new Label();
            label2 = new Label();
            lblUser = new Label();
            btnDashboard = new Button();
            SuspendLayout();
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(139, 512);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(111, 29);
            btnTambah.TabIndex = 0;
            btnTambah.Text = "Tambah Data";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(268, 512);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(113, 29);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update Data";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(401, 512);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(102, 29);
            btnHapus.TabIndex = 2;
            btnHapus.Text = "Hapus Data";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(12, 460);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(111, 29);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnMatkul
            // 
            btnMatkul.Location = new Point(12, 114);
            btnMatkul.Name = "btnMatkul";
            btnMatkul.Size = new Size(111, 29);
            btnMatkul.TabIndex = 4;
            btnMatkul.Text = "Mata Kuliah";
            btnMatkul.UseVisualStyleBackColor = true;
            btnMatkul.Click += btnMatkul_Click;
            // 
            // btnNilai
            // 
            btnNilai.Location = new Point(12, 160);
            btnNilai.Name = "btnNilai";
            btnNilai.Size = new Size(111, 29);
            btnNilai.TabIndex = 5;
            btnNilai.Text = "Nilai";
            btnNilai.UseVisualStyleBackColor = true;
            btnNilai.Click += btnNilai_Click;
            // 
            // lvwMhs
            // 
            lvwMhs.Location = new Point(139, 70);
            lvwMhs.Name = "lvwMhs";
            lvwMhs.Size = new Size(731, 436);
            lvwMhs.TabIndex = 6;
            lvwMhs.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(401, 21);
            label1.Name = "label1";
            label1.Size = new Size(90, 27);
            label1.TabIndex = 7;
            label1.Text = "Siakad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(735, 42);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 8;
            label2.Text = "user :";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(784, 42);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(13, 20);
            lblUser.TabIndex = 9;
            lblUser.Text = " ";
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = SystemColors.ActiveCaption;
            btnDashboard.Location = new Point(12, 70);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(111, 29);
            btnDashboard.TabIndex = 21;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // frmMhs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 553);
            Controls.Add(btnDashboard);
            Controls.Add(lblUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lvwMhs);
            Controls.Add(btnNilai);
            Controls.Add(btnMatkul);
            Controls.Add(btnLogout);
            Controls.Add(btnHapus);
            Controls.Add(btnUpdate);
            Controls.Add(btnTambah);
            Name = "frmMhs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMhs";
            Load += frmMhs_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTambah;
        private Button btnUpdate;
        private Button btnHapus;
        private Button btnLogout;
        private Button btnMatkul;
        private Button btnNilai;
        private ListView lvwMhs;
        private Label label1;
        private Label label2;
        private Label lblUser;
        private Button btnDashboard;
    }
}