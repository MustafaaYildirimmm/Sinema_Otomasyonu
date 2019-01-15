namespace Sinema_Otomasyonu
{
    partial class FormMovieAdd
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnFilmKaydet = new System.Windows.Forms.Button();
            this.pctPhoto = new System.Windows.Forms.PictureBox();
            this.btnDosyaSec = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtActor = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nmpLong = new System.Windows.Forms.NumericUpDown();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.dtpSession = new System.Windows.Forms.DateTimePicker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pctPhoto)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmpLong)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(427, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 31);
            this.label5.TabIndex = 18;
            this.label5.Text = "FILM EKLE";
            // 
            // btnFilmKaydet
            // 
            this.btnFilmKaydet.BackColor = System.Drawing.Color.Crimson;
            this.btnFilmKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFilmKaydet.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFilmKaydet.Location = new System.Drawing.Point(775, 181);
            this.btnFilmKaydet.Name = "btnFilmKaydet";
            this.btnFilmKaydet.Size = new System.Drawing.Size(112, 155);
            this.btnFilmKaydet.TabIndex = 35;
            this.btnFilmKaydet.Text = "KAYDET";
            this.btnFilmKaydet.UseVisualStyleBackColor = false;
            this.btnFilmKaydet.Click += new System.EventHandler(this.btnFilmKaydet_Click);
            // 
            // pctPhoto
            // 
            this.pctPhoto.Location = new System.Drawing.Point(546, 174);
            this.pctPhoto.Name = "pctPhoto";
            this.pctPhoto.Size = new System.Drawing.Size(146, 155);
            this.pctPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPhoto.TabIndex = 33;
            this.pctPhoto.TabStop = false;
            // 
            // btnDosyaSec
            // 
            this.btnDosyaSec.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDosyaSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDosyaSec.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDosyaSec.Location = new System.Drawing.Point(576, 344);
            this.btnDosyaSec.Name = "btnDosyaSec";
            this.btnDosyaSec.Size = new System.Drawing.Size(95, 34);
            this.btnDosyaSec.TabIndex = 34;
            this.btnDosyaSec.Text = "Dosya Sec";
            this.btnDosyaSec.UseVisualStyleBackColor = false;
            this.btnDosyaSec.Click += new System.EventHandler(this.btnDosyaSec_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(100, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Film Adı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(82, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Yönetmen:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(85, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Oyuncular:";
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtType.Location = new System.Drawing.Point(175, 281);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(223, 24);
            this.txtType.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(124, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Sure:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(124, 283);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "Türü:";
            // 
            // txtActor
            // 
            this.txtActor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtActor.Location = new System.Drawing.Point(175, 216);
            this.txtActor.Name = "txtActor";
            this.txtActor.Size = new System.Drawing.Size(223, 24);
            this.txtActor.TabIndex = 28;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.DimGray;
            this.label16.Location = new System.Drawing.Point(138, 318);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 20);
            this.label16.TabIndex = 24;
            this.label16.Text = "Dil:";
            // 
            // txtDirector
            // 
            this.txtDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDirector.Location = new System.Drawing.Point(175, 185);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(223, 24);
            this.txtDirector.TabIndex = 27;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.DimGray;
            this.label17.Location = new System.Drawing.Point(67, 349);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(102, 20);
            this.label17.TabIndex = 25;
            this.label17.Text = "Vizyon Tarihi:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtName.Location = new System.Drawing.Point(175, 155);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(223, 24);
            this.txtName.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nmpLong);
            this.groupBox1.Controls.Add(this.cmbLanguage);
            this.groupBox1.Controls.Add(this.dtpSession);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnFilmKaydet);
            this.groupBox1.Controls.Add(this.pctPhoto);
            this.groupBox1.Controls.Add(this.btnDosyaSec);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtType);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtActor);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtDirector);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1004, 511);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            // 
            // nmpLong
            // 
            this.nmpLong.Location = new System.Drawing.Point(177, 251);
            this.nmpLong.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nmpLong.Name = "nmpLong";
            this.nmpLong.Size = new System.Drawing.Size(221, 20);
            this.nmpLong.TabIndex = 38;
            this.nmpLong.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Items.AddRange(new object[] {
            "Türkçe Dublaj\t",
            "Altyazılı",
            "İngilizce"});
            this.cmbLanguage.Location = new System.Drawing.Point(175, 317);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(223, 21);
            this.cmbLanguage.TabIndex = 37;
            // 
            // dtpSession
            // 
            this.dtpSession.Location = new System.Drawing.Point(175, 349);
            this.dtpSession.Name = "dtpSession";
            this.dtpSession.Size = new System.Drawing.Size(223, 20);
            this.dtpSession.TabIndex = 36;
            // 
            // FormMovieAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 511);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMovieAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMovieAdd";
            this.Load += new System.EventHandler(this.FormMovieAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctPhoto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmpLong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFilmKaydet;
        private System.Windows.Forms.PictureBox pctPhoto;
        private System.Windows.Forms.Button btnDosyaSec;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtActor;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DateTimePicker dtpSession;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.NumericUpDown nmpLong;
    }
}