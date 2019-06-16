namespace KutuphaneTakip
{
    partial class KullaniciEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciEkle));
            this.label10 = new System.Windows.Forms.Label();
            this.ımageListKaydet = new System.Windows.Forms.ImageList(this.components);
            this.ımageListKapat = new System.Windows.Forms.ImageList(this.components);
            this.ımageListTemizle = new System.Windows.Forms.ImageList(this.components);
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.grpBxOkuyucuEkle = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.grpBxOkuyucuEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "Kullanıcı Şifresi :";
            // 
            // ımageListKaydet
            // 
            this.ımageListKaydet.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageListKaydet.ImageStream")));
            this.ımageListKaydet.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageListKaydet.Images.SetKeyName(0, "save.png");
            // 
            // ımageListKapat
            // 
            this.ımageListKapat.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageListKapat.ImageStream")));
            this.ımageListKapat.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageListKapat.Images.SetKeyName(0, "cancel.png");
            // 
            // ımageListTemizle
            // 
            this.ımageListTemizle.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageListTemizle.ImageStream")));
            this.ımageListTemizle.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageListTemizle.Images.SetKeyName(0, "clean.png");
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(108, 45);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(178, 20);
            this.txtKullaniciAdi.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Kullanıcı Adı :";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(108, 72);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(178, 20);
            this.txtSifre.TabIndex = 36;
            // 
            // grpBxOkuyucuEkle
            // 
            this.grpBxOkuyucuEkle.Controls.Add(this.label10);
            this.grpBxOkuyucuEkle.Controls.Add(this.btnKaydet);
            this.grpBxOkuyucuEkle.Controls.Add(this.btnKapat);
            this.grpBxOkuyucuEkle.Controls.Add(this.btnTemizle);
            this.grpBxOkuyucuEkle.Controls.Add(this.txtSifre);
            this.grpBxOkuyucuEkle.Controls.Add(this.txtKullaniciAdi);
            this.grpBxOkuyucuEkle.Controls.Add(this.label2);
            this.grpBxOkuyucuEkle.Location = new System.Drawing.Point(10, 10);
            this.grpBxOkuyucuEkle.MaximumSize = new System.Drawing.Size(337, 240);
            this.grpBxOkuyucuEkle.MinimumSize = new System.Drawing.Size(337, 240);
            this.grpBxOkuyucuEkle.Name = "grpBxOkuyucuEkle";
            this.grpBxOkuyucuEkle.Size = new System.Drawing.Size(337, 240);
            this.grpBxOkuyucuEkle.TabIndex = 5;
            this.grpBxOkuyucuEkle.TabStop = false;
            this.grpBxOkuyucuEkle.Text = "Kişi Ekle";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.SystemColors.Window;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKaydet.ImageKey = "save.png";
            this.btnKaydet.ImageList = this.ımageListKaydet;
            this.btnKaydet.Location = new System.Drawing.Point(22, 124);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(291, 39);
            this.btnKaydet.TabIndex = 48;
            this.btnKaydet.Text = "Kaydet";
            this.toolTip.SetToolTip(this.btnKaydet, "Kaydet");
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click_1);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.SystemColors.Window;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKapat.ImageKey = "cancel.png";
            this.btnKapat.ImageList = this.ımageListKapat;
            this.btnKapat.Location = new System.Drawing.Point(178, 179);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(135, 32);
            this.btnKapat.TabIndex = 46;
            this.btnKapat.Text = "Kapat";
            this.toolTip.SetToolTip(this.btnKapat, "Kapat");
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click_1);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.SystemColors.Window;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTemizle.ImageKey = "clean.png";
            this.btnTemizle.ImageList = this.ımageListTemizle;
            this.btnTemizle.Location = new System.Drawing.Point(22, 179);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(135, 32);
            this.btnTemizle.TabIndex = 45;
            this.btnTemizle.Text = "Temizle";
            this.toolTip.SetToolTip(this.btnTemizle, "Temizle");
            this.btnTemizle.UseVisualStyleBackColor = false;
            // 
            // KullaniciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(357, 261);
            this.Controls.Add(this.grpBxOkuyucuEkle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(373, 300);
            this.MinimumSize = new System.Drawing.Size(373, 300);
            this.Name = "KullaniciEkle";
            this.Text = "KullaniciEkle";
            this.Load += new System.EventHandler(this.KullaniciEkle_Load);
            this.grpBxOkuyucuEkle.ResumeLayout(false);
            this.grpBxOkuyucuEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ImageList ımageListKaydet;
        private System.Windows.Forms.ImageList ımageListKapat;
        private System.Windows.Forms.ImageList ımageListTemizle;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.GroupBox grpBxOkuyucuEkle;
    }
}