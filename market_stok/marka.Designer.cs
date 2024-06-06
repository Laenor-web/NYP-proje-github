namespace market_stok
{
    partial class marka
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
            kategori_CB = new ComboBox();
            marka_TB = new TextBox();
            ekle_BTN = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            adres_TB = new TextBox();
            mensei_CB = new ComboBox();
            tel_TB = new MaskedTextBox();
            SuspendLayout();
            // 
            // kategori_CB
            // 
            kategori_CB.FormattingEnabled = true;
            kategori_CB.Location = new Point(166, 36);
            kategori_CB.Name = "kategori_CB";
            kategori_CB.Size = new Size(121, 23);
            kategori_CB.TabIndex = 0;
            // 
            // marka_TB
            // 
            marka_TB.Location = new Point(166, 65);
            marka_TB.Name = "marka_TB";
            marka_TB.Size = new Size(121, 23);
            marka_TB.TabIndex = 1;
            // 
            // ekle_BTN
            // 
            ekle_BTN.Location = new Point(130, 256);
            ekle_BTN.Name = "ekle_BTN";
            ekle_BTN.Size = new Size(75, 23);
            ekle_BTN.TabIndex = 2;
            ekle_BTN.Text = "Ekle";
            ekle_BTN.UseVisualStyleBackColor = true;
            ekle_BTN.Click += ekle_BTN_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 39);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "Kategori";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 68);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 4;
            label2.Text = "Marka İsmi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 97);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 5;
            label3.Text = "Marka Menşei";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 126);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 6;
            label4.Text = "Telefon Numarası";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 155);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 7;
            label5.Text = "Adres";
            // 
            // adres_TB
            // 
            adres_TB.Location = new Point(166, 152);
            adres_TB.Multiline = true;
            adres_TB.Name = "adres_TB";
            adres_TB.Size = new Size(121, 64);
            adres_TB.TabIndex = 13;
            // 
            // mensei_CB
            // 
            mensei_CB.FormattingEnabled = true;
            mensei_CB.Items.AddRange(new object[] { "Afganistan", "Almanya", "Amerika Birleşik Devletleri", "Andorra", "Angola", "Antigua ve Barbuda", "Arnavutluk", "Arjantin", "Arnavutluk", "Avustralya", "Avusturya", "Azerbaycan", "Bahamalar", "Bahreyn", "Bangladeş", "Barbados", "Belarus", "Belçika", "Belize", "Benin", "Bhutan", "Birleşik Arap Emirlikleri", "Bolivya", "Bosna-Hersek", "Botsvana", "Brezilya", "Brunei", "Bulgaristan", "Burkina Faso", "Burundi", "Butan", "Cape Verde", "Cebelitarık", "Cezayir", "Cibuti", "Çad", "Çek Cumhuriyeti", "Çin", "Dominika", "Dominik Cumhuriyeti", "Ekvator", "Ekvator Ginesi", "El Salvador", "Endonezya", "Eritre", "Ermenistan", "Estonya", "Esvatini", "Etiyopya", "Fas", "Fiji", "Fildişi Sahili", "Filipinler", "Filistin", "Finlandiya", "Fransa", "Gabon", "Gambiya", "Gana", "Gine", "Gine-Bissau", "Grenada", "Guatemala", "Guyana", "Güney Afrika", "Güney Kore", "Gürcistan", "Haiti", "Hırvatistan", "Hindistan", "Hollanda", "Honduras", "Irak", "İngiltere", "İran", "İrlanda", "İspanya", "İsrail", "İsveç", "İsviçre", "İtalya", "İzlanda", "Jamaika", "Japonya", "Kamboçya", "Kamerun", "Kanada", "Karadağ", "Katar", "Kazakistan", "Kenya", "Kırgızistan", "Kiribati", "Kolombiya", "Komorlar", "Kongo Demokratik Cumhuriyeti", "Kongo Cumhuriyeti", "Kosova", "Kuveyt", "Kuzey Kore", "Küba", "Laos", "Lesotho", "Letonya", "Liberya", "Libya", "Lihtenştayn", "Litvanya", "Lübnan", "Lüksemburg", "Macaristan", "Madagaskar", "Makedonya", "Malavi", "Maldivler", "Malezya", "Mali", "Malta", "Marshall Adaları", "Mauritius", "Mauritanya", "Meksika", "Mikronezya", "Moğolistan", "Moldova", "Monako", "Moritanya", "Moro Adaları", "Mozambik", "Myanmar (Burma)", "Namibya", "Nauru", "Nepal", "Nijer", "Nijerya", "Nikaragua", "Niue", "Norveç", "Orta Afrika Cumhuriyeti", "Özbekistan", "Pakistan", "Palau", "Panama", "Papua Yeni Gine", "Paraguay", "Peru", "Polonya", "Portekiz", "Romanya", "Ruanda", "Rusya", "Saint Kitts ve Nevis", "Saint Lucia", "Saint Vincent ve Grenadinler", "Samoa", "San Marino", "São Tomé ve Príncipe", "Senegal", "Sırbistan", "Seyşeller", "Sierra Leone", "Singapur", "Slovakya", "Slovenya", "Solomon Adaları", "Somali", "Sri Lanka", "Sudan", "Surinam", "Suriye", "Suudi Arabistan", "Svaziland", "Tacikistan", "Tanzanya", "Tayland", "Tayvan", "Togo", "Tonga", "Trinidad ve Tobago", "Tunus", "Türkiye", "Türkmenistan", "Tuvalu", "Uganda", "Ukrayna", "Umman", "Uruguay", "Ürdün", "Vanuatu", "Vatikan Şehri", "Venezuela", "Vietnam", "Yemen", "Yeni Zelanda", "Yeşil Burun Adaları", "Yunanistan", "Zambiya", "Zimbabve" });
            mensei_CB.Location = new Point(166, 94);
            mensei_CB.Name = "mensei_CB";
            mensei_CB.Size = new Size(121, 23);
            mensei_CB.TabIndex = 15;
            // 
            // tel_TB
            // 
            tel_TB.Location = new Point(166, 123);
            tel_TB.Mask = "0000000000";
            tel_TB.Name = "tel_TB";
            tel_TB.PromptChar = ' ';
            tel_TB.Size = new Size(121, 23);
            tel_TB.TabIndex = 34;
            tel_TB.ValidatingType = typeof(int);
            // 
            // marka
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(347, 347);
            Controls.Add(tel_TB);
            Controls.Add(mensei_CB);
            Controls.Add(adres_TB);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ekle_BTN);
            Controls.Add(marka_TB);
            Controls.Add(kategori_CB);
            Name = "marka";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Markalar Ekranı";
            Load += marka_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox kategori_CB;
        private TextBox marka_TB;
        private Button ekle_BTN;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox adres_TB;
        private ComboBox mensei_CB;
        private MaskedTextBox tel_TB;
    }
}