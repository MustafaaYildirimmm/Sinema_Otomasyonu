namespace Sinema_Otomasyonu
{
    partial class FormUserPanel
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kisiselBilgilerimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guvenliÇıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kisiselBilgilerimToolStripMenuItem,
            this.biletToolStripMenuItem,
            this.satışToolStripMenuItem,
            this.guvenliÇıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1004, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kisiselBilgilerimToolStripMenuItem
            // 
            this.kisiselBilgilerimToolStripMenuItem.Name = "kisiselBilgilerimToolStripMenuItem";
            this.kisiselBilgilerimToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.kisiselBilgilerimToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.kisiselBilgilerimToolStripMenuItem.Text = "Kişisel Bilgilerim";
            this.kisiselBilgilerimToolStripMenuItem.ToolTipText = "F3";
            this.kisiselBilgilerimToolStripMenuItem.Click += new System.EventHandler(this.kisiselBilgilerimToolStripMenuItem_Click);
            // 
            // biletToolStripMenuItem
            // 
            this.biletToolStripMenuItem.Name = "biletToolStripMenuItem";
            this.biletToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.biletToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.biletToolStripMenuItem.Text = "Bilet";
            this.biletToolStripMenuItem.ToolTipText = "F1";
            this.biletToolStripMenuItem.Click += new System.EventHandler(this.biletToolStripMenuItem_Click);
            // 
            // satışToolStripMenuItem
            // 
            this.satışToolStripMenuItem.Name = "satışToolStripMenuItem";
            this.satışToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.satışToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.satışToolStripMenuItem.Text = "Satış";
            this.satışToolStripMenuItem.ToolTipText = "F12";
            this.satışToolStripMenuItem.Click += new System.EventHandler(this.satışToolStripMenuItem_Click);
            // 
            // guvenliÇıkışToolStripMenuItem
            // 
            this.guvenliÇıkışToolStripMenuItem.Name = "guvenliÇıkışToolStripMenuItem";
            this.guvenliÇıkışToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.guvenliÇıkışToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.guvenliÇıkışToolStripMenuItem.Text = "Güvenli Çıkış";
            this.guvenliÇıkışToolStripMenuItem.ToolTipText = "Alt+F4";
            this.guvenliÇıkışToolStripMenuItem.Click += new System.EventHandler(this.guvenliÇıkışToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 489);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1004, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // FormUserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 511);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "FormUserPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUserPanel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormUserPanel_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kisiselBilgilerimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biletToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guvenliÇıkışToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}