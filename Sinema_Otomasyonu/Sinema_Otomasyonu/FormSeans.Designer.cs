namespace Sinema_Otomasyonu
{
    partial class FormSeans
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
            this.dtpSeansTarih = new System.Windows.Forms.DateTimePicker();
            this.label24 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cmbSeansFilm = new System.Windows.Forms.ComboBox();
            this.cmbSeansSalon = new System.Windows.Forms.ComboBox();
            this.btnSeansEkle = new System.Windows.Forms.Button();
            this.btnSeansSil = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstvSeans = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpSeansEkle = new System.Windows.Forms.GroupBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.cmbMinute = new System.Windows.Forms.ComboBox();
            this.cmbHour = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpSeansEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpSeansTarih
            // 
            this.dtpSeansTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSeansTarih.Location = new System.Drawing.Point(141, 100);
            this.dtpSeansTarih.Name = "dtpSeansTarih";
            this.dtpSeansTarih.Size = new System.Drawing.Size(173, 26);
            this.dtpSeansTarih.TabIndex = 25;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label24.ForeColor = System.Drawing.Color.DimGray;
            this.label24.Location = new System.Drawing.Point(34, 140);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(100, 20);
            this.label24.TabIndex = 24;
            this.label24.Text = "Seans Saati:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.ForeColor = System.Drawing.Color.DimGray;
            this.label21.Location = new System.Drawing.Point(33, 105);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(101, 20);
            this.label21.TabIndex = 23;
            this.label21.Text = "Seans Tarihi:";
            // 
            // cmbSeansFilm
            // 
            this.cmbSeansFilm.FormattingEnabled = true;
            this.cmbSeansFilm.Location = new System.Drawing.Point(141, 66);
            this.cmbSeansFilm.Name = "cmbSeansFilm";
            this.cmbSeansFilm.Size = new System.Drawing.Size(173, 28);
            this.cmbSeansFilm.TabIndex = 22;
            // 
            // cmbSeansSalon
            // 
            this.cmbSeansSalon.FormattingEnabled = true;
            this.cmbSeansSalon.Items.AddRange(new object[] {
            "Salon-1",
            "Salon-2",
            "Salon-3"});
            this.cmbSeansSalon.Location = new System.Drawing.Point(141, 32);
            this.cmbSeansSalon.Name = "cmbSeansSalon";
            this.cmbSeansSalon.Size = new System.Drawing.Size(173, 28);
            this.cmbSeansSalon.TabIndex = 21;
            // 
            // btnSeansEkle
            // 
            this.btnSeansEkle.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSeansEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeansEkle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSeansEkle.Location = new System.Drawing.Point(216, 201);
            this.btnSeansEkle.Name = "btnSeansEkle";
            this.btnSeansEkle.Size = new System.Drawing.Size(104, 34);
            this.btnSeansEkle.TabIndex = 20;
            this.btnSeansEkle.Text = "Seans Ekle";
            this.btnSeansEkle.UseVisualStyleBackColor = false;
            this.btnSeansEkle.Click += new System.EventHandler(this.btnSeansEkle_Click);
            // 
            // btnSeansSil
            // 
            this.btnSeansSil.BackColor = System.Drawing.Color.Crimson;
            this.btnSeansSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeansSil.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSeansSil.Location = new System.Drawing.Point(112, 201);
            this.btnSeansSil.Name = "btnSeansSil";
            this.btnSeansSil.Size = new System.Drawing.Size(104, 34);
            this.btnSeansSil.TabIndex = 19;
            this.btnSeansSil.Text = "Seans Sil";
            this.btnSeansSil.UseVisualStyleBackColor = false;
            this.btnSeansSil.Click += new System.EventHandler(this.btnSeansSil_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.ForeColor = System.Drawing.Color.DimGray;
            this.label22.Location = new System.Drawing.Point(15, 69);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(120, 20);
            this.label22.TabIndex = 3;
            this.label22.Text = "Eklenecek Film:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.ForeColor = System.Drawing.Color.DimGray;
            this.label23.Location = new System.Drawing.Point(81, 35);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(54, 20);
            this.label23.TabIndex = 2;
            this.label23.Text = "Salon:";
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Seans Saati";
            this.columnHeader20.Width = 210;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Seans Tarihi";
            this.columnHeader19.Width = 212;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Film Adı";
            this.columnHeader18.Width = 204;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Salon No";
            this.columnHeader17.Width = 186;
            // 
            // lstvSeans
            // 
            this.lstvSeans.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstvSeans.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader1});
            this.lstvSeans.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstvSeans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstvSeans.FullRowSelect = true;
            this.lstvSeans.GridLines = true;
            this.lstvSeans.Location = new System.Drawing.Point(0, 313);
            this.lstvSeans.Name = "lstvSeans";
            this.lstvSeans.Size = new System.Drawing.Size(1004, 198);
            this.lstvSeans.TabIndex = 39;
            this.lstvSeans.UseCompatibleStateImageBehavior = false;
            this.lstvSeans.View = System.Windows.Forms.View.Details;
            this.lstvSeans.SelectedIndexChanged += new System.EventHandler(this.lstvSeans_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Seans Bitiş";
            this.columnHeader1.Width = 222;
            // 
            // grpSeansEkle
            // 
            this.grpSeansEkle.Controls.Add(this.btnGuncelle);
            this.grpSeansEkle.Controls.Add(this.cmbMinute);
            this.grpSeansEkle.Controls.Add(this.cmbHour);
            this.grpSeansEkle.Controls.Add(this.label1);
            this.grpSeansEkle.Controls.Add(this.dtpSeansTarih);
            this.grpSeansEkle.Controls.Add(this.label24);
            this.grpSeansEkle.Controls.Add(this.label21);
            this.grpSeansEkle.Controls.Add(this.cmbSeansFilm);
            this.grpSeansEkle.Controls.Add(this.cmbSeansSalon);
            this.grpSeansEkle.Controls.Add(this.btnSeansEkle);
            this.grpSeansEkle.Controls.Add(this.btnSeansSil);
            this.grpSeansEkle.Controls.Add(this.label22);
            this.grpSeansEkle.Controls.Add(this.label23);
            this.grpSeansEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpSeansEkle.ForeColor = System.Drawing.Color.SeaGreen;
            this.grpSeansEkle.Location = new System.Drawing.Point(345, 24);
            this.grpSeansEkle.Name = "grpSeansEkle";
            this.grpSeansEkle.Size = new System.Drawing.Size(326, 252);
            this.grpSeansEkle.TabIndex = 38;
            this.grpSeansEkle.TabStop = false;
            this.grpSeansEkle.Text = "Seans Ekle";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.SeaGreen;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGuncelle.Location = new System.Drawing.Point(19, 201);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(100, 34);
            this.btnGuncelle.TabIndex = 29;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // cmbMinute
            // 
            this.cmbMinute.FormattingEnabled = true;
            this.cmbMinute.IntegralHeight = false;
            this.cmbMinute.Location = new System.Drawing.Point(220, 138);
            this.cmbMinute.Name = "cmbMinute";
            this.cmbMinute.Size = new System.Drawing.Size(47, 28);
            this.cmbMinute.TabIndex = 28;
            // 
            // cmbHour
            // 
            this.cmbHour.FormattingEnabled = true;
            this.cmbHour.IntegralHeight = false;
            this.cmbHour.Location = new System.Drawing.Point(140, 137);
            this.cmbHour.Name = "cmbHour";
            this.cmbHour.Size = new System.Drawing.Size(47, 28);
            this.cmbHour.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(201, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = ":";
            // 
            // FormSeans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 511);
            this.Controls.Add(this.lstvSeans);
            this.Controls.Add(this.grpSeansEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormSeans";
            this.Text = "FormSeans";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormSeans_Load);
            this.grpSeansEkle.ResumeLayout(false);
            this.grpSeansEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpSeansTarih;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cmbSeansFilm;
        private System.Windows.Forms.ComboBox cmbSeansSalon;
        private System.Windows.Forms.Button btnSeansEkle;
        private System.Windows.Forms.Button btnSeansSil;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ListView lstvSeans;
        private System.Windows.Forms.GroupBox grpSeansEkle;
        private System.Windows.Forms.ComboBox cmbMinute;
        private System.Windows.Forms.ComboBox cmbHour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}