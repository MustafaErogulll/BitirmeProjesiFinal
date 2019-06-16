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
    public partial class OkuyuculariListele : Form
    {
        public OkuyuculariListele()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();
        SqlDataAdapter adaptor = new SqlDataAdapter();
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-4KCUF77;Initial Catalog=Kutuphane_Db;Integrated Security=True");
        SqlCommand komut = new SqlCommand();

        private void GridGuncelle()
        {
            SqlCommand selectKomutu = new SqlCommand("SELECT * FROM Okuyucular", baglanti);
            ds.Clear();
            adaptor.SelectCommand = selectKomutu;
            dataGridViewOkuyucuListesi.Update();
            adaptor.Fill(ds, "Okuyucular");
            dataGridViewOkuyucuListesi.DataSource = ds.Tables["Okuyucular"];
            adaptor.Dispose();

            SqlCommand kitapSayisi = new SqlCommand("SELECT Count(*) FROM Okuyucular", baglanti);
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
            txtArama.Clear();
            cmboBxAramaTuru.ResetText();
            cmboBxDogumYeri.ResetText();
            cmboBxCinsiyet.ResetText();
            dTPDogumTarihi.ResetText();
            dTPUyelikTarihi.ResetText();
            cmboBxAramaTuru.ResetText();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtTCKimlikNo.Text == "" || txtAd.Text == "" || txtSoyad.Text == "" || cmboBxDogumYeri.Text == "Seçiniz..." || cmboBxCinsiyet.Text == "Seçiniz..." || txtEPosta.Text == "" || txtAdres.Text == "")
            {
                MessageBox.Show("Lütfen Güncellemek İstediğiniz Kişiyi Seçiniz!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Bu kişiyi güncellemek istediğinizden emin misiniz?", "Soru Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (baglanti.State == ConnectionState.Closed)
                        {
                            baglanti.Open();
                        }
                        ds.Clear();
                        SqlCommand guncelleKomutu = new SqlCommand("UPDATE Okuyucular Set Ad= '" + txtAd.Text + "', Soyad= '" + txtSoyad.Text + "', DogumTarihi= '" + dTPDogumTarihi.Value.Date + "', DogumYeri= '" + cmboBxDogumYeri.Text + "', Telefon= '" + txtTelefon.Text + "', Cinsiyet= '" + cmboBxCinsiyet.Text + "', UyelikTarihi= '" + dTPUyelikTarihi.Value.Date + "', EPosta= '" + txtEPosta.Text + "', Adres= '" + txtAdres.Text + "' WHERE TCKimlikNo= '" + txtTCKimlikNo.Text + "'", baglanti);
                        guncelleKomutu.ExecuteNonQuery();

                        SqlCommand selectKomutu = new SqlCommand("SELECT * FROM Okuyucular", baglanti);
                        ds.Clear();
                        adaptor.SelectCommand = selectKomutu;
                        dataGridViewOkuyucuListesi.Update();
                        adaptor.Fill(ds, "Okuyucular");
                        dataGridViewOkuyucuListesi.DataSource = ds.Tables["Okuyucular"];

                        SqlCommand kisiSayisi = new SqlCommand("SELECT Count(*) FROM Okuyucular", baglanti);
                        lblKisiSayisi.Text = "Kayıtlı Kişi Sayısı " + (int)kisiSayisi.ExecuteScalar();
                        adaptor.Dispose();
                        baglanti.Close();

                        AlanlariTemizle();
                        MessageBox.Show("Kişi Başarıyla Güncellendi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();
                    }
                    GridGuncelle();
                    AlanlariTemizle();
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtTCKimlikNo.Text == "")
            {
                MessageBox.Show("Lütfen Silmek İstediğiniz Kişiyi Seçiniz!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Bu kişiyi silmek istediğinizden emin misiniz?", "Soru Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (baglanti.State == ConnectionState.Closed)
                        {
                            baglanti.Open();
                            ds.Clear();
                            SqlCommand silKomutu = new SqlCommand("DELETE  FROM Okuyucular WHERE TCKimlikNo = '" + txtTCKimlikNo.Text + "'", baglanti);
                            silKomutu.ExecuteNonQuery();

                            SqlCommand selectKomutu = new SqlCommand("SELECT * FROM Okuyucular", baglanti);
                            ds.Clear();
                            adaptor.SelectCommand = selectKomutu;
                            dataGridViewOkuyucuListesi.Update();
                            adaptor.Fill(ds, "Okuyucular");
                            dataGridViewOkuyucuListesi.DataSource = ds.Tables["Okuyucular"];

                            SqlCommand kitapSayisi = new SqlCommand("SELECT Count(*) FROM Okuyucular", baglanti);
                            lblKisiSayisi.Text = "Kayıtlı Kişi Sayısı: " + (int)kitapSayisi.ExecuteScalar();
                            adaptor.Dispose();
                            AlanlariTemizle();
                            MessageBox.Show("Kişi Başarıyla Silindi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            GridGuncelle();
                            baglanti.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();
                    }
                    GridGuncelle();
                    AlanlariTemizle();
                }
            }
        }





        private void OkuyuculariListele_Load(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            GridGuncelle();
        }

        private void dataGridViewOkuyucuListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int satirNo;
                satirNo = e.RowIndex;
                txtTCKimlikNo.Text = dataGridViewOkuyucuListesi.Rows[satirNo].Cells[0].Value.ToString();
                txtAd.Text = dataGridViewOkuyucuListesi.Rows[satirNo].Cells[1].Value.ToString();
                txtSoyad.Text = dataGridViewOkuyucuListesi.Rows[satirNo].Cells[2].Value.ToString();
                dTPDogumTarihi.Text = dataGridViewOkuyucuListesi.Rows[satirNo].Cells[3].Value.ToString();
                cmboBxDogumYeri.Text = dataGridViewOkuyucuListesi.Rows[satirNo].Cells[4].Value.ToString();
                txtTelefon.Text = dataGridViewOkuyucuListesi.Rows[satirNo].Cells[5].Value.ToString();
                cmboBxCinsiyet.Text = dataGridViewOkuyucuListesi.Rows[satirNo].Cells[6].Value.ToString();
                dTPUyelikTarihi.Text = dataGridViewOkuyucuListesi.Rows[satirNo].Cells[7].Value.ToString();
                txtEPosta.Text = dataGridViewOkuyucuListesi.Rows[satirNo].Cells[8].Value.ToString();
                txtAdres.Text = dataGridViewOkuyucuListesi.Rows[satirNo].Cells[9].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtAra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Ara.PerformClick();
            }
        }

        private void btnCikis_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Ara_Click(object sender, EventArgs e)
        {
            if (cmboBxAramaTuru.SelectedIndex == 0)
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                try
                {
                    komut = new SqlCommand("SELECT * FROM Okuyucular WHERE TCKimlikNo Like '" + txtArama.Text + "%'", baglanti);
                    komut.ExecuteNonQuery();
                    ds.Clear();
                    adaptor.SelectCommand = komut;
                    dataGridViewOkuyucuListesi.Update();
                    adaptor.Fill(ds, "Okuyucular");
                    dataGridViewOkuyucuListesi.DataSource = ds.Tables["Okuyucular"];
                    adaptor.Dispose();
                    baglanti.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (cmboBxAramaTuru.SelectedIndex == 1)
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                try
                {
                    komut = new SqlCommand("SELECT * FROM Okuyucular WHERE Ad Like '" + txtArama.Text + "%'", baglanti);
                    komut.ExecuteNonQuery();
                    ds.Clear();
                    adaptor.SelectCommand = komut;
                    dataGridViewOkuyucuListesi.Update();
                    adaptor.Fill(ds, "Okuyucular");
                    dataGridViewOkuyucuListesi.DataSource = ds.Tables["Okuyucular"];
                    adaptor.Dispose();
                    baglanti.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (cmboBxAramaTuru.SelectedIndex == 2)
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                try
                {
                    komut = new SqlCommand("SELECT * FROM Okuyucular WHERE Soyad Like '" + txtArama.Text + "%'", baglanti);
                    komut.ExecuteNonQuery();
                    ds.Clear();
                    adaptor.SelectCommand = komut;
                    dataGridViewOkuyucuListesi.Update();
                    adaptor.Fill(ds, "Okuyucular");
                    dataGridViewOkuyucuListesi.DataSource = ds.Tables["Okuyucular"];
                    adaptor.Dispose();
                    baglanti.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (cmboBxAramaTuru.SelectedIndex == 3)
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                try
                {
                    komut = new SqlCommand("SELECT * FROM Okuyucular WHERE DogumYeri Like '" + txtArama.Text + "%'", baglanti);
                    komut.ExecuteNonQuery();
                    ds.Clear();
                    adaptor.SelectCommand = komut;
                    dataGridViewOkuyucuListesi.Update();
                    adaptor.Fill(ds, "Okuyucular");
                    dataGridViewOkuyucuListesi.DataSource = ds.Tables["Okuyucular"];
                    adaptor.Dispose();
                    baglanti.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (cmboBxAramaTuru.SelectedIndex == 4)
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                try
                {
                    komut = new SqlCommand("SELECT * FROM Okuyucular WHERE Cinsiyet Like '" + txtArama.Text + "%'", baglanti);
                    komut.ExecuteNonQuery();
                    ds.Clear();
                    adaptor.SelectCommand = komut;
                    dataGridViewOkuyucuListesi.Update();
                    adaptor.Fill(ds, "Okuyucular");
                    dataGridViewOkuyucuListesi.DataSource = ds.Tables["Okuyucular"];
                    adaptor.Dispose();
                    baglanti.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (cmboBxAramaTuru.SelectedIndex == 5)
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                try
                {
                    komut = new SqlCommand("SELECT * FROM Okuyucular WHERE EPosta Like '" + txtArama.Text + "%'", baglanti);
                    komut.ExecuteNonQuery();
                    ds.Clear();
                    adaptor.SelectCommand = komut;
                    dataGridViewOkuyucuListesi.Update();
                    adaptor.Fill(ds, "Okuyucular");
                    dataGridViewOkuyucuListesi.DataSource = ds.Tables["Okuyucular"];
                    adaptor.Dispose();
                    baglanti.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (cmboBxAramaTuru.SelectedIndex == 6)
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                try
                {
                    komut = new SqlCommand("SELECT * FROM Okuyucular WHERE Adres Like '" + txtArama.Text + "%'", baglanti);
                    komut.ExecuteNonQuery();
                    ds.Clear();
                    adaptor.SelectCommand = komut;
                    dataGridViewOkuyucuListesi.Update();
                    adaptor.Fill(ds, "Okuyucular");
                    dataGridViewOkuyucuListesi.DataSource = ds.Tables["Okuyucular"];
                    adaptor.Dispose();
                    baglanti.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }  
  
            }

        }
    }

