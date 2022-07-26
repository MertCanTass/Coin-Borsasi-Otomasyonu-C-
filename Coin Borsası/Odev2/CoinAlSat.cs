using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using VTI;

namespace Odev2
{
    public partial class CoinAlSat : Form
    {
        public CoinAlSat()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ANK4\Desktop\Kitap1.xlsx; Extended Properties='Excel 12.0 xml;HDR=YES;'");
        Veritabani vt = new Veritabani();
        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt2 = vt.Select(@"select KullanıcıBakiye from tbl_Kullanıcı where KullanıcıId=" + label14.Text);
            if (dt2.Rows.Count != 0)
            {
                label11.Text = dt2.Rows[0]["KullanıcıBakiye"].ToString();
            }

            OleDbDataAdapter da = new OleDbDataAdapter("SELECT CoinAdı FROM  [24hr$]", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                foreach (DataColumn item2 in dt.Columns)
                {
                    cb_coinad.Items.Add(item[item2].ToString());
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (cb_coinad.Text == "")
            {
                baglanti.Open();
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM  [24hr$]  ", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt.DefaultView;
                baglanti.Close();
                timer1.Interval = 60000;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //dataGridView1.Hide();
            //baglanti.Open();
            //OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM  [24hr$] where CoinAdı='" + tx_coinad.Text + "' ", baglanti);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dataGridView1.DataSource = dt.DefaultView;
            //baglanti.Close();
            //timer1.Interval = 60000;
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (baglanti.State != ConnectionState.Open)
            {
                baglanti.Open();
            }       
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM  [24hr$] where CoinAdı='" + cb_coinad.Text + "' ", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;
            baglanti.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double lastprice, fiyat, coin;
            lastprice = Convert.ToDouble(lbl_lastprice.Text.Replace(".", ","));
            fiyat = Convert.ToDouble(textBox1.Text);
            coin = Math.Round((fiyat / lastprice), 2);

            if (MessageBox.Show(coin.ToString() + " " + cb_coinad.Text + " satın almak istiyor musun?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                double cuzdan = Convert.ToDouble(label11.Text);
                if (cuzdan > fiyat)
                {
                    DataTable dt = vt.Select(@"select coinId from tbl_Coinler where coinAdi='" + dataGridView1.SelectedRows[0].Cells["CoinAdı"].Value.ToString() + "'");
                                 
                    object kayitSay = vt.Insert(@"insert into tbl_Cuzdan(KullanıcıId,coinId,Miktar) values('" + label14.Text + "','" + dt.Rows[0]["coinId"].ToString() + "','" + coin.ToString() + "')");

                    if (Convert.ToInt32(kayitSay) > 0)
                    {
                        Form1_Load(null, null);
                        MessageBox.Show("Satın alım başarılı.");
                    }
                    else
                    {
                        MessageBox.Show("Satın alım başarısız.");
                    }

                }
                else
                {
                    MessageBox.Show("Bakiyen yetersiz");
                }
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cuzdan cuzdan = new cuzdan();
            cuzdan.label14.Text = label14.Text;
            cuzdan.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                double lastprice, fiyat, coin;
                lastprice = Convert.ToDouble(lbl_lastprice.Text.Replace(".", ","));
                fiyat = Convert.ToDouble(textBox1.Text);
                coin = Math.Round((fiyat / lastprice), 2);
                label7.Text = coin.ToString();
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

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                lbl_coinad.Text = dataGridView1.SelectedRows[0].Cells["CoinAdı"].Value.ToString();
                lbl_lastprice.Text = dataGridView1.SelectedRows[0].Cells["SonFiyat"].Value.ToString();
                lbl_pricepercent.Text = dataGridView1.SelectedRows[0].Cells["Fiyat Değişimi"].Value.ToString();
                lbl_open.Text = dataGridView1.SelectedRows[0].Cells["Açılış Fiyatı"].Value.ToString();
                lbl_high.Text = dataGridView1.SelectedRows[0].Cells["Yüksek Fiyat"].Value.ToString();
                lbl_low.Text = dataGridView1.SelectedRows[0].Cells["Düşük Fiyat"].Value.ToString();
                lbl_volume.Text = dataGridView1.SelectedRows[0].Cells["Hacim"].Value.ToString();

            }
        }
    }
}
