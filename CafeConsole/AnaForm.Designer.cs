namespace CafeConsole
{
    partial class AnaForm
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
            menuStrip1 = new MenuStrip();
            ürünlerToolStripMenuItem = new ToolStripMenuItem();
            geçmişSiparişlerToolStripMenuItem = new ToolStripMenuItem();
            lstViewMasalar = new ListView();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ürünlerToolStripMenuItem, geçmişSiparişlerToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(760, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ürünlerToolStripMenuItem
            // 
            ürünlerToolStripMenuItem.Name = "ürünlerToolStripMenuItem";
            ürünlerToolStripMenuItem.Size = new Size(71, 24);
            ürünlerToolStripMenuItem.Text = "Ürünler";
            // 
            // geçmişSiparişlerToolStripMenuItem
            // 
            geçmişSiparişlerToolStripMenuItem.Name = "geçmişSiparişlerToolStripMenuItem";
            geçmişSiparişlerToolStripMenuItem.Size = new Size(136, 24);
            geçmişSiparişlerToolStripMenuItem.Text = "Geçmiş Siparişler";
            // 
            // lstViewMasalar
            // 
            lstViewMasalar.Dock = DockStyle.Fill;
            lstViewMasalar.Location = new Point(0, 28);
            lstViewMasalar.Name = "lstViewMasalar";
            lstViewMasalar.Size = new Size(760, 466);
            lstViewMasalar.TabIndex = 1;
            lstViewMasalar.UseCompatibleStateImageBehavior = false;
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 494);
            Controls.Add(lstViewMasalar);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "AnaForm";
            Text = "Cafe Console";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ürünlerToolStripMenuItem;
        private ToolStripMenuItem geçmişSiparişlerToolStripMenuItem;
        private ListView lstViewMasalar;
    }
}