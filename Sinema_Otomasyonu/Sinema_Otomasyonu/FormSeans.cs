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
    public partial class FormSeans : Form
    {
        public FormSeans()
        {
            InitializeComponent();
        }
        //db baglantısını acma islemi
        SinemaEntities _db = new SinemaEntities();
        private void FormSeans_Load(object sender, EventArgs e)
        {
            //form yuklendigi zaman filmleri çekme islemi
            List<Film> movieList = _db.Film.ToList();
            foreach (Film item in movieList)
            {
                cmbSeansFilm.Items.Add(item);
            }

            for (int i = 1; i < 25; i++)
            {
                cmbHour.Items.Add(i.ToString().PadLeft(2, '0'));
            }
            for (int i = 0; i < 61; i++)
            {
                cmbMinute.Items.Add(i.ToString().PadLeft(2, '0'));
            }

            fillSeans();
        }
        //listview da seansları listeleme methodu
        private void fillSeans()
        {
            lstvSeans.Items.Clear();
            List<Seans> session = _db.Seans.ToList();
            foreach (Seans item in session)
            {
                ListViewItem li = new ListViewItem();
                li.Text = item.SalonId;
                li.SubItems.Add(item.FilmAdi);
                li.SubItems.Add(item.Tarihi.ToString());
                li.SubItems.Add(item.Saati);
                li.SubItems.Add(item.BitisSaati);
                li.Tag = item;
                lstvSeans.Items.Add(li);
            }
        }

        private void btnSeansEkle_Click(object sender, EventArgs e)
        {
            Seans s = new Seans();
            s.SalonId = cmbSeansSalon.SelectedItem.ToString();
            s.FilmAdi = cmbSeansFilm.SelectedItem.ToString();
            s.Tarihi = dtpSeansTarih.Value;
            s.Saati = cmbHour.SelectedItem.ToString() + ":" + cmbMinute.SelectedItem.ToString();
            endSession(s);
            _db.Seans.Add(s);

            dbChangeControl("Kaydetme İslemi Basarılı", "Error 404");
            fillSeans();
        }

        private void endSession(Seans s)
        {
            Film flm = (Film)cmbSeansFilm.SelectedItem;
            int flmArasi = 15;
            int endHour = (int)flm.FilmSuresi / 60 + Convert.ToInt32(cmbHour.SelectedItem);
            int endMin = (int)flm.FilmSuresi % 60 + Convert.ToInt32(cmbMinute.SelectedItem)+flmArasi;

            if (endMin>60)
                s.BitisSaati = (endMin / 60 + endHour) + ":" + endMin % 60;
            else
                s.BitisSaati = endHour + ":" + endMin;
        }

        private void lstvSeans_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillControl();
        }

        //lstw den tıklanan seansı bilgilerini controllerde tekrardan gösterme islemi
        private void fillControl()
        {
            ListViewItem li = lstvSeans.FocusedItem;
            for (int i = 0; i < cmbSeansSalon.Items.Count; i++)
            {
                if (cmbSeansSalon.Items[i].ToString() == li.Text)
                {
                    cmbSeansSalon.SelectedIndex = i;
                }
            }
            for (int i = 0; i < cmbSeansFilm.Items.Count; i++)
            {
                if (cmbSeansFilm.Items[i].ToString() == li.SubItems[1].Text)
                {
                    cmbSeansFilm.SelectedIndex = i;
                }
            }
            dtpSeansTarih.Value = Convert.ToDateTime(li.SubItems[2].Text);
            string[] hour = li.SubItems[3].Text.Split(':');
            cmbHour.SelectedItem = hour[0];
            cmbMinute.SelectedItem = hour[1];
        }

        //db uzerinde degisiklik yapılıp yapılamadıgını kontrol eden method islemi
        private void dbChangeControl(string message, string message2)
        {
            int result = _db.SaveChanges();
            if (result > 0)
            {
                MessageBox.Show(message);
            }
            else
            {
                MessageBox.Show(message2);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bilgileri Degiştirmek isteginizden eminmisiniz", "Guncelleme", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                ListViewItem li = lstvSeans.FocusedItem;
                Seans choosing = (Seans)li.Tag;
                Seans s = _db.Seans.SingleOrDefault(t => t.SeansId == choosing.SeansId);
                s.SalonId = cmbSeansSalon.SelectedItem.ToString();
                s.FilmAdi = cmbSeansFilm.SelectedItem.ToString();
                s.Tarihi = dtpSeansTarih.Value;
                s.Saati = cmbHour.SelectedItem + ":" + cmbMinute.SelectedItem;
                endSession(s);
                dbChangeControl("Guncelleme islemi Başarılı", "Error 404");
                fillSeans();
            }
        }

        private void btnSeansSil_Click(object sender, EventArgs e)
        {
            ListViewItem li = lstvSeans.FocusedItem;
            Seans choosing = (Seans)li.Tag;
            Seans s = _db.Seans.SingleOrDefault(t => t.SeansId == choosing.SeansId);
            _db.Seans.Remove(s);
            dbChangeControl("Silme İslemi Başarılı", "Error 404");
            fillSeans();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillSaloon();
        }

        private void fillSaloon()
        {
            
        }
    }
}
