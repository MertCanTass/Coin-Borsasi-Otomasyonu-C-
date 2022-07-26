
namespace Odev2
{
    partial class CoinTurleri
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
            this.cb_coinsec = new System.Windows.Forms.ComboBox();
            this.lbl_cointur = new System.Windows.Forms.Label();
            this.rbt_cointur = new System.Windows.Forms.RichTextBox();
            this.pb_coin = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton8 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton6 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton7 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_coin)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton7)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_coinsec
            // 
            this.cb_coinsec.FormattingEnabled = true;
            this.cb_coinsec.Items.AddRange(new object[] {
            "Metaverse",
            "DeFi",
            "Token",
            "NFT",
            "WEB 3.0"});
            this.cb_coinsec.Location = new System.Drawing.Point(151, 65);
            this.cb_coinsec.Name = "cb_coinsec";
            this.cb_coinsec.Size = new System.Drawing.Size(121, 21);
            this.cb_coinsec.TabIndex = 0;
            this.cb_coinsec.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl_cointur
            // 
            this.lbl_cointur.AutoSize = true;
            this.lbl_cointur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.lbl_cointur.ForeColor = System.Drawing.Color.Lavender;
            this.lbl_cointur.Location = new System.Drawing.Point(28, 68);
            this.lbl_cointur.Name = "lbl_cointur";
            this.lbl_cointur.Size = new System.Drawing.Size(117, 13);
            this.lbl_cointur.TabIndex = 1;
            this.lbl_cointur.Text = "Coin Kullanılan Alanlar :";
            // 
            // rbt_cointur
            // 
            this.rbt_cointur.BackColor = System.Drawing.SystemColors.Control;
            this.rbt_cointur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rbt_cointur.Location = new System.Drawing.Point(431, 69);
            this.rbt_cointur.Name = "rbt_cointur";
            this.rbt_cointur.Size = new System.Drawing.Size(357, 114);
            this.rbt_cointur.TabIndex = 8;
            this.rbt_cointur.Text = "";
            this.rbt_cointur.TextChanged += new System.EventHandler(this.rbt_cointur_TextChanged);
            // 
            // pb_coin
            // 
            this.pb_coin.Location = new System.Drawing.Point(92, 198);
            this.pb_coin.Name = "pb_coin";
            this.pb_coin.Size = new System.Drawing.Size(696, 440);
            this.pb_coin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_coin.TabIndex = 9;
            this.pb_coin.TabStop = false;
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
            this.panel1.Size = new System.Drawing.Size(916, 63);
            this.panel1.TabIndex = 16;
            // 
            // bunifuImageButton8
            // 
            this.bunifuImageButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.bunifuImageButton8.Image = global::Odev2.Properties.Resources.exit_32;
            this.bunifuImageButton8.ImageActive = null;
            this.bunifuImageButton8.Location = new System.Drawing.Point(881, 17);
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
            this.bunifuImageButton6.Location = new System.Drawing.Point(813, 17);
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
            this.bunifuImageButton7.Location = new System.Drawing.Point(847, 17);
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
            this.panel2.Location = new System.Drawing.Point(0, 651);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(916, 75);
            this.panel2.TabIndex = 17;
            // 
            // CoinTurleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(916, 726);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pb_coin);
            this.Controls.Add(this.rbt_cointur);
            this.Controls.Add(this.lbl_cointur);
            this.Controls.Add(this.cb_coinsec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CoinTurleri";
            this.Text = "CoinOzellikleri";
            this.Load += new System.EventHandler(this.CoinOzellikleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_coin)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_coinsec;
        private System.Windows.Forms.Label lbl_cointur;
        private System.Windows.Forms.RichTextBox rbt_cointur;
        private System.Windows.Forms.PictureBox pb_coin;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton8;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton6;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton7;
        private System.Windows.Forms.Panel panel2;
    }
}