using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market_stok
{
    public partial class girisekrani : Form
    {
        public girisekrani()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-G7IR143;Initial Catalog=marketstok_db;Integrated Security=True;");

        private void girisBTN_Click(object sender, EventArgs e)
        {
            if (kullaniciadi.Text == "tuna" || sifre.Text == "123")
            {
                MessageBox.Show("Başarıyla Giriş Yaptınız");
                satis_ekrani satis_ekrani = new satis_ekrani();
                satis_ekrani.Show();
                this.Hide();
            }
            else

            {
                MessageBox.Show("Yanlış Kullanıcı Adı Veya Şifre");
            }
           
        }
    }
}
