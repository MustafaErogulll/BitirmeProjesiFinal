using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KutuphaneTakip
{
    public partial class KullaniciPaneli : Form
    {
        public KullaniciPaneli()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void btnEmanetAlVer_Click(object sender, EventArgs e)
        {
            EmanetAlVer frm6 = new EmanetAlVer();
            frm6.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OkuyuculariListele frm7 = new OkuyuculariListele();
            frm7.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OkuyucuEkle frm8 = new OkuyucuEkle();
            frm8.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmanetKitaplar frm9 = new EmanetKitaplar();
            frm9.Show();

        }
    }
}
