using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Sinema_Otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SinemaEntities db = new SinemaEntities();
        List<Kullanici> userList;
        List<Admin> adminList;

        private void btnAdminGiris_Click(object sender, EventArgs e)
        {
            //admin giriş bilgilerinin kontrolunu saglama işlemi

            bool check = false;

            foreach (Admin admin in adminList)
            {
                if (admin.Kullanici_Adi == txtAdminKulAdi.Text && admin.Parola == txtAdminParola.Text)
                {
                    check = true;
                }
            }
            if (check == true)
            {
                FormAdminPanel frmA = new FormAdminPanel();
                frmA.Show();
                this.Hide();
            }
            else
                MessageBox.Show("sifre yada kullanici adiniz hatalidir !");
           
        }
        

        private void btnKullaniciGiris_Click(object sender, EventArgs e)
        {
            //kullanici bilgilerinin kontrolünü saglama islemi

            bool check = false;
            Kullanici item = new Kullanici();

            foreach (Kullanici kullanici in userList)
            {
                if (kullanici.Kullanici_Adi == txtKullaniciAdi.Text && kullanici.Parola == txtKullaniciParola.Text)
                {
                    check = true;
                    item = kullanici;
                }
            }
            if (check==true)
            {
                FormUserPanel frm = new FormUserPanel(item);
                frm.Show();
                this.Hide();
            }
            else
                MessageBox.Show("sifre yada kullanici adiniz hatalidir !");
        }

        private void btnKullaniciKayit_Click(object sender, EventArgs e)
        {
            FormUserSave frm = new FormUserSave();
            frm.ShowDialog();
        }

        private void lnkLblKunuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlKullaniciSfrUnttum.Visible = true;
        }

        
        private void btnMailGönder_Click(object sender, EventArgs e)
        {
            //sistemde kayitli olan kullanici veya admin mail adreslerine göre şifrelerini hatırlatmak icin mail gönderme islemi yapıldı
            try
            {
                MailMessage eMail = new MailMessage();
                eMail.From = new MailAddress("mustafaaayildirimm7@gmail.com", "Soft-Fare yazilim bilisim A.S.");
                eMail.Subject = "Şifre Hatırlatma Mesajı ";
                bool checkA = false,checkU=false;
                Admin a = null;
                Kullanici k = null;

                foreach (Admin admin in adminList)
                {
                    if (txtSifreUntMail.Text==admin.E_mail)
                    {
                        checkA = true;
                        a = admin;
                    }
                }
                foreach (Kullanici kullanici in userList)
                {
                    if (txtSifreUntMail.Text == kullanici.E_mail)
                    {
                        checkU = true;
                        k = kullanici;
                    }
                }

                if (checkA==true||checkU==true)
                {
                    if (a!=null)
                    {
                        eMail.To.Add(a.E_mail);
                        eMail.Body = "şifreniz: " + a.Parola;
                    }
                    if (k!=null)
                    {
                        eMail.To.Add(k.E_mail);
                        eMail.Body = "şifreniz: " + k.Parola;
                    }
                }
                else
                    MessageBox.Show("mail adresi hatali");
                

                SmtpClient smtp = new SmtpClient();
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential("mustafaaayildirimm7@gmail.com", "galatasaray123");
                smtp.Send(eMail);
                MessageBox.Show("mail basari ile göderildi mail postanizi kontrol ediniz");
                pnlKullaniciSfrUnttum.Visible = false;
            }
            catch (SmtpException ex)
            {
                MessageBox.Show("sunucu hatasi tekrar deneyiniz");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userList = db.Kullanici.ToList();
            adminList = db.Admin.ToList();
        }

        private void lnkLblGeri_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlKullaniciSfrUnttum.Visible = false;

        }

        private void lnkLblAunuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlKullaniciSfrUnttum.Visible = true;
        }
    }
}
