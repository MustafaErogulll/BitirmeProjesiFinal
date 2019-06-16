namespace KutuphaneTakip
{
    partial class KullaniciPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciPaneli));
            this.pictureBoxKitap = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCikisYap = new System.Windows.Forms.Button();
            this.btnEmanetAlVer = new System.Windows.Forms.Button();
            this.btnKitaplariListele = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKitap)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxKitap
            // 
            this.pictureBoxKitap.BackgroundImage = global::KutuphaneTakip.Properties.Resources.Kitap;
            this.pictureBoxKitap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxKitap.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxKitap.Name = "pictureBoxKitap";
            this.pictureBoxKitap.Size = new System.Drawing.Size(360, 86);
            this.pictureBoxKitap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxKitap.TabIndex = 18;
            this.pictureBoxKitap.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(67, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 31);
            this.label1.TabIndex = 19;
            this.label1.Text = "Kullanıcı İşlemleri";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCikisYap
            // 
            this.btnCikisYap.BackColor = System.Drawing.SystemColors.Window;
            this.btnCikisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikisYap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikisYap.ImageKey = "exit.png";
            this.btnCikisYap.Location = new System.Drawing.Point(49, 405);
            this.btnCikisYap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCikisYap.Name = "btnCikisYap";
            this.btnCikisYap.Size = new System.Drawing.Size(274, 44);
            this.btnCikisYap.TabIndex = 27;
            this.btnCikisYap.Text = "Çıkış Yap";
            this.btnCikisYap.UseVisualStyleBackColor = false;
            this.btnCikisYap.Click += new System.EventHandler(this.btnCikisYap_Click);
            // 
            // btnEmanetAlVer
            // 
            this.btnEmanetAlVer.BackColor = System.Drawing.SystemColors.Window;
            this.btnEmanetAlVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmanetAlVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmanetAlVer.ImageKey = "library.png";
            this.btnEmanetAlVer.Location = new System.Drawing.Point(49, 307);
            this.btnEmanetAlVer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEmanetAlVer.Name = "btnEmanetAlVer";
            this.btnEmanetAlVer.Size = new System.Drawing.Size(274, 44);
            this.btnEmanetAlVer.TabIndex = 26;
            this.btnEmanetAlVer.Text = "Emanet Ver - Teslim Al";
            this.btnEmanetAlVer.UseVisualStyleBackColor = false;
            this.btnEmanetAlVer.Click += new System.EventHandler(this.btnEmanetAlVer_Click);
            // 
            // btnKitaplariListele
            // 
            this.btnKitaplariListele.BackColor = System.Drawing.SystemColors.Window;
            this.btnKitaplariListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKitaplariListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKitaplariListele.ImageKey = "clipboard.png";
            this.btnKitaplariListele.Location = new System.Drawing.Point(49, 157);
            this.btnKitaplariListele.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnKitaplariListele.Name = "btnKitaplariListele";
            this.btnKitaplariListele.Size = new System.Drawing.Size(274, 44);
            this.btnKitaplariListele.TabIndex = 25;
            this.btnKitaplariListele.Text = "Kitapları Listele";
            this.btnKitaplariListele.UseVisualStyleBackColor = false;
            this.btnKitaplariListele.Click += new System.EventHandler(this.btnKitaplariListele_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageKey = "library.png";
            this.button1.Location = new System.Drawing.Point(49, 207);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(274, 44);
            this.button1.TabIndex = 28;
            this.button1.Text = "Okuyucu Listele";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Window;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageKey = "library.png";
            this.button2.Location = new System.Drawing.Point(49, 257);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(274, 44);
            this.button2.TabIndex = 29;
            this.button2.Text = "Okuyucu Ekle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Window;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.ImageKey = "library.png";
            this.button3.Location = new System.Drawing.Point(49, 357);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(274, 44);
            this.button3.TabIndex = 30;
            this.button3.Text = "Emanet Verilen Kitaplar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // KullaniciPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCikisYap);
            this.Controls.Add(this.btnEmanetAlVer);
            this.Controls.Add(this.btnKitaplariListele);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxKitap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(400, 500);
            this.MinimumSize = new System.Drawing.Size(400, 500);
            this.Name = "KullaniciPaneli";
            this.Text = "KullaniciPaneli";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKitap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxKitap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCikisYap;
        private System.Windows.Forms.Button btnEmanetAlVer;
        private System.Windows.Forms.Button btnKitaplariListele;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}