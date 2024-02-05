namespace fp_new.View
{
    partial class frmEntryNilai
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNIM = new TextBox();
            txtNilai = new TextBox();
            cboxMK = new ComboBox();
            btnSimpan = new Button();
            btnSelesai = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 61);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 0;
            label1.Text = "NIM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 104);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 1;
            label2.Text = "Mata Kuliah";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 149);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 2;
            label3.Text = "Nilai";
            // 
            // txtNIM
            // 
            txtNIM.Location = new Point(139, 58);
            txtNIM.Name = "txtNIM";
            txtNIM.Size = new Size(125, 27);
            txtNIM.TabIndex = 3;
            // 
            // txtNilai
            // 
            txtNilai.Location = new Point(139, 146);
            txtNilai.Name = "txtNilai";
            txtNilai.Size = new Size(125, 27);
            txtNilai.TabIndex = 4;
            // 
            // cboxMK
            // 
            cboxMK.FormattingEnabled = true;
            cboxMK.Location = new Point(139, 101);
            cboxMK.Name = "cboxMK";
            cboxMK.Size = new Size(252, 28);
            cboxMK.TabIndex = 5;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(195, 193);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(94, 29);
            btnSimpan.TabIndex = 6;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnSelesai
            // 
            btnSelesai.Location = new Point(309, 193);
            btnSelesai.Name = "btnSelesai";
            btnSelesai.Size = new Size(94, 29);
            btnSelesai.TabIndex = 7;
            btnSelesai.Text = "Selesai";
            btnSelesai.UseVisualStyleBackColor = true;
            btnSelesai.Click += btnSelesai_Click;
            // 
            // frmEntryNilai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 239);
            Controls.Add(btnSelesai);
            Controls.Add(btnSimpan);
            Controls.Add(cboxMK);
            Controls.Add(txtNilai);
            Controls.Add(txtNIM);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmEntryNilai";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmEntryNilai";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNIM;
        private TextBox txtNilai;
        private ComboBox cboxMK;
        private Button btnSimpan;
        private Button btnSelesai;
    }
}