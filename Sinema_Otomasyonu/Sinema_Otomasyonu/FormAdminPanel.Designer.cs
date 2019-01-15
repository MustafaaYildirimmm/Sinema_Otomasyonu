namespace Sinema_Otomasyonu
{
    partial class FormAdminPanel
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personeBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seansEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guvenliÇıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personeBilgileriToolStripMenuItem,
            this.filmToolStripMenuItem,
            this.biletToolStripMenuItem,
            this.satışToolStripMenuItem,
            this.guvenliÇıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1004, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // personeBilgileriToolStripMenuItem
            // 
            this.personeBilgileriToolStripMenuItem.Name = "personeBilgileriToolStripMenuItem";
            this.personeBilgileriToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.personeBilgileriToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.personeBilgileriToolStripMenuItem.Text = "Personel Bilgileri";
            this.personeBilgileriToolStripMenuItem.ToolTipText = "F3";
            this.personeBilgileriToolStripMenuItem.Click += new System.EventHandler(this.personeBilgileriToolStripMenuItem_Click);
            // 
            // filmToolStripMenuItem
            // 
            this.filmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmListesiToolStripMenuItem,
            this.filmEkleToolStripMenuItem,
            this.seansEkleToolStripMenuItem});
            this.filmToolStripMenuItem.Name = "filmToolStripMenuItem";
            this.filmToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.filmToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.filmToolStripMenuItem.Text = "Film";
            this.filmToolStripMenuItem.ToolTipText = "F2";
            // 
            // filmListesiToolStripMenuItem
            // 
            this.filmListesiToolStripMenuItem.Name = "filmListesiToolStripMenuItem";
            this.filmListesiToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.filmListesiToolStripMenuItem.Text = "Film Listesi";
            this.filmListesiToolStripMenuItem.Click += new System.EventHandler(this.filmListesiToolStripMenuItem_Click);
            // 
            // filmEkleToolStripMenuItem
            // 
            this.filmEkleToolStripMenuItem.Name = "filmEkleToolStripMenuItem";
            this.filmEkleToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.filmEkleToolStripMenuItem.Text = "Film Ekle";
            this.filmEkleToolStripMenuItem.Click += new System.EventHandler(this.filmEkleToolStripMenuItem_Click);
            // 
            // seansEkleToolStripMenuItem
            // 
            this.seansEkleToolStripMenuItem.Name = "seansEkleToolStripMenuItem";
            this.seansEkleToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.seansEkleToolStripMenuItem.Text = "Seans Ekle";
            this.seansEkleToolStripMenuItem.Click += new System.EventHandler(this.seansEkleToolStripMenuItem_Click);
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
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
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
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 511);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormAdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdminPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAdminPanel_FormClosing);
            this.Load += new System.EventHandler(this.FormAdminPanel_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personeBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biletToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guvenliÇıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seansEkleToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Timer timer1;
    }
}