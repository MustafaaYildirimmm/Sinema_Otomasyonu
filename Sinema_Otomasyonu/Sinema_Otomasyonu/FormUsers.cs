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
    public partial class FormUsers : Form
    {
        public FormUsers()
        {
            InitializeComponent();
        }
        SinemaEntities db = new SinemaEntities();

        private void FormUsers_Load(object sender, EventArgs e)
        {
            fillList();
        }

        //lstv üzerine kullanici bilgilerini getiren metod
        private void fillList()
        {
            lstvKullanici.Items.Clear();
            List<Kullanici> klnList = db.Kullanici.ToList();
            foreach (Kullanici kullanici in klnList)
            {
                ListViewItem li = new ListViewItem();
                li.Text = kullanici.Adi;
                li.SubItems.Add(kullanici.Soyadi);
                li.SubItems.Add(kullanici.Kullanici_Adi);
                li.SubItems.Add(kullanici.E_mail);
                li.SubItems.Add(kullanici.Telefon);
                li.Tag = kullanici;

                lstvKullanici.Items.Add(li);
            }
        }

        private void lstvKullanici_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kullanici kln = (Kullanici)lstvKullanici.FocusedItem.Tag;
            txtKullaniciAd.Text = kln.Adi;
            txtKullaniciAdi.Text = kln.Kullanici_Adi;
            txtKullaniciMail.Text = kln.E_mail;
            txtKullaniciSoyad.Text = kln.Soyadi;
            txtKullaniciTelefon.Text = kln.Telefon;
            txtKullaniciParola.Text = kln.Parola;
        }

        private void FormUsers_Click(object sender, EventArgs e)
        {
            cleanUp();
        }

        private void cleanUp()
        {
            foreach (Control item in grpKullaniciBilgi.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnKullaniciSil_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("silmek istediginizden emin misiniz ?", "UYARI", MessageBoxButtons.YesNo);
            if (DialogResult.Yes == dr)
            {
                Kullanici kln = (Kullanici)lstvKullanici.FocusedItem.Tag;
                Kullanici k = db.Kullanici.SingleOrDefault(t => t.Id == kln.Id);
                db.Kullanici.Remove(k);
                int result = db.SaveChanges();
                if (result > 0)
                {
                    MessageBox.Show("silme islemi basarili");
                    fillList();
                }
                else
                    MessageBox.Show("server hatasi");
            }

        }

        private void btnKullaniciGuncelle_Click(object sender, EventArgs e)
        {
            
            Kullanici kln = (Kullanici)lstvKullanici.FocusedItem.Tag;
            Kullanici k = db.Kullanici.SingleOrDefault(t => t.Id == kln.Id);
            k.Adi = txtKullaniciAd.Text;
            k.Soyadi = txtKullaniciSoyad.Text;
            k.E_mail = txtKullaniciMail.Text;
            k.Parola = txtKullaniciParola.Text;
            k.Telefon = txtKullaniciTelefon.Text;
            int result = db.SaveChanges();
            if (result > 0)
            {
                MessageBox.Show("guncelleme islemi basarili");
                fillList();
                cleanUp();
            }
            else
                MessageBox.Show("kullanici bilgileri en guncel haldedir.");
        }

        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            //kayitli kullanici olup olmadigi kontrol edildi.ayrica mail,kullAdi,parola bilgilerinin bos olammasi icin kontrol saglandi.
            List<Kullanici> klnList = db.Kullanici.ToList();
            bool control = false;

            Kullanici kln = new Kullanici();
            foreach (Kullanici kullanici in klnList)
            {
                if (kullanici.E_mail == txtKullaniciMail.Text || kullanici.Kullanici_Adi == txtKullaniciAdi.Text)
                {
                    control = true;
                }
            }
            if (control==false)
            {
                try
                {
                    kln.Adi = txtKullaniciAd.Text;
                    kln.E_mail = txtKullaniciMail.Text;
                    kln.Kullanici_Adi = txtKullaniciAdi.Text;
                    kln.Parola = txtKullaniciParola.Text;
                    kln.Soyadi = txtKullaniciSoyad.Text;
                    kln.Telefon = txtKullaniciTelefon.Text;
                    if (kln.E_mail!=""&&kln.Parola!=""&&kln.Kullanici_Adi!="")
                    {
                        db.Kullanici.Add(kln);
                        int result = db.SaveChanges();
                        if (result > 0)
                        {
                            MessageBox.Show("kayit islemi basarili");
                            fillList();
                            cleanUp();
                        }
                        else
                        {
                            MessageBox.Show("server hatasi");
                        }
                    }
                    else
                        MessageBox.Show("lütfen bos alanları doldurunuz");
                    
                }
                catch (Exception)
                {

                    MessageBox.Show("lütfen bos alanları doldurunuz");
                }
               
               
            }
            else
                MessageBox.Show("kullanici adi veya email kayitlidir.");
          
        }
    }
}
