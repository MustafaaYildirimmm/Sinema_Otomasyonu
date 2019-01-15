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
    public partial class FormMovieChoose : Form
    {
        

        public FormMovieChoose()
        {
            InitializeComponent();
        }

        SinemaEntities _db = new SinemaEntities();
        private void FormMovieChoose_Load(object sender, EventArgs e)
        {
            fillToLstMovie();
        }

        private void fillToLstMovie()
        {
            List<Seans> seansList = _db.Seans.ToList();
            List<Film> flmList = _db.Film.ToList();
            foreach (Seans item in seansList)
            {
                ListViewItem li = new ListViewItem();
                li.Text = item.FilmAdi;
                li.SubItems.Add(item.Saati.ToString());
                li.SubItems.Add(item.SalonId);
                foreach (Film ite in flmList)
                {
                    if (ite.FilmAdi == item.FilmAdi)
                    {
                        li.SubItems.Add(ite.FilmSuresi.ToString());
                    }
                }
                //diger formlara seans bilgilerini gönderebilmek icin listview elemanlarinin taglerinde seans bilgilerini tuttum. 
                li.Tag = item;
                lstvFilmler.Items.Add(li);
            }
        }

        private void lstvFilmler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Seans chSess = (Seans)lstvFilmler.FocusedItem.Tag;

            FormSeatChoose frm = new FormSeatChoose(chSess);
            frm.ShowDialog();

        }

    }
}
