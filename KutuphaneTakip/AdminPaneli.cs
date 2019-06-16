using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneTakip
{
    public partial class AdminPaneli : Form
    {
        public AdminPaneli()
        {
            InitializeComponent();
        }

        private void btnKitaplariListele_Click(object sender, EventArgs e)
        {
            KitaplariListele frm4 = new KitaplariListele();
            frm4.Show();
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            Form1 frm5 = new Form1();
            frm5.Show();
            this.Hide();

        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            KitapEkle frm6 = new KitapEkle();
            frm6.Show();
        }

        private void btnOkuyucuEkle_Click(object sender, EventArgs e)
        {
            OkuyucuEkle frm7 = new OkuyucuEkle();
            frm7.Show();

        }

        private void btnOkuyuculariListele_Click(object sender, EventArgs e)
        {
            OkuyuculariListele frm8 = new OkuyuculariListele();
            frm8.Show();
        }

        private void btnEmanetAlVer_Click(object sender, EventArgs e)
        {
            EmanetAlVer frm9 = new EmanetAlVer();
            frm9.Show();
        }

        private void btnEmanetVerilenKitaplar_Click(object sender, EventArgs e)
        {
            EmanetKitaplar frm10 = new EmanetKitaplar();
            frm10.Show();

        }

        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            KullaniciEkle frm11 = new KullaniciEkle();
            frm11.Show();
        }
    }
}
