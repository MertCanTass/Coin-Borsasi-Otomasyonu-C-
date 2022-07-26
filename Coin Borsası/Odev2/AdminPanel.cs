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

namespace Odev2
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani();


        private void AdminPanel_Load(object sender, EventArgs e)
        {
            dgv_kullanici.DataSource = vt.Select("select KullanıcıId,KullanıcıAd,KullanıcıSoyad,KullanıcıEposta,KullanıcıSifre,KullanıcıDogumTarihi,KullanıcıTel,KullanıcıAdres,KullanıcıUlke,KullanıcıTc from tbl_Kullanıcı");
            dgv_kullanici.Columns["KullanıcıSifre"].Visible = false;
            dgv_kullanici.Columns["KullanıcıId"].Visible = false;
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (tx_ad.Text == "" || tx_soyad.Text == "" || tx_tc.Text == "" || tx_tel.Text == "" || tx_adres.Text == "" || tx_eposta.Text == "" || cb_ulke.Text == "" || tx_dogumtarihi.Text == ""||tx_sifre.Text=="")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
            }
            if (tx_ad.Text.Length < 2)
            {
                MessageBox.Show("Ad en az 2 karakter olmalıdır.");
                return;
            }
            if (tx_soyad.Text.Length < 2)
            {
                MessageBox.Show("Soyad en az 2 karakter olmalıdır.");
                return;
            }
            if (tx_tc.Text.Length != 11)
            {
                MessageBox.Show("TcNo 11 karakter olmalıdır !!!");
                return;
            }
            if (tx_tel.Text.Length != 10)
            {
                MessageBox.Show("Tel 10 karakter olmalıdır !!!");
                return;
            }
            if (tx_adres.Text.Length == 0)
            {
                MessageBox.Show("Adresiniz boş bırakılamaz.");
                return;
            }
            if (!tx_eposta.Text.Contains("@"))//@ yoksa hata verecek
            {
                MessageBox.Show("Lütfen geçerli bir e posta giriniz.");
                return;
            }
            if (cb_ulke.Text == "")
            {
                MessageBox.Show("Lütfen ülkenizi seçiniz.");
                return;
            }
            if (tx_sifre.Text.Length == 0)
            {
                MessageBox.Show("Lütfen şifre giriniz.");
                return;
            }
            if (tx_dogumtarihi.Text.Length == 0)
            {
                MessageBox.Show("Lütfen geçerli bir doğum tarihi giriniz.");
                return;
            }
            object kayitSay = vt.Insert(@"insert into tbl_Kullanıcı(KullanıcıAd,KullanıcıSoyad,KullanıcıEposta,KullanıcıSifre,KullanıcıDogumTarihi,KullanıcıTel,KullanıcıAdres,KullanıcıUlke,KullanıcıTc)
                                        values('" + tx_ad.Text + "','" + tx_soyad.Text + "','" + tx_eposta.Text + "','" + tx_sifre.Text + "','" + tx_dogumtarihi.Text + "','" + tx_tel.Text + "','" + tx_adres.Text + "','" + cb_ulke.Text + "','" + tx_tc.Text + "')");

            if (Convert.ToInt32(kayitSay) > 0)
            {
                AdminPanel_Load(null, null);
                MessageBox.Show("Kayıt Eklendi...");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (dgv_kullanici.SelectedRows.Count == 0)
            {
                MessageBox.Show("Güncellenecek satırı seçiniz !!!");
                return;
            }
            if (dgv_kullanici.SelectedRows.Count > 1)
            {
                MessageBox.Show("Güncellenecek satır 1 tane olmalıdır. !!!");
                return;
            }
            int kayitSay = vt.UpdateDelete(@"update tbl_Kullanıcı
                                           set KullanıcıAd='"+tx_ad.Text+ @"',      
                                               KullanıcıSoyad='" + tx_soyad.Text + @"',
                                               KullanıcıEposta='" + tx_eposta.Text + @"',
                                               KullanıcıSifre='" + tx_sifre.Text + @"',
                                               KullanıcıTel='" + tx_tel.Text+ @"',
                                               KullanıcıAdres='" + tx_adres.Text + @"',
                                               KullanıcıUlke='" + cb_ulke.Text + @"',
                                               KullanıcıTc='" + tx_tc.Text + @"'
                                            where KullanıcıId="+dgv_kullanici.SelectedRows[0].Cells["KullanıcıId"].Value);
            if (kayitSay > 0)
            {
                AdminPanel_Load(null, null);
                MessageBox.Show("Kayıt güncellendi...");
            }


        }

        private void btn_silme_Click(object sender, EventArgs e)
        {
            if (dgv_kullanici.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silinecek satırı seçiniz !!!");
                return;
            }

            int kayitSay = vt.UpdateDelete("Delete from tbl_Kullanıcı where KullanıcıId =" + dgv_kullanici.SelectedRows[0].Cells["KullanıcıId"].Value);
            if (kayitSay > 0)
            {
                AdminPanel_Load(null, null);
                MessageBox.Show("Kayıt silindi...");
            }
        }

        private void dgv_kullanici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
 }
