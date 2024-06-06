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
    public partial class kategori : Form
    {
        public kategori()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-G7IR143;Initial Catalog=marketstok_db;Integrated Security=True;");


        private void kategori_Load(object sender, EventArgs e)
        {

        }

        private void ekle_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (kategori_TB.Text == "")
                {
                    MessageBox.Show("Hatalı Veya Eksik Veri Girişi Yaptınız Lütfen Kontrol Ediniz");
                }
                else
                {
                    con.Open();
                    SqlCommand ekle = new SqlCommand("insert into kategori_tbl(urun_kategori) values('" + kategori_TB.Text + "')", con);
                    ekle.ExecuteNonQuery();
                    con.Close();
                    kategori_TB.Text = "";
                    MessageBox.Show("Ürün Kategorisi Başarıyla Eklenmiştir");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Kategoriyi Kontrol Ediniz Bu Kategori Önceden Eklenmiştir");
                
            }
        }
    }



}
