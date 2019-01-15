namespace Sinema_Otomasyonu
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlKullaniciGiris = new System.Windows.Forms.Panel();
            this.lnkLblKunuttum = new System.Windows.Forms.LinkLabel();
            this.btnKullaniciKayit = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.btnKullaniciGiris = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtKullaniciParola = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.pnlKullaniciSfrUnttum = new System.Windows.Forms.Panel();
            this.lnkLblGeri = new System.Windows.Forms.LinkLabel();
            this.btnMailGönder = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSifreUntMail = new System.Windows.Forms.TextBox();
            this.pnlAdminGiris = new System.Windows.Forms.Panel();
            this.lnkLblAunuttum = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdminGiris = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdminKulAdi = new System.Windows.Forms.TextBox();
            this.txtAdminParola = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlKullaniciGiris.SuspendLayout();
            this.pnlKullaniciSfrUnttum.SuspendLayout();
            this.pnlAdminGiris.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlKullaniciGiris
            // 
            this.pnlKullaniciGiris.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKullaniciGiris.Controls.Add(this.lnkLblKunuttum);
            this.pnlKullaniciGiris.Controls.Add(this.btnKullaniciKayit);
            this.pnlKullaniciGiris.Controls.Add(this.label18);
            this.pnlKullaniciGiris.Controls.Add(this.btnKullaniciGiris);
            this.pnlKullaniciGiris.Controls.Add(this.label17);
            this.pnlKullaniciGiris.Controls.Add(this.txtKullaniciAdi);
            this.pnlKullaniciGiris.Controls.Add(this.txtKullaniciParola);
            this.pnlKullaniciGiris.Controls.Add(this.label16);
            this.pnlKullaniciGiris.Location = new System.Drawing.Point(127, 86);
            this.pnlKullaniciGiris.Name = "pnlKullaniciGiris";
            this.pnlKullaniciGiris.Size = new System.Drawing.Size(273, 279);
            this.pnlKullaniciGiris.TabIndex = 18;
            // 
            // lnkLblKunuttum
            // 
            this.lnkLblKunuttum.AutoSize = true;
            this.lnkLblKunuttum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnkLblKunuttum.ForeColor = System.Drawing.Color.DimGray;
            this.lnkLblKunuttum.LinkColor = System.Drawing.Color.DimGray;
            this.lnkLblKunuttum.Location = new System.Drawing.Point(55, 199);
            this.lnkLblKunuttum.Name = "lnkLblKunuttum";
            this.lnkLblKunuttum.Size = new System.Drawing.Size(114, 18);
            this.lnkLblKunuttum.TabIndex = 17;
            this.lnkLblKunuttum.TabStop = true;
            this.lnkLblKunuttum.Text = "Şifremi Unuttum";
            this.lnkLblKunuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblKunuttum_LinkClicked);
            // 
            // btnKullaniciKayit
            // 
            this.btnKullaniciKayit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKullaniciKayit.BackgroundImage")));
            this.btnKullaniciKayit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKullaniciKayit.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKullaniciKayit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(188)))), ((int)(((byte)(2)))));
            this.btnKullaniciKayit.Location = new System.Drawing.Point(139, 218);
            this.btnKullaniciKayit.Name = "btnKullaniciKayit";
            this.btnKullaniciKayit.Size = new System.Drawing.Size(109, 42);
            this.btnKullaniciKayit.TabIndex = 16;
            this.btnKullaniciKayit.Text = "Kayıt Ol";
            this.btnKullaniciKayit.UseVisualStyleBackColor = true;
            this.btnKullaniciKayit.Click += new System.EventHandler(this.btnKullaniciKayit_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(27)))), ((int)(((byte)(2)))));
            this.label18.Location = new System.Drawing.Point(29, 35);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(182, 24);
            this.label18.TabIndex = 9;
            this.label18.Text = "Kullanıcı Girisi";
            // 
            // btnKullaniciGiris
            // 
            this.btnKullaniciGiris.BackColor = System.Drawing.Color.SeaGreen;
            this.btnKullaniciGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKullaniciGiris.BackgroundImage")));
            this.btnKullaniciGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKullaniciGiris.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKullaniciGiris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(188)))), ((int)(((byte)(2)))));
            this.btnKullaniciGiris.Location = new System.Drawing.Point(24, 218);
            this.btnKullaniciGiris.Name = "btnKullaniciGiris";
            this.btnKullaniciGiris.Size = new System.Drawing.Size(109, 42);
            this.btnKullaniciGiris.TabIndex = 15;
            this.btnKullaniciGiris.Text = "Giriş Yap";
            this.btnKullaniciGiris.UseVisualStyleBackColor = false;
            this.btnKullaniciGiris.Click += new System.EventHandler(this.btnKullaniciGiris_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.DimGray;
            this.label17.Location = new System.Drawing.Point(52, 77);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(115, 18);
            this.label17.TabIndex = 10;
            this.label17.Text = "Kullanıcı Adınız *";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.Location = new System.Drawing.Point(55, 101);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(156, 26);
            this.txtKullaniciAdi.TabIndex = 11;
            // 
            // txtKullaniciParola
            // 
            this.txtKullaniciParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciParola.Location = new System.Drawing.Point(55, 162);
            this.txtKullaniciParola.Name = "txtKullaniciParola";
            this.txtKullaniciParola.PasswordChar = '*';
            this.txtKullaniciParola.Size = new System.Drawing.Size(156, 26);
            this.txtKullaniciParola.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.DimGray;
            this.label16.Location = new System.Drawing.Point(52, 138);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 18);
            this.label16.TabIndex = 12;
            this.label16.Text = "Parolanız*";
            // 
            // pnlKullaniciSfrUnttum
            // 
            this.pnlKullaniciSfrUnttum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKullaniciSfrUnttum.Controls.Add(this.lnkLblGeri);
            this.pnlKullaniciSfrUnttum.Controls.Add(this.btnMailGönder);
            this.pnlKullaniciSfrUnttum.Controls.Add(this.label6);
            this.pnlKullaniciSfrUnttum.Controls.Add(this.txtSifreUntMail);
            this.pnlKullaniciSfrUnttum.Location = new System.Drawing.Point(302, 69);
            this.pnlKullaniciSfrUnttum.Name = "pnlKullaniciSfrUnttum";
            this.pnlKullaniciSfrUnttum.Size = new System.Drawing.Size(238, 206);
            this.pnlKullaniciSfrUnttum.TabIndex = 19;
            this.pnlKullaniciSfrUnttum.Visible = false;
            // 
            // lnkLblGeri
            // 
            this.lnkLblGeri.AutoSize = true;
            this.lnkLblGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnkLblGeri.LinkColor = System.Drawing.Color.DimGray;
            this.lnkLblGeri.Location = new System.Drawing.Point(27, 134);
            this.lnkLblGeri.Name = "lnkLblGeri";
            this.lnkLblGeri.Size = new System.Drawing.Size(50, 18);
            this.lnkLblGeri.TabIndex = 17;
            this.lnkLblGeri.TabStop = true;
            this.lnkLblGeri.Text = "<- geri";
            this.lnkLblGeri.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblGeri_LinkClicked);
            // 
            // btnMailGönder
            // 
            this.btnMailGönder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMailGönder.BackgroundImage")));
            this.btnMailGönder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMailGönder.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMailGönder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(188)))), ((int)(((byte)(2)))));
            this.btnMailGönder.Location = new System.Drawing.Point(94, 122);
            this.btnMailGönder.Name = "btnMailGönder";
            this.btnMailGönder.Size = new System.Drawing.Size(109, 42);
            this.btnMailGönder.TabIndex = 16;
            this.btnMailGönder.Text = "Gönder";
            this.btnMailGönder.UseVisualStyleBackColor = true;
            this.btnMailGönder.Click += new System.EventHandler(this.btnMailGönder_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(5, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mail Adresinizi Giriniz";
            // 
            // txtSifreUntMail
            // 
            this.txtSifreUntMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifreUntMail.Location = new System.Drawing.Point(47, 73);
            this.txtSifreUntMail.Name = "txtSifreUntMail";
            this.txtSifreUntMail.Size = new System.Drawing.Size(156, 26);
            this.txtSifreUntMail.TabIndex = 11;
            // 
            // pnlAdminGiris
            // 
            this.pnlAdminGiris.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAdminGiris.Controls.Add(this.lnkLblAunuttum);
            this.pnlAdminGiris.Controls.Add(this.label1);
            this.pnlAdminGiris.Controls.Add(this.btnAdminGiris);
            this.pnlAdminGiris.Controls.Add(this.label2);
            this.pnlAdminGiris.Controls.Add(this.txtAdminKulAdi);
            this.pnlAdminGiris.Controls.Add(this.txtAdminParola);
            this.pnlAdminGiris.Controls.Add(this.label4);
            this.pnlAdminGiris.Location = new System.Drawing.Point(406, 86);
            this.pnlAdminGiris.Name = "pnlAdminGiris";
            this.pnlAdminGiris.Size = new System.Drawing.Size(273, 279);
            this.pnlAdminGiris.TabIndex = 19;
            // 
            // lnkLblAunuttum
            // 
            this.lnkLblAunuttum.AutoSize = true;
            this.lnkLblAunuttum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnkLblAunuttum.ForeColor = System.Drawing.Color.DimGray;
            this.lnkLblAunuttum.LinkColor = System.Drawing.Color.DimGray;
            this.lnkLblAunuttum.Location = new System.Drawing.Point(52, 197);
            this.lnkLblAunuttum.Name = "lnkLblAunuttum";
            this.lnkLblAunuttum.Size = new System.Drawing.Size(114, 18);
            this.lnkLblAunuttum.TabIndex = 18;
            this.lnkLblAunuttum.TabStop = true;
            this.lnkLblAunuttum.Text = "Şifremi Unuttum";
            this.lnkLblAunuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblAunuttum_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(27)))), ((int)(((byte)(2)))));
            this.label1.Location = new System.Drawing.Point(29, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Admin Girisi";
            // 
            // btnAdminGiris
            // 
            this.btnAdminGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdminGiris.BackgroundImage")));
            this.btnAdminGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdminGiris.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminGiris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(188)))), ((int)(((byte)(2)))));
            this.btnAdminGiris.Location = new System.Drawing.Point(113, 218);
            this.btnAdminGiris.Name = "btnAdminGiris";
            this.btnAdminGiris.Size = new System.Drawing.Size(109, 42);
            this.btnAdminGiris.TabIndex = 15;
            this.btnAdminGiris.Text = "Giriş Yap";
            this.btnAdminGiris.UseVisualStyleBackColor = true;
            this.btnAdminGiris.Click += new System.EventHandler(this.btnAdminGiris_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(52, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kullanıcı Adınız *";
            // 
            // txtAdminKulAdi
            // 
            this.txtAdminKulAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdminKulAdi.Location = new System.Drawing.Point(55, 101);
            this.txtAdminKulAdi.Name = "txtAdminKulAdi";
            this.txtAdminKulAdi.Size = new System.Drawing.Size(156, 26);
            this.txtAdminKulAdi.TabIndex = 11;
            // 
            // txtAdminParola
            // 
            this.txtAdminParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdminParola.Location = new System.Drawing.Point(55, 162);
            this.txtAdminParola.Name = "txtAdminParola";
            this.txtAdminParola.PasswordChar = '*';
            this.txtAdminParola.Size = new System.Drawing.Size(156, 26);
            this.txtAdminParola.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(52, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Paralonuz*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sinema_Otomasyonu.Properties.Resources.background_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlKullaniciSfrUnttum);
            this.Controls.Add(this.pnlKullaniciGiris);
            this.Controls.Add(this.pnlAdminGiris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlKullaniciGiris.ResumeLayout(false);
            this.pnlKullaniciGiris.PerformLayout();
            this.pnlKullaniciSfrUnttum.ResumeLayout(false);
            this.pnlKullaniciSfrUnttum.PerformLayout();
            this.pnlAdminGiris.ResumeLayout(false);
            this.pnlAdminGiris.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlKullaniciGiris;
        private System.Windows.Forms.Panel pnlKullaniciSfrUnttum;
        private System.Windows.Forms.LinkLabel lnkLblGeri;
        private System.Windows.Forms.Button btnMailGönder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSifreUntMail;
        private System.Windows.Forms.LinkLabel lnkLblKunuttum;
        private System.Windows.Forms.Button btnKullaniciKayit;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnKullaniciGiris;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtKullaniciParola;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel pnlAdminGiris;
        private System.Windows.Forms.LinkLabel lnkLblAunuttum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdminGiris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdminKulAdi;
        private System.Windows.Forms.TextBox txtAdminParola;
        private System.Windows.Forms.Label label4;
    }
}

