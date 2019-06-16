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
    public partial class KitaplariListele : Form
    {
        public KitaplariListele()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();
        SqlDataAdapter adaptor = new SqlDataAdapter();
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-4KCUF77;Initial Catalog=Kutuphane_Db;Integrated Security=True");
        SqlCommand komut = new SqlCommand();

        private void GridGuncelle()
        {
            SqlCommand selectKomutu = new SqlCommand("SELECT * FROM Kitaplar", baglanti);
            ds.Clear();
            adaptor.SelectCommand = selectKomutu;
            dataGridViewKitaplariListele.Update();
            adaptor.Fill(ds, "Kitaplar");
            dataGridViewKitaplariListele.DataSource = ds.Tables["Kitaplar"];
            adaptor.Dispose();

            SqlCommand kitapSayisi = new SqlCommand("SELECT Count(*) FROM Kitaplar", baglanti);
            lblKitapSayisi.Text = "Kayıtlı Kitap Sayısı: " + (int)kitapSayisi.ExecuteScalar();
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
            txtArama.Clear();
            cmboBxKitapTuru.ResetText();
            cmboBxTeminTuru.ResetText();
            dTPTeminTarihi.ResetText();
            nmrcUpDownStokSayisi.ResetText();
            dTPTeminTarihi.ResetText();
            cmboBxAramaTuru.ResetText();
        }

       

       

        private void Form3_Load(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            GridGuncelle();
        }


        private void btnAra_Click_1(object sender, EventArgs e)
        {
            if (cmboBxAramaTuru.SelectedIndex == 0)
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                try
                {
                    komut = new SqlCommand("SELECT * FROM Kitaplar WHERE BarkodNo Like '" + txtArama.Text + "%'", baglanti);
                    komut.ExecuteNonQuery();
                    ds.Clear();
                    adaptor.SelectCommand = komut;
                    dataGridViewKitaplariListele.Update();
                    adaptor.Fill(ds, "Kitaplar");
                    dataGridViewKitaplariListele.DataSource = ds.Tables["Kitaplar"];
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
                    komut = new SqlCommand("SELECT * FROM Kitaplar WHERE KitapAdi Like '" + txtArama.Text + "%'", baglanti);
                    komut.ExecuteNonQuery();
                    ds.Clear();
                    adaptor.SelectCommand = komut;
                    dataGridViewKitaplariListele.Update();
                    adaptor.Fill(ds, "Kitaplar");
                    dataGridViewKitaplariListele.DataSource = ds.Tables["Kitaplar"];
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
                    komut = new SqlCommand("SELECT * FROM Kitaplar WHERE YazarAdi Like '" + txtArama.Text + "%'", baglanti);
                    komut.ExecuteNonQuery();
                    ds.Clear();
                    adaptor.SelectCommand = komut;
                    dataGridViewKitaplariListele.Update();
                    adaptor.Fill(ds, "Kitaplar");
                    dataGridViewKitaplariListele.DataSource = ds.Tables["Kitaplar"];
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
                    komut = new SqlCommand("SELECT * FROM Kitaplar WHERE YayinEvi Like '" + txtArama.Text + "%'", baglanti);
                    komut.ExecuteNonQuery();
                    ds.Clear();
                    adaptor.SelectCommand = komut;
                    dataGridViewKitaplariListele.Update();
                    adaptor.Fill(ds, "Kitaplar");
                    dataGridViewKitaplariListele.DataSource = ds.Tables["Kitaplar"];
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
                    komut = new SqlCommand("SELECT * FROM Kitaplar WHERE SayfaSayisi Like '" + txtArama.Text + "%'", baglanti);
                    komut.ExecuteNonQuery();
                    ds.Clear();
                    adaptor.SelectCommand = komut;
                    dataGridViewKitaplariListele.Update();
                    adaptor.Fill(ds, "Kitaplar");
                    dataGridViewKitaplariListele.DataSource = ds.Tables["Kitaplar"];
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
                    komut = new SqlCommand("SELECT * FROM Kitaplar WHERE KitapTuru Like '" + txtArama.Text + "%'", baglanti);
                    komut.ExecuteNonQuery();
                    ds.Clear();
                    adaptor.SelectCommand = komut;
                    dataGridViewKitaplariListele.Update();
                    adaptor.Fill(ds, "Kitaplar");
                    dataGridViewKitaplariListele.DataSource = ds.Tables["Kitaplar"];
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
                    komut = new SqlCommand("SELECT * FROM Kitaplar WHERE TeminTuru Like '" + txtArama.Text + "%'", baglanti);
                    komut.ExecuteNonQuery();
                    ds.Clear();
                    adaptor.SelectCommand = komut;
                    dataGridViewKitaplariListele.Update();
                    adaptor.Fill(ds, "Kitaplar");
                    dataGridViewKitaplariListele.DataSource = ds.Tables["Kitaplar"];
                    adaptor.Dispose();
                    baglanti.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (cmboBxAramaTuru.SelectedIndex == 7)
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                try
                {
                    komut = new SqlCommand("SELECT * FROM Kitaplar WHERE CiltNo Like '" + txtArama.Text + "%'", baglanti);
                    komut.ExecuteNonQuery();
                    ds.Clear();
                    adaptor.SelectCommand = komut;
                    dataGridViewKitaplariListele.Update();
                    adaptor.Fill(ds, "Kitaplar");
                    dataGridViewKitaplariListele.DataSource = ds.Tables["Kitaplar"];
                    adaptor.Dispose();
                    baglanti.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (cmboBxAramaTuru.SelectedIndex == 8)
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                try
                {
                    komut = new SqlCommand("SELECT * FROM Kitaplar WHERE StokSayisi Like '" + txtArama.Text + "%'", baglanti);
                    komut.ExecuteNonQuery();
                    ds.Clear();
                    adaptor.SelectCommand = komut;
                    dataGridViewKitaplariListele.Update();
                    adaptor.Fill(ds, "Kitaplar");
                    dataGridViewKitaplariListele.DataSource = ds.Tables["Kitaplar"];
                    adaptor.Dispose();
                    baglanti.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void dataGridViewKitaplariListele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int satirNo;
                satirNo = e.RowIndex;
                txtBarkodNo.Text = dataGridViewKitaplariListele.Rows[satirNo].Cells[0].Value.ToString();
                txtKitapAdi.Text = dataGridViewKitaplariListele.Rows[satirNo].Cells[1].Value.ToString();
                txtYazarAdi.Text = dataGridViewKitaplariListele.Rows[satirNo].Cells[2].Value.ToString();
                txtYayinEvi.Text = dataGridViewKitaplariListele.Rows[satirNo].Cells[3].Value.ToString();
                txtSayfaSayisi.Text = dataGridViewKitaplariListele.Rows[satirNo].Cells[4].Value.ToString();
                cmboBxKitapTuru.Text = dataGridViewKitaplariListele.Rows[satirNo].Cells[5].Value.ToString();
                cmboBxTeminTuru.Text = dataGridViewKitaplariListele.Rows[satirNo].Cells[6].Value.ToString();
                dTPTeminTarihi.Text = dataGridViewKitaplariListele.Rows[satirNo].Cells[7].Value.ToString();
                txtCiltNo.Text = dataGridViewKitaplariListele.Rows[satirNo].Cells[8].Value.ToString();
                nmrcUpDownStokSayisi.Text = dataGridViewKitaplariListele.Rows[satirNo].Cells[9].Value.ToString();
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
                btnAra.PerformClick();
            }
        }

        private void KitaplariListele_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtBarkodNo.Text == "" || txtKitapAdi.Text == "" || txtYazarAdi.Text == "" || txtYayinEvi.Text == "" || txtSayfaSayisi.Text == "" || cmboBxKitapTuru.Text == "Seçiniz..." || cmboBxTeminTuru.Text == "Seçiniz..." || txtCiltNo.Text == "")
            {
                MessageBox.Show("Lütfen Güncellemek İstediğiniz Kitabı Seçiniz!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Bu kitabı güncellemek istediğinizden emin misiniz?", "Soru Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (baglanti.State == ConnectionState.Closed)
                        {
                            baglanti.Open();
                        }
                        ds.Clear();
                        SqlCommand guncelleKomutu = new SqlCommand("UPDATE Kitaplar Set KitapAdi= '" + txtKitapAdi.Text + "', YazarAdi= '" + txtYazarAdi.Text + "', YayinEvi= '" + txtYayinEvi.Text + "', SayfaSayisi= '" + txtSayfaSayisi.Text + "', KitapTuru= '" + cmboBxKitapTuru.Text + "', TeminTuru= '" + cmboBxTeminTuru.Text + "', TeminTarihi= '" + dTPTeminTarihi.Value.Date + "', CiltNo= '" + txtCiltNo.Text + "', StokSayisi= '" + nmrcUpDownStokSayisi.Value + "' WHERE BarkodNo= '" + txtBarkodNo.Text + "'", baglanti);
                        guncelleKomutu.ExecuteNonQuery();

                        ds.Clear();
                        SqlCommand selectKomutu = new SqlCommand("SELECT * FROM Kitaplar", baglanti);
                        adaptor.SelectCommand = selectKomutu;
                        dataGridViewKitaplariListele.Update();
                        adaptor.Fill(ds, "Kitaplar");
                        dataGridViewKitaplariListele.DataSource = ds.Tables["Kitaplar"];
                        SqlCommand kitapSayisi = new SqlCommand("SELECT Count(*) FROM Kitaplar", baglanti);
                        lblKitapSayisi.Text = "Kayıtlı Kitap Sayısı: " + (int)kitapSayisi.ExecuteScalar();
                        adaptor.Dispose();
                        AlanlariTemizle();

                        MessageBox.Show("Kitap Başarıyla Güncellendi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        baglanti.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBarkodNo.Text == "")
            {
                MessageBox.Show("Lütfen Silmek İstediğiniz Kitabı Seçiniz!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Bu kitabı silmek istediğinizden emin misiniz?", "Soru Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (baglanti.State == ConnectionState.Closed)
                        {
                            baglanti.Open();
                            ds.Clear();
                            SqlCommand silKomutu = new SqlCommand("DELETE FROM  Kitaplar WHERE BarkodNo= '" + txtBarkodNo.Text + "'", baglanti);
                            silKomutu.ExecuteNonQuery();

                            SqlCommand selectKomutu = new SqlCommand("SELECT * FROM Kitaplar", baglanti);
                            ds.Clear();
                            adaptor.SelectCommand = selectKomutu;
                            dataGridViewKitaplariListele.Update();
                            adaptor.Fill(ds, "Kitaplar");
                            dataGridViewKitaplariListele.DataSource = ds.Tables["Kitaplar"];
                            SqlCommand kitapSayisi = new SqlCommand("SELECT Count(*) FROM Kitaplar", baglanti);
                            lblKitapSayisi.Text = "Kayıtlı Kitap Sayısı: " + (int)kitapSayisi.ExecuteScalar();
                            adaptor.Dispose();
                            AlanlariTemizle();
                            MessageBox.Show("Kitap Başarıyla Silindi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnCikis_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
        
    }

    

}
