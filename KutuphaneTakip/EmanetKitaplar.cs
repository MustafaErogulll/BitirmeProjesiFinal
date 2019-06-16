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
    public partial class EmanetKitaplar : Form
    {
        public EmanetKitaplar()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();
        SqlDataAdapter adaptor = new SqlDataAdapter();
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-4KCUF77;Initial Catalog=Kutuphane_Db;Integrated Security=True");
        SqlCommand komut = new SqlCommand();

        private void GridGuncelle()
        {
            SqlCommand selectKomutu = new SqlCommand("SELECT * FROM EmanetKitaplar", baglanti);
            ds.Clear();
            adaptor.SelectCommand = selectKomutu;
            dataGridViewEmanetKitaplar.Update();
            adaptor.Fill(ds, "EmanetKitaplar");
            dataGridViewEmanetKitaplar.DataSource = ds.Tables["EmanetKitaplar"];
            adaptor.Dispose();

            SqlCommand EmanetKitapSayisi = new SqlCommand("SELECT Count(*) FROM EmanetKitaplar", baglanti);
            lblEmanetKitapSayisi.Text = "Emanet Verilen Kitap Sayısı: " + (int)EmanetKitapSayisi.ExecuteScalar();
            adaptor.Dispose();
            baglanti.Close();
        }

        private void AlanlariTemizle()
        {
            txtArama.Clear();
            cmboBxAramaTuru.ResetText();
        }

        private void EmanetKitaplar_Load(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            GridGuncelle();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (cmboBxAramaTuru.SelectedIndex == 0)
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                try
                {
                    komut = new SqlCommand("SELECT * FROM EmanetKitaplar WHERE KitapID Like '" + txtArama.Text + "%'", baglanti);
                    komut.ExecuteNonQuery();
                    ds.Clear();
                    adaptor.SelectCommand = komut;
                    dataGridViewEmanetKitaplar.Update();
                    adaptor.Fill(ds, "EmanetKitaplar");
                    dataGridViewEmanetKitaplar.DataSource = ds.Tables["EmanetKitaplar"];
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
                    komut = new SqlCommand("SELECT * FROM EmanetKitaplar WHERE KisiTCKimlikNo Like '" + txtArama.Text + "%'", baglanti);
                    komut.ExecuteNonQuery();
                    ds.Clear();
                    adaptor.SelectCommand = komut;
                    dataGridViewEmanetKitaplar.Update();
                    adaptor.Fill(ds, "EmanetKitaplar");
                    dataGridViewEmanetKitaplar.DataSource = ds.Tables["EmanetKitaplar"];
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
                    komut = new SqlCommand("SELECT * FROM EmanetKitaplar WHERE KitapBarkodNo Like '" + txtArama.Text + "%'", baglanti);
                    komut.ExecuteNonQuery();
                    ds.Clear();
                    adaptor.SelectCommand = komut;
                    dataGridViewEmanetKitaplar.Update();
                    adaptor.Fill(ds, "EmanetKitaplar");
                    dataGridViewEmanetKitaplar.DataSource = ds.Tables["EmanetKitaplar"];
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
                    komut = new SqlCommand("SELECT * FROM EmanetKitaplar WHERE KitapDurumu Like '" + txtArama.Text + "%'", baglanti);
                    komut.ExecuteNonQuery();
                    ds.Clear();
                    adaptor.SelectCommand = komut;
                    dataGridViewEmanetKitaplar.Update();
                    adaptor.Fill(ds, "EmanetKitaplar");
                    dataGridViewEmanetKitaplar.DataSource = ds.Tables["EmanetKitaplar"];
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
                    komut = new SqlCommand("SELECT * FROM EmanetKitaplar WHERE TeslimDurumu Like '" + txtArama.Text + "%'", baglanti);
                    komut.ExecuteNonQuery();
                    ds.Clear();
                    adaptor.SelectCommand = komut;
                    dataGridViewEmanetKitaplar.Update();
                    adaptor.Fill(ds, "EmanetKitaplar");
                    dataGridViewEmanetKitaplar.DataSource = ds.Tables["EmanetKitaplar"];
                    adaptor.Dispose();
                    baglanti.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            GridGuncelle();
            AlanlariTemizle();

        }

        private void dataGridViewEmanetKitaplar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                btnYenile.PerformClick();
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtAra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAra.PerformClick();
            }
        }


        private void dataGridViewEmanetKitaplar_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TimeSpan kalan = Convert.ToDateTime(dataGridViewEmanetKitaplar.SelectedRows[0].Cells["BaslangicTarihi"].Value) - DateTime.Today  ;
            lblTarih.Text = "Kitabı aldığınız günden bu güne kadar geçen süre " + kalan.Days.ToString() + " gündür . Lütfen 30 günü aşmadan teslim ediniz." ;


        }










    }
}
