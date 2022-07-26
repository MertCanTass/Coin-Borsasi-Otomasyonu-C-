using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using VTI;
using System.Security.Cryptography;

namespace Odev2
{
    public partial class KullaniciGiris : Form
    {
        public KullaniciGiris()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public static string MD5Sifrele(string sifrelenecekMetin)
        {

            // MD5CryptoServiceProvider sınıfının bir örneğini oluşturduk.
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            //Parametre olarak gelen veriyi byte dizisine dönüştürdük.
            byte[] dizi = Encoding.UTF8.GetBytes(sifrelenecekMetin);
            //dizinin hash'ini hesaplattık.
            dizi = md5.ComputeHash(dizi);
            //Hashlenmiş verileri depolamak için StringBuilder nesnesi oluşturduk.
            StringBuilder sb = new StringBuilder();
            //Her byte'i dizi içerisinden alarak string türüne dönüştürdük.

            foreach (byte ba in dizi)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }

            //hexadecimal(onaltılık) stringi geri döndürdük.
            return sb.ToString();
        }

    private void Form1_Load(object sender, EventArgs e)
        {
             lbl_tarih.Text=DateTime.Now.ToString();
            //string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            //var xmldoc = new XmlDocument();
            //xmldoc.Load(bugun);
            //DateTime tarih = Convert.ToDateTime(xmldoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);

            //string USD = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            //label1.Text = string.Format("USD;{0}",USD);

            //string EURO = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            //label2.Text=string.Format("EURO;{0}",EURO);

            //string STERLIN = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteSelling").InnerXml;
            //label3.Text = string.Format("STERLIN;{0}",STERLIN);
        }

        Veritabani vt = new Veritabani();
        private void btn_giris_Click(object sender, EventArgs e)
        {
            if (tx_ad.Text==""||tx_sifre.Text=="")
            {
                MessageBox.Show("Kullanıcı Adınızı veya Şifrenizi Girmediniz.");
                return;
            }
            DataTable dt = vt.Select(@"select KullanıcıId, KullanıcıAd,KullanıcıSoyad from tbl_Kullanıcı where KullanıcıTc=" + tx_ad.Text + "and KullanıcıSifre='" + MD5Sifrele(tx_sifre.Text) + "'");

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Kullanıcı adın veya şifre hatalı...");
                tx_ad.Text = tx_sifre.Text = "";
                return;
            }
            AnaSayfa ana= new AnaSayfa();
            this.Hide();
            ana.Show();
            //CoinAlSat kg = new CoinAlSat();
            ana.lbl_kullanıcıad.Text = dt.Rows[0]["KullanıcıId"].ToString();
            //kg.label14.Text = dt.Rows[0]["KullanıcıId"].ToString();
            //this.Hide();
            //kg.Show();
        }

         private void tx_ad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KullaniciKayit kk = new KullaniciKayit();
            this.Hide();
            kk.Show();

        }

        private void lbl_tarih_Click(object sender, EventArgs e)
        {
            DateTime.Now.ToString();
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
