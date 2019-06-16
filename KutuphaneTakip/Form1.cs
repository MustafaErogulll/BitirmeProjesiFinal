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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-4KCUF77;Initial Catalog=Kutuphane_Db;Integrated Security=True");
        SqlCommand komut = new SqlCommand();


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAdmGiris_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "" || txtKullaniciSifresi.Text == "")
            {
                MessageBox.Show("Lütfen Kullanıcı Adı ve Şifrenizi Giriniz!", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();
                        komut = new SqlCommand("SELECT Count(*) FROM AdminGirisi WHERE KullaniciAdi = '" + txtKullaniciAdi.Text + "' AND KullaniciSifresi = '" + txtKullaniciSifresi.Text + "'", baglanti);
                        int sonuc;
                        sonuc = (int)komut.ExecuteScalar();
                        if (sonuc == 1)
                        {
                            MessageBox.Show("Sisteme Başarılı Bir Şekilde Giriş Yapıldı!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AdminPaneli frm2 = new AdminPaneli();
                            frm2.Show();
                            this.Hide();
                            baglanti.Close();
                        }
                        else
                        {
                            MessageBox.Show("Girdiğiniz Kullanıcı Adınız veya Şifreniz Hatalı! Lütfen Kontrol Edip Tekrar Deneyiniz.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            baglanti.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        

        private void txtKullaniciSifresi_TextChanged(object sender, EventArgs e)
        {
            txtKullaniciSifresi.PasswordChar = '*';
        }

    
        private void txtKullaniciAdi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnKapat.PerformClick();
            }
        }

        private void txtKullaniciSifresi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdmGiris.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btnKapat.PerformClick();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Programı kapatmak istediğinizden emin misiniz?", "Çıkış Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnKulGiris_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "" || txtKullaniciSifresi.Text == "")
            {
                MessageBox.Show("Lütfen Kullanıcı Adı ve Şifrenizi Giriniz!", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();
                        komut = new SqlCommand("SELECT Count(*) FROM KullaniciGirisi WHERE KullaniciAdi = '" + txtKullaniciAdi.Text + "' AND KullaniciSifresi = '" + txtKullaniciSifresi.Text + "'", baglanti);
                        int sonuc;
                        sonuc = (int)komut.ExecuteScalar();
                        if (sonuc == 1)
                        {
                            MessageBox.Show("Sisteme Başarılı Bir Şekilde Giriş Yapıldı!", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            KullaniciPaneli frm3 = new KullaniciPaneli();
                            frm3.Show();
                            this.Hide();
                            baglanti.Close();
                        }
                        else
                        {
                            MessageBox.Show("Girdiğiniz Kullanıcı Adınız veya Şifreniz Hatalı! Lütfen Kontrol Edip Tekrar Deneyiniz.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            baglanti.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void chckBxSifreyiGoster_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chckBxSifreyiGoster.Checked)
            {
                txtKullaniciSifresi.PasswordChar = '\0';
            }
            else
            {
                txtKullaniciSifresi.PasswordChar = '*';
            }
        }
    
    }
}
