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
    public partial class FormCustomer : Form
    {

        public FormCustomer()
        {
            InitializeComponent();
        }
        private Seans chSess;
        private List<Button> btnList;
        private List<Button> fillBtn;
        
        //constructor methodu ile bu form uzerine film,seans,koltuk bilgileri ilgili formlardan cekilip bu form uzerinde kullanildi.

        public FormCustomer(List<Button> btnList, List<Button> fillBtn, Seans chSess)
        {
            InitializeComponent();
            this.btnList = btnList;
            this.fillBtn = fillBtn;
            this.chSess = chSess;
        }

        SinemaEntities _db = new SinemaEntities();
        int price = 12, stdPrice = 8;
        Image satildi = Image.FromFile("..\\..\\images\\kltSatildi.png");
        

        private void btnSatis_Click(object sender, EventArgs e)
        {
            Bilet b = new Bilet();
            BiletProcess(b);

        }

        private void BiletProcess(Bilet b)
        {
            foreach (Button item in btnList)
            {
                if (item.Tag != null)
                {
                    btnList.Remove(item);
                }
                else
                {
                    Seans s = chSess;
                    seatPrice(b);
                    b.FilmAdi = s.FilmAdi;
                    b.TarihSaat = DateTime.Now;
                    b.SalonNo = s.SalonId;
                    b.SeansSaati = s.Saati;
                    b.mstAd = txtName.Text;
                    b.mstSoyad = txtSurname.Text;
                    b.mstTelefon = txtPhone.Text;
                    _db.Bilet.Add(b);


                    int result = _db.SaveChanges();
                    if (result > 0)
                    {
                        MessageBox.Show("satis islemi gerceklesmistir.");
                        if (item.Tag == null)
                        {
                            item.Tag = b;
                            item.BackgroundImage = satildi;
                        }


                    }
                    this.Close();
                    break;
                }
            }
        }

        //database e kaydeedebilmek icin  bilet sinifinda koltuk numaralarini const metodu ile gelen buttonların textlerinden aliyoruz ve bilet sinifinda tutuyoruz ayrica toplam fiyati hesaplayip veritabanina kaydediyoruruz..

        private void seatPrice(Bilet b)
        {
            int count = 0, totalPrice;

            foreach (Button button in btnList)
            {
                if (button.Tag == null)
                {
                    b.KoltukNumarasi += button.Text + "-";
                    button.Tag = b;
                    count++;
                }
            }
            if (rdbOgrenci.Checked)
            {
                totalPrice = stdPrice * count;
                b.BiletTipi = "Ogrenci";
                b.Ucret = totalPrice;
                lblTotalPrice.Text = totalPrice.ToString();
            }
            else
            {
                totalPrice = price * count;
                b.BiletTipi = "Tam";
                b.Ucret = totalPrice;
                lblTotalPrice.Text = totalPrice.ToString();
            }

        }

        private void rdbOgrenci_CheckedChanged(object sender, EventArgs e)
        {
            totalPrice();
        }

        // toplam fiyati rdb lere göre hesaplayip kullaniciya gösteriyoruz  ..
        private void totalPrice()
        {
            int count = 0;
            int tSeat, totalPrice;
            string seat = "";

            foreach (Button item in btnList)
            {
                if (item.Tag == null)
                {
                    seat += item.Text + "-";
                    count++;
                    lblSeat.Text = "";
                    lblSeat.Text += seat;
                }
            }
            tSeat = count;
            if (rdbOgrenci.Checked)
            {
                totalPrice = stdPrice * tSeat;
                lblTotalPrice.Text = totalPrice.ToString();
            }
            else
            {
                totalPrice = price * tSeat;
                lblTotalPrice.Text = totalPrice.ToString();
            }
        }


        // koltuksecimi formunda dolu olan koltukların bilgilerini gösterme islemi bu form üzerinde yapildi..

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            if (fillBtn.Count > 0&&btnList.Count==0)
            {
                Button button = fillBtn.Last();
                Bilet btnTck = (Bilet)button.Tag;

                if (button.Tag != null)
                {
                    txtName.Text = btnTck.mstAd;
                    txtSurname.Text = btnTck.mstSoyad;
                    txtPhone.Text = btnTck.mstTelefon;
                    if (btnTck.BiletTipi == "Ogrenci")
                        rdbOgrenci.Checked = true;
                    else
                        rdbTam.Checked = true;
                    lblSeat.Text = btnTck.KoltukNumarasi;
                    lblTotalPrice.Text = btnTck.Ucret.ToString();
                }
                lblMovie.Text = chSess.FilmAdi;
                lblSalloon.Text = chSess.SalonId;
                lblSession.Text = chSess.Saati;
            }

        }
    }
}

