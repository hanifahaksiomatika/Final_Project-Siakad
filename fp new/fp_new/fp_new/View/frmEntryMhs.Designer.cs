namespace fp_new.View
{
    partial class frmEntryMhs
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
            btnSimpan = new Button();
            cboxKelamin = new ComboBox();
            dateTglLahir = new DateTimePicker();
            txtAlamat = new TextBox();
            txtNoHP = new TextBox();
            txtNama = new TextBox();
            txtNIM = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSelesai = new Button();
            label7 = new Label();
            SuspendLayout();
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(228, 343);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(114, 29);
            btnSimpan.TabIndex = 40;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // cboxKelamin
            // 
            cboxKelamin.FormattingEnabled = true;
            cboxKelamin.Items.AddRange(new object[] { "Laki-laki", "Perempuan" });
            cboxKelamin.Location = new Point(139, 204);
            cboxKelamin.Margin = new Padding(3, 4, 3, 4);
            cboxKelamin.Name = "cboxKelamin";
            cboxKelamin.Size = new Size(178, 28);
            cboxKelamin.TabIndex = 35;
            // 
            // dateTglLahir
            // 
            dateTglLahir.Location = new Point(139, 159);
            dateTglLahir.Margin = new Padding(3, 4, 3, 4);
            dateTglLahir.Name = "dateTglLahir";
            dateTglLahir.Size = new Size(228, 27);
            dateTglLahir.TabIndex = 34;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(139, 291);
            txtAlamat.Margin = new Padding(3, 4, 3, 4);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(339, 27);
            txtAlamat.TabIndex = 33;
            // 
            // txtNoHP
            // 
            txtNoHP.Location = new Point(139, 247);
            txtNoHP.Margin = new Padding(3, 4, 3, 4);
            txtNoHP.Name = "txtNoHP";
            txtNoHP.Size = new Size(228, 27);
            txtNoHP.TabIndex = 32;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(139, 122);
            txtNama.Margin = new Padding(3, 4, 3, 4);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(339, 27);
            txtNama.TabIndex = 31;
            // 
            // txtNIM
            // 
            txtNIM.Location = new Point(139, 80);
            txtNIM.Margin = new Padding(3, 4, 3, 4);
            txtNIM.Name = "txtNIM";
            txtNIM.Size = new Size(178, 27);
            txtNIM.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 294);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 29;
            label6.Text = "Alamat";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 250);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 28;
            label5.Text = "No HP";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 207);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 27;
            label4.Text = "Jenis Kelamin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 166);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 26;
            label3.Text = "Tgl Lahir";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 125);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 25;
            label2.Text = "Nama";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 83);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 24;
            label1.Text = "NIM";
            // 
            // btnSelesai
            // 
            btnSelesai.Location = new Point(367, 342);
            btnSelesai.Margin = new Padding(3, 4, 3, 4);
            btnSelesai.Name = "btnSelesai";
            btnSelesai.Size = new Size(111, 31);
            btnSelesai.TabIndex = 41;
            btnSelesai.Text = "Selesai";
            btnSelesai.UseVisualStyleBackColor = true;
            btnSelesai.Click += btnSelesai_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(122, 25);
            label7.Name = "label7";
            label7.Size = new Size(272, 27);
            label7.TabIndex = 42;
            label7.Text = "Entry Data Mahasiswa";
            // 
            // frmEntryMhs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 386);
            Controls.Add(label7);
            Controls.Add(btnSelesai);
            Controls.Add(btnSimpan);
            Controls.Add(cboxKelamin);
            Controls.Add(dateTglLahir);
            Controls.Add(txtAlamat);
            Controls.Add(txtNoHP);
            Controls.Add(txtNama);
            Controls.Add(txtNIM);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmEntryMhs";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmEntryMhs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSimpan;
        private ComboBox cboxKelamin;
        private DateTimePicker dateTglLahir;
        private TextBox txtAlamat;
        private TextBox txtNoHP;
        private TextBox txtNama;
        private TextBox txtNIM;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSelesai;
        private Label label7;
    }
}