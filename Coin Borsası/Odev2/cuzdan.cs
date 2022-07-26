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
using System.Data.OleDb;

namespace Odev2
{
    public partial class cuzdan : Form
    {
        public cuzdan()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani();
        private void cuzdan_Load(object sender, EventArgs e)
        {
            DataTable dt2 = vt.Select(@"select KullanıcıBakiye from tbl_Kullanıcı where KullanıcıId=" + label14.Text);
            if (dt2.Rows.Count != 0)
            {
                label4.Text = dt2.Rows[0]["KullanıcıBakiye"].ToString() + "₺";
            }

            dataGridView1.DataSource = vt.Select("select * from tbl_Cuzdan where KullanıcıId=" + label14.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = vt.Select(@"select KullanıcıBakiye from tbl_Kullanıcı where KullanıcıId=" + label14.Text);

            double bakiye = Convert.ToDouble(dt.Rows[0]["KullanıcıBakiye"]);
            double eklenecekMiktar = Convert.ToDouble(textBox1.Text);
            double sonuc = bakiye + eklenecekMiktar;

            int kayitSay = vt.UpdateDelete(@"update tbl_Kullanıcı set KullanıcıBakiye=" + sonuc.ToString() + " where KullanıcıId=" + label14.Text);
            if (kayitSay > 0)
            {
                MessageBox.Show(eklenecekMiktar.ToString() +  " bakiye yüklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cuzdan_Load(null, null);
            }
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            AnaSayfa ana = new AnaSayfa();
            this.Hide();
            ana.Show();
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ANK4\Desktop\Kitap1.xlsx; Extended Properties='Excel 12.0 xml;HDR=YES;'");

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        CoinAlSat c1 = new CoinAlSat();
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dolar kurundaki ani çıkış ve inişlerden dolayı şuan satış yapılamamaktadır!");
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
