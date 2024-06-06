using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace market_stok
{
    public partial class musteri_ekle : Form
    {
        public musteri_ekle()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-G7IR143;Initial Catalog=marketstok_db;Integrated Security=True;");
        private void musteri_ekle_Load(object sender, EventArgs e)
        {

        }

        private void ekle_BTN_Click(object sender, EventArgs e)
        {
         
            try
            {
                if (tc_TB.Text == "" || ad_TB.Text == "" || soyad_TB.Text == "" || tel_TB.Text == "" || adres_TB.Text == "")
                {
                    MessageBox.Show("Hatalı Veya Eksik Veri Girişi Yaptınız Lütfen Kontrol Ediniz");
                }
                else
                {
                    con.Open();
                    SqlCommand ekle = new SqlCommand("insert into musteri_tbl(musteri_tc,musteri_ad,musteri_soyad,musteri_tel,musteri_adres) values(@musteri_tc,@musteri_ad,@musteri_soyad,@musteri_tel,@musteri_adres)", con);
                    ekle.Parameters.AddWithValue("@musteri_tc", tc_TB.Text);
                    ekle.Parameters.AddWithValue("@musteri_ad", ad_TB.Text);
                    ekle.Parameters.AddWithValue("@musteri_soyad", soyad_TB.Text);
                    ekle.Parameters.AddWithValue("@musteri_tel", tel_TB.Text);
                    ekle.Parameters.AddWithValue("@musteri_adres", adres_TB.Text);
                    ekle.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Müşteri Başarıyla Eklenmiştir");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bu Müşteri Önceden Eklenmiştir");
                con.Close();
                
            }
           
            foreach (Control degerler in this.Controls)
            {
                if (degerler is MaskedTextBox or TextBox)
                {
                    degerler.Text = "";
                }
            }
        }
    }

}
