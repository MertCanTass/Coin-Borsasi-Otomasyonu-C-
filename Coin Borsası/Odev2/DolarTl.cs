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
using System.Data.SqlClient;

namespace Odev2
{
    public partial class DolarTl : Form
    {
        public DolarTl()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani();

        private void DolarTl_Load(object sender, EventArgs e)
        {
            dgvdolar.DataSource = vt.Select("select Tarih,Acılıs,Yuksek,Dusuk,Kapanıs from tbl_dolar");
            //DataTable dt = vt.Select("select Tarih, Kapanıs from tbl_dolar");
            //DataTable dt2 = vt.Select("select Kapanıs from tbl_dolar");

            //foreach (DataRow item in dt.Row)
            //{
              
            //        chart1.Series["Series1"].Points.AddXY(dt.Rows[0]["Tarih"], dt.Rows[0]["Kapanıs"]);
                
            //}
                
              
          
            

        }

        private void dgvdolar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
    }
}
