namespace KutuphaneTakip
{
    partial class OkuyuculariListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OkuyuculariListele));
            this.lblKisiSayisi = new System.Windows.Forms.Label();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpBxAramaYap = new System.Windows.Forms.GroupBox();
            this.btn_Ara = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmboBxAramaTuru = new System.Windows.Forms.ComboBox();
            this.ımageListCikis = new System.Windows.Forms.ImageList(this.components);
            this.dataGridViewOkuyucuListesi = new System.Windows.Forms.DataGridView();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.ımageListSil = new System.Windows.Forms.ImageList(this.components);
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.ımageListGuncelle = new System.Windows.Forms.ImageList(this.components);
            this.cmboBxCinsiyet = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmboBxDogumYeri = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.grpBxİslemler = new System.Windows.Forms.GroupBox();
            this.dTPUyelikTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtTCKimlikNo = new System.Windows.Forms.TextBox();
            this.grpBxOkuyucuBilgileri = new System.Windows.Forms.GroupBox();
            this.txtEPosta = new System.Windows.Forms.TextBox();
            this.dTPDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpBxAramaYap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOkuyucuListesi)).BeginInit();
            this.grpBxİslemler.SuspendLayout();
            this.grpBxOkuyucuBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKisiSayisi
            // 
            this.lblKisiSayisi.AutoSize = true;
            this.lblKisiSayisi.BackColor = System.Drawing.SystemColors.Window;
            this.lblKisiSayisi.Location = new System.Drawing.Point(16, 489);
            this.lblKisiSayisi.Name = "lblKisiSayisi";
            this.lblKisiSayisi.Size = new System.Drawing.Size(0, 13);
            this.lblKisiSayisi.TabIndex = 62;
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(291, 37);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(129, 20);
            this.txtArama.TabIndex = 7;
            this.txtArama.TextChanged += new System.EventHandler(this.btn_Ara_Click);
            this.txtArama.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAra_KeyDown);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(291, 64);
            this.txtTelefon.Mask = "\\0(599) 000-0000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(129, 20);
            this.txtTelefon.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(245, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Adres :";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(291, 93);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(599, 58);
            this.txtAdres.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Arama :";
            // 
            // grpBxAramaYap
            // 
            this.grpBxAramaYap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpBxAramaYap.Controls.Add(this.btn_Ara);
            this.grpBxAramaYap.Controls.Add(this.txtArama);
            this.grpBxAramaYap.Controls.Add(this.label2);
            this.grpBxAramaYap.Controls.Add(this.label1);
            this.grpBxAramaYap.Controls.Add(this.cmboBxAramaTuru);
            this.grpBxAramaYap.Location = new System.Drawing.Point(12, 11);
            this.grpBxAramaYap.Name = "grpBxAramaYap";
            this.grpBxAramaYap.Size = new System.Drawing.Size(481, 67);
            this.grpBxAramaYap.TabIndex = 55;
            this.grpBxAramaYap.TabStop = false;
            this.grpBxAramaYap.Text = "Arama Yap";
            // 
            // btn_Ara
            // 
            this.btn_Ara.Location = new System.Drawing.Point(435, 33);
            this.btn_Ara.Name = "btn_Ara";
            this.btn_Ara.Size = new System.Drawing.Size(35, 27);
            this.btn_Ara.TabIndex = 63;
            this.btn_Ara.Text = "Ara";
            this.btn_Ara.UseVisualStyleBackColor = true;
            this.btn_Ara.Click += new System.EventHandler(this.btn_Ara_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Arama Türü :";
            // 
            // cmboBxAramaTuru
            // 
            this.cmboBxAramaTuru.FormattingEnabled = true;
            this.cmboBxAramaTuru.Items.AddRange(new object[] {
            "T.C Kimlik No",
            "Ad",
            "Soyad",
            "Doğum Yeri",
            "Cinsiyet",
            "E - Posta",
            "Adres"});
            this.cmboBxAramaTuru.Location = new System.Drawing.Point(91, 34);
            this.cmboBxAramaTuru.Name = "cmboBxAramaTuru";
            this.cmboBxAramaTuru.Size = new System.Drawing.Size(129, 21);
            this.cmboBxAramaTuru.TabIndex = 0;
            this.cmboBxAramaTuru.Text = "Seçiniz...";
            // 
            // ımageListCikis
            // 
            this.ımageListCikis.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageListCikis.ImageStream")));
            this.ımageListCikis.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageListCikis.Images.SetKeyName(0, "cancel.png");
            // 
            // dataGridViewOkuyucuListesi
            // 
            this.dataGridViewOkuyucuListesi.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewOkuyucuListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOkuyucuListesi.Location = new System.Drawing.Point(12, 255);
            this.dataGridViewOkuyucuListesi.Name = "dataGridViewOkuyucuListesi";
            this.dataGridViewOkuyucuListesi.Size = new System.Drawing.Size(1024, 216);
            this.dataGridViewOkuyucuListesi.TabIndex = 61;
            this.dataGridViewOkuyucuListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOkuyucuListesi_CellContentClick);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.SystemColors.Window;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCikis.ImageKey = "cancel.png";
            this.btnCikis.ImageList = this.ımageListCikis;
            this.btnCikis.Location = new System.Drawing.Point(922, 477);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(114, 34);
            this.btnCikis.TabIndex = 59;
            this.btnCikis.Text = "Çıkış";
            this.toolTip.SetToolTip(this.btnCikis, "Çıkış");
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click_1);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.Window;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.ImageKey = "delete.png";
            this.btnSil.ImageList = this.ımageListSil;
            this.btnSil.Location = new System.Drawing.Point(7, 98);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(106, 38);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "   Sil";
            this.toolTip.SetToolTip(this.btnSil, "Sil");
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // ımageListSil
            // 
            this.ımageListSil.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageListSil.ImageStream")));
            this.ımageListSil.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageListSil.Images.SetKeyName(0, "delete.png");
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.Window;
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.ImageKey = "update.png";
            this.btnGuncelle.ImageList = this.ımageListGuncelle;
            this.btnGuncelle.Location = new System.Drawing.Point(7, 35);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(106, 40);
            this.btnGuncelle.TabIndex = 0;
            this.btnGuncelle.Text = "       Güncelle";
            this.toolTip.SetToolTip(this.btnGuncelle, "Güncelle");
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // ımageListGuncelle
            // 
            this.ımageListGuncelle.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageListGuncelle.ImageStream")));
            this.ımageListGuncelle.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageListGuncelle.Images.SetKeyName(0, "update.png");
            // 
            // cmboBxCinsiyet
            // 
            this.cmboBxCinsiyet.FormattingEnabled = true;
            this.cmboBxCinsiyet.Items.AddRange(new object[] {
            "Bay",
            "Bayan"});
            this.cmboBxCinsiyet.Location = new System.Drawing.Point(487, 62);
            this.cmboBxCinsiyet.Name = "cmboBxCinsiyet";
            this.cmboBxCinsiyet.Size = new System.Drawing.Size(146, 21);
            this.cmboBxCinsiyet.TabIndex = 17;
            this.cmboBxCinsiyet.Text = "Seçiniz...";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "E Posta :";
            // 
            // cmboBxDogumYeri
            // 
            this.cmboBxDogumYeri.FormattingEnabled = true;
            this.cmboBxDogumYeri.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyon",
            "Ağrı",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Isparta",
            "Mersin",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Kahramanmaraş",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kırıkkale",
            "Batman",
            "Şırnak",
            "Bartın",
            "Ardahan",
            "Iğdır",
            "Yalova",
            "Karabük",
            "Kilis",
            "Osmaniye",
            "Düzce"});
            this.cmboBxDogumYeri.Location = new System.Drawing.Point(91, 62);
            this.cmboBxDogumYeri.Name = "cmboBxDogumYeri";
            this.cmboBxDogumYeri.Size = new System.Drawing.Size(129, 21);
            this.cmboBxDogumYeri.TabIndex = 15;
            this.cmboBxDogumYeri.Text = "Seçiniz...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(432, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Cinsiyet :";
            // 
            // grpBxİslemler
            // 
            this.grpBxİslemler.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpBxİslemler.Controls.Add(this.btnSil);
            this.grpBxİslemler.Controls.Add(this.btnGuncelle);
            this.grpBxİslemler.Location = new System.Drawing.Point(915, 86);
            this.grpBxİslemler.Name = "grpBxİslemler";
            this.grpBxİslemler.Size = new System.Drawing.Size(121, 163);
            this.grpBxİslemler.TabIndex = 58;
            this.grpBxİslemler.TabStop = false;
            this.grpBxİslemler.Text = "İşlemler";
            // 
            // dTPUyelikTarihi
            // 
            this.dTPUyelikTarihi.Location = new System.Drawing.Point(721, 64);
            this.dTPUyelikTarihi.Name = "dTPUyelikTarihi";
            this.dTPUyelikTarihi.Size = new System.Drawing.Size(169, 20);
            this.dTPUyelikTarihi.TabIndex = 14;
            // 
            // txtTCKimlikNo
            // 
            this.txtTCKimlikNo.Location = new System.Drawing.Point(91, 29);
            this.txtTCKimlikNo.MaxLength = 11;
            this.txtTCKimlikNo.Name = "txtTCKimlikNo";
            this.txtTCKimlikNo.Size = new System.Drawing.Size(129, 20);
            this.txtTCKimlikNo.TabIndex = 8;
            // 
            // grpBxOkuyucuBilgileri
            // 
            this.grpBxOkuyucuBilgileri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpBxOkuyucuBilgileri.Controls.Add(this.txtTelefon);
            this.grpBxOkuyucuBilgileri.Controls.Add(this.label12);
            this.grpBxOkuyucuBilgileri.Controls.Add(this.txtAdres);
            this.grpBxOkuyucuBilgileri.Controls.Add(this.cmboBxCinsiyet);
            this.grpBxOkuyucuBilgileri.Controls.Add(this.label11);
            this.grpBxOkuyucuBilgileri.Controls.Add(this.cmboBxDogumYeri);
            this.grpBxOkuyucuBilgileri.Controls.Add(this.dTPUyelikTarihi);
            this.grpBxOkuyucuBilgileri.Controls.Add(this.txtEPosta);
            this.grpBxOkuyucuBilgileri.Controls.Add(this.dTPDogumTarihi);
            this.grpBxOkuyucuBilgileri.Controls.Add(this.txtAd);
            this.grpBxOkuyucuBilgileri.Controls.Add(this.txtSoyad);
            this.grpBxOkuyucuBilgileri.Controls.Add(this.label8);
            this.grpBxOkuyucuBilgileri.Controls.Add(this.txtTCKimlikNo);
            this.grpBxOkuyucuBilgileri.Controls.Add(this.label10);
            this.grpBxOkuyucuBilgileri.Controls.Add(this.label9);
            this.grpBxOkuyucuBilgileri.Controls.Add(this.label7);
            this.grpBxOkuyucuBilgileri.Controls.Add(this.label6);
            this.grpBxOkuyucuBilgileri.Controls.Add(this.label5);
            this.grpBxOkuyucuBilgileri.Controls.Add(this.label4);
            this.grpBxOkuyucuBilgileri.Controls.Add(this.label3);
            this.grpBxOkuyucuBilgileri.Location = new System.Drawing.Point(12, 86);
            this.grpBxOkuyucuBilgileri.Name = "grpBxOkuyucuBilgileri";
            this.grpBxOkuyucuBilgileri.Size = new System.Drawing.Size(897, 163);
            this.grpBxOkuyucuBilgileri.TabIndex = 57;
            this.grpBxOkuyucuBilgileri.TabStop = false;
            this.grpBxOkuyucuBilgileri.Text = "Okuyucu Bilgileri";
            // 
            // txtEPosta
            // 
            this.txtEPosta.Location = new System.Drawing.Point(91, 96);
            this.txtEPosta.Name = "txtEPosta";
            this.txtEPosta.Size = new System.Drawing.Size(129, 20);
            this.txtEPosta.TabIndex = 12;
            // 
            // dTPDogumTarihi
            // 
            this.dTPDogumTarihi.Location = new System.Drawing.Point(722, 29);
            this.dTPDogumTarihi.Name = "dTPDogumTarihi";
            this.dTPDogumTarihi.Size = new System.Drawing.Size(169, 20);
            this.dTPDogumTarihi.TabIndex = 11;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(291, 29);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(129, 20);
            this.txtAd.TabIndex = 9;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(487, 28);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(146, 20);
            this.txtSoyad.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(238, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Telefon :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(644, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Üyelik Tarihi :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(438, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Soyad :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(639, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Doğum Tarihi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Doğum Yeri :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "T.C Kimlik No :";
            // 
            // OkuyuculariListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1048, 522);
            this.Controls.Add(this.lblKisiSayisi);
            this.Controls.Add(this.grpBxAramaYap);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.dataGridViewOkuyucuListesi);
            this.Controls.Add(this.grpBxİslemler);
            this.Controls.Add(this.grpBxOkuyucuBilgileri);
            this.MaximumSize = new System.Drawing.Size(1064, 561);
            this.MinimumSize = new System.Drawing.Size(1064, 561);
            this.Name = "OkuyuculariListele";
            this.Text = "OkuyuculariListele";
            this.Load += new System.EventHandler(this.OkuyuculariListele_Load);
            this.grpBxAramaYap.ResumeLayout(false);
            this.grpBxAramaYap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOkuyucuListesi)).EndInit();
            this.grpBxİslemler.ResumeLayout(false);
            this.grpBxOkuyucuBilgileri.ResumeLayout(false);
            this.grpBxOkuyucuBilgileri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKisiSayisi;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpBxAramaYap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmboBxAramaTuru;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.ImageList ımageListCikis;
        private System.Windows.Forms.DataGridView dataGridViewOkuyucuListesi;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ImageList ımageListSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ImageList ımageListGuncelle;
        private System.Windows.Forms.ComboBox cmboBxCinsiyet;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmboBxDogumYeri;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grpBxİslemler;
        private System.Windows.Forms.DateTimePicker dTPUyelikTarihi;
        private System.Windows.Forms.TextBox txtTCKimlikNo;
        private System.Windows.Forms.GroupBox grpBxOkuyucuBilgileri;
        private System.Windows.Forms.TextBox txtEPosta;
        private System.Windows.Forms.DateTimePicker dTPDogumTarihi;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Ara;
    }
}