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
    public partial class CoinProjeleri : Form
    {
        public CoinProjeleri()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void cb_coinproje_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_coinproje.Text == "Metaverse")
            {
                rtb_coinproje.Visible = true;
                rtb_coinproje.Text = "";
              
            }
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
    }
}
