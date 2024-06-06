namespace market_stok
{
    partial class kategori
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
            label1 = new Label();
            kategori_TB = new TextBox();
            ekle_BTN = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 56);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Kategori";
            // 
            // kategori_TB
            // 
            kategori_TB.Location = new Point(127, 53);
            kategori_TB.Name = "kategori_TB";
            kategori_TB.Size = new Size(129, 23);
            kategori_TB.TabIndex = 1;
            // 
            // ekle_BTN
            // 
            ekle_BTN.Location = new Point(141, 118);
            ekle_BTN.Name = "ekle_BTN";
            ekle_BTN.Size = new Size(75, 23);
            ekle_BTN.TabIndex = 2;
            ekle_BTN.Text = "Ekle";
            ekle_BTN.UseVisualStyleBackColor = true;
            ekle_BTN.Click += ekle_BTN_Click;
            // 
            // kategori
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(345, 185);
            Controls.Add(ekle_BTN);
            Controls.Add(kategori_TB);
            Controls.Add(label1);
            Name = "kategori";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kategori Ekranı";
            Load += kategori_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox kategori_TB;
        private Button ekle_BTN;
    }
}