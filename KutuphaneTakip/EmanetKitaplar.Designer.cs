namespace KutuphaneTakip
{
    partial class EmanetKitaplar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmanetKitaplar));
            this.ımageListYenile = new System.Windows.Forms.ImageList(this.components);
            this.ımageListAra = new System.Windows.Forms.ImageList(this.components);
            this.ımageListCikis = new System.Windows.Forms.ImageList(this.components);
            this.dataGridViewEmanetKitaplar = new System.Windows.Forms.DataGridView();
            this.lblEmanetKitapSayisi = new System.Windows.Forms.Label();
            this.grpBxAramaYap = new System.Windows.Forms.GroupBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmboBxAramaTuru = new System.Windows.Forms.ComboBox();
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.lblTarih = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmanetKitaplar)).BeginInit();
            this.grpBxAramaYap.SuspendLayout();
            this.SuspendLayout();
            // 
            // ımageListYenile
            // 
            this.ımageListYenile.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageListYenile.ImageStream")));
            this.ımageListYenile.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageListYenile.Images.SetKeyName(0, "refresh.png");
            // 
            // ımageListAra
            // 
            this.ımageListAra.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageListAra.ImageStream")));
            this.ımageListAra.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageListAra.Images.SetKeyName(0, "search.png");
            // 
            // ımageListCikis
            // 
            this.ımageListCikis.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageListCikis.ImageStream")));
            this.ımageListCikis.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageListCikis.Images.SetKeyName(0, "cancel.png");
            // 
            // dataGridViewEmanetKitaplar
            // 
            this.dataGridViewEmanetKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmanetKitaplar.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewEmanetKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmanetKitaplar.Location = new System.Drawing.Point(14, 92);
            this.dataGridViewEmanetKitaplar.Name = "dataGridViewEmanetKitaplar";
            this.dataGridViewEmanetKitaplar.Size = new System.Drawing.Size(739, 290);
            this.dataGridViewEmanetKitaplar.TabIndex = 66;
            this.dataGridViewEmanetKitaplar.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewEmanetKitaplar_RowHeaderMouseClick);
            this.dataGridViewEmanetKitaplar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewEmanetKitaplar_KeyDown);
            // 
            // lblEmanetKitapSayisi
            // 
            this.lblEmanetKitapSayisi.AutoSize = true;
            this.lblEmanetKitapSayisi.BackColor = System.Drawing.SystemColors.Window;
            this.lblEmanetKitapSayisi.Location = new System.Drawing.Point(90, 388);
            this.lblEmanetKitapSayisi.Name = "lblEmanetKitapSayisi";
            this.lblEmanetKitapSayisi.Size = new System.Drawing.Size(0, 13);
            this.lblEmanetKitapSayisi.TabIndex = 67;
            // 
            // grpBxAramaYap
            // 
            this.grpBxAramaYap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpBxAramaYap.Controls.Add(this.btnAra);
            this.grpBxAramaYap.Controls.Add(this.label2);
            this.grpBxAramaYap.Controls.Add(this.txtArama);
            this.grpBxAramaYap.Controls.Add(this.label1);
            this.grpBxAramaYap.Controls.Add(this.cmboBxAramaTuru);
            this.grpBxAramaYap.Location = new System.Drawing.Point(14, 12);
            this.grpBxAramaYap.Name = "grpBxAramaYap";
            this.grpBxAramaYap.Size = new System.Drawing.Size(424, 74);
            this.grpBxAramaYap.TabIndex = 63;
            this.grpBxAramaYap.TabStop = false;
            this.grpBxAramaYap.Text = "Arama Yap";
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.SystemColors.Window;
            this.btnAra.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAra.ImageKey = "search.png";
            this.btnAra.ImageList = this.ımageListAra;
            this.btnAra.Location = new System.Drawing.Point(380, 36);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(34, 27);
            this.btnAra.TabIndex = 5;
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Arama :";
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(257, 42);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(109, 20);
            this.txtArama.TabIndex = 3;
            this.txtArama.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAra_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Arama Türü :";
            // 
            // cmboBxAramaTuru
            // 
            this.cmboBxAramaTuru.FormattingEnabled = true;
            this.cmboBxAramaTuru.Items.AddRange(new object[] {
            "Kitap Numarası",
            "TC Kimlik Numarası",
            "Barkod Numarası",
            "Kitap Durumu",
            "Teslim Durumu"});
            this.cmboBxAramaTuru.Location = new System.Drawing.Point(76, 41);
            this.cmboBxAramaTuru.Name = "cmboBxAramaTuru";
            this.cmboBxAramaTuru.Size = new System.Drawing.Size(121, 21);
            this.cmboBxAramaTuru.TabIndex = 0;
            this.cmboBxAramaTuru.Text = "Seçiniz...";
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.SystemColors.Window;
            this.btnYenile.ImageKey = "refresh.png";
            this.btnYenile.ImageList = this.ımageListYenile;
            this.btnYenile.Location = new System.Drawing.Point(714, 24);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(38, 29);
            this.btnYenile.TabIndex = 65;
            this.btnYenile.UseVisualStyleBackColor = false;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.SystemColors.Window;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCikis.ImageKey = "cancel.png";
            this.btnCikis.ImageList = this.ımageListCikis;
            this.btnCikis.Location = new System.Drawing.Point(647, 388);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(106, 34);
            this.btnCikis.TabIndex = 64;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTarih.Location = new System.Drawing.Point(90, 412);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(0, 13);
            this.lblTarih.TabIndex = 68;
            // 
            // EmanetKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(766, 435);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.dataGridViewEmanetKitaplar);
            this.Controls.Add(this.lblEmanetKitapSayisi);
            this.Controls.Add(this.grpBxAramaYap);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.btnCikis);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(782, 474);
            this.MinimumSize = new System.Drawing.Size(782, 474);
            this.Name = "EmanetKitaplar";
            this.Text = "Emanet Kitaplar";
            this.Load += new System.EventHandler(this.EmanetKitaplar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmanetKitaplar)).EndInit();
            this.grpBxAramaYap.ResumeLayout(false);
            this.grpBxAramaYap.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList ımageListYenile;
        private System.Windows.Forms.ImageList ımageListAra;
        private System.Windows.Forms.ImageList ımageListCikis;
        public System.Windows.Forms.DataGridView dataGridViewEmanetKitaplar;
        private System.Windows.Forms.Label lblEmanetKitapSayisi;
        private System.Windows.Forms.GroupBox grpBxAramaYap;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmboBxAramaTuru;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label lblTarih;
    }
}