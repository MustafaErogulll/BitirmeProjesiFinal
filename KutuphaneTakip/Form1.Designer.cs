namespace KutuphaneTakip
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnAdmGiris = new System.Windows.Forms.Button();
            this.btnKulGiris = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chckBxSifreyiGoster = new System.Windows.Forms.CheckBox();
            this.txtKullaniciSifresi = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(54, 237);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(130, 34);
            this.btnKapat.TabIndex = 4;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            // 
            // btnAdmGiris
            // 
            this.btnAdmGiris.Location = new System.Drawing.Point(218, 237);
            this.btnAdmGiris.Name = "btnAdmGiris";
            this.btnAdmGiris.Size = new System.Drawing.Size(130, 34);
            this.btnAdmGiris.TabIndex = 5;
            this.btnAdmGiris.Text = "Admin Girişi";
            this.btnAdmGiris.UseVisualStyleBackColor = true;
            this.btnAdmGiris.Click += new System.EventHandler(this.btnAdmGiris_Click);
            // 
            // btnKulGiris
            // 
            this.btnKulGiris.Location = new System.Drawing.Point(391, 237);
            this.btnKulGiris.Name = "btnKulGiris";
            this.btnKulGiris.Size = new System.Drawing.Size(130, 34);
            this.btnKulGiris.TabIndex = 6;
            this.btnKulGiris.Text = "Kullanıcı Girişi";
            this.btnKulGiris.UseVisualStyleBackColor = true;
            this.btnKulGiris.Click += new System.EventHandler(this.btnKulGiris_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chckBxSifreyiGoster);
            this.groupBox1.Controls.Add(this.txtKullaniciSifresi);
            this.groupBox1.Controls.Add(this.txtKullaniciAdi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(135, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 107);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // chckBxSifreyiGoster
            // 
            this.chckBxSifreyiGoster.AutoSize = true;
            this.chckBxSifreyiGoster.BackColor = System.Drawing.SystemColors.Window;
            this.chckBxSifreyiGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckBxSifreyiGoster.Location = new System.Drawing.Point(125, 77);
            this.chckBxSifreyiGoster.Name = "chckBxSifreyiGoster";
            this.chckBxSifreyiGoster.Size = new System.Drawing.Size(88, 17);
            this.chckBxSifreyiGoster.TabIndex = 17;
            this.chckBxSifreyiGoster.Text = "Şifreyi Göster";
            this.chckBxSifreyiGoster.UseVisualStyleBackColor = false;
            this.chckBxSifreyiGoster.CheckedChanged += new System.EventHandler(this.chckBxSifreyiGoster_CheckedChanged_1);
            // 
            // txtKullaniciSifresi
            // 
            this.txtKullaniciSifresi.Location = new System.Drawing.Point(125, 51);
            this.txtKullaniciSifresi.Name = "txtKullaniciSifresi";
            this.txtKullaniciSifresi.PasswordChar = '*';
            this.txtKullaniciSifresi.Size = new System.Drawing.Size(111, 20);
            this.txtKullaniciSifresi.TabIndex = 16;
            this.txtKullaniciSifresi.Text = "1234";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(125, 20);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(111, 20);
            this.txtKullaniciAdi.TabIndex = 15;
            this.txtKullaniciAdi.Text = "admin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kullanıcı Şifresi";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kullanıcı Adı";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Kütüphane Otomasyonu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KutuphaneTakip.Properties.Resources.Kitap;
            this.ClientSize = new System.Drawing.Size(601, 328);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnKulGiris);
            this.Controls.Add(this.btnAdmGiris);
            this.Controls.Add(this.btnKapat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(617, 367);
            this.MinimumSize = new System.Drawing.Size(617, 367);
            this.Name = "Form1";
            this.Text = "KullaniciGirisi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnAdmGiris;
        private System.Windows.Forms.Button btnKulGiris;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chckBxSifreyiGoster;
        private System.Windows.Forms.TextBox txtKullaniciSifresi;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label label1;
    }
}

