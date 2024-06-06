namespace market_stok
{
    partial class urun_listele
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
            urunler_GridView = new DataGridView();
            sil_BTN = new Button();
            guncelle_BTN = new Button();
            skt = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            urunad_TB = new TextBox();
            kategori_CB = new ComboBox();
            label3 = new Label();
            marka_CB = new ComboBox();
            label9 = new Label();
            label4 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            barkodno_TB = new TextBox();
            miktar_TB = new MaskedTextBox();
            alisfiyat_TB = new MaskedTextBox();
            satisfiyat_TB = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)urunler_GridView).BeginInit();
            SuspendLayout();
            // 
            // urunler_GridView
            // 
            urunler_GridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            urunler_GridView.Location = new Point(259, 32);
            urunler_GridView.Name = "urunler_GridView";
            urunler_GridView.Size = new Size(843, 292);
            urunler_GridView.TabIndex = 72;
            urunler_GridView.CellMouseClick += urunler_GridView_CellMouseClick;
            // 
            // sil_BTN
            // 
            sil_BTN.Location = new Point(128, 301);
            sil_BTN.Name = "sil_BTN";
            sil_BTN.Size = new Size(75, 23);
            sil_BTN.TabIndex = 71;
            sil_BTN.Text = "Sil";
            sil_BTN.UseVisualStyleBackColor = true;
            sil_BTN.Click += sil_BTN_Click;
            // 
            // guncelle_BTN
            // 
            guncelle_BTN.Location = new Point(25, 301);
            guncelle_BTN.Name = "guncelle_BTN";
            guncelle_BTN.Size = new Size(75, 23);
            guncelle_BTN.TabIndex = 70;
            guncelle_BTN.Text = "Güncelle";
            guncelle_BTN.UseVisualStyleBackColor = true;
            guncelle_BTN.Click += guncelle_BTN_Click;
            // 
            // skt
            // 
            skt.Format = DateTimePickerFormat.Short;
            skt.Location = new Point(100, 252);
            skt.Name = "skt";
            skt.Size = new Size(116, 23);
            skt.TabIndex = 69;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 55);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 58;
            label1.Text = "Barkod No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 113);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 59;
            label2.Text = "Marka";
            // 
            // urunad_TB
            // 
            urunad_TB.Location = new Point(100, 139);
            urunad_TB.Name = "urunad_TB";
            urunad_TB.Size = new Size(116, 23);
            urunad_TB.TabIndex = 56;
            // 
            // kategori_CB
            // 
            kategori_CB.FormattingEnabled = true;
            kategori_CB.Location = new Point(100, 81);
            kategori_CB.Name = "kategori_CB";
            kategori_CB.Size = new Size(116, 23);
            kategori_CB.TabIndex = 67;
            kategori_CB.SelectedIndexChanged += kategori_CB_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 142);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 60;
            label3.Text = "Ürün Ad";
            // 
            // marka_CB
            // 
            marka_CB.FormattingEnabled = true;
            marka_CB.Location = new Point(100, 110);
            marka_CB.Name = "marka_CB";
            marka_CB.Size = new Size(116, 23);
            marka_CB.TabIndex = 57;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 84);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 61;
            label9.Text = "Kategori";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 258);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 66;
            label4.Text = "S.K.T";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 171);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 63;
            label7.Text = "Miktar";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 200);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 64;
            label6.Text = "Alış Fiyatı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 229);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 65;
            label5.Text = "Satış Fiyatı";
            // 
            // barkodno_TB
            // 
            barkodno_TB.Location = new Point(100, 52);
            barkodno_TB.Name = "barkodno_TB";
            barkodno_TB.Size = new Size(116, 23);
            barkodno_TB.TabIndex = 76;
            // 
            // miktar_TB
            // 
            miktar_TB.Location = new Point(100, 168);
            miktar_TB.Mask = "0000000000";
            miktar_TB.Name = "miktar_TB";
            miktar_TB.PromptChar = ' ';
            miktar_TB.Size = new Size(116, 23);
            miktar_TB.TabIndex = 77;
            miktar_TB.ValidatingType = typeof(int);
            // 
            // alisfiyat_TB
            // 
            alisfiyat_TB.Location = new Point(100, 197);
            alisfiyat_TB.Mask = "000000000";
            alisfiyat_TB.Name = "alisfiyat_TB";
            alisfiyat_TB.PromptChar = ' ';
            alisfiyat_TB.Size = new Size(116, 23);
            alisfiyat_TB.TabIndex = 78;
            alisfiyat_TB.ValidatingType = typeof(int);
            // 
            // satisfiyat_TB
            // 
            satisfiyat_TB.Location = new Point(100, 226);
            satisfiyat_TB.Mask = "00000000000";
            satisfiyat_TB.Name = "satisfiyat_TB";
            satisfiyat_TB.PromptChar = ' ';
            satisfiyat_TB.Size = new Size(116, 23);
            satisfiyat_TB.TabIndex = 79;
            satisfiyat_TB.ValidatingType = typeof(int);
            // 
            // urun_listele
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1114, 357);
            Controls.Add(satisfiyat_TB);
            Controls.Add(alisfiyat_TB);
            Controls.Add(miktar_TB);
            Controls.Add(barkodno_TB);
            Controls.Add(urunler_GridView);
            Controls.Add(sil_BTN);
            Controls.Add(guncelle_BTN);
            Controls.Add(skt);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(urunad_TB);
            Controls.Add(kategori_CB);
            Controls.Add(label3);
            Controls.Add(marka_CB);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Name = "urun_listele";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ürün Listeleme Ekranı";
            Load += urun_listele_Load;
            ((System.ComponentModel.ISupportInitialize)urunler_GridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView urunler_GridView;
        private Button sil_BTN;
        private Button guncelle_BTN;
        private DateTimePicker skt;
        private Label label1;
        private Label label2;
        private TextBox urunad_TB;
        private ComboBox kategori_CB;
        private Label label3;
        private ComboBox marka_CB;
        private Label label9;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox barkodno_TB;
        private MaskedTextBox miktar_TB;
        private MaskedTextBox alisfiyat_TB;
        private MaskedTextBox satisfiyat_TB;
    }
}