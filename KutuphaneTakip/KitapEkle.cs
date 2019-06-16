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
    public partial class KitapEkle : Form
    {
        public KitapEkle()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();
        SqlDataAdapter adaptor = new SqlDataAdapter();
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-4KCUF77;Initial Catalog=Kutuphane_Db;Integrated Security=True");
        SqlCommand komut = new SqlCommand();


        private void GridGuncelle()
        {
            SqlCommand selectkomutu = new SqlCommand("SELECT * FROM Kitaplar", baglanti);
            ds.Clear();
            adaptor.SelectCommand = selectkomutu;
            adaptor.Fill(ds, "Kitaplar");
            adaptor.Dispose();
            baglanti.Close();
        }

        private void AlanlariTemizle()
        {
            txtBarkodNo.Clear();
            txtKitapAdi.Clear();
            txtYazarAdi.Clear();
            txtYayinEvi.Clear();
            txtSayfaSayisi.Clear();
            txtCiltNo.Clear();
            cmboBxKitapTuru.ResetText();
            cmboBxTeminTuru.ResetText();
            dTPTeminTarihi.ResetText();
            nmrcUpDownStokSayisi.ResetText();
            nmrcUpDownStokSayisi.ResetText();
        }

        private void nmrcUpDownStokSayisi_KeyDown(object sender, KeyEventArgs e)
        {

        }


        private void KitapEkle_Load(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            GridGuncelle();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            AlanlariTemizle();
        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            if (txtBarkodNo.Text == "" || txtKitapAdi.Text == "" || txtYazarAdi.Text == "" || txtYayinEvi.Text == "" || txtSayfaSayisi.Text == "" || cmboBxKitapTuru.Text == "Seçiniz..." || cmboBxTeminTuru.Text == "Seçiniz..." || txtCiltNo.Text == "")
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurunuz!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Bu kitabı kaydetmek istediğinizden emin misiniz?", "Soru Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (baglanti.State == ConnectionState.Closed)
                        {
                            baglanti.Open();
                        }

                        ds.Clear();
                        komut = new SqlCommand("INSERT INTO Kitaplar (BarkodNo, KitapAdi, YazarAdi, YayinEvi, SayfaSayisi, KitapTuru, TeminTuru, TeminTarihi, CiltNo, StokSayisi) VALUES(@BarkodNo, @KitapAdi, @YazarAdi, @YayinEvi, @SayfaSayisi, @KitapTuru, @TeminTuru, @TeminTarihi, @CiltNo, @StokSayisi)", baglanti);
                        komut.Parameters.AddWithValue("@BarkodNo", txtBarkodNo.Text);
                        komut.Parameters.AddWithValue("@KitapAdi", txtKitapAdi.Text);
                        komut.Parameters.AddWithValue("@YazarAdi", txtYazarAdi.Text);
                        komut.Parameters.AddWithValue("@YayinEvi", txtYayinEvi.Text);
                        komut.Parameters.AddWithValue("@SayfaSayisi", txtSayfaSayisi.Text);
                        komut.Parameters.AddWithValue("@KitapTuru", cmboBxKitapTuru.Text);
                        komut.Parameters.AddWithValue("@TeminTuru", cmboBxTeminTuru.Text);
                        komut.Parameters.AddWithValue("@TeminTarihi", dTPTeminTarihi.Value.Date);
                        komut.Parameters.AddWithValue("@CiltNo", txtCiltNo.Text);
                        komut.Parameters.AddWithValue("@StokSayisi", nmrcUpDownStokSayisi.Value);
                        komut.ExecuteNonQuery();

                        GridGuncelle();
                        baglanti.Close();
                        AlanlariTemizle();
                        MessageBox.Show("Kitap Başarıyla Kaydedildi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

    }
}
