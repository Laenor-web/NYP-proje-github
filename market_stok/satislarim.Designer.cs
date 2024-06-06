namespace market_stok
{
    partial class satislarim
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
            satis_GridView = new DataGridView();
            sil_BTN = new Button();
            ilkTarih = new DateTimePicker();
            ikinciTarih = new DateTimePicker();
            label2 = new Label();
            sepet_tutar = new Label();
            tcara_TB = new TextBox();
            stok_TB = new TextBox();
            ((System.ComponentModel.ISupportInitialize)satis_GridView).BeginInit();
            SuspendLayout();
            // 
            // satis_GridView
            // 
            satis_GridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            satis_GridView.Location = new Point(46, 61);
            satis_GridView.Name = "satis_GridView";
            satis_GridView.ReadOnly = true;
            satis_GridView.Size = new Size(932, 466);
            satis_GridView.TabIndex = 0;
            satis_GridView.CellMouseClick += satis_GridView_CellMouseClick;
            // 
            // sil_BTN
            // 
            sil_BTN.Location = new Point(788, 24);
            sil_BTN.Name = "sil_BTN";
            sil_BTN.Size = new Size(75, 23);
            sil_BTN.TabIndex = 8;
            sil_BTN.Text = "Sil";
            sil_BTN.UseVisualStyleBackColor = true;
            sil_BTN.Click += sil_BTN_Click;
            // 
            // ilkTarih
            // 
            ilkTarih.Location = new Point(129, 22);
            ilkTarih.Name = "ilkTarih";
            ilkTarih.Size = new Size(200, 23);
            ilkTarih.TabIndex = 10;
            ilkTarih.ValueChanged += ilkTarih_ValueChanged;
            // 
            // ikinciTarih
            // 
            ikinciTarih.Location = new Point(353, 22);
            ikinciTarih.Name = "ikinciTarih";
            ikinciTarih.Size = new Size(200, 23);
            ikinciTarih.TabIndex = 11;
            ikinciTarih.ValueChanged += ikinciTarih_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(335, 25);
            label2.Name = "label2";
            label2.Size = new Size(12, 15);
            label2.TabIndex = 12;
            label2.Text = "-";
            // 
            // sepet_tutar
            // 
            sepet_tutar.AutoSize = true;
            sepet_tutar.Font = new Font("Segoe UI", 15F);
            sepet_tutar.Location = new Point(353, 537);
            sepet_tutar.Name = "sepet_tutar";
            sepet_tutar.Size = new Size(42, 28);
            sepet_tutar.TabIndex = 20;
            sepet_tutar.Text = "asd";
            // 
            // tcara_TB
            // 
            tcara_TB.Location = new Point(665, 542);
            tcara_TB.Name = "tcara_TB";
            tcara_TB.Size = new Size(100, 23);
            tcara_TB.TabIndex = 21;
            tcara_TB.Visible = false;
            tcara_TB.TextChanged += tcara_TB_TextChanged;
            // 
            // stok_TB
            // 
            stok_TB.Location = new Point(147, 541);
            stok_TB.Name = "stok_TB";
            stok_TB.Size = new Size(100, 23);
            stok_TB.TabIndex = 22;
            stok_TB.Visible = false;
            // 
            // satislarim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1021, 574);
            Controls.Add(stok_TB);
            Controls.Add(tcara_TB);
            Controls.Add(sepet_tutar);
            Controls.Add(label2);
            Controls.Add(ikinciTarih);
            Controls.Add(ilkTarih);
            Controls.Add(sil_BTN);
            Controls.Add(satis_GridView);
            Name = "satislarim";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Satışlarım";
            Load += satislarim_Load;
            ((System.ComponentModel.ISupportInitialize)satis_GridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView satis_GridView;
        private Button sil_BTN;
        private DateTimePicker ilkTarih;
        private DateTimePicker ikinciTarih;
        private Label label2;
        private Label sepet_tutar;
        private TextBox tcara_TB;
        private TextBox stok_TB;
    }
}