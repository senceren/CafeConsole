namespace CafeConsole
{
    partial class Form1
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
            nudAdet = new NumericUpDown();
            btnEkle = new Button();
            btnTasi = new Button();
            label3 = new Label();
            dgvMasa = new DataGridView();
            cmbUrunAd = new ComboBox();
            label4 = new Label();
            lblÖdemeTutar = new Label();
            lblMasaNo = new Label();
            cmbMasaNo = new ComboBox();
            btnİptal = new Button();
            btnÖdemeAl = new Button();
            btnAnasayfa = new Button();
            ((System.ComponentModel.ISupportInitialize)nudAdet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMasa).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 0;
            label1.Text = "Ürün";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(204, 22);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 1;
            label2.Text = "Adet";
            // 
            // nudAdet
            // 
            nudAdet.Location = new Point(204, 55);
            nudAdet.Name = "nudAdet";
            nudAdet.Size = new Size(92, 27);
            nudAdet.TabIndex = 2;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = SystemColors.AppWorkspace;
            btnEkle.Location = new Point(302, 53);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            // 
            // btnTasi
            // 
            btnTasi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTasi.BackColor = SystemColors.AppWorkspace;
            btnTasi.Location = new Point(710, 56);
            btnTasi.Name = "btnTasi";
            btnTasi.Size = new Size(94, 29);
            btnTasi.TabIndex = 7;
            btnTasi.Text = "TAŞI";
            btnTasi.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(553, 22);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 5;
            label3.Text = "Masa No";
            // 
            // dgvMasa
            // 
            dgvMasa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMasa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMasa.Location = new Point(12, 104);
            dgvMasa.Name = "dgvMasa";
            dgvMasa.RowHeadersWidth = 51;
            dgvMasa.RowTemplate.Height = 29;
            dgvMasa.Size = new Size(454, 437);
            dgvMasa.TabIndex = 8;
            // 
            // cmbUrunAd
            // 
            cmbUrunAd.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUrunAd.FormattingEnabled = true;
            cmbUrunAd.Location = new Point(12, 53);
            cmbUrunAd.Name = "cmbUrunAd";
            cmbUrunAd.Size = new Size(185, 28);
            cmbUrunAd.TabIndex = 9;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(575, 338);
            label4.Name = "label4";
            label4.Size = new Size(130, 25);
            label4.TabIndex = 10;
            label4.Text = "Ödeme Tutarı:";
            // 
            // lblÖdemeTutar
            // 
            lblÖdemeTutar.Anchor = AnchorStyles.Right;
            lblÖdemeTutar.AutoSize = true;
            lblÖdemeTutar.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblÖdemeTutar.Location = new Point(711, 338);
            lblÖdemeTutar.Name = "lblÖdemeTutar";
            lblÖdemeTutar.Size = new Size(22, 25);
            lblÖdemeTutar.TabIndex = 11;
            lblÖdemeTutar.Text = "0";
            // 
            // lblMasaNo
            // 
            lblMasaNo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblMasaNo.BackColor = Color.Tomato;
            lblMasaNo.Font = new Font("Segoe UI", 60F, FontStyle.Bold, GraphicsUnit.Point);
            lblMasaNo.Location = new Point(499, 104);
            lblMasaNo.Name = "lblMasaNo";
            lblMasaNo.Size = new Size(301, 189);
            lblMasaNo.TabIndex = 12;
            lblMasaNo.Text = "00";
            lblMasaNo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbMasaNo
            // 
            cmbMasaNo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbMasaNo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMasaNo.FormattingEnabled = true;
            cmbMasaNo.Location = new Point(553, 57);
            cmbMasaNo.Name = "cmbMasaNo";
            cmbMasaNo.Size = new Size(151, 28);
            cmbMasaNo.TabIndex = 13;
            // 
            // btnİptal
            // 
            btnİptal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnİptal.BackColor = Color.DarkRed;
            btnİptal.ForeColor = Color.White;
            btnİptal.Location = new Point(499, 397);
            btnİptal.Name = "btnİptal";
            btnİptal.Size = new Size(140, 57);
            btnİptal.TabIndex = 14;
            btnİptal.Text = "SİPARİŞ İPTAL";
            btnİptal.UseVisualStyleBackColor = false;
            // 
            // btnÖdemeAl
            // 
            btnÖdemeAl.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnÖdemeAl.BackColor = Color.Green;
            btnÖdemeAl.ForeColor = Color.White;
            btnÖdemeAl.Location = new Point(645, 397);
            btnÖdemeAl.Name = "btnÖdemeAl";
            btnÖdemeAl.Size = new Size(151, 57);
            btnÖdemeAl.TabIndex = 15;
            btnÖdemeAl.Text = "ÖDEME AL";
            btnÖdemeAl.UseVisualStyleBackColor = false;
            // 
            // btnAnasayfa
            // 
            btnAnasayfa.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAnasayfa.BackColor = Color.Yellow;
            btnAnasayfa.Location = new Point(499, 465);
            btnAnasayfa.Name = "btnAnasayfa";
            btnAnasayfa.Size = new Size(297, 65);
            btnAnasayfa.TabIndex = 16;
            btnAnasayfa.Text = "ANASAYFAYA DÖN";
            btnAnasayfa.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 557);
            Controls.Add(btnAnasayfa);
            Controls.Add(btnÖdemeAl);
            Controls.Add(btnİptal);
            Controls.Add(cmbMasaNo);
            Controls.Add(lblMasaNo);
            Controls.Add(lblÖdemeTutar);
            Controls.Add(label4);
            Controls.Add(cmbUrunAd);
            Controls.Add(dgvMasa);
            Controls.Add(btnTasi);
            Controls.Add(label3);
            Controls.Add(btnEkle);
            Controls.Add(nudAdet);
            Controls.Add(label2);
            Controls.Add(label1);
            MinimumSize = new Size(769, 550);
            Name = "Form1";
            Text = "Masa 0";
            ((System.ComponentModel.ISupportInitialize)nudAdet).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMasa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown nudAdet;
        private Button btnEkle;
        private Button btnTasi;
        private Label label3;
        private DataGridView dgvMasa;
        private ComboBox cmbUrunAd;
        private Label label4;
        private Label lblÖdemeTutar;
        private Label lblMasaNo;
        private ComboBox cmbMasaNo;
        private Button btnİptal;
        private Button btnÖdemeAl;
        private Button btnAnasayfa;
    }
}