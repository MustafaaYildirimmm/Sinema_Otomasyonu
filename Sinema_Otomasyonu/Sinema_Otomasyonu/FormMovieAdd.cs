using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sinema_Otomasyonu
{
    public partial class FormMovieAdd : Form
    {
        public FormMovieAdd()
        {
            InitializeComponent();
        }

        public FormMovieAdd(Film choosing)
        {
            InitializeComponent();
            if (choosing != null)
            {
                this.choosing = choosing;
            }
        }

        SinemaEntities _db = new SinemaEntities();
        private Film choosing;

        private void btnFilmKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Film flm = _db.Film.SingleOrDefault(t => t.FilmId == choosing.FilmId);
                if (flm == null)
                {
                    //film kaydetme işlemi
                    Film mv = new Film();
                    mv.FilmAdi = txtName.Text;
                    mv.FilmYonetmen = txtDirector.Text;
                    mv.FilmOyuncu = txtActor.Text;
                    mv.FilmSuresi = (int)nmpLong.Value;
                    mv.FilmTuru = txtType.Text;
                    mv.FilmDili = cmbLanguage.SelectedItem.ToString();
                    mv.FilmVizyonTarihi = dtpSession.Value;
                    imageAdd(mv);
                    _db.Film.Add(mv);
                    dbChangeControl("Film Başarılı Bir Şekilde Kaydedildi.", "Error 404");
                }
                else
                {
                    //film gunceleme islemii 
                    flm.FilmAdi = txtName.Text;
                    flm.FilmDili = cmbLanguage.SelectedItem.ToString();
                    flm.FilmOyuncu = txtActor.Text;
                    flm.FilmSuresi = (int)nmpLong.Value;
                    flm.FilmTuru = txtType.Text;
                    flm.FilmVizyonTarihi = dtpSession.Value;
                    imageAdd(flm);
                    dbChangeControl("Film Başarılı Bir Şekilde Guncellendi.", "Error 404");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //db üzerinde degişiklik yapılıp yapılamadıgını kontrol eden method
        private void dbChangeControl(string message1,string message2)
        {
            int result = _db.SaveChanges();
            if (result > 0)
            {
                MessageBox.Show(message1);
                this.Close();
            }
            else
            {
                MessageBox.Show(message2);
            }
        }

        //resim kaydetme methodu
        private void imageAdd(Film mv)
        {
            MemoryStream ms = new MemoryStream();
            pctPhoto.Image.Save(ms, ImageFormat.Jpeg);
            byte[] picture = ms.GetBuffer();
            mv.FilmResmi = picture;
        }

        private void btnDosyaSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Resimler |* .jpg;* .nef;* .png | Tüm Dosyalar |* .*";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog1.CheckFileExists = false;
            openFileDialog1.Title = "Film icin bir resim seciniz ...";
            openFileDialog1.ShowDialog();
            string filePath = openFileDialog1.FileName;
            pctPhoto.ImageLocation = filePath;
        }

        private void FormMovieAdd_Load(object sender, EventArgs e)
        {
            if (choosing!=null)
            {
                txtActor.Text = choosing.FilmOyuncu;
                txtDirector.Text = choosing.FilmYonetmen;
                txtName.Text = choosing.FilmAdi;
                txtType.Text = choosing.FilmTuru;
                nmpLong.Value = (int)choosing.FilmSuresi;
                cmbLanguage.SelectedItem = choosing.FilmDili;
                dtpSession.Value = (DateTime)choosing.FilmVizyonTarihi;
                byte[] image = choosing.FilmResmi;
                if (image!=null)
                {
                    MemoryStream mem = new MemoryStream(image);
                    pctPhoto.Image = Image.FromStream(mem);
                }
            }     
        }
    }
}
