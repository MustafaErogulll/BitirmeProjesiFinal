namespace KutuphaneTakip
{
    partial class KitapEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapEkle));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnKapat = new System.Windows.Forms.Button();
            this.ımageListKapat = new System.Windows.Forms.ImageList(this.components);
            this.btnTemizle = new System.Windows.Forms.Button();
            this.ımageListTemizle = new System.Windows.Forms.ImageList(this.components);
            this.btnKaydet = new System.Windows.Forms.Button();
            this.ımageListKaydet = new System.Windows.Forms.ImageList(this.components);
            this.cmboBxTeminTuru = new System.Windows.Forms.ComboBox();
            this.txtCiltNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.grpBxKitapEkle = new System.Windows.Forms.GroupBox();
            this.txtSayfaSayisi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nmrcUpDownStokSayisi = new System.Windows.Forms.NumericUpDown();
            this.dTPTeminTarihi = new System.Windows.Forms.DateTimePicker();
            this.cmboBxKitapTuru = new System.Windows.Forms.ComboBox();
            this.txtYayinEvi = new System.Windows.Forms.TextBox();
            this.txtYazarAdi = new System.Windows.Forms.TextBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBxKitapEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDownStokSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.SystemColors.Window;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKapat.ImageKey = "cancel.png";
            this.btnKapat.ImageList = this.ımageListKapat;
            this.btnKapat.Location = new System.Drawing.Point(15, 198);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(126, 32);
            this.btnKapat.TabIndex = 61;
            this.btnKapat.Text = "Kapat             ";
            this.btnKapat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.btnKapat, "Kapat");
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // ımageListKapat
            // 
            this.ımageListKapat.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageListKapat.ImageStream")));
            this.ımageListKapat.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageListKapat.Images.SetKeyName(0, "cancel.png");
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.SystemColors.Window;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTemizle.ImageKey = "clean.png";
            this.btnTemizle.ImageList = this.ımageListTemizle;
            this.btnTemizle.Location = new System.Drawing.Point(158, 198);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(126, 32);
            this.btnTemizle.TabIndex = 59;
            this.btnTemizle.Text = "Temizle           ";
            this.btnTemizle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.btnTemizle, "Temizle");
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // ımageListTemizle
            // 
            this.ımageListTemizle.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageListTemizle.ImageStream")));
            this.ımageListTemizle.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageListTemizle.Images.SetKeyName(0, "clean.png");
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.SystemColors.Window;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKaydet.ImageKey = "save.png";
            this.btnKaydet.ImageList = this.ımageListKaydet;
            this.btnKaydet.Location = new System.Drawing.Point(322, 189);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(238, 41);
            this.btnKaydet.TabIndex = 51;
            this.btnKaydet.Text = "Kaydet";
            this.toolTip.SetToolTip(this.btnKaydet, "Kaydet");
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click_1);
            // 
            // ımageListKaydet
            // 
            this.ımageListKaydet.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageListKaydet.ImageStream")));
            this.ımageListKaydet.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageListKaydet.Images.SetKeyName(0, "save.png");
            // 
            // cmboBxTeminTuru
            // 
            this.cmboBxTeminTuru.FormattingEnabled = true;
            this.cmboBxTeminTuru.Items.AddRange(new object[] {
            "Bağış",
            "Satın Alma"});
            this.cmboBxTeminTuru.Location = new System.Drawing.Point(390, 62);
            this.cmboBxTeminTuru.Name = "cmboBxTeminTuru";
            this.cmboBxTeminTuru.Size = new System.Drawing.Size(170, 21);
            this.cmboBxTeminTuru.TabIndex = 62;
            this.cmboBxTeminTuru.Text = "Seçiniz...";
            // 
            // txtCiltNo
            // 
            this.txtCiltNo.Location = new System.Drawing.Point(390, 117);
            this.txtCiltNo.Name = "txtCiltNo";
            this.txtCiltNo.Size = new System.Drawing.Size(170, 20);
            this.txtCiltNo.TabIndex = 58;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(317, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 57;
            this.label10.Text = "Stok Sayısı :";
            // 
            // grpBxKitapEkle
            // 
            this.grpBxKitapEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpBxKitapEkle.Controls.Add(this.cmboBxTeminTuru);
            this.grpBxKitapEkle.Controls.Add(this.btnKapat);
            this.grpBxKitapEkle.Controls.Add(this.btnTemizle);
            this.grpBxKitapEkle.Controls.Add(this.txtCiltNo);
            this.grpBxKitapEkle.Controls.Add(this.label10);
            this.grpBxKitapEkle.Controls.Add(this.txtSayfaSayisi);
            this.grpBxKitapEkle.Controls.Add(this.label9);
            this.grpBxKitapEkle.Controls.Add(this.btnKaydet);
            this.grpBxKitapEkle.Controls.Add(this.nmrcUpDownStokSayisi);
            this.grpBxKitapEkle.Controls.Add(this.dTPTeminTarihi);
            this.grpBxKitapEkle.Controls.Add(this.cmboBxKitapTuru);
            this.grpBxKitapEkle.Controls.Add(this.txtYayinEvi);
            this.grpBxKitapEkle.Controls.Add(this.txtYazarAdi);
            this.grpBxKitapEkle.Controls.Add(this.txtKitapAdi);
            this.grpBxKitapEkle.Controls.Add(this.txtBarkodNo);
            this.grpBxKitapEkle.Controls.Add(this.label8);
            this.grpBxKitapEkle.Controls.Add(this.label7);
            this.grpBxKitapEkle.Controls.Add(this.label6);
            this.grpBxKitapEkle.Controls.Add(this.label5);
            this.grpBxKitapEkle.Controls.Add(this.label4);
            this.grpBxKitapEkle.Controls.Add(this.label3);
            this.grpBxKitapEkle.Controls.Add(this.label2);
            this.grpBxKitapEkle.Controls.Add(this.label1);
            this.grpBxKitapEkle.Location = new System.Drawing.Point(13, 12);
            this.grpBxKitapEkle.Name = "grpBxKitapEkle";
            this.grpBxKitapEkle.Size = new System.Drawing.Size(583, 251);
            this.grpBxKitapEkle.TabIndex = 2;
            this.grpBxKitapEkle.TabStop = false;
            this.grpBxKitapEkle.Text = "Yeni Kitap Ekle";
            // 
            // txtSayfaSayisi
            // 
            this.txtSayfaSayisi.Location = new System.Drawing.Point(114, 143);
            this.txtSayfaSayisi.Name = "txtSayfaSayisi";
            this.txtSayfaSayisi.Size = new System.Drawing.Size(170, 20);
            this.txtSayfaSayisi.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(338, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 54;
            this.label9.Text = "Cilt No :";
            // 
            // nmrcUpDownStokSayisi
            // 
            this.nmrcUpDownStokSayisi.Location = new System.Drawing.Point(390, 143);
            this.nmrcUpDownStokSayisi.Name = "nmrcUpDownStokSayisi";
            this.nmrcUpDownStokSayisi.Size = new System.Drawing.Size(170, 20);
            this.nmrcUpDownStokSayisi.TabIndex = 32;
            // 
            // dTPTeminTarihi
            // 
            this.dTPTeminTarihi.Location = new System.Drawing.Point(390, 90);
            this.dTPTeminTarihi.Name = "dTPTeminTarihi";
            this.dTPTeminTarihi.Size = new System.Drawing.Size(170, 20);
            this.dTPTeminTarihi.TabIndex = 31;
            // 
            // cmboBxKitapTuru
            // 
            this.cmboBxKitapTuru.FormattingEnabled = true;
            this.cmboBxKitapTuru.Items.AddRange(new object[] {
            "Aksiyon ve Macera",
            "Anı ",
            "Günlük",
            "Anı",
            "Antropoloji",
            "Arkeoloji",
            "Askerlik Bilimi",
            "Astronomi ve YerBilimleri",
            "Aşk / Roman",
            "Aşk Şiirleri",
            "Aşk ve Romantizm",
            "Atatürkçülük / Kemalizm",
            "Belgesel",
            "Bilgisayar",
            "Bilim - Astronomi",
            "Bilim Kurgu",
            "Bilim ve Teknoloji",
            "Biyografi/Otobiyografi",
            "Cumhuriyet Tarihi",
            "Çocuk",
            "Deneme",
            "Dil / Kurs Kitapları",
            "Din",
            "Doğa Bilimleri",
            "Eğlence",
            "Ekoloji",
            "Ekonomi",
            "Felsefe Bilimi",
            "Gezi",
            "Halkla İlişkiler",
            "Kişisel Gelişim",
            "Kültür Sanat",
            "Macera",
            "Makale",
            "Masal ve Fıkra",
            "Mektup",
            "Politika",
            "Psikoloji",
            "Roman",
            "Sağlık",
            "Sanat",
            "Seyahatname",
            "Siyaset",
            "Sosyoloji",
            "Sözlük",
            "Spor - Futbol",
            "Şiir",
            "Tarih",
            "Tasavvuf",
            "Tiyatro"});
            this.cmboBxKitapTuru.Location = new System.Drawing.Point(390, 33);
            this.cmboBxKitapTuru.Name = "cmboBxKitapTuru";
            this.cmboBxKitapTuru.Size = new System.Drawing.Size(170, 21);
            this.cmboBxKitapTuru.TabIndex = 29;
            this.cmboBxKitapTuru.Text = "Seçiniz...";
            // 
            // txtYayinEvi
            // 
            this.txtYayinEvi.Location = new System.Drawing.Point(114, 117);
            this.txtYayinEvi.Name = "txtYayinEvi";
            this.txtYayinEvi.Size = new System.Drawing.Size(170, 20);
            this.txtYayinEvi.TabIndex = 28;
            // 
            // txtYazarAdi
            // 
            this.txtYazarAdi.Location = new System.Drawing.Point(114, 90);
            this.txtYazarAdi.Name = "txtYazarAdi";
            this.txtYazarAdi.Size = new System.Drawing.Size(170, 20);
            this.txtYazarAdi.TabIndex = 27;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(114, 62);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(170, 20);
            this.txtKitapAdi.TabIndex = 26;
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Location = new System.Drawing.Point(114, 34);
            this.txtBarkodNo.MaxLength = 13;
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(170, 20);
            this.txtBarkodNo.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(311, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Temin Tarihi :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(315, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Temin Türü :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Kitap Türü :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Sayfa Sayısı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Yayın Evi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Yazar Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Kitap Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Barkod Numarası :";
            // 
            // KitapEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(608, 275);
            this.Controls.Add(this.grpBxKitapEkle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(624, 314);
            this.MinimumSize = new System.Drawing.Size(624, 314);
            this.Name = "KitapEkle";
            this.Text = "KitapEkle";
            this.Load += new System.EventHandler(this.KitapEkle_Load);
            this.grpBxKitapEkle.ResumeLayout(false);
            this.grpBxKitapEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDownStokSayisi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.ImageList ımageListKapat;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.ImageList ımageListTemizle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ImageList ımageListKaydet;
        private System.Windows.Forms.ComboBox cmboBxTeminTuru;
        private System.Windows.Forms.TextBox txtCiltNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox grpBxKitapEkle;
        private System.Windows.Forms.TextBox txtSayfaSayisi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nmrcUpDownStokSayisi;
        private System.Windows.Forms.DateTimePicker dTPTeminTarihi;
        private System.Windows.Forms.ComboBox cmboBxKitapTuru;
        private System.Windows.Forms.TextBox txtYayinEvi;
        private System.Windows.Forms.TextBox txtYazarAdi;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}