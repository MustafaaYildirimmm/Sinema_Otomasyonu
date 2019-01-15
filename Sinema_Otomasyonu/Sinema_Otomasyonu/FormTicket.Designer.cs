namespace Sinema_Otomasyonu
{
    partial class FormTicket
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
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label29 = new System.Windows.Forms.Label();
            this.columnHeader30 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader28 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader27 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnBiletIptal = new System.Windows.Forms.Button();
            this.lstvBilet = new System.Windows.Forms.ListView();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.DarkRed;
            this.label29.Location = new System.Drawing.Point(413, 28);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(271, 31);
            this.label29.TabIndex = 18;
            this.label29.Text = "BILET ISLEMLERI";
            // 
            // columnHeader30
            // 
            this.columnHeader30.Text = "Tarih ve Saat";
            this.columnHeader30.Width = 175;
            // 
            // columnHeader28
            // 
            this.columnHeader28.Text = "Ucret";
            this.columnHeader28.Width = 64;
            // 
            // columnHeader27
            // 
            this.columnHeader27.Text = "Bilet Tipi";
            this.columnHeader27.Width = 86;
            // 
            // columnHeader26
            // 
            this.columnHeader26.Text = "Koltuk No";
            this.columnHeader26.Width = 141;
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "Seans";
            this.columnHeader25.Width = 88;
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "Salon";
            this.columnHeader24.Width = 91;
            // 
            // columnHeader23
            // 
            this.columnHeader23.DisplayIndex = 1;
            this.columnHeader23.Text = "Soyad";
            this.columnHeader23.Width = 115;
            // 
            // columnHeader22
            // 
            this.columnHeader22.DisplayIndex = 2;
            this.columnHeader22.Text = "Film";
            this.columnHeader22.Width = 122;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Ad";
            this.columnHeader21.Width = 115;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 489);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1004, 22);
            this.statusStrip1.TabIndex = 25;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnBiletIptal
            // 
            this.btnBiletIptal.BackColor = System.Drawing.Color.Crimson;
            this.btnBiletIptal.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBiletIptal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBiletIptal.Location = new System.Drawing.Point(793, 17);
            this.btnBiletIptal.Name = "btnBiletIptal";
            this.btnBiletIptal.Size = new System.Drawing.Size(177, 57);
            this.btnBiletIptal.TabIndex = 23;
            this.btnBiletIptal.Text = "Iptal Et";
            this.btnBiletIptal.UseVisualStyleBackColor = false;
            this.btnBiletIptal.Click += new System.EventHandler(this.btnBiletIptal_Click);
            // 
            // lstvBilet
            // 
            this.lstvBilet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lstvBilet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader21,
            this.columnHeader22,
            this.columnHeader23,
            this.columnHeader24,
            this.columnHeader25,
            this.columnHeader26,
            this.columnHeader27,
            this.columnHeader28,
            this.columnHeader30});
            this.lstvBilet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstvBilet.FullRowSelect = true;
            this.lstvBilet.GridLines = true;
            this.lstvBilet.Location = new System.Drawing.Point(0, 90);
            this.lstvBilet.Name = "lstvBilet";
            this.lstvBilet.Size = new System.Drawing.Size(1004, 369);
            this.lstvBilet.TabIndex = 19;
            this.lstvBilet.UseCompatibleStateImageBehavior = false;
            this.lstvBilet.View = System.Windows.Forms.View.Details;
            // 
            // FormTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 511);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnBiletIptal);
            this.Controls.Add(this.lstvBilet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormTicket";
            this.Text = "FormTicket";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormTicket_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ColumnHeader columnHeader30;
        private System.Windows.Forms.ColumnHeader columnHeader28;
        private System.Windows.Forms.ColumnHeader columnHeader27;
        private System.Windows.Forms.ColumnHeader columnHeader26;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnBiletIptal;
        private System.Windows.Forms.ListView lstvBilet;
    }
}