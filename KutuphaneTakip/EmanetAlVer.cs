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
    public partial class EmanetAlVer : Form
    {
        public EmanetAlVer()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();
        SqlDataAdapter adaptor = new SqlDataAdapter();
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-4KCUF77;Initial Catalog=Kutuphane_Db;Integrated Security=True");
        SqlCommand komut = new SqlCommand();


        private void GridGuncelle()
        {
            SqlCommand selectkomutu = new SqlCommand("SELECT * FROM EmanetKitaplar", baglanti);
            ds.Clear();
            adaptor.SelectCommand = selectkomutu;
            adaptor.Fill(ds, "EmanetKitaplar");
            adaptor.Dispose();
            baglanti.Close();
        }

        private void EmanetAlanTemizle()
        {
            txtTCKimlikNoEmanetVer.Clear();
            txtKitapBarkodNoEmanetVer.Clear();
            dTPBaslangicTarihi.ResetText();
            cmboBxDurumEmanetVer.ResetText();
        }

        private void IadeAlanTemizle()
        {
            txtTCKimlikNoIadeAl.Clear();
            txtKitapBarkodNoIadeAl.Clear();
            cmboBxDurumIadeAl.ResetText();
        }


        private void EmanetAlVer_Load(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            GridGuncelle();
        }

        private void btnEmanetVer_Click(object sender, EventArgs e)
        {
            if (txtTCKimlikNoEmanetVer.Text == "" || txtKitapBarkodNoEmanetVer.Text == "")
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurunuz!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                IadeAlanTemizle();
                if (MessageBox.Show("Bu kitabı emanet vermek istediğinizden emin misiniz?", "Soru Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (baglanti.State == ConnectionState.Closed)
                        {
                            baglanti.Open();
                        }

                        if (txtTCKimlikNoEmanetVer.Text != "" || txtKitapBarkodNoEmanetVer.Text != "")
                        {
                            SqlCommand komut = new SqlCommand("INSERT INTO EmanetKitaplar (KisiTCKimlikNo, KitapBarkodNo, BaslangicTarihi, KitapDurumu, TeslimDurumu) VALUES(@KisiTCKimlikNo, @KitapBarkodNo, @BaslangicTarihi, @KitapDurumu, @TeslimDurumu)", baglanti);
                            komut.Parameters.AddWithValue("@KisiTCKimlikNo", txtTCKimlikNoEmanetVer.Text);
                            komut.Parameters.AddWithValue("@KitapBarkodNo", txtKitapBarkodNoEmanetVer.Text);
                            komut.Parameters.AddWithValue("@BaslangicTarihi", dTPBaslangicTarihi.Value.Date);
                            komut.Parameters.AddWithValue("@KitapDurumu", cmboBxDurumEmanetVer.Text);
                            komut.Parameters.AddWithValue("@TeslimDurumu", txtTeslimDurumEmanetVer.Text);
                            komut.ExecuteNonQuery();

                            SqlCommand sorgu2 = new SqlCommand("UPDATE Kitaplar SET StokSayisi=StokSayisi-1 WHERE BarkodNo='" + txtKitapBarkodNoEmanetVer.Text + "'", baglanti);
                            sorgu2.ExecuteNonQuery();
                            EmanetAlanTemizle();
                            MessageBox.Show("Kitap Başarıyla Emanet Verildi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {

                        if (baglanti.State == ConnectionState.Open)
                        {
                            baglanti.Close();
                        }
                    }
                }
                else
                {
                    EmanetAlanTemizle();
                    GridGuncelle();
                }
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            GridGuncelle();
        }

        private void btnIadeAl_Click(object sender, EventArgs e)
        {
            if (txtTCKimlikNoIadeAl.Text == "" || txtKitapBarkodNoIadeAl.Text == "")
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurunuz!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                EmanetAlanTemizle();
                if (MessageBox.Show("Bu kitabı iade almak istediğinizden emin misiniz?", "Soru Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (baglanti.State == ConnectionState.Closed)
                        {
                            baglanti.Open();
                        }


                        SqlCommand durum = new SqlCommand("SELECT COUNT(*) AS Durum FROM EmanetKitaplar WHERE TeslimDurumu='Hayır' AND KitapBarkodNo=@KitapBarkodNo", baglanti);
                        durum.Parameters.AddWithValue("@KitapBarkodNo", txtKitapBarkodNoIadeAl.Text);
                        DataTable tablo = new DataTable();
                        SqlDataAdapter adaptor2 = new SqlDataAdapter(durum);
                        adaptor2.Fill(tablo);

                        if (tablo.Rows[0]["Durum"].ToString() != "0")
                        {
                            SqlCommand komut = new SqlCommand("UPDATE EmanetKitaplar SET KitapDurumu='" + cmboBxDurumIadeAl.Text + "', TeslimDurumu= '" + txtTeslimDurumIadeAl.Text + "' WHERE KisiTCKimlikNo='" + txtTCKimlikNoIadeAl.Text + "' AND KitapBarkodNo='" + txtKitapBarkodNoIadeAl.Text + "'", baglanti);
                            komut.ExecuteNonQuery();
                            SqlCommand sorgu2 = new SqlCommand("UPDATE Kitaplar SET StokSayisi=StokSayisi+1 WHERE BarkodNo='" + txtKitapBarkodNoIadeAl.Text + "'", baglanti);
                            sorgu2.ExecuteNonQuery();
                            GridGuncelle();
                            IadeAlanTemizle();
                            MessageBox.Show("Kitap Başarıyla İade Alındı.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Seçtiğiniz kitap zaten iade alınmıştır.", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            IadeAlanTemizle();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {

                        if (baglanti.State == ConnectionState.Open)
                        {
                            baglanti.Close();
                        }
                    }
                }
                else
                {
                    IadeAlanTemizle();
                    GridGuncelle();
                }
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {

            this.Hide();

        }


    }
}
