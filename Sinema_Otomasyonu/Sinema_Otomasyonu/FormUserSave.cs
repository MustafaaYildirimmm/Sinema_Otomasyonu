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
    public partial class FormUserSave : Form
    {
        public FormUserSave()
        {
            InitializeComponent();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }
        SinemaEntities db = new SinemaEntities();

        private void btnKayit_Click(object sender, EventArgs e)
        {
            //kayitli kullanici olup olmadigi kontrol edildi.ayrica mail,kullAdi,parola bilgilerinin bos olammasi icin kontrol saglandi.
            List<Kullanici> klnList = db.Kullanici.ToList();
            bool control=false;

            Kullanici kln = new Kullanici();
            
            foreach (Kullanici kullanici in klnList)
            {
                if (kullanici.E_mail==txtMail.Text||kullanici.Kullanici_Adi==txtKullaniciAdi.Text)
                {
                    control = true;
                    break;
                }
            }
            if (control==false)
            {
                kln.Adi = txtAd.Text;
                kln.E_mail = txtMail.Text;
                kln.Kullanici_Adi = txtKullaniciAdi.Text;
                kln.Parola = txtParola.Text;
                kln.Soyadi = txtSoyad.Text;
                kln.Telefon = txtTelefon.Text;
                db.Kullanici.Add(kln);
                int result = db.SaveChanges();
                if (result > 0)
                {
                    MessageBox.Show("kayit islemi basarili");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("server hatasi");
                }
            }
            else
                MessageBox.Show("kullanici adi veya email kayitlidir.");
           
        }
    }
}
