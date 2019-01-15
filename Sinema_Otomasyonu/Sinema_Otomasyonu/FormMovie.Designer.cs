namespace Sinema_Otomasyonu
{
    partial class FormMovie
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnFilmSil = new System.Windows.Forms.Button();
            this.btnFilmGuncelle = new System.Windows.Forms.Button();
            this.lstvFilmler = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(369, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 36);
            this.label3.TabIndex = 20;
            this.label3.Text = "Film Kayıtları";
            // 
            // btnFilmSil
            // 
            this.btnFilmSil.BackColor = System.Drawing.Color.Crimson;
            this.btnFilmSil.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilmSil.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFilmSil.Location = new System.Drawing.Point(843, 111);
            this.btnFilmSil.Name = "btnFilmSil";
            this.btnFilmSil.Size = new System.Drawing.Size(117, 40);
            this.btnFilmSil.TabIndex = 16;
            this.btnFilmSil.Text = "Sil";
            this.btnFilmSil.UseVisualStyleBackColor = false;
            this.btnFilmSil.Click += new System.EventHandler(this.btnFilmSil_Click);
            // 
            // btnFilmGuncelle
            // 
            this.btnFilmGuncelle.BackColor = System.Drawing.Color.SeaGreen;
            this.btnFilmGuncelle.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilmGuncelle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFilmGuncelle.Location = new System.Drawing.Point(693, 111);
            this.btnFilmGuncelle.Name = "btnFilmGuncelle";
            this.btnFilmGuncelle.Size = new System.Drawing.Size(117, 40);
            this.btnFilmGuncelle.TabIndex = 15;
            this.btnFilmGuncelle.Text = "Güncelle";
            this.btnFilmGuncelle.UseVisualStyleBackColor = false;
            this.btnFilmGuncelle.Click += new System.EventHandler(this.btnFilmGuncelle_Click);
            // 
            // lstvFilmler
            // 
            this.lstvFilmler.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lstvFilmler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader9,
            this.columnHeader8,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.lstvFilmler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstvFilmler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstvFilmler.FullRowSelect = true;
            this.lstvFilmler.GridLines = true;
            this.lstvFilmler.Location = new System.Drawing.Point(0, 189);
            this.lstvFilmler.Name = "lstvFilmler";
            this.lstvFilmler.Size = new System.Drawing.Size(1004, 322);
            this.lstvFilmler.TabIndex = 14;
            this.lstvFilmler.UseCompatibleStateImageBehavior = false;
            this.lstvFilmler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Film Adı";
            this.columnHeader7.Width = 167;
            // 
            // columnHeader9
            // 
            this.columnHeader9.DisplayIndex = 2;
            this.columnHeader9.Text = "Vizyon Tarihi";
            this.columnHeader9.Width = 127;
            // 
            // columnHeader8
            // 
            this.columnHeader8.DisplayIndex = 1;
            this.columnHeader8.Text = "Film Yonetmeni";
            this.columnHeader8.Width = 168;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Dili";
            this.columnHeader10.Width = 108;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Süresi";
            this.columnHeader11.Width = 99;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Film Türü";
            this.columnHeader12.Width = 120;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Oyuncuları";
            this.columnHeader13.Width = 155;
            // 
            // FormMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 511);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFilmSil);
            this.Controls.Add(this.btnFilmGuncelle);
            this.Controls.Add(this.lstvFilmler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMovie";
            this.Text = "FormMovie";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMovie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFilmSil;
        private System.Windows.Forms.Button btnFilmGuncelle;
        private System.Windows.Forms.ListView lstvFilmler;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
    }
}