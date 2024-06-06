namespace market_stok
{
    partial class urun_ekle
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
            skt = new DateTimePicker();
            ekle_BTN = new Button();
            kategori_CB = new ComboBox();
            marka_CB = new ComboBox();
            label4 = new Label();
            barkodno_TB = new MaskedTextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            label3 = new Label();
            urunad_TB = new TextBox();
            label2 = new Label();
            label1 = new Label();
            miktar_TB = new MaskedTextBox();
            alisfiyat_TB = new MaskedTextBox();
            satisfiyat_TB = new MaskedTextBox();
            SuspendLayout();
            // 
            // skt
            // 
            skt.Format = DateTimePickerFormat.Short;
            skt.Location = new Point(133, 237);
            skt.Name = "skt";
            skt.Size = new Size(116, 23);
            skt.TabIndex = 49;
            // 
            // ekle_BTN
            // 
            ekle_BTN.Location = new Point(109, 290);
            ekle_BTN.Name = "ekle_BTN";
            ekle_BTN.Size = new Size(75, 23);
            ekle_BTN.TabIndex = 44;
            ekle_BTN.Text = "Ekle";
            ekle_BTN.UseVisualStyleBackColor = true;
            ekle_BTN.Click += ekle_BTN_Click;
            // 
            // kategori_CB
            // 
            kategori_CB.FormattingEnabled = true;
            kategori_CB.Location = new Point(133, 66);
            kategori_CB.Name = "kategori_CB";
            kategori_CB.Size = new Size(116, 23);
            kategori_CB.TabIndex = 43;
            kategori_CB.SelectedIndexChanged += kategori_CB_SelectedIndexChanged;
            // 
            // marka_CB
            // 
            marka_CB.FormattingEnabled = true;
            marka_CB.Location = new Point(133, 95);
            marka_CB.Name = "marka_CB";
            marka_CB.Size = new Size(116, 23);
            marka_CB.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 243);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 42;
            label4.Text = "S.K.T";
            // 
            // barkodno_TB
            // 
            barkodno_TB.Location = new Point(133, 37);
            barkodno_TB.Mask = "0000000000000";
            barkodno_TB.Name = "barkodno_TB";
            barkodno_TB.PromptChar = ' ';
            barkodno_TB.Size = new Size(116, 23);
            barkodno_TB.TabIndex = 16;
            barkodno_TB.ValidatingType = typeof(int);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 214);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 38;
            label5.Text = "Satış Fiyatı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 185);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 37;
            label6.Text = "Alış Fiyatı";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 156);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 36;
            label7.Text = "Miktar";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(45, 69);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 11;
            label9.Text = "Kategori";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 127);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 9;
            label3.Text = "Ürün Ad";
            // 
            // urunad_TB
            // 
            urunad_TB.Location = new Point(133, 124);
            urunad_TB.Name = "urunad_TB";
            urunad_TB.Size = new Size(116, 23);
            urunad_TB.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 98);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 8;
            label2.Text = "Marka";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 40);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 7;
            label1.Text = "Barkod No";
            // 
            // miktar_TB
            // 
            miktar_TB.Location = new Point(133, 153);
            miktar_TB.Mask = "0000000000";
            miktar_TB.Name = "miktar_TB";
            miktar_TB.PromptChar = ' ';
            miktar_TB.Size = new Size(116, 23);
            miktar_TB.TabIndex = 56;
            miktar_TB.ValidatingType = typeof(int);
            // 
            // alisfiyat_TB
            // 
            alisfiyat_TB.Location = new Point(133, 182);
            alisfiyat_TB.Mask = "000000000";
            alisfiyat_TB.Name = "alisfiyat_TB";
            alisfiyat_TB.PromptChar = ' ';
            alisfiyat_TB.Size = new Size(116, 23);
            alisfiyat_TB.TabIndex = 57;
            alisfiyat_TB.ValidatingType = typeof(int);
            // 
            // satisfiyat_TB
            // 
            satisfiyat_TB.Location = new Point(133, 211);
            satisfiyat_TB.Mask = "00000000000";
            satisfiyat_TB.Name = "satisfiyat_TB";
            satisfiyat_TB.PromptChar = ' ';
            satisfiyat_TB.Size = new Size(116, 23);
            satisfiyat_TB.TabIndex = 58;
            satisfiyat_TB.ValidatingType = typeof(int);
            // 
            // urun_ekle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(312, 339);
            Controls.Add(satisfiyat_TB);
            Controls.Add(alisfiyat_TB);
            Controls.Add(miktar_TB);
            Controls.Add(ekle_BTN);
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
            Controls.Add(barkodno_TB);
            Controls.Add(label6);
            Controls.Add(label5);
            Name = "urun_ekle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ürün Ekleme Ekranı";
            Load += urun_ekle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaskedTextBox barkodno_TB;
        private Label label9;
        private Label label3;
        private TextBox urunad_TB;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button ekle_BTN;
        private ComboBox kategori_CB;
        private ComboBox marka_CB;
        private DateTimePicker skt;
        private MaskedTextBox miktar_TB;
        private MaskedTextBox alisfiyat_TB;
        private MaskedTextBox satisfiyat_TB;
    }
}