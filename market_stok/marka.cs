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
    public partial class marka : Form
    {
        public marka()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-G7IR143;Initial Catalog=marketstok_db;Integrated Security=True;;");


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

        private void marka_Load(object sender, EventArgs e)
        {
            kategoriyigetir();
        }

        private void ekle_BTN_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand ekle = new SqlCommand("insert into marka_tbl(marka_ad,marka_mensei,marka_tel,marka_adres,kategori) values(@marka_ad,@marka_mensei,@marka_tel,@marka_adres,@kategori)", con);
            ekle.Parameters.AddWithValue("@kategori", kategori_CB.Text);
            ekle.Parameters.AddWithValue("@marka_ad", marka_TB.Text);
            ekle.Parameters.AddWithValue("@marka_mensei", mensei_CB.Text);
            ekle.Parameters.AddWithValue("@marka_tel", tel_TB.Text);
            ekle.Parameters.AddWithValue("@marka_adres", adres_TB.Text);
            ekle.ExecuteNonQuery();
            con.Close();
            kategori_CB.Text = "";
            marka_TB.Text = "";
            mensei_CB.Text = "";
            tel_TB.Text = "";
            adres_TB.Text = "";
            MessageBox.Show("Marka Başarıyla Eklenmiştir");
        }

       
    }
}
