namespace Sinema_Otomasyonu
{
    partial class FormUsers
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
            this.lstvKullanici = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnKullaniciGuncelle = new System.Windows.Forms.Button();
            this.btnKullaniciEkle = new System.Windows.Forms.Button();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtKullaniciMail = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtKullaniciParola = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKullaniciSoyad = new System.Windows.Forms.TextBox();
            this.txtKullaniciTelefon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnKullaniciSil = new System.Windows.Forms.Button();
            this.txtKullaniciAd = new System.Windows.Forms.TextBox();
            this.grpKullaniciBilgi = new System.Windows.Forms.GroupBox();
            this.grpKullaniciBilgi.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstvKullanici
            // 
            this.lstvKullanici.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lstvKullanici.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader6});
            this.lstvKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstvKullanici.FullRowSelect = true;
            this.lstvKullanici.GridLines = true;
            this.lstvKullanici.Location = new System.Drawing.Point(12, 76);
            this.lstvKullanici.Name = "lstvKullanici";
            this.lstvKullanici.Size = new System.Drawing.Size(590, 270);
            this.lstvKullanici.TabIndex = 17;
            this.lstvKullanici.UseCompatibleStateImageBehavior = false;
            this.lstvKullanici.View = System.Windows.Forms.View.Details;
            this.lstvKullanici.SelectedIndexChanged += new System.EventHandler(this.lstvKullanici_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ad";
            this.columnHeader1.Width = 96;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Soyad";
            this.columnHeader2.Width = 104;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kullanıcı Adı";
            this.columnHeader3.Width = 111;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mail";
            this.columnHeader5.Width = 89;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Telefon";
            this.columnHeader6.Width = 95;
            // 
            // btnKullaniciGuncelle
            // 
            this.btnKullaniciGuncelle.BackColor = System.Drawing.Color.SeaGreen;
            this.btnKullaniciGuncelle.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKullaniciGuncelle.ForeColor = System.Drawing.Color.Beige;
            this.btnKullaniciGuncelle.Location = new System.Drawing.Point(44, 257);
            this.btnKullaniciGuncelle.Name = "btnKullaniciGuncelle";
            this.btnKullaniciGuncelle.Size = new System.Drawing.Size(121, 40);
            this.btnKullaniciGuncelle.TabIndex = 38;
            this.btnKullaniciGuncelle.Text = "Guncelle";
            this.btnKullaniciGuncelle.UseVisualStyleBackColor = false;
            this.btnKullaniciGuncelle.Click += new System.EventHandler(this.btnKullaniciGuncelle_Click);
            // 
            // btnKullaniciEkle
            // 
            this.btnKullaniciEkle.BackColor = System.Drawing.Color.OrangeRed;
            this.btnKullaniciEkle.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKullaniciEkle.ForeColor = System.Drawing.Color.Beige;
            this.btnKullaniciEkle.Location = new System.Drawing.Point(200, 257);
            this.btnKullaniciEkle.Name = "btnKullaniciEkle";
            this.btnKullaniciEkle.Size = new System.Drawing.Size(121, 40);
            this.btnKullaniciEkle.TabIndex = 37;
            this.btnKullaniciEkle.Text = "Kayıt Ekle";
            this.btnKullaniciEkle.UseVisualStyleBackColor = false;
            this.btnKullaniciEkle.Click += new System.EventHandler(this.btnKullaniciEkle_Click);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.Location = new System.Drawing.Point(184, 129);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(156, 26);
            this.txtKullaniciAdi.TabIndex = 36;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(181, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 18);
            this.label13.TabIndex = 35;
            this.label13.Text = "Kullanıcı Adı";
            // 
            // txtKullaniciMail
            // 
            this.txtKullaniciMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciMail.Location = new System.Drawing.Point(184, 63);
            this.txtKullaniciMail.Name = "txtKullaniciMail";
            this.txtKullaniciMail.Size = new System.Drawing.Size(156, 26);
            this.txtKullaniciMail.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.DimGray;
            this.label14.Location = new System.Drawing.Point(181, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 18);
            this.label14.TabIndex = 33;
            this.label14.Text = "Mail Adresiniz";
            // 
            // txtKullaniciParola
            // 
            this.txtKullaniciParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciParola.Location = new System.Drawing.Point(184, 194);
            this.txtKullaniciParola.Name = "txtKullaniciParola";
            this.txtKullaniciParola.PasswordChar = '*';
            this.txtKullaniciParola.Size = new System.Drawing.Size(156, 26);
            this.txtKullaniciParola.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.DimGray;
            this.label15.Location = new System.Drawing.Point(186, 173);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 18);
            this.label15.TabIndex = 31;
            this.label15.Text = "Paralonuz*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(6, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 18);
            this.label12.TabIndex = 30;
            this.label12.Text = "Ad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(5, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 28;
            this.label4.Text = "Soyad";
            // 
            // txtKullaniciSoyad
            // 
            this.txtKullaniciSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciSoyad.Location = new System.Drawing.Point(8, 130);
            this.txtKullaniciSoyad.Name = "txtKullaniciSoyad";
            this.txtKullaniciSoyad.Size = new System.Drawing.Size(156, 26);
            this.txtKullaniciSoyad.TabIndex = 29;
            // 
            // txtKullaniciTelefon
            // 
            this.txtKullaniciTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciTelefon.Location = new System.Drawing.Point(9, 197);
            this.txtKullaniciTelefon.Name = "txtKullaniciTelefon";
            this.txtKullaniciTelefon.Size = new System.Drawing.Size(156, 26);
            this.txtKullaniciTelefon.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(335, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(359, 31);
            this.label2.TabIndex = 16;
            this.label2.Text = "KULLANICI ISLEMLERI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(6, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 18);
            this.label6.TabIndex = 26;
            this.label6.Text = "Telefon";
            // 
            // btnKullaniciSil
            // 
            this.btnKullaniciSil.BackColor = System.Drawing.Color.Crimson;
            this.btnKullaniciSil.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKullaniciSil.ForeColor = System.Drawing.Color.Beige;
            this.btnKullaniciSil.Location = new System.Drawing.Point(218, 378);
            this.btnKullaniciSil.Name = "btnKullaniciSil";
            this.btnKullaniciSil.Size = new System.Drawing.Size(182, 57);
            this.btnKullaniciSil.TabIndex = 19;
            this.btnKullaniciSil.Text = "Sil";
            this.btnKullaniciSil.UseVisualStyleBackColor = false;
            this.btnKullaniciSil.Click += new System.EventHandler(this.btnKullaniciSil_Click);
            // 
            // txtKullaniciAd
            // 
            this.txtKullaniciAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAd.Location = new System.Drawing.Point(8, 66);
            this.txtKullaniciAd.Name = "txtKullaniciAd";
            this.txtKullaniciAd.Size = new System.Drawing.Size(156, 26);
            this.txtKullaniciAd.TabIndex = 25;
            // 
            // grpKullaniciBilgi
            // 
            this.grpKullaniciBilgi.Controls.Add(this.btnKullaniciGuncelle);
            this.grpKullaniciBilgi.Controls.Add(this.btnKullaniciEkle);
            this.grpKullaniciBilgi.Controls.Add(this.txtKullaniciAdi);
            this.grpKullaniciBilgi.Controls.Add(this.label13);
            this.grpKullaniciBilgi.Controls.Add(this.txtKullaniciMail);
            this.grpKullaniciBilgi.Controls.Add(this.label14);
            this.grpKullaniciBilgi.Controls.Add(this.txtKullaniciParola);
            this.grpKullaniciBilgi.Controls.Add(this.label15);
            this.grpKullaniciBilgi.Controls.Add(this.label12);
            this.grpKullaniciBilgi.Controls.Add(this.label4);
            this.grpKullaniciBilgi.Controls.Add(this.txtKullaniciSoyad);
            this.grpKullaniciBilgi.Controls.Add(this.txtKullaniciTelefon);
            this.grpKullaniciBilgi.Controls.Add(this.label6);
            this.grpKullaniciBilgi.Controls.Add(this.txtKullaniciAd);
            this.grpKullaniciBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpKullaniciBilgi.ForeColor = System.Drawing.Color.SeaGreen;
            this.grpKullaniciBilgi.Location = new System.Drawing.Point(639, 76);
            this.grpKullaniciBilgi.Name = "grpKullaniciBilgi";
            this.grpKullaniciBilgi.Size = new System.Drawing.Size(352, 323);
            this.grpKullaniciBilgi.TabIndex = 23;
            this.grpKullaniciBilgi.TabStop = false;
            this.grpKullaniciBilgi.Text = "Kullanıcı Bilgileri";
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 511);
            this.Controls.Add(this.lstvKullanici);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnKullaniciSil);
            this.Controls.Add(this.grpKullaniciBilgi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormUsers";
            this.Text = "FormUsers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormUsers_Load);
            this.Click += new System.EventHandler(this.FormUsers_Click);
            this.grpKullaniciBilgi.ResumeLayout(false);
            this.grpKullaniciBilgi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstvKullanici;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnKullaniciGuncelle;
        private System.Windows.Forms.Button btnKullaniciEkle;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtKullaniciMail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtKullaniciParola;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKullaniciSoyad;
        private System.Windows.Forms.TextBox txtKullaniciTelefon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnKullaniciSil;
        private System.Windows.Forms.TextBox txtKullaniciAd;
        private System.Windows.Forms.GroupBox grpKullaniciBilgi;
    }
}