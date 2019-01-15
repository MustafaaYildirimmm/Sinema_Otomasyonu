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
    public partial class FormUserPanel : Form
    {
        private Kullanici item;

        public FormUserPanel()
        {
            InitializeComponent();
        }

        public FormUserPanel(Kullanici item)
        {
            InitializeComponent();
            this.item = item;
        }

        //menustripte tıklanan ilgili formları acma islemi yapildi.eger form acıksa tekrar acmak yerine sadece odaklama yapildi.


        private void kisiselBilgilerimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool check = false;
            foreach (Form item in Application.OpenForms)
            {
                if (item.Name == "FormUserInfo")
                {
                    check = true;
                    item.Focus();
                }
            }
            if (check == false)
            {
                FormUserInfo frm = new FormUserInfo(item);
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

        private void FormUserPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
