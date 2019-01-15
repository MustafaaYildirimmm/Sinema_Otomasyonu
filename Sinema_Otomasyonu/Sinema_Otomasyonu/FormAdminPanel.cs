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
    public partial class FormAdminPanel : Form
    {
        public FormAdminPanel()
        {
            InitializeComponent();
        }

        //menustripte tıklanan ilgili formları acma islemi yapildi.eger form acıksa tekrar acmak yerine sadece odaklama yapildi.

        SinemaEntities db = new SinemaEntities();
        private void personeBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool check=false;
            foreach (Form item in Application.OpenForms)
            {
                if (item.Name=="FormUsers")
                {
                    check = true;
                    item.Focus();
                }
            }
            if (check==false)
            {
                FormUsers frm = new FormUsers();
                frm.MdiParent = this;
                frm.Show();
            }
        }

      

        private void biletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool check = false;
            foreach (Form item in Application.OpenForms)
            {
                if (item.Name == "FormTicket")
                {
                    check = true;
                    item.Focus();
                }
            }
            if (check == false)
            {
                FormTicket frm = new FormTicket();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void satışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool check = false;
            foreach (Form item in Application.OpenForms)
            {
                if (item.Name == "FormMovieChoose")
                {
                    check = true;
                    item.Focus();
                }
            }
            if (check == false)
            {
                FormMovieChoose frm = new FormMovieChoose();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void guvenliÇıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
        }

        //load eventinde gerçek zamanlı saat ve tarih gösterme islemi yapildi.
        private void FormAdminPanel_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void filmListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool check = false;
            foreach (Form item in Application.OpenForms)
            {
                if (item.Name == "FormMovie")
                {
                    check = true;
                    item.Focus();
                }
            }
            if (check == false)
            {
                FormMovie frm = new FormMovie();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void filmEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool check = false;
            foreach (Form item in Application.OpenForms)
            {
                if (item.Name == "FormMovieAdd")
                {
                    check = true;
                    item.Focus();
                }
            }
            if (check == false)
            {
                FormMovieAdd frm = new FormMovieAdd();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void seansEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool check = false;
            foreach (Form item in Application.OpenForms)
            {
                if (item.Name == "FormSeans")
                {
                    check = true;
                    item.Focus();
                }
            }
            if (check == false)
            {
                FormSeans frm = new FormSeans();
                frm.MdiParent = this;
                frm.Show();
            }
        }
 
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            toolStripStatusLabel1.Text = DateTime.Now.ToLongDateString();
            toolStripStatusLabel2.Text = DateTime.Now.ToLongTimeString();
        }

        private void FormAdminPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
