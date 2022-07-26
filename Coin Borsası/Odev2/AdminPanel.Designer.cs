
namespace Odev2
{
    partial class AdminPanel
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
            this.dgv_kullanici = new System.Windows.Forms.DataGridView();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.lbl_eposta = new System.Windows.Forms.Label();
            this.lbl_tc = new System.Windows.Forms.Label();
            this.lbl_tel = new System.Windows.Forms.Label();
            this.lbl_dogumtarihi = new System.Windows.Forms.Label();
            this.lbl_adres = new System.Windows.Forms.Label();
            this.lbl_ulke = new System.Windows.Forms.Label();
            this.tx_ad = new System.Windows.Forms.TextBox();
            this.tx_soyad = new System.Windows.Forms.TextBox();
            this.tx_tc = new System.Windows.Forms.TextBox();
            this.tx_eposta = new System.Windows.Forms.TextBox();
            this.tx_adres = new System.Windows.Forms.TextBox();
            this.tx_tel = new System.Windows.Forms.TextBox();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_silme = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.cb_ulke = new System.Windows.Forms.ComboBox();
            this.tx_dogumtarihi = new DevExpress.XtraEditors.DateEdit();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.tx_sifre = new System.Windows.Forms.TextBox();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kullanici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_dogumtarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_dogumtarihi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_kullanici
            // 
            this.dgv_kullanici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_kullanici.Location = new System.Drawing.Point(0, 443);
            this.dgv_kullanici.Name = "dgv_kullanici";
            this.dgv_kullanici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_kullanici.Size = new System.Drawing.Size(1074, 304);
            this.dgv_kullanici.TabIndex = 0;
            this.dgv_kullanici.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_kullanici_CellContentClick);
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Location = new System.Drawing.Point(81, 40);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(26, 13);
            this.lbl_ad.TabIndex = 1;
            this.lbl_ad.Text = "Ad :";
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Location = new System.Drawing.Point(64, 79);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(43, 13);
            this.lbl_soyad.TabIndex = 2;
            this.lbl_soyad.Text = "Soyad :";
            // 
            // lbl_eposta
            // 
            this.lbl_eposta.AutoSize = true;
            this.lbl_eposta.Location = new System.Drawing.Point(260, 79);
            this.lbl_eposta.Name = "lbl_eposta";
            this.lbl_eposta.Size = new System.Drawing.Size(49, 13);
            this.lbl_eposta.TabIndex = 3;
            this.lbl_eposta.Text = "E-posta :";
            // 
            // lbl_tc
            // 
            this.lbl_tc.AutoSize = true;
            this.lbl_tc.Location = new System.Drawing.Point(266, 40);
            this.lbl_tc.Name = "lbl_tc";
            this.lbl_tc.Size = new System.Drawing.Size(43, 13);
            this.lbl_tc.TabIndex = 4;
            this.lbl_tc.Text = "Tc No :";
            // 
            // lbl_tel
            // 
            this.lbl_tel.AutoSize = true;
            this.lbl_tel.Location = new System.Drawing.Point(453, 79);
            this.lbl_tel.Name = "lbl_tel";
            this.lbl_tel.Size = new System.Drawing.Size(96, 13);
            this.lbl_tel.TabIndex = 5;
            this.lbl_tel.Text = "Telefon Numarası :";
            // 
            // lbl_dogumtarihi
            // 
            this.lbl_dogumtarihi.AutoSize = true;
            this.lbl_dogumtarihi.Location = new System.Drawing.Point(473, 41);
            this.lbl_dogumtarihi.Name = "lbl_dogumtarihi";
            this.lbl_dogumtarihi.Size = new System.Drawing.Size(76, 13);
            this.lbl_dogumtarihi.TabIndex = 6;
            this.lbl_dogumtarihi.Text = "Dogum Tarihi :";
            // 
            // lbl_adres
            // 
            this.lbl_adres.AutoSize = true;
            this.lbl_adres.Location = new System.Drawing.Point(729, 41);
            this.lbl_adres.Name = "lbl_adres";
            this.lbl_adres.Size = new System.Drawing.Size(40, 13);
            this.lbl_adres.TabIndex = 7;
            this.lbl_adres.Text = "Adres :";
            // 
            // lbl_ulke
            // 
            this.lbl_ulke.AutoSize = true;
            this.lbl_ulke.Location = new System.Drawing.Point(734, 80);
            this.lbl_ulke.Name = "lbl_ulke";
            this.lbl_ulke.Size = new System.Drawing.Size(35, 13);
            this.lbl_ulke.TabIndex = 8;
            this.lbl_ulke.Text = "Ulke :";
            // 
            // tx_ad
            // 
            this.tx_ad.Location = new System.Drawing.Point(122, 36);
            this.tx_ad.Name = "tx_ad";
            this.tx_ad.Size = new System.Drawing.Size(100, 20);
            this.tx_ad.TabIndex = 9;
            // 
            // tx_soyad
            // 
            this.tx_soyad.Location = new System.Drawing.Point(122, 76);
            this.tx_soyad.Name = "tx_soyad";
            this.tx_soyad.Size = new System.Drawing.Size(100, 20);
            this.tx_soyad.TabIndex = 10;
            // 
            // tx_tc
            // 
            this.tx_tc.Location = new System.Drawing.Point(324, 36);
            this.tx_tc.Name = "tx_tc";
            this.tx_tc.Size = new System.Drawing.Size(100, 20);
            this.tx_tc.TabIndex = 11;
            // 
            // tx_eposta
            // 
            this.tx_eposta.Location = new System.Drawing.Point(324, 76);
            this.tx_eposta.Name = "tx_eposta";
            this.tx_eposta.Size = new System.Drawing.Size(100, 20);
            this.tx_eposta.TabIndex = 12;
            // 
            // tx_adres
            // 
            this.tx_adres.Location = new System.Drawing.Point(784, 37);
            this.tx_adres.Name = "tx_adres";
            this.tx_adres.Size = new System.Drawing.Size(100, 20);
            this.tx_adres.TabIndex = 13;
            // 
            // tx_tel
            // 
            this.tx_tel.Location = new System.Drawing.Point(564, 76);
            this.tx_tel.Name = "tx_tel";
            this.tx_tel.Size = new System.Drawing.Size(100, 20);
            this.tx_tel.TabIndex = 14;
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(428, 163);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(138, 23);
            this.btn_guncelle.TabIndex = 17;
            this.btn_guncelle.Text = "Kullanıcı Bilgi Güncelleme";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_silme
            // 
            this.btn_silme.Location = new System.Drawing.Point(654, 163);
            this.btn_silme.Name = "btn_silme";
            this.btn_silme.Size = new System.Drawing.Size(138, 23);
            this.btn_silme.TabIndex = 18;
            this.btn_silme.Text = "Kullanıcı Silme ";
            this.btn_silme.UseVisualStyleBackColor = true;
            this.btn_silme.Click += new System.EventHandler(this.btn_silme_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(218, 163);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(138, 23);
            this.btn_ekle.TabIndex = 19;
            this.btn_ekle.Text = "Kullanıcı Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // cb_ulke
            // 
            this.cb_ulke.FormattingEnabled = true;
            this.cb_ulke.Items.AddRange(new object[] {
            "Abhazya",
            "Afganistan",
            "Almanya",
            "Amerika Birleşik Devletleri",
            "Andorra",
            "Angola",
            "Antigua ve Barbuda",
            "Arjantin",
            "Arnavutluk",
            "Avustralya",
            "Avusturya",
            "Azerbaycan",
            "Bahamalar",
            "Bahreyn",
            "Bangladeş",
            "Barbados",
            "Batı Sahra",
            "Belçika",
            "Belize",
            "Benin",
            "Beyaz Rusya",
            "Bhutan",
            "Birleşik Arap Emirlikleri",
            "Bolivya",
            "Bosna Hersek",
            "Botsvana",
            "Brezilya",
            "Brunei",
            "Bulgaristan",
            "Burkina Faso",
            "Burundi",
            "Cezayir",
            "Cibuti",
            "Çad",
            "Çek Cumhuriyeti",
            "Çin Halk Cumhuriyeti",
            "Dağlık Karabağ Cumhuriyeti",
            "Danimarka",
            "Doğu Timor",
            "Dominik Cumhuriyeti",
            "Dominika",
            "Ekvador",
            "Ekvator Ginesi",
            "El Salvador",
            "Endonezya",
            "Eritre",
            "Ermenistan",
            "Estonya",
            "Etiyopya",
            "Fas",
            "Fiji",
            "Fildişi Sahilleri",
            "Filipinler",
            "Filistin",
            "Finlandiya",
            "Fransa",
            "Gabon",
            "Gambiya",
            "Gana",
            "Gine",
            "Gine Bissau Gine Bissau Batı Afrika",
            "Grenada",
            "Guyana",
            "Guatemala",
            "Güney Afrika Cumhuriyeti",
            "Güney Kore",
            "Güney Osetya",
            "Güney Sudan",
            "Gürcistan",
            "Haiti",
            "Hırvatistan",
            "Hindistan",
            "Hollanda",
            "Honduras",
            "Irak",
            "İngiltere",
            "İran",
            "İrlanda",
            "İspanya",
            "İsrail",
            "İsveç",
            "İsviçre",
            "İtalya",
            "İzlanda",
            "Jamaika",
            "Japonya",
            "Kamboçya",
            "Kamerun",
            "Kanada",
            "Karadağ Katar",
            "Kazakistan",
            "Kenya",
            "Kırgızistan",
            "Kıbrıs Cumhuriyeti",
            "Kiribati",
            "Kolombiya",
            "Komorlar",
            "Kongo",
            "Kongo Demokratik Cumhuriyeti",
            "Kosova",
            "Kosta Rika",
            "Kuveyt",
            "Kuzey Kıbrıs Türk Cumhuriyeti",
            "Kuzey Kore",
            "Küba",
            "Laos",
            "Lesotho",
            "Letonya",
            "Liberya",
            "Libya",
            "Liechtenstein",
            "Litvanya",
            "Lübnan",
            "Lüksemburg",
            "Macaristan",
            "Madagaskar",
            "Makedonya Cumhuriyeti",
            "Malavi",
            "Maldivler",
            "Malezya",
            "Mali",
            "Malta",
            "Marshall Adaları",
            "Meksika",
            "Mısır",
            "Mikronezya",
            "Moğolistan",
            "Moldova",
            "Monako",
            "Moritanya",
            "Moritius",
            "Mozambik",
            "Myanmar",
            "Namibya",
            "Nauru",
            "Nepal",
            "Nikaragua",
            "Nijer",
            "Nijerya",
            "Norveç",
            "Orta Afrika Cumhuriyeti",
            "Özbekistan",
            "Pakistan",
            "Palau",
            "Panama",
            "Papua",
            "Paraguay",
            "Peru",
            "Polonya",
            "Portekiz",
            "Porto Riko",
            "Romanya",
            "Ruanda",
            "Rusya Federasyonu",
            "Saint Kitts",
            "Saint Lucia",
            "Saint Vincent ve Grenadinler",
            "Samoa",
            "San Marino",
            "Sao Tome ve Principe",
            "Sealand",
            "Senegal",
            "Seyşeller",
            "Sırbistan",
            "Sierra Leone",
            "Singapur",
            "Slovakya",
            "Slovenya",
            "Solomon Adaları",
            "Somali",
            "Somaliland",
            "Sri Lanka",
            "Sudan",
            "Surinam",
            "Suriye",
            "Suudi Arabistan",
            "Svaziland",
            "Şili",
            "Tacikistan",
            "Tanzanya",
            "Tayland",
            "Tayvan",
            "Togo",
            "Tonga",
            "Transdinyester",
            "Trinidad ve Tobago",
            "Tunus",
            "Tuvalu",
            "Türkiye",
            "Türkmenistan",
            "Uganda",
            "Ukrayna",
            "Umman",
            "Uruguay",
            "Ürdün",
            "Vanuatu",
            "Vatikan",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Yeni Zelanda",
            "Yeşil Burun",
            "Yunanistan",
            "Zambiyav",
            "Zimbabve"});
            this.cb_ulke.Location = new System.Drawing.Point(784, 80);
            this.cb_ulke.Name = "cb_ulke";
            this.cb_ulke.Size = new System.Drawing.Size(100, 21);
            this.cb_ulke.TabIndex = 20;
            // 
            // tx_dogumtarihi
            // 
            this.tx_dogumtarihi.EditValue = null;
            this.tx_dogumtarihi.Location = new System.Drawing.Point(564, 36);
            this.tx_dogumtarihi.Name = "tx_dogumtarihi";
            this.tx_dogumtarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tx_dogumtarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tx_dogumtarihi.Properties.DisplayFormat.FormatString = "";
            this.tx_dogumtarihi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.tx_dogumtarihi.Properties.EditFormat.FormatString = "";
            this.tx_dogumtarihi.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.tx_dogumtarihi.Properties.Mask.EditMask = "";
            this.tx_dogumtarihi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.tx_dogumtarihi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.tx_dogumtarihi.Size = new System.Drawing.Size(100, 18);
            this.tx_dogumtarihi.TabIndex = 21;
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Location = new System.Drawing.Point(923, 59);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(34, 13);
            this.lbl_sifre.TabIndex = 22;
            this.lbl_sifre.Text = "Şifre :";
            // 
            // tx_sifre
            // 
            this.tx_sifre.Location = new System.Drawing.Point(963, 56);
            this.tx_sifre.Name = "tx_sifre";
            this.tx_sifre.PasswordChar = '*';
            this.tx_sifre.Size = new System.Drawing.Size(100, 20);
            this.tx_sifre.TabIndex = 23;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 749);
            this.Controls.Add(this.tx_sifre);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.cb_ulke);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.btn_silme);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.tx_tel);
            this.Controls.Add(this.tx_adres);
            this.Controls.Add(this.tx_eposta);
            this.Controls.Add(this.tx_tc);
            this.Controls.Add(this.tx_soyad);
            this.Controls.Add(this.tx_ad);
            this.Controls.Add(this.lbl_ulke);
            this.Controls.Add(this.lbl_adres);
            this.Controls.Add(this.lbl_dogumtarihi);
            this.Controls.Add(this.lbl_tel);
            this.Controls.Add(this.lbl_tc);
            this.Controls.Add(this.lbl_eposta);
            this.Controls.Add(this.lbl_soyad);
            this.Controls.Add(this.lbl_ad);
            this.Controls.Add(this.dgv_kullanici);
            this.Controls.Add(this.tx_dogumtarihi);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kullanici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_dogumtarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_dogumtarihi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_kullanici;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.Label lbl_eposta;
        private System.Windows.Forms.Label lbl_tc;
        private System.Windows.Forms.Label lbl_tel;
        private System.Windows.Forms.Label lbl_dogumtarihi;
        private System.Windows.Forms.Label lbl_adres;
        private System.Windows.Forms.Label lbl_ulke;
        private System.Windows.Forms.TextBox tx_ad;
        private System.Windows.Forms.TextBox tx_soyad;
        private System.Windows.Forms.TextBox tx_tc;
        private System.Windows.Forms.TextBox tx_eposta;
        private System.Windows.Forms.TextBox tx_adres;
        private System.Windows.Forms.TextBox tx_tel;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_silme;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.ComboBox cb_ulke;
        private DevExpress.XtraEditors.DateEdit tx_dogumtarihi;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.TextBox tx_sifre;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
    }
}