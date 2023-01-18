namespace ClinicManagementSystem
{
    partial class FormMuayeneEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMuayeneEkle));
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            this.btnHastaKontrol = new System.Windows.Forms.Button();
            this.txtTani = new System.Windows.Forms.TextBox();
            this.lblTanı = new System.Windows.Forms.Label();
            this.txtSikayet = new System.Windows.Forms.TextBox();
            this.lblSikayet = new System.Windows.Forms.Label();
            this.txtKutuSayisi = new System.Windows.Forms.TextBox();
            this.lblKutuSayisi = new System.Windows.Forms.Label();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.lblBarkodNo = new System.Windows.Forms.Label();
            this.txtTedavi = new System.Windows.Forms.TextBox();
            this.lblHastaDogumYeri = new System.Windows.Forms.Label();
            this.lblHastaTC = new System.Windows.Forms.Label();
            this.lblClassName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTCNumber = new System.Windows.Forms.TextBox();
            this.txtMuayeneTarihi = new System.Windows.Forms.TextBox();
            this.checkBoxRecete = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMuayeneOlustur = new System.Windows.Forms.Button();
            this.btnReceteOlustur = new System.Windows.Forms.Button();
            this.btnBaskaİlacEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.Location = new System.Drawing.Point(12, 445);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(188, 28);
            this.btnAnaSayfa.TabIndex = 50;
            this.btnAnaSayfa.Text = "Ana Sayfaya Dönelim\r\n";
            this.btnAnaSayfa.UseVisualStyleBackColor = true;
            this.btnAnaSayfa.Click += new System.EventHandler(this.btnAnaSayfa_Click);
            // 
            // btnHastaKontrol
            // 
            this.btnHastaKontrol.Location = new System.Drawing.Point(130, 192);
            this.btnHastaKontrol.Name = "btnHastaKontrol";
            this.btnHastaKontrol.Size = new System.Drawing.Size(169, 28);
            this.btnHastaKontrol.TabIndex = 49;
            this.btnHastaKontrol.Text = "Hasta Bilgilerini Kontrol Et ";
            this.btnHastaKontrol.UseVisualStyleBackColor = true;
            this.btnHastaKontrol.Click += new System.EventHandler(this.btnHastaKontrol_Click);
            // 
            // txtTani
            // 
            this.txtTani.Location = new System.Drawing.Point(431, 101);
            this.txtTani.Name = "txtTani";
            this.txtTani.Size = new System.Drawing.Size(138, 20);
            this.txtTani.TabIndex = 48;
            // 
            // lblTanı
            // 
            this.lblTanı.AutoSize = true;
            this.lblTanı.BackColor = System.Drawing.Color.Transparent;
            this.lblTanı.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTanı.Location = new System.Drawing.Point(342, 104);
            this.lblTanı.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTanı.Name = "lblTanı";
            this.lblTanı.Size = new System.Drawing.Size(37, 16);
            this.lblTanı.TabIndex = 47;
            this.lblTanı.Text = "Tanı:";
            // 
            // txtSikayet
            // 
            this.txtSikayet.Location = new System.Drawing.Point(431, 60);
            this.txtSikayet.Name = "txtSikayet";
            this.txtSikayet.Size = new System.Drawing.Size(138, 20);
            this.txtSikayet.TabIndex = 46;
            // 
            // lblSikayet
            // 
            this.lblSikayet.AutoSize = true;
            this.lblSikayet.BackColor = System.Drawing.Color.Transparent;
            this.lblSikayet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSikayet.Location = new System.Drawing.Point(342, 63);
            this.lblSikayet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSikayet.Name = "lblSikayet";
            this.lblSikayet.Size = new System.Drawing.Size(74, 16);
            this.lblSikayet.TabIndex = 45;
            this.lblSikayet.Text = "Şikayetiniz:";
            // 
            // txtKutuSayisi
            // 
            this.txtKutuSayisi.Location = new System.Drawing.Point(369, 281);
            this.txtKutuSayisi.Name = "txtKutuSayisi";
            this.txtKutuSayisi.Size = new System.Drawing.Size(37, 20);
            this.txtKutuSayisi.TabIndex = 44;
            this.txtKutuSayisi.Visible = false;
            this.txtKutuSayisi.TextChanged += new System.EventHandler(this.txtKutuSayisi_TextChanged);
            // 
            // lblKutuSayisi
            // 
            this.lblKutuSayisi.AutoSize = true;
            this.lblKutuSayisi.BackColor = System.Drawing.Color.Transparent;
            this.lblKutuSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKutuSayisi.Location = new System.Drawing.Point(221, 285);
            this.lblKutuSayisi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKutuSayisi.Name = "lblKutuSayisi";
            this.lblKutuSayisi.Size = new System.Drawing.Size(99, 16);
            this.lblKutuSayisi.TabIndex = 43;
            this.lblKutuSayisi.Text = "İlaç Kutu Sayısı:";
            this.lblKutuSayisi.Visible = false;
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Location = new System.Drawing.Point(342, 251);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(96, 20);
            this.txtBarkodNo.TabIndex = 42;
            this.txtBarkodNo.Visible = false;
            // 
            // lblBarkodNo
            // 
            this.lblBarkodNo.AutoSize = true;
            this.lblBarkodNo.BackColor = System.Drawing.Color.Transparent;
            this.lblBarkodNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBarkodNo.Location = new System.Drawing.Point(221, 251);
            this.lblBarkodNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBarkodNo.Name = "lblBarkodNo";
            this.lblBarkodNo.Size = new System.Drawing.Size(99, 16);
            this.lblBarkodNo.TabIndex = 41;
            this.lblBarkodNo.Text = "İlaç Barkod No:";
            this.lblBarkodNo.Visible = false;
            // 
            // txtTedavi
            // 
            this.txtTedavi.Location = new System.Drawing.Point(171, 146);
            this.txtTedavi.Name = "txtTedavi";
            this.txtTedavi.Size = new System.Drawing.Size(138, 20);
            this.txtTedavi.TabIndex = 40;
            // 
            // lblHastaDogumYeri
            // 
            this.lblHastaDogumYeri.AutoSize = true;
            this.lblHastaDogumYeri.BackColor = System.Drawing.Color.Transparent;
            this.lblHastaDogumYeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHastaDogumYeri.Location = new System.Drawing.Point(61, 150);
            this.lblHastaDogumYeri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHastaDogumYeri.Name = "lblHastaDogumYeri";
            this.lblHastaDogumYeri.Size = new System.Drawing.Size(53, 16);
            this.lblHastaDogumYeri.TabIndex = 39;
            this.lblHastaDogumYeri.Text = "Tedavi:";
            // 
            // lblHastaTC
            // 
            this.lblHastaTC.AutoSize = true;
            this.lblHastaTC.BackColor = System.Drawing.Color.Transparent;
            this.lblHastaTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHastaTC.Location = new System.Drawing.Point(61, 61);
            this.lblHastaTC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHastaTC.Name = "lblHastaTC";
            this.lblHastaTC.Size = new System.Drawing.Size(86, 16);
            this.lblHastaTC.TabIndex = 37;
            this.lblHastaTC.Text = "Hasta Tc No:";
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.BackColor = System.Drawing.Color.Transparent;
            this.lblClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblClassName.Location = new System.Drawing.Point(58, 102);
            this.lblClassName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(103, 16);
            this.lblClassName.TabIndex = 35;
            this.lblClassName.Text = "Muayene Tarihi:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(81, 32);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(506, 16);
            this.lblTitle.TabIndex = 34;
            this.lblTitle.Text = "Sisteme Yeni Muayene Eklemek İçin Lütfen Gerekli Alanları Doldurunuz...";
            // 
            // txtTCNumber
            // 
            this.txtTCNumber.Location = new System.Drawing.Point(171, 60);
            this.txtTCNumber.Name = "txtTCNumber";
            this.txtTCNumber.Size = new System.Drawing.Size(138, 20);
            this.txtTCNumber.TabIndex = 51;
            // 
            // txtMuayeneTarihi
            // 
            this.txtMuayeneTarihi.Location = new System.Drawing.Point(171, 98);
            this.txtMuayeneTarihi.Name = "txtMuayeneTarihi";
            this.txtMuayeneTarihi.Size = new System.Drawing.Size(138, 20);
            this.txtMuayeneTarihi.TabIndex = 52;
            // 
            // checkBoxRecete
            // 
            this.checkBoxRecete.AutoSize = true;
            this.checkBoxRecete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxRecete.Location = new System.Drawing.Point(431, 162);
            this.checkBoxRecete.Name = "checkBoxRecete";
            this.checkBoxRecete.Size = new System.Drawing.Size(61, 20);
            this.checkBoxRecete.TabIndex = 53;
            this.checkBoxRecete.Text = "Evet.";
            this.checkBoxRecete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBoxRecete.UseVisualStyleBackColor = true;
            this.checkBoxRecete.CheckedChanged += new System.EventHandler(this.checkBoxRecete_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(337, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 16);
            this.label1.TabIndex = 54;
            this.label1.Text = "Hastaya Reçete Yazacak mısınız?";
            // 
            // btnMuayeneOlustur
            // 
            this.btnMuayeneOlustur.Location = new System.Drawing.Point(369, 192);
            this.btnMuayeneOlustur.Name = "btnMuayeneOlustur";
            this.btnMuayeneOlustur.Size = new System.Drawing.Size(188, 28);
            this.btnMuayeneOlustur.TabIndex = 55;
            this.btnMuayeneOlustur.Text = "Muayene Oluştur!";
            this.btnMuayeneOlustur.UseVisualStyleBackColor = true;
            this.btnMuayeneOlustur.Click += new System.EventHandler(this.btnMuayeneOlustur_Click);
            // 
            // btnReceteOlustur
            // 
            this.btnReceteOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReceteOlustur.Location = new System.Drawing.Point(224, 445);
            this.btnReceteOlustur.Name = "btnReceteOlustur";
            this.btnReceteOlustur.Size = new System.Drawing.Size(222, 28);
            this.btnReceteOlustur.TabIndex = 56;
            this.btnReceteOlustur.Text = "Reçeteli Muayene Oluştur!";
            this.btnReceteOlustur.UseVisualStyleBackColor = true;
            this.btnReceteOlustur.Visible = false;
            this.btnReceteOlustur.Click += new System.EventHandler(this.btnReceteOlustur_Click);
            // 
            // btnBaskaİlacEkle
            // 
            this.btnBaskaİlacEkle.Location = new System.Drawing.Point(273, 307);
            this.btnBaskaİlacEkle.Name = "btnBaskaİlacEkle";
            this.btnBaskaİlacEkle.Size = new System.Drawing.Size(165, 23);
            this.btnBaskaİlacEkle.TabIndex = 59;
            this.btnBaskaİlacEkle.Text = "Başka Bir İlaç Ekle";
            this.btnBaskaİlacEkle.UseVisualStyleBackColor = true;
            this.btnBaskaİlacEkle.Visible = false;
            this.btnBaskaİlacEkle.Click += new System.EventHandler(this.btnBaskaİlacEkle_Click);
            // 
            // FormMuayeneEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1113, 485);
            this.Controls.Add(this.btnBaskaİlacEkle);
            this.Controls.Add(this.btnReceteOlustur);
            this.Controls.Add(this.btnMuayeneOlustur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxRecete);
            this.Controls.Add(this.txtMuayeneTarihi);
            this.Controls.Add(this.txtTCNumber);
            this.Controls.Add(this.btnAnaSayfa);
            this.Controls.Add(this.btnHastaKontrol);
            this.Controls.Add(this.txtTani);
            this.Controls.Add(this.lblTanı);
            this.Controls.Add(this.txtSikayet);
            this.Controls.Add(this.lblSikayet);
            this.Controls.Add(this.txtKutuSayisi);
            this.Controls.Add(this.lblKutuSayisi);
            this.Controls.Add(this.txtBarkodNo);
            this.Controls.Add(this.lblBarkodNo);
            this.Controls.Add(this.txtTedavi);
            this.Controls.Add(this.lblHastaDogumYeri);
            this.Controls.Add(this.lblHastaTC);
            this.Controls.Add(this.lblClassName);
            this.Controls.Add(this.lblTitle);
            this.Name = "FormMuayeneEkle";
            this.Text = "FormMuayeneEkle";
            this.Load += new System.EventHandler(this.FormMuayeneEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnaSayfa;
        private System.Windows.Forms.Button btnHastaKontrol;
        private System.Windows.Forms.TextBox txtTani;
        private System.Windows.Forms.Label lblTanı;
        private System.Windows.Forms.TextBox txtSikayet;
        private System.Windows.Forms.Label lblSikayet;
        private System.Windows.Forms.TextBox txtKutuSayisi;
        private System.Windows.Forms.Label lblKutuSayisi;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.Label lblBarkodNo;
        private System.Windows.Forms.TextBox txtTedavi;
        private System.Windows.Forms.Label lblHastaDogumYeri;
        private System.Windows.Forms.Label lblHastaTC;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTCNumber;
        private System.Windows.Forms.TextBox txtMuayeneTarihi;
        private System.Windows.Forms.CheckBox checkBoxRecete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMuayeneOlustur;
        private System.Windows.Forms.Button btnReceteOlustur;
        private System.Windows.Forms.Button btnBaskaİlacEkle;
    }
}