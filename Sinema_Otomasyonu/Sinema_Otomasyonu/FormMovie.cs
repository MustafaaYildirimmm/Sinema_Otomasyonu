using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sinema_Otomasyonu
{
    public partial class FormMovie : Form
    {
        public FormMovie()
        {
            InitializeComponent();
        }
        SinemaEntities _db = new SinemaEntities();
        private void FormMovie_Load(object sender, EventArgs e)
        {
            lstMovieLoad();
        }

        //lstvw e film yukelem metodu
        public void lstMovieLoad()
        {
            lstvFilmler.Items.Clear();
            List<Film> movieList = _db.Film.ToList();
            foreach (Film item in movieList)
            {
                ListViewItem li = new ListViewItem();
                li.Text = item.FilmAdi;
                li.SubItems.Add(item.FilmVizyonTarihi.ToString());
                li.SubItems.Add(item.FilmYonetmen);
                li.SubItems.Add(item.FilmDili);
                li.SubItems.Add(item.FilmSuresi.ToString());
                li.SubItems.Add(item.FilmTuru);
                li.SubItems.Add(item.FilmOyuncu);
                li.Tag = item;
                lstvFilmler.Items.Add(li);
            }
        }

        private void btnFilmGuncelle_Click(object sender, EventArgs e)
        {
            //guncelleme islemi icin  lstv den secilen film classına ait olan elemanı movieadd formuna gönderdim 
            Film choosing = (Film)lstvFilmler.FocusedItem.Tag;
            FormMovieAdd frm = new FormMovieAdd(choosing);
            frm.ShowDialog();
        }

        private void btnFilmSil_Click(object sender, EventArgs e)
        {
            ListViewItem li = lstvFilmler.FocusedItem;
            Film removing = (Film)li.Tag;
            _db.Film.Remove(removing);
            int resul = _db.SaveChanges();
            if (resul > 0)
            {
                MessageBox.Show("Silme islemi basarılı");
                lstMovieLoad();
            }
            else
            {
                MessageBox.Show("Error 404");
            }
        }
    }
}
