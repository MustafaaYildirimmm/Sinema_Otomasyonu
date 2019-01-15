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
    public partial class FormUserInfo : Form
    {
        private Kullanici item;

        public FormUserInfo()
        {
            InitializeComponent();
        }
        SinemaEntities db = new SinemaEntities();

        public FormUserInfo(Kullanici item)
        {
            InitializeComponent();
            this.item = item;
        }

        //kullanici ibligilerinin hangi kullanici tarafindan giris yapildiysa  form1 üzerinden formuserinfo ya ordan bu form üzerine const metodu ile alinan bilgiler sayesinde bu formun load eventinde kullanici bilgilerinin getirilme islemi yapildi
        private void FormUserInfo_Load(object sender, EventArgs e)
        {
            if (item!=null)
            {
                txtMail.Text = item.E_mail;
                txtName.Text = item.Adi;
                txtPassword.Text = item.Parola;
                txtPhone.Text = item.Telefon;
                txtSurname.Text = item.Soyadi;
                txtUserNAme.Text = item.Kullanici_Adi;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                Kullanici kullanici = db.Kullanici.SingleOrDefault(t => t.Id == item.Id);
                kullanici.Adi = txtName.Text;
                kullanici.E_mail = txtMail.Text;
                kullanici.Kullanici_Adi = txtUserNAme.Text;
                kullanici.Parola = txtPassword.Text;
                kullanici.Soyadi = txtSurname.Text;
                kullanici.Telefon = txtPhone.Text;

                int result = db.SaveChanges();
                if (result > 0)
                {
                    MessageBox.Show("güncelleme islemi basarili");
                }
                else
                {
                    MessageBox.Show("kişisel bilgileriniz en guncel haldedir.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          

        }

        private void chcPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chcPassword.Checked)
                txtPassword.PasswordChar = '\0';
            else
                txtPassword.PasswordChar = '*';
        }
    }
}
