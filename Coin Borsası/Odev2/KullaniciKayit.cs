using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VTI;
using System.Security.Cryptography;

namespace Odev2
{
    public partial class KullaniciKayit : Form
    {
        public KullaniciKayit()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tx_kysoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
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

        Veritabani vt = new Veritabani();
        private void btn_kayıt_Click(object sender, EventArgs e)
        {
            if (tx_kyad.Text==""||tx_kysoyad.Text==""||tx_kytc.Text==""||tx_kytel.Text==""||tx_kyadres.Text==""||tx_kyeposta.Text==""||cb_ulke.Text==""||tx_kysifre.Text==""||tx_kydogumtarihi.Text=="")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
            }
            if (tx_kyad.Text.Length<2)
            {
                MessageBox.Show("Ad en az 2 karakter olmalıdır.");
                return;
            }
            if (tx_kysoyad.Text.Length<2)
            {
                MessageBox.Show("Soyad en az 2 karakter olmalıdır.");
                return;
            }
            if (tx_kytc.Text.Length != 11)
            {
                MessageBox.Show("TcNo 11 karakter olmalıdır !!!");
                return;
            }
            if (tx_kytel.Text.Length != 10)
            {
                MessageBox.Show("Tel 10 karakter olmalıdır !!!");
                return;
            }
            if (tx_kyadres.Text.Length==0)
            {
                MessageBox.Show("Adresiniz boş bırakılamaz.");
                return;
            }
            if (!tx_kyeposta.Text.Contains("@"))//@ yoksa hata verecek
            {
                MessageBox.Show("Lütfen geçerli bir e posta giriniz.");
                return;
            }
            if (cb_ulke.Text.Length==0)
            {
                MessageBox.Show("Lütfen ülkenizi seçiniz.");
                return;
            }
            if (tx_kysifre.Text.Length==0)
            {
                MessageBox.Show("Lütfen şifre giriniz.");
                return;
            }
            if (tx_kydogumtarihi.Text.Length==0)
            {
                MessageBox.Show("Lütfen geçerli bir doğum tarihi giriniz.");
                return;
            }
            object kayitSay = vt.Insert(@"insert into tbl_Kullanıcı(KullanıcıAd,KullanıcıSoyad,KullanıcıEposta,KullanıcıSifre,KullanıcıDogumTarihi,KullanıcıTel,KullanıcıAdres,KullanıcıUlke,KullanıcıTc)
                                        values('"+tx_kyad.Text+"','"+tx_kysoyad.Text+"','"+tx_kyeposta.Text+"','"+ MD5Sifrele(tx_kysifre.Text) +"','"+tx_kydogumtarihi.Text+"','"+tx_kytel.Text+"','"+tx_kyadres.Text+"','"+cb_ulke.Text+"','"+tx_kytc.Text+"')");

            if (Convert.ToInt32(kayitSay) > 0)
            {
                Form2_Load(null, null);
                MessageBox.Show("Kayıt Eklendi...");
            }
            KullaniciGiris kg = new KullaniciGiris();
            this.Hide();
            kg.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void tx_kytc_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            KullaniciGiris kg = new KullaniciGiris();
            this.Hide();
            kg.Show();
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
