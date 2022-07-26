using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev2
{
    public partial class CoinTurleri : Form
    {
        public CoinTurleri()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CoinOzellikleri_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_coinsec.Text=="Metaverse")
            {
                rbt_cointur.Visible = true;
                rbt_cointur.Text = "“Meta-evren”in kısaltması olan metaverse, gerçek ve sanalın bir bilim kurgu vizyonunda birleştiği ve insanların farklı cihazlar arasında hareket etmesine ve sanal bir ortamda iletişim kurmasına izin verdiği dijital bir dünya. Bu projelere sahip coinleri borsamız üzerinden alım satım yapabilirsiniz.";
                pb_coin.Image = Properties.Resources.metaverse;
            }
            else if (cb_coinsec.Text== "DeFi")
            {
                rbt_cointur.Visible = true;
                rbt_cointur.Text = "DeFi, merkeziyetsiz (decentralized) ve finans (finance) kelimelerinden oluşan merkeziyetsiz finans işlemlerine verilen genel addır. Bitcoin ve Ethereum gibi belli bir merkezi olmayan ve karar verici otoritelerin olmadığı sistemler DeFi için ideal örneklerdir. Fakat finansal araçlar sadece para gönderme ve alma ile sınırlı olmadığı için DeFi denildiğinde daha gelişmiş finansal işlevleri akla getirmek doğru olacaktır. Bunlara arasında kredi alma, kredi verme, merkeziyetsiz borsa, sigorta, alışveriş, pazaryeri ve benzerlerini sayabiliriz.";
                pb_coin.Image = Properties.Resources.defi;
            }

            else if (cb_coinsec.Text == "Token")
            {
                rbt_cointur.Visible = true;
                rbt_cointur.Text = "Token’lar, Blockchain ekosisteminde dijital olarak transfer edilebilen varlıklardır. Bir token; değeri, hizmeti veya bir ürünü temsil edebilir. Blockchain teknolojisi söz konusu olduğunda üç ana token çeşidi vardır. Bunlar, hizmet token’ı, menkul kıymet token’ı ve hisse senedi token’ı olarak ifade edilebilir. Bir hizmet token’ı, yazılım, dijital içerik vb. gibi hizmetlere ya da ürünlere erişim imkanı verir. Bir menkul kıymet token’ı gerçek hayattaki fiziksel varlıkları temsil edebilir. Bir hisse senedi token’ı da bir şirkette kısmi sahipliğe karşılık gelir. Günümüzde token’lar, çoğunlukla Ethereum blok zinciri üzerinde yer alır. Token’ın coin’den temel farkı, coin’in kendine ait bağımsız bir blok zincirine sahip olması, token’ın ise mevcut bir blok zinciri üzerine inşa edilmiş bir kripto para olmasında yatar.";
                pb_coin.Image = Properties.Resources.token;
            }
            else if (cb_coinsec.Text == "NFT")
            {
                rbt_cointur.Visible = true;
                rbt_cointur.Text = "Non-Fungible Token (NFT), en kısa tanımıyla başka bir eşi daha bulunmayan dijital varlıklardır. Tüm NFT’lerin benzeri olmayan eşsiz bilgiler barındırmaları ve kolayca erişilebilir olmaları, koleksiyon değeri olan fiziksel bir ürünle karşılaştırıldığında bir ürüne dijital olarak sahip olmanın avantajlarını ortaya çıkartmaktadır. Sahte ürünlerin yapım ve çoğaltılmasının önüne geçerek dijital varlığın orijinalliği konusunda önceki sahibi ve üreticisine kadar tüm bilgilere sahip olunmasını sağlamaktadır. İlk üretilen NFT’lerden biri olan CryptoPunk oyununa ait bir karakter olan Alien2089, Ocak 2021’de 605 Ethereum (27.02.2021 tarihli fiyatıyla 6.455.000 TRY) karşılığında satılmıştır";
                pb_coin.Image = Properties.Resources.nft605;
            }
            else if (cb_coinsec.Text == "WEB 3.0")
            {
                rbt_cointur.Visible = true;
                rbt_cointur.Text = "Dağıtık defterler ve Blockchain üzerinde depolama gibi teknolojilerin yükselişi, verilerin merkezden dağıtılmasına izin verecek; şeffaf ve güvenli bir ortam yaratarak Web 2.0’ın merkeziliğini, gözetimini ve reklamcılığını geride bırakacak. Ayrıca Web 2.0’da norm haline gelen kronik kesintiler ortadan kalkacaktır çünkü merkeziyetsizlik şeffaf, isteğe bağlı, eşler arası iletişimi mümkün kılacaktır. Özetle, Web 3.0, bireyin egemen olmasını sağlayarak bize daha adil bir internet getirmenin hedeflendiğini ifade eder. Bu sebeple, daha “demokratik” olarak tanımlanır.";
                pb_coin.Image = Properties.Resources.web3_0;
            }

          

        }

        private void pb_coin_Click(object sender, EventArgs e)
        {
            
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

        private void rbt_cointur_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
