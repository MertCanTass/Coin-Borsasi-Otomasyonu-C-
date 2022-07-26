
namespace Odev2
{
    partial class CoinProjeleri
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
            this.components = new System.ComponentModel.Container();
            this.cb_coinproje = new System.Windows.Forms.ComboBox();
            this.rtb_coinproje = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.alımSatımSayfasınaGitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sayfayıYenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coinKullanımAlanlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yTDALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton8 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton6 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton7 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton7)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_coinproje
            // 
            this.cb_coinproje.FormattingEnabled = true;
            this.cb_coinproje.Items.AddRange(new object[] {
            "----MarketCapIlk10----",
            "BTC",
            "ETH",
            "BNB",
            "SOL",
            "ADA",
            "XRP",
            "DOT",
            "LUNA",
            "DOGE",
            "AVAX"});
            this.cb_coinproje.Location = new System.Drawing.Point(42, 91);
            this.cb_coinproje.Name = "cb_coinproje";
            this.cb_coinproje.Size = new System.Drawing.Size(121, 21);
            this.cb_coinproje.TabIndex = 0;
            this.cb_coinproje.SelectedIndexChanged += new System.EventHandler(this.cb_coinproje_SelectedIndexChanged);
            // 
            // rtb_coinproje
            // 
            this.rtb_coinproje.Location = new System.Drawing.Point(283, 91);
            this.rtb_coinproje.Name = "rtb_coinproje";
            this.rtb_coinproje.Size = new System.Drawing.Size(492, 445);
            this.rtb_coinproje.TabIndex = 1;
            this.rtb_coinproje.Text = "";
            this.rtb_coinproje.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alımSatımSayfasınaGitToolStripMenuItem,
            this.sayfayıYenileToolStripMenuItem,
            this.coinKullanımAlanlarıToolStripMenuItem,
            this.çıkışYapToolStripMenuItem,
            this.yTDALToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(205, 114);
            // 
            // alımSatımSayfasınaGitToolStripMenuItem
            // 
            this.alımSatımSayfasınaGitToolStripMenuItem.Name = "alımSatımSayfasınaGitToolStripMenuItem";
            this.alımSatımSayfasınaGitToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.alımSatımSayfasınaGitToolStripMenuItem.Text = "Alım-Satım Sayfasına Git";
            // 
            // sayfayıYenileToolStripMenuItem
            // 
            this.sayfayıYenileToolStripMenuItem.Name = "sayfayıYenileToolStripMenuItem";
            this.sayfayıYenileToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.sayfayıYenileToolStripMenuItem.Text = "Sayfayı Yenile";
            // 
            // coinKullanımAlanlarıToolStripMenuItem
            // 
            this.coinKullanımAlanlarıToolStripMenuItem.Name = "coinKullanımAlanlarıToolStripMenuItem";
            this.coinKullanımAlanlarıToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.coinKullanımAlanlarıToolStripMenuItem.Text = "Coin Kullanım Alanları";
            // 
            // çıkışYapToolStripMenuItem
            // 
            this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            // 
            // yTDALToolStripMenuItem
            // 
            this.yTDALToolStripMenuItem.Name = "yTDALToolStripMenuItem";
            this.yTDALToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.yTDALToolStripMenuItem.Text = "YTD AL !!!";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.bunifuImageButton8);
            this.panel1.Controls.Add(this.bunifuImageButton6);
            this.panel1.Controls.Add(this.bunifuImageButton7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(926, 63);
            this.panel1.TabIndex = 15;
            // 
            // bunifuImageButton8
            // 
            this.bunifuImageButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.bunifuImageButton8.Image = global::Odev2.Properties.Resources.exit_32;
            this.bunifuImageButton8.ImageActive = null;
            this.bunifuImageButton8.Location = new System.Drawing.Point(884, 21);
            this.bunifuImageButton8.Name = "bunifuImageButton8";
            this.bunifuImageButton8.Size = new System.Drawing.Size(31, 28);
            this.bunifuImageButton8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton8.TabIndex = 13;
            this.bunifuImageButton8.TabStop = false;
            this.bunifuImageButton8.Zoom = 10;
            this.bunifuImageButton8.Click += new System.EventHandler(this.bunifuImageButton8_Click);
            // 
            // bunifuImageButton6
            // 
            this.bunifuImageButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.bunifuImageButton6.Image = global::Odev2.Properties.Resources.back_to_32;
            this.bunifuImageButton6.ImageActive = null;
            this.bunifuImageButton6.Location = new System.Drawing.Point(816, 21);
            this.bunifuImageButton6.Name = "bunifuImageButton6";
            this.bunifuImageButton6.Size = new System.Drawing.Size(31, 28);
            this.bunifuImageButton6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton6.TabIndex = 11;
            this.bunifuImageButton6.TabStop = false;
            this.bunifuImageButton6.Zoom = 10;
            this.bunifuImageButton6.Click += new System.EventHandler(this.bunifuImageButton6_Click);
            // 
            // bunifuImageButton7
            // 
            this.bunifuImageButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.bunifuImageButton7.Image = global::Odev2.Properties.Resources.minus_32;
            this.bunifuImageButton7.ImageActive = null;
            this.bunifuImageButton7.Location = new System.Drawing.Point(850, 21);
            this.bunifuImageButton7.Name = "bunifuImageButton7";
            this.bunifuImageButton7.Size = new System.Drawing.Size(31, 28);
            this.bunifuImageButton7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton7.TabIndex = 12;
            this.bunifuImageButton7.TabStop = false;
            this.bunifuImageButton7.Zoom = 10;
            this.bunifuImageButton7.Click += new System.EventHandler(this.bunifuImageButton7_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 693);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(926, 75);
            this.panel2.TabIndex = 16;
            // 
            // CoinProjeleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(926, 768);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rtb_coinproje);
            this.Controls.Add(this.cb_coinproje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CoinProjeleri";
            this.Text = "CoinProjeleri";
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_coinproje;
        private System.Windows.Forms.RichTextBox rtb_coinproje;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alımSatımSayfasınaGitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sayfayıYenileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coinKullanımAlanlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yTDALToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton8;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton6;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton7;
        private System.Windows.Forms.Panel panel2;
    }
}