namespace fp_new.View
{
    partial class frmEntryMatkul
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
            txtKodeMK = new TextBox();
            txtNamaMK = new TextBox();
            txtSKS = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 84);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "Kode MK";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 129);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Nama MK";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 174);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 2;
            label3.Text = "SKS";
            // 
            // txtKodeMK
            // 
            txtKodeMK.Location = new Point(124, 81);
            txtKodeMK.Name = "txtKodeMK";
            txtKodeMK.Size = new Size(125, 27);
            txtKodeMK.TabIndex = 3;
            // 
            // txtNamaMK
            // 
            txtNamaMK.Location = new Point(124, 126);
            txtNamaMK.Name = "txtNamaMK";
            txtNamaMK.Size = new Size(242, 27);
            txtNamaMK.TabIndex = 4;
            // 
            // txtSKS
            // 
            txtSKS.Location = new Point(124, 174);
            txtSKS.Name = "txtSKS";
            txtSKS.Size = new Size(125, 27);
            txtSKS.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(174, 233);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Simpan";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(284, 233);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "Selesai";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // frmEntryMatkul
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 285);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtSKS);
            Controls.Add(txtNamaMK);
            Controls.Add(txtKodeMK);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmEntryMatkul";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmEntryMatkul";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtKodeMK;
        private TextBox txtNamaMK;
        private TextBox txtSKS;
        private Button button1;
        private Button button2;
    }
}