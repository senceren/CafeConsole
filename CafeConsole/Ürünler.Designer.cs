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
            dgvÜrünler = new DataGridView();
            label1 = new Label();
            txtUrunAd = new TextBox();
            label2 = new Label();
            nudBirimFiyat = new NumericUpDown();
            btnEkle = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvÜrünler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudBirimFiyat).BeginInit();
            SuspendLayout();
            // 
            // dgvÜrünler
            // 
            dgvÜrünler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvÜrünler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvÜrünler.Location = new Point(12, 88);
            dgvÜrünler.Name = "dgvÜrünler";
            dgvÜrünler.RowHeadersWidth = 51;
            dgvÜrünler.RowTemplate.Height = 29;
            dgvÜrünler.Size = new Size(480, 365);
            dgvÜrünler.TabIndex = 0;
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
            // 
            // Ürünler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 467);
            Controls.Add(btnEkle);
            Controls.Add(nudBirimFiyat);
            Controls.Add(label2);
            Controls.Add(txtUrunAd);
            Controls.Add(label1);
            Controls.Add(dgvÜrünler);
            Name = "Ürünler";
            Text = "Ürünler";
            ((System.ComponentModel.ISupportInitialize)dgvÜrünler).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudBirimFiyat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvÜrünler;
        private Label label1;
        private TextBox txtUrunAd;
        private Label label2;
        private NumericUpDown nudBirimFiyat;
        private Button btnEkle;
    }
}