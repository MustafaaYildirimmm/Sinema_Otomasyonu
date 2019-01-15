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
    public partial class FormSeatChoose : Form
    {
        private Seans chSess;

        public FormSeatChoose()
        {
            InitializeComponent();
        }

        public FormSeatChoose(Seans chSess)
        {
            InitializeComponent();
            this.chSess = chSess;
        }
        List<Button> btnList = new List<Button>();
        List<Button> fillBtn = new List<Button>();
        SinemaEntities db = new SinemaEntities();
        Image sec = Image.FromFile("..\\..\\images\\kltSec.png");
        Image secili = Image.FromFile("..\\..\\images\\kltSecili.png");
        Image satildi = Image.FromFile("..\\..\\images\\kltSatildi.png");

        private void FormSeatChoose_Load(object sender, EventArgs e)
        {
            Seat();
            fillSeat();
        }

        private void Seat()
        {
            //runtime da buttonlardan koltukların belirlenen tasarımda olusturulma islemi yapildi.

            int Salon1row = 9, Salon1col = 13, m = 1;
            if (chSess != null)
            {
                grpSeat.Text = chSess.SalonId.ToString();
                for (int i = 0; i < Salon1row; i++)
                {
                    for (int k = 0; k < Salon1col; k++)
                    {
                        Button btn = new Button();
                        btn.Width = 40;
                        btn.Height = 40;
                        btn.Left = 200 + k * 48;
                        btn.Top = 25 + i * 48;
                        if (btn.Tag == null)
                        {
                            btn.BackgroundImage = sec;
                            btn.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        btn.FlatStyle = FlatStyle.Popup;
                        btn.Text = m.ToString();
                        btn.Tag = null;
                        btn.Click += Btn_Click;
                        if (i % 2 == 1 && (k < 2 || k > 10))
                        {
                            continue;
                        }
                        grpSeat.Controls.Add(btn);
                        m++;
                    }
                }
            }

        }




        //veritabaninda kayitli olan filme, seansa ,salona ve koltuk numarasina göre kayıtlari getirebilmek icin tiklanan butonun tagine kayitli bileti atiyoruz ve arkaplanini degisitiriyoruz ..
        private void fillSeat()
        {
            List<Bilet> bltList = db.Bilet.ToList();
            foreach (Bilet bilet in bltList)
            {
                string[] seat = bilet.KoltukNumarasi.TrimEnd('-').Split('-');
                foreach (Button button in grpSeat.Controls)
                {
                    for (int i = 0; i < seat.Length; i++)
                    {
                        if (button.Text == seat[i] && chSess.FilmAdi == bilet.FilmAdi)
                        {
                            button.Tag = bilet;
                            button.BackgroundImage = satildi;
                            button.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                    }
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button tiklananBtn = (Button)sender;

            //koltuk secimi yaptiktan sonra tekrardan secimi kaldirma islemi yapildi ..

            if (tiklananBtn.Tag == null && (!btnList.Contains(tiklananBtn)))
            {
                tiklananBtn.BackgroundImage = secili;
                tiklananBtn.BackgroundImageLayout = ImageLayout.Stretch;
                btnList.Add(tiklananBtn);
            }
            else if (tiklananBtn.Tag == null && btnList.Contains(tiklananBtn))
            {
                tiklananBtn.BackgroundImage = sec;
                tiklananBtn.BackgroundImageLayout = ImageLayout.Stretch;
                btnList.Remove(tiklananBtn);
            }
            else if (tiklananBtn.Tag != null)
            {

                fillBtn.Add(tiklananBtn);
            }
        }

        private void btnGoing_Click(object sender, EventArgs e)
        {
            FormCustomer frm = new FormCustomer(btnList, fillBtn, chSess);
            frm.ShowDialog();
        }
    }
}