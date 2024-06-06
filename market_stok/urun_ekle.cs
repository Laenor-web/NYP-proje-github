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
    public partial class urun_ekle : Form
    {
        public urun_ekle()
        {
            InitializeComponent();
            skt.MinDate = DateTime.Today;
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-G7IR143;Initial Catalog=marketstok_db;Integrated Security=True;");

        DataSet ds = new DataSet();

        private void urun_ekle_Load(object sender, EventArgs e)
        {
            kategoriyigetir();
        }



        private void kategoriyigetir()
        {
            con.Open();
            SqlCommand ekle = new SqlCommand("select * from kategori_tbl", con);
            SqlDataReader r = ekle.ExecuteReader();
            while (r.Read())
            {
                kategori_CB.Items.Add(r["urun_kategori"].ToString());
            }
            con.Close();
        }

       

        private void ekle_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (barkodno_TB.Text == "" || marka_CB.SelectedItem == null || urunad_TB.Text == "" || kategori_CB.SelectedItem == null || miktar_TB.Text == "" || alisfiyat_TB.Text == "" || satisfiyat_TB.Text == "")
                {
                    MessageBox.Show("Hatalı Veya Eksik Veri Girişi Yaptınız Lütfen Kontrol Ediniz");
                }
                else
                {
                    int satisfiyati = int.Parse(satisfiyat_TB.Text);
                    int alisfiyati = int.Parse(alisfiyat_TB.Text);
                    if (alisfiyati > satisfiyati)
                    {
                        MessageBox.Show("Alış Fiyatı Satış Fiyatından Yüksek Lütfen Kontrol Ediniz");
                    }
                    else
                    {
                        con.Open();
                        SqlCommand ekle = new SqlCommand("insert into urun_tbl(urun_barkod,urun_marka,urun_ad,kategori,miktar,alis_fiyat,satis_fiyat,sontuketim_tarihi) values(@urun_barkod,@urun_marka,@urun_ad,@kategori,@miktar,@alis_fiyat,@satis_fiyat,@sontuketim_tarihi)", con);
                        ekle.Parameters.AddWithValue("@urun_barkod", barkodno_TB.Text);
                        ekle.Parameters.AddWithValue("@urun_marka", marka_CB.SelectedItem.ToString());
                        ekle.Parameters.AddWithValue("@urun_ad", urunad_TB.Text);
                        ekle.Parameters.AddWithValue("@kategori", kategori_CB.SelectedItem.ToString());
                        ekle.Parameters.AddWithValue("@miktar", int.Parse(miktar_TB.Text));
                        ekle.Parameters.AddWithValue("@alis_fiyat", int.Parse(alisfiyat_TB.Text));
                        ekle.Parameters.AddWithValue("@satis_fiyat", int.Parse(satisfiyat_TB.Text));
                        ekle.Parameters.AddWithValue("@sontuketim_tarihi", skt.Value.Date);
                        ekle.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Ürünler Başarıyla Eklenmiştir");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bu Barkod Numarasıyla Ürün Var Kontrol Ediniz");
                con.Close();

            }

            foreach (Control degerler in this.Controls)
            {
                if (degerler is MaskedTextBox or TextBox or ComboBox)
                {
                    degerler.Text = "";
                }
            }
        }

        private void kategori_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            marka_CB.Items.Clear();
            marka_CB.Text = "";
            con.Open();
            SqlCommand ekle = new SqlCommand("select * from marka_tbl where kategori = '" + kategori_CB.SelectedItem + "'", con);
            SqlDataReader r = ekle.ExecuteReader();
            while (r.Read())
            {
                marka_CB.Items.Add(r["marka_ad"].ToString());
            }
            con.Close();
        }

       
    }
}
