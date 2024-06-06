namespace market_stok
{
    partial class satis_ekrani
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            satis_GridView = new DataGridView();
            groupBox1 = new GroupBox();
            tel_TB = new MaskedTextBox();
            label12 = new Label();
            adres_TB = new TextBox();
            label9 = new Label();
            label3 = new Label();
            soyad_TB = new TextBox();
            label2 = new Label();
            ad_TB = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            barkodno_CB = new ComboBox();
            label10 = new Label();
            miktar_TB = new TextBox();
            stok_TB = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label4 = new Label();
            toplamfiyat_TB = new TextBox();
            label5 = new Label();
            label6 = new Label();
            satisfiyat_TB = new TextBox();
            urunad_TB = new TextBox();
            ekle_BTN = new Button();
            satisonay_BTN = new Button();
            menuStrip1 = new MenuStrip();
            müşteriEkleToolStripMenuItem = new ToolStripMenuItem();
            müşteriListeleToolStripMenuItem = new ToolStripMenuItem();
            ürünEkleToolStripMenuItem = new ToolStripMenuItem();
            ürünListeleToolStripMenuItem = new ToolStripMenuItem();
            satışlarıListeleToolStripMenuItem = new ToolStripMenuItem();
            kategoriToolStripMenuItem = new ToolStripMenuItem();
            markaToolStripMenuItem = new ToolStripMenuItem();
            sil_BTN = new Button();
            label11 = new Label();
            toplam_LBL = new Label();
            sepet_tutar = new Label();
            tc_CB = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)satis_GridView).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // satis_GridView
            // 
            satis_GridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            satis_GridView.Location = new Point(274, 57);
            satis_GridView.Name = "satis_GridView";
            satis_GridView.ReadOnly = true;
            satis_GridView.Size = new Size(1044, 550);
            satis_GridView.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tc_CB);
            groupBox1.Controls.Add(tel_TB);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(adres_TB);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(soyad_TB);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(ad_TB);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(216, 208);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Müşteri İşlemleri";
            // 
            // tel_TB
            // 
            tel_TB.Location = new Point(94, 109);
            tel_TB.Mask = "0000000000";
            tel_TB.Name = "tel_TB";
            tel_TB.PromptChar = ' ';
            tel_TB.ReadOnly = true;
            tel_TB.Size = new Size(116, 23);
            tel_TB.TabIndex = 33;
            tel_TB.ValidatingType = typeof(int);
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 141);
            label12.Name = "label12";
            label12.Size = new Size(37, 15);
            label12.TabIndex = 13;
            label12.Text = "Adres";
            // 
            // adres_TB
            // 
            adres_TB.Location = new Point(94, 138);
            adres_TB.Multiline = true;
            adres_TB.Name = "adres_TB";
            adres_TB.ReadOnly = true;
            adres_TB.Size = new Size(116, 64);
            adres_TB.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 112);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 11;
            label9.Text = "Telefon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 83);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 9;
            label3.Text = "Soyad";
            // 
            // soyad_TB
            // 
            soyad_TB.Location = new Point(94, 80);
            soyad_TB.Name = "soyad_TB";
            soyad_TB.ReadOnly = true;
            soyad_TB.Size = new Size(116, 23);
            soyad_TB.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 54);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 8;
            label2.Text = "Ad";
            // 
            // ad_TB
            // 
            ad_TB.Location = new Point(94, 51);
            ad_TB.Name = "ad_TB";
            ad_TB.ReadOnly = true;
            ad_TB.Size = new Size(116, 23);
            ad_TB.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 7;
            label1.Text = "T.C.";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(barkodno_CB);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(miktar_TB);
            groupBox2.Controls.Add(stok_TB);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(toplamfiyat_TB);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(satisfiyat_TB);
            groupBox2.Controls.Add(urunad_TB);
            groupBox2.Location = new Point(12, 283);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(216, 195);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ürün İşlemleri";
            // 
            // barkodno_CB
            // 
            barkodno_CB.FormattingEnabled = true;
            barkodno_CB.Location = new Point(94, 22);
            barkodno_CB.Name = "barkodno_CB";
            barkodno_CB.Size = new Size(116, 23);
            barkodno_CB.TabIndex = 18;
            barkodno_CB.SelectedIndexChanged += barkodno_CB_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 83);
            label10.Name = "label10";
            label10.Size = new Size(70, 15);
            label10.TabIndex = 18;
            label10.Text = "Stok Miktarı";
            // 
            // miktar_TB
            // 
            miktar_TB.Location = new Point(94, 109);
            miktar_TB.Name = "miktar_TB";
            miktar_TB.Size = new Size(116, 23);
            miktar_TB.TabIndex = 15;
            miktar_TB.Text = "1";
            miktar_TB.TextChanged += miktar_TB_TextChanged;
            // 
            // stok_TB
            // 
            stok_TB.Location = new Point(94, 80);
            stok_TB.Name = "stok_TB";
            stok_TB.ReadOnly = true;
            stok_TB.Size = new Size(116, 23);
            stok_TB.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 170);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 14;
            label7.Text = "Toplam Fiyat";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 141);
            label8.Name = "label8";
            label8.Size = new Size(62, 15);
            label8.TabIndex = 13;
            label8.Text = "Satış Fiyatı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 112);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 12;
            label4.Text = "Satış Miktarı";
            // 
            // toplamfiyat_TB
            // 
            toplamfiyat_TB.Location = new Point(94, 167);
            toplamfiyat_TB.Name = "toplamfiyat_TB";
            toplamfiyat_TB.ReadOnly = true;
            toplamfiyat_TB.Size = new Size(116, 23);
            toplamfiyat_TB.TabIndex = 6;
            toplamfiyat_TB.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 54);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 11;
            label5.Text = "Ürün Adı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 25);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 10;
            label6.Text = "Barkod No";
            // 
            // satisfiyat_TB
            // 
            satisfiyat_TB.Location = new Point(94, 138);
            satisfiyat_TB.Name = "satisfiyat_TB";
            satisfiyat_TB.ReadOnly = true;
            satisfiyat_TB.Size = new Size(116, 23);
            satisfiyat_TB.TabIndex = 5;
            satisfiyat_TB.TextChanged += satisfiyat_TB_TextChanged;
            // 
            // urunad_TB
            // 
            urunad_TB.Location = new Point(94, 51);
            urunad_TB.Name = "urunad_TB";
            urunad_TB.ReadOnly = true;
            urunad_TB.Size = new Size(116, 23);
            urunad_TB.TabIndex = 3;
            // 
            // ekle_BTN
            // 
            ekle_BTN.Location = new Point(30, 505);
            ekle_BTN.Name = "ekle_BTN";
            ekle_BTN.Size = new Size(80, 41);
            ekle_BTN.TabIndex = 3;
            ekle_BTN.Text = "Sepete Ekle";
            ekle_BTN.UseVisualStyleBackColor = true;
            ekle_BTN.Click += ekle_BTN_Click;
            // 
            // satisonay_BTN
            // 
            satisonay_BTN.Location = new Point(134, 528);
            satisonay_BTN.Name = "satisonay_BTN";
            satisonay_BTN.Size = new Size(80, 41);
            satisonay_BTN.TabIndex = 5;
            satisonay_BTN.Text = "Satış Onay";
            satisonay_BTN.UseVisualStyleBackColor = true;
            satisonay_BTN.Click += satisonay_BTN_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlDark;
            menuStrip1.Items.AddRange(new ToolStripItem[] { müşteriEkleToolStripMenuItem, müşteriListeleToolStripMenuItem, ürünEkleToolStripMenuItem, ürünListeleToolStripMenuItem, satışlarıListeleToolStripMenuItem, kategoriToolStripMenuItem, markaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1335, 24);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            // 
            // müşteriEkleToolStripMenuItem
            // 
            müşteriEkleToolStripMenuItem.Name = "müşteriEkleToolStripMenuItem";
            müşteriEkleToolStripMenuItem.Size = new Size(83, 20);
            müşteriEkleToolStripMenuItem.Text = "Müşteri Ekle";
            müşteriEkleToolStripMenuItem.Click += müşteriEkleToolStripMenuItem_Click;
            // 
            // müşteriListeleToolStripMenuItem
            // 
            müşteriListeleToolStripMenuItem.Name = "müşteriListeleToolStripMenuItem";
            müşteriListeleToolStripMenuItem.Size = new Size(95, 20);
            müşteriListeleToolStripMenuItem.Text = "Müşteri Listele";
            müşteriListeleToolStripMenuItem.Click += müşteriListeleToolStripMenuItem_Click;
            // 
            // ürünEkleToolStripMenuItem
            // 
            ürünEkleToolStripMenuItem.Name = "ürünEkleToolStripMenuItem";
            ürünEkleToolStripMenuItem.Size = new Size(69, 20);
            ürünEkleToolStripMenuItem.Text = "Ürün Ekle";
            ürünEkleToolStripMenuItem.Click += ürünEkleToolStripMenuItem_Click;
            // 
            // ürünListeleToolStripMenuItem
            // 
            ürünListeleToolStripMenuItem.Name = "ürünListeleToolStripMenuItem";
            ürünListeleToolStripMenuItem.Size = new Size(81, 20);
            ürünListeleToolStripMenuItem.Text = "Ürün Listele";
            ürünListeleToolStripMenuItem.Click += ürünListeleToolStripMenuItem_Click;
            // 
            // satışlarıListeleToolStripMenuItem
            // 
            satışlarıListeleToolStripMenuItem.Name = "satışlarıListeleToolStripMenuItem";
            satışlarıListeleToolStripMenuItem.Size = new Size(70, 20);
            satışlarıListeleToolStripMenuItem.Text = "Satışlarım";
            satışlarıListeleToolStripMenuItem.Click += satışlarıListeleToolStripMenuItem_Click;
            // 
            // kategoriToolStripMenuItem
            // 
            kategoriToolStripMenuItem.Name = "kategoriToolStripMenuItem";
            kategoriToolStripMenuItem.Size = new Size(63, 20);
            kategoriToolStripMenuItem.Text = "Kategori";
            kategoriToolStripMenuItem.Click += kategoriToolStripMenuItem_Click;
            // 
            // markaToolStripMenuItem
            // 
            markaToolStripMenuItem.Name = "markaToolStripMenuItem";
            markaToolStripMenuItem.Size = new Size(52, 20);
            markaToolStripMenuItem.Text = "Marka";
            markaToolStripMenuItem.Click += markaToolStripMenuItem_Click;
            // 
            // sil_BTN
            // 
            sil_BTN.Location = new Point(30, 563);
            sil_BTN.Name = "sil_BTN";
            sil_BTN.Size = new Size(80, 41);
            sil_BTN.TabIndex = 4;
            sil_BTN.Text = "Sepetten Çıkar";
            sil_BTN.UseVisualStyleBackColor = true;
            sil_BTN.Click += sil_BTN_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15F);
            label11.Location = new Point(590, 621);
            label11.Name = "label11";
            label11.Size = new Size(121, 28);
            label11.TabIndex = 15;
            label11.Text = "Sepet Tutarı:";
            // 
            // toplam_LBL
            // 
            toplam_LBL.AutoSize = true;
            toplam_LBL.Font = new Font("Segoe UI", 15F);
            toplam_LBL.Location = new Point(717, 632);
            toplam_LBL.Name = "toplam_LBL";
            toplam_LBL.Size = new Size(0, 28);
            toplam_LBL.TabIndex = 16;
            // 
            // sepet_tutar
            // 
            sepet_tutar.AutoSize = true;
            sepet_tutar.Font = new Font("Segoe UI", 15F);
            sepet_tutar.Location = new Point(717, 621);
            sepet_tutar.Name = "sepet_tutar";
            sepet_tutar.Size = new Size(0, 28);
            sepet_tutar.TabIndex = 17;
            // 
            // tc_CB
            // 
            tc_CB.FormattingEnabled = true;
            tc_CB.Location = new Point(94, 22);
            tc_CB.Name = "tc_CB";
            tc_CB.Size = new Size(116, 23);
            tc_CB.TabIndex = 18;
            tc_CB.SelectedIndexChanged += tc_CB_SelectedIndexChanged;
            // 
            // satis_ekrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1335, 658);
            Controls.Add(sepet_tutar);
            Controls.Add(toplam_LBL);
            Controls.Add(label11);
            Controls.Add(satisonay_BTN);
            Controls.Add(sil_BTN);
            Controls.Add(ekle_BTN);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(satis_GridView);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "satis_ekrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Satış Ekranı";
            Load += satis_sayfa_Load;
            ((System.ComponentModel.ISupportInitialize)satis_GridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView satis_GridView;
        private GroupBox groupBox1;
        private TextBox ad_TB;
        private GroupBox groupBox2;
        private TextBox urunad_TB;
        private TextBox soyad_TB;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label label8;
        private Label label4;
        private TextBox toplamfiyat_TB;
        private Label label5;
        private Label label6;
        private TextBox satisfiyat_TB;
        private Label label9;
        private Button ekle_BTN;
        private Button satisonay_BTN;
        private Label label12;
        private TextBox adres_TB;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem müşteriEkleToolStripMenuItem;
        private ToolStripMenuItem müşteriListeleToolStripMenuItem;
        private ToolStripMenuItem ürünEkleToolStripMenuItem;
        private ToolStripMenuItem ürünListeleToolStripMenuItem;
        private ToolStripMenuItem satışlarıListeleToolStripMenuItem;
        private ToolStripMenuItem kategoriToolStripMenuItem;
        private ToolStripMenuItem markaToolStripMenuItem;
        private MaskedTextBox tel_TB;
        private TextBox miktar_TB;
        private Label label10;
        private TextBox stok_TB;
        private Button sil_BTN;
        private Label label11;
        private Label toplam_LBL;
        private Label sepet_tutar;
        private ComboBox barkodno_CB;
        private ComboBox tc_CB;
    }
}
