using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneTakip
{
    public partial class KullaniciEkle : Form
    {
        public KullaniciEkle()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();
        SqlDataAdapter adaptor = new SqlDataAdapter();
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-4KCUF77;Initial Catalog=Kutuphane_Db;Integrated Security=True");
        SqlCommand komut = new SqlCommand();

        private void GridGuncelle()
        {
            SqlCommand selectkomutu = new SqlCommand("SELECT * FROM KullaniciGirisi", baglanti);
            ds.Clear();
            adaptor.SelectCommand = selectkomutu;
            adaptor.Fill(ds, "KullaniciGirisi");
            adaptor.Dispose();
            baglanti.Close();
        }

        private void AlanlariTemizle()
        {
            txtKullaniciAdi.Clear();
            txtSifre.Clear();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            AlanlariTemizle();
        }


        private void KullaniciEkle_Load(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            GridGuncelle();
        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "" || txtSifre.Text == "")
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurunuz!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Bu kişiyi kaydetmek istediğinizden emin misiniz?", "Soru Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (baglanti.State == ConnectionState.Closed)
                        {
                            baglanti.Open();
                        }
                        ds.Clear();
                        komut = new SqlCommand("INSERT INTO KullaniciGirisi (KullaniciAdi, KullaniciSifresi) VALUES(@KullaniciAdi, @KullaniciSifresi)", baglanti);
                        komut.Parameters.AddWithValue("@KullaniciAdi", txtKullaniciAdi.Text);
                        komut.Parameters.AddWithValue("@KullaniciSifresi", txtSifre.Text);
                        komut.ExecuteNonQuery();
                        GridGuncelle();
                        baglanti.Close();
                        AlanlariTemizle();
                        MessageBox.Show("Kişi Başarıyla Kaydedildi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    GridGuncelle();
                    AlanlariTemizle();
                }
            }
        }

        private void btnKapat_Click_1(object sender, EventArgs e)
        {

            this.Hide();
        }
    }
}
