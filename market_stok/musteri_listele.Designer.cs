namespace market_stok
{
    partial class musteri_listele
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
            musteriler_GridView = new DataGridView();
            label12 = new Label();
            adres_TB = new TextBox();
            label9 = new Label();
            label1 = new Label();
            ad_TB = new TextBox();
            label3 = new Label();
            label2 = new Label();
            soyad_TB = new TextBox();
            label4 = new Label();
            sil_BTN = new Button();
            guncelle_BTN = new Button();
            label5 = new Label();
            tel_TB = new MaskedTextBox();
            adara_TB = new TextBox();
            tc_TB = new TextBox();
            ((System.ComponentModel.ISupportInitialize)musteriler_GridView).BeginInit();
            SuspendLayout();
            // 
            // musteriler_GridView
            // 
            musteriler_GridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            musteriler_GridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            musteriler_GridView.Location = new Point(277, 77);
            musteriler_GridView.Name = "musteriler_GridView";
            musteriler_GridView.ReadOnly = true;
            musteriler_GridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            musteriler_GridView.Size = new Size(731, 550);
            musteriler_GridView.TabIndex = 3;
            musteriler_GridView.CellMouseClick += musteriler_GridView_CellMouseClick;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(21, 326);
            label12.Name = "label12";
            label12.Size = new Size(37, 15);
            label12.TabIndex = 24;
            label12.Text = "Adres";
            // 
            // adres_TB
            // 
            adres_TB.Location = new Point(109, 323);
            adres_TB.Multiline = true;
            adres_TB.Name = "adres_TB";
            adres_TB.Size = new Size(116, 64);
            adres_TB.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 297);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 22;
            label9.Text = "Telefon";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 210);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 18;
            label1.Text = "T.C.";
            // 
            // ad_TB
            // 
            ad_TB.Location = new Point(109, 236);
            ad_TB.Name = "ad_TB";
            ad_TB.Size = new Size(116, 23);
            ad_TB.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 268);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 20;
            label3.Text = "Soyad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 239);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 19;
            label2.Text = "Ad";
            // 
            // soyad_TB
            // 
            soyad_TB.Location = new Point(109, 265);
            soyad_TB.Name = "soyad_TB";
            soyad_TB.Size = new Size(116, 23);
            soyad_TB.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(23, 113);
            label4.Name = "label4";
            label4.Size = new Size(202, 37);
            label4.TabIndex = 27;
            label4.Text = "Müşteri Bilgileri";
            // 
            // sil_BTN
            // 
            sil_BTN.Location = new Point(159, 451);
            sil_BTN.Name = "sil_BTN";
            sil_BTN.Size = new Size(80, 41);
            sil_BTN.TabIndex = 29;
            sil_BTN.Text = "Sil";
            sil_BTN.UseVisualStyleBackColor = true;
            sil_BTN.Click += sil_BTN_Click;
            // 
            // guncelle_BTN
            // 
            guncelle_BTN.Location = new Point(23, 451);
            guncelle_BTN.Name = "guncelle_BTN";
            guncelle_BTN.Size = new Size(80, 41);
            guncelle_BTN.TabIndex = 28;
            guncelle_BTN.Text = "Güncelle";
            guncelle_BTN.UseVisualStyleBackColor = true;
            guncelle_BTN.Click += guncelle_BTN_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(445, 27);
            label5.Name = "label5";
            label5.Size = new Size(128, 28);
            label5.TabIndex = 30;
            label5.Text = "Ad İle Arama:";
            // 
            // tel_TB
            // 
            tel_TB.Location = new Point(109, 294);
            tel_TB.Mask = "0000000000";
            tel_TB.Name = "tel_TB";
            tel_TB.PromptChar = ' ';
            tel_TB.Size = new Size(116, 23);
            tel_TB.TabIndex = 34;
            tel_TB.ValidatingType = typeof(int);
            // 
            // adara_TB
            // 
            adara_TB.Location = new Point(584, 32);
            adara_TB.Name = "adara_TB";
            adara_TB.Size = new Size(167, 23);
            adara_TB.TabIndex = 35;
            adara_TB.TextChanged += tcara_TB_TextChanged;
            // 
            // tc_TB
            // 
            tc_TB.Location = new Point(109, 207);
            tc_TB.Name = "tc_TB";
            tc_TB.Size = new Size(116, 23);
            tc_TB.TabIndex = 36;
            // 
            // musteri_listele
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1020, 658);
            Controls.Add(tc_TB);
            Controls.Add(adara_TB);
            Controls.Add(tel_TB);
            Controls.Add(label5);
            Controls.Add(sil_BTN);
            Controls.Add(guncelle_BTN);
            Controls.Add(label4);
            Controls.Add(label12);
            Controls.Add(adres_TB);
            Controls.Add(label9);
            Controls.Add(label1);
            Controls.Add(ad_TB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(soyad_TB);
            Controls.Add(musteriler_GridView);
            Name = "musteri_listele";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Müşteri Listeleme Ekranı";
            Load += musteri_listele_Load;
            ((System.ComponentModel.ISupportInitialize)musteriler_GridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView musteriler_GridView;
        private Label label12;
        private TextBox adres_TB;
        private Label label9;
        private Label label1;
        private TextBox ad_TB;
        private Label label3;
        private Label label2;
        private TextBox soyad_TB;
        private Label label4;
        private Button sil_BTN;
        private Button guncelle_BTN;
        private Label label5;
        private MaskedTextBox tel_TB;
        private TextBox adara_TB;
        private TextBox tc_TB;
    }
}