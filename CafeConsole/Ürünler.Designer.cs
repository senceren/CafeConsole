namespace CafeConsole
{
    partial class Ürünler
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvUrunler = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtUrunAd = new TextBox();
            label2 = new Label();
            nudBirimFiyat = new NumericUpDown();
            btnEkle = new Button();
            btnIptal = new Button();
            btnDuzenle = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudBirimFiyat).BeginInit();
            SuspendLayout();
            // 
            // dgvUrunler
            // 
            dgvUrunler.AllowUserToAddRows = false;
            dgvUrunler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUrunler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUrunler.Columns.AddRange(new DataGridViewColumn[] { Column2, Column1 });
            dgvUrunler.Location = new Point(12, 88);
            dgvUrunler.MultiSelect = false;
            dgvUrunler.Name = "dgvUrunler";
            dgvUrunler.ReadOnly = true;
            dgvUrunler.RowHeadersVisible = false;
            dgvUrunler.RowHeadersWidth = 51;
            dgvUrunler.RowTemplate.Height = 29;
            dgvUrunler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUrunler.Size = new Size(595, 381);
            dgvUrunler.TabIndex = 0;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "UrunAd";
            Column2.HeaderText = "Ürün Adı";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 96;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "BirimFiyat";
            dataGridViewCellStyle1.Format = "c2";
            Column1.DefaultCellStyle = dataGridViewCellStyle1;
            Column1.HeaderText = "Birim Fiyat";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 108;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 23);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 1;
            label1.Text = "Ürün Adı";
            // 
            // txtUrunAd
            // 
            txtUrunAd.Location = new Point(20, 46);
            txtUrunAd.Name = "txtUrunAd";
            txtUrunAd.Size = new Size(168, 27);
            txtUrunAd.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(194, 23);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 3;
            label2.Text = "Birim Fiyatı ( ₺)";
            // 
            // nudBirimFiyat
            // 
            nudBirimFiyat.DecimalPlaces = 2;
            nudBirimFiyat.Location = new Point(194, 47);
            nudBirimFiyat.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudBirimFiyat.Name = "nudBirimFiyat";
            nudBirimFiyat.Size = new Size(135, 27);
            nudBirimFiyat.TabIndex = 4;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = SystemColors.AppWorkspace;
            btnEkle.Location = new Point(344, 47);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 5;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnIptal
            // 
            btnIptal.BackColor = SystemColors.AppWorkspace;
            btnIptal.Location = new Point(444, 46);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(94, 29);
            btnIptal.TabIndex = 6;
            btnIptal.Text = "İPTAL";
            btnIptal.UseVisualStyleBackColor = false;
            btnIptal.Visible = false;
            btnIptal.Click += btnIptal_Click;
            // 
            // btnDuzenle
            // 
            btnDuzenle.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDuzenle.BackColor = SystemColors.AppWorkspace;
            btnDuzenle.Location = new Point(488, 475);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(119, 29);
            btnDuzenle.TabIndex = 7;
            btnDuzenle.Text = "DÜZENLE";
            btnDuzenle.UseVisualStyleBackColor = false;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // Ürünler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 519);
            Controls.Add(btnDuzenle);
            Controls.Add(btnIptal);
            Controls.Add(btnEkle);
            Controls.Add(nudBirimFiyat);
            Controls.Add(label2);
            Controls.Add(txtUrunAd);
            Controls.Add(label1);
            Controls.Add(dgvUrunler);
            Name = "Ürünler";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ürünler";
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudBirimFiyat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUrunler;
        private Label label1;
        private TextBox txtUrunAd;
        private Label label2;
        private NumericUpDown nudBirimFiyat;
        private Button btnEkle;
        private Button btnIptal;
        private Button btnDuzenle;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
    }
}