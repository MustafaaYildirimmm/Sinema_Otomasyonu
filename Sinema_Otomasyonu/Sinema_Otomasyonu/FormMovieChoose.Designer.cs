namespace Sinema_Otomasyonu
{
    partial class FormMovieChoose
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
            this.pnlFilmSec = new System.Windows.Forms.Panel();
            this.lstvFilmler = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label26 = new System.Windows.Forms.Label();
            this.pnlFilmSec.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFilmSec
            // 
            this.pnlFilmSec.Controls.Add(this.lstvFilmler);
            this.pnlFilmSec.Controls.Add(this.label26);
            this.pnlFilmSec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilmSec.Location = new System.Drawing.Point(0, 0);
            this.pnlFilmSec.Name = "pnlFilmSec";
            this.pnlFilmSec.Size = new System.Drawing.Size(1004, 511);
            this.pnlFilmSec.TabIndex = 28;
            // 
            // lstvFilmler
            // 
            this.lstvFilmler.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lstvFilmler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader9,
            this.columnHeader1,
            this.columnHeader11});
            this.lstvFilmler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstvFilmler.FullRowSelect = true;
            this.lstvFilmler.GridLines = true;
            this.lstvFilmler.Location = new System.Drawing.Point(274, 93);
            this.lstvFilmler.Name = "lstvFilmler";
            this.lstvFilmler.Size = new System.Drawing.Size(481, 365);
            this.lstvFilmler.TabIndex = 36;
            this.lstvFilmler.UseCompatibleStateImageBehavior = false;
            this.lstvFilmler.View = System.Windows.Forms.View.Details;
            this.lstvFilmler.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstvFilmler_MouseDoubleClick);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Film Adı";
            this.columnHeader7.Width = 167;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Seans Saati";
            this.columnHeader9.Width = 116;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Salon";
            this.columnHeader1.Width = 87;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Süresi";
            this.columnHeader11.Width = 99;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.DarkRed;
            this.label26.Location = new System.Drawing.Point(406, 28);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(197, 36);
            this.label26.TabIndex = 7;
            this.label26.Text = "Film Secimi";
            // 
            // FormMovieChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 511);
            this.Controls.Add(this.pnlFilmSec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMovieChoose";
            this.Text = "FormMovieChoose";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMovieChoose_Load);
            this.pnlFilmSec.ResumeLayout(false);
            this.pnlFilmSec.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFilmSec;
        private System.Windows.Forms.ListView lstvFilmler;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Label label26;
    }
}