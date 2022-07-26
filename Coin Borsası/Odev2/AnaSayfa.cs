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
using System.Xml;

namespace Odev2
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani();
        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldoc = new XmlDocument();
            xmldoc.Load(bugun);
            DateTime tarih = Convert.ToDateTime(xmldoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);

            string USD = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            label7.Text = string.Format("USD;{0}", USD);

            string EURO = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            label6.Text = string.Format("EURO;{0}", EURO);

            string STERLIN = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteSelling").InnerXml;
            label5.Text = string.Format("STERLIN;{0}", STERLIN);
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            CoinAlSat cas = new CoinAlSat();
            cas.label14.Text = lbl_kullanıcıad.Text;
            this.Hide();
            cas.Show();
        }

        private void btn_cuzdan_Click(object sender, EventArgs e)
        {
            cuzdan czd = new cuzdan();
            this.Hide();
            czd.Show();
        }

        private void btn_dolartl_Click(object sender, EventArgs e)
        {
            DolarTl dtl = new DolarTl();
            this.Hide();
            dtl.Show();
        }

        private void btn_cointur_Click(object sender, EventArgs e)
        {
            CoinTurleri ct = new CoinTurleri();
            this.Hide();
            ct.Show();
        }

        private void btn_coinozellik_Click(object sender, EventArgs e)
        {
            CoinProjeleri cp = new CoinProjeleri();
            this.Hide();
            cp.Show();
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            KullaniciGiris kg = new KullaniciGiris();
            this.Hide();
            kg.Show();

        }
    }
}
