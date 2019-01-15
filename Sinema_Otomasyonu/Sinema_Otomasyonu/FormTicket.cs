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
    public partial class FormTicket : Form
    {
        public FormTicket()
        {
            InitializeComponent();
        }
        SinemaEntities db = new SinemaEntities();

        private void FormTicket_Load(object sender, EventArgs e)
        {
            fillLst();
        }

        //lstv üzerine veritabanindaki bilet bilgilerinin getirilme islemini yapan method 

        private void fillLst()
        {
            List<Bilet> bltList = db.Bilet.ToList();
            lstvBilet.Items.Clear();

            foreach (Bilet item in bltList)
            {
                ListViewItem li = new ListViewItem();
                li.Text = item.mstAd;
                li.SubItems.Add(item.FilmAdi);
                li.SubItems.Add(item.mstSoyad);
                li.SubItems.Add(item.SalonNo);
                li.SubItems.Add(item.SeansSaati);
                li.SubItems.Add(item.KoltukNumarasi);
                li.SubItems.Add(item.BiletTipi);
                li.SubItems.Add(item.Ucret.ToString());
                li.SubItems.Add(item.TarihSaat.ToString());
                li.Tag = item;
                lstvBilet.Items.Add(li);
            }
        }

        private void btnBiletIptal_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Silmek istediginizden eminmisiniz", "Uyarı", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                Bilet chooseTicket = (Bilet)lstvBilet.FocusedItem.Tag;
                Bilet deleteTck = db.Bilet.SingleOrDefault(t => t.BiletId == chooseTicket.BiletId);
                db.Bilet.Remove(deleteTck);
                int result = db.SaveChanges();
                if (result > 0)
                {
                    MessageBox.Show("silme islemi basarili");

                }
                else
                {
                    MessageBox.Show("baglanti hatasi");
                }

            }
            fillLst();
        }

    }
}
