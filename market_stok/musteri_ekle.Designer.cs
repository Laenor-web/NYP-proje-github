namespace market_stok
{
    partial class musteri_ekle
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
            label12 = new Label();
            adres_TB = new TextBox();
            label9 = new Label();
            label3 = new Label();
            soyad_TB = new TextBox();
            label2 = new Label();
            ad_TB = new TextBox();
            label1 = new Label();
            ekle_BTN = new Button();
            tc_TB = new MaskedTextBox();
            tel_TB = new MaskedTextBox();
            SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(54, 165);
            label12.Name = "label12";
            label12.Size = new Size(37, 15);
            label12.TabIndex = 13;
            label12.Text = "Adres";
            // 
            // adres_TB
            // 
            adres_TB.Location = new Point(142, 162);
            adres_TB.Multiline = true;
            adres_TB.Name = "adres_TB";
            adres_TB.Size = new Size(116, 64);
            adres_TB.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(54, 136);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 11;
            label9.Text = "Telefon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 107);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 9;
            label3.Text = "Soyad";
            // 
            // soyad_TB
            // 
            soyad_TB.Location = new Point(142, 104);
            soyad_TB.Name = "soyad_TB";
            soyad_TB.Size = new Size(116, 23);
            soyad_TB.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 78);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 8;
            label2.Text = "Ad";
            // 
            // ad_TB
            // 
            ad_TB.Location = new Point(142, 75);
            ad_TB.Name = "ad_TB";
            ad_TB.Size = new Size(116, 23);
            ad_TB.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 49);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 7;
            label1.Text = "T.C.";
            // 
            // ekle_BTN
            // 
            ekle_BTN.Location = new Point(128, 272);
            ekle_BTN.Name = "ekle_BTN";
            ekle_BTN.Size = new Size(75, 23);
            ekle_BTN.TabIndex = 14;
            ekle_BTN.Text = "Ekle";
            ekle_BTN.UseVisualStyleBackColor = true;
            ekle_BTN.Click += ekle_BTN_Click;
            // 
            // tc_TB
            // 
            tc_TB.Location = new Point(142, 46);
            tc_TB.Mask = "00000000000";
            tc_TB.Name = "tc_TB";
            tc_TB.PromptChar = ' ';
            tc_TB.Size = new Size(116, 23);
            tc_TB.TabIndex = 15;
            tc_TB.ValidatingType = typeof(int);
            // 
            // tel_TB
            // 
            tel_TB.Location = new Point(142, 133);
            tel_TB.Mask = "0000000000";
            tel_TB.Name = "tel_TB";
            tel_TB.PromptChar = ' ';
            tel_TB.Size = new Size(116, 23);
            tel_TB.TabIndex = 34;
            tel_TB.ValidatingType = typeof(int);
            // 
            // musteri_ekle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(341, 340);
            Controls.Add(tel_TB);
            Controls.Add(tc_TB);
            Controls.Add(ekle_BTN);
            Controls.Add(label12);
            Controls.Add(adres_TB);
            Controls.Add(label9);
            Controls.Add(label1);
            Controls.Add(ad_TB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(soyad_TB);
            Name = "musteri_ekle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Müşteri Ekleme Ekranı";
            Load += musteri_ekle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label12;
        private TextBox adres_TB;
        private Label label9;
        private Label label3;
        private TextBox soyad_TB;
        private Label label2;
        private TextBox ad_TB;
        private Label label1;
        private Button ekle_BTN;
        private MaskedTextBox tc_TB;
        private MaskedTextBox tel_TB;
    }
}