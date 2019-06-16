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
    public partial class OkuyucuEkle : Form
    {
        public OkuyucuEkle()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();
        SqlDataAdapter adaptor = new SqlDataAdapter();
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-4KCUF77;Initial Catalog=Kutuphane_Db;Integrated Security=True");
        SqlCommand komut = new SqlCommand();

        private void GridGuncelle()
        {
            SqlCommand selectkomutu = new SqlCommand("SELECT * FROM Okuyucular", baglanti);
            ds.Clear();
            adaptor.SelectCommand = selectkomutu;
            adaptor.Fill(ds, "Okuyucular");
            adaptor.Dispose();
            baglanti.Close();
        }

        private void AlanlariTemizle()
        {
            txtTCKimlikNo.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            txtTelefon.Clear();
            txtEPosta.Clear();
            txtAdres.Clear();
            cmboBxDogumYeri.ResetText();
            dTPDogumTarihi.ResetText();
            dTPUyelikTarihi.ResetText();
            if (radioBtnBay.Checked)
            {
                radioBtnBay.Checked = false;
            }
            else if (radioBtnBayan.Checked)
            {
                radioBtnBayan.Checked = false;
            }
        }



        private void txtAdres_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnKaydet.PerformClick();
            }
        }
        private void OkuyucuEkle_Load(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            GridGuncelle();
        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            if (txtTCKimlikNo.Text == "" || txtAd.Text == "" || txtSoyad.Text == "" || cmboBxDogumYeri.Text == "" || txtEPosta.Text == "" || txtAdres.Text == "")
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
                        komut = new SqlCommand("INSERT INTO Okuyucular (TCKimlikNo, Ad, Soyad, DogumTarihi, DogumYeri, Telefon, Cinsiyet, UyelikTarihi, EPosta, Adres) VALUES(@TCKimlikNo, @Ad, @Soyad, @DogumTarihi, @DogumYeri, @Telefon, @Cinsiyet, @UyelikTarihi, @EPosta, @Adres)", baglanti);
                        komut.Parameters.AddWithValue("@TCKimlikNo", txtTCKimlikNo.Text);
                        komut.Parameters.AddWithValue("@Ad", txtAd.Text);
                        komut.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
                        komut.Parameters.AddWithValue("@DogumTarihi", dTPDogumTarihi.Value.Date);
                        komut.Parameters.AddWithValue("@DogumYeri", cmboBxDogumYeri.Text);
                        komut.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                        string cinsiyet = "";
                        if (radioBtnBay.Checked == true)
                        {
                            cinsiyet = radioBtnBay.Text;
                        }
                        else if (radioBtnBayan.Checked == true)
                        {
                            cinsiyet = radioBtnBayan.Text;
                        }
                        komut.Parameters.AddWithValue("@Cinsiyet", cinsiyet);
                        komut.Parameters.AddWithValue("@UyelikTarihi", dTPUyelikTarihi.Value.Date);
                        komut.Parameters.AddWithValue("@EPosta", txtEPosta.Text);
                        komut.Parameters.AddWithValue("@Adres", txtAdres.Text);
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

        private void btnTemizle_Click_1(object sender, EventArgs e)
        {
            AlanlariTemizle();
        }

        private void btnKapat_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
