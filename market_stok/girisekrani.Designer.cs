namespace market_stok
{
    partial class girisekrani
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
            girisBTN = new Button();
            label3 = new Label();
            label2 = new Label();
            sifre = new TextBox();
            kullaniciadi = new TextBox();
            SuspendLayout();
            // 
            // girisBTN
            // 
            girisBTN.Location = new Point(57, 213);
            girisBTN.Name = "girisBTN";
            girisBTN.Size = new Size(157, 51);
            girisBTN.TabIndex = 11;
            girisBTN.Text = "Giriş";
            girisBTN.UseVisualStyleBackColor = true;
            girisBTN.Click += girisBTN_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(120, 129);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 10;
            label3.Text = "Şifre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 65);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 9;
            label2.Text = "Kullanıcı Adı";
            // 
            // sifre
            // 
            sifre.Location = new Point(57, 156);
            sifre.Name = "sifre";
            sifre.PasswordChar = '*';
            sifre.Size = new Size(157, 23);
            sifre.TabIndex = 8;
            // 
            // kullaniciadi
            // 
            kullaniciadi.Location = new Point(57, 93);
            kullaniciadi.Name = "kullaniciadi";
            kullaniciadi.Size = new Size(157, 23);
            kullaniciadi.TabIndex = 7;
            // 
            // girisekrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(267, 339);
            Controls.Add(girisBTN);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(sifre);
            Controls.Add(kullaniciadi);
            Name = "girisekrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş Ekranı";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button girisBTN;
        private Label label3;
        private Label label2;
        private TextBox sifre;
        private TextBox kullaniciadi;
    }
}