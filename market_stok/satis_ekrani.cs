using System.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace market_stok
{
    public partial class satis_ekrani : Form
    {
        public satis_ekrani()
        {
            InitializeComponent();
        }

        private void müþteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musteri_ekle ekle = new musteri_ekle();
            ekle.Show();
        }

        private void müþteriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musteri_listele listele = new musteri_listele();
            listele.Show();
        }

        private void kategoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kategori kategori = new kategori();
            kategori.Show();
        }

        private void markaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            marka markalar = new marka();
            markalar.Show();
        }

        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            urun_ekle urunler = new urun_ekle();
            urunler.Show();
        }

        private void ürünListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            urun_listele listele = new urun_listele();
            listele.Show();
        }
        private void satýþlarýListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            satislarim satislarim = new satislarim();
            satislarim.Show();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-G7IR143;Initial Catalog=marketstok_db;Integrated Security=True;");
        DataSet ds = new DataSet();

        private void sepetgetir()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from sepet_tbl", con);
            dataAdapter.Fill(ds, "sepet_tbl");
            satis_GridView.DataSource = ds.Tables["sepet_tbl"];
            con.Close();
        }

        private void satis_sayfa_Load(object sender, EventArgs e)
        {
            sepetgetir();
            barkodnogetir();
            tcgetir();
        }

        private void tcgetir()
        {
            con.Open();
            SqlCommand komut = new SqlCommand("select musteri_tc from musteri_tbl", con);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                tc_CB.Items.Add(oku["musteri_tc"].ToString());
            }
            con.Close();
        }

        private void tc_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tc_CB.SelectedIndex == null)
            {
                ad_TB.Text = "";
                soyad_TB.Text = "";
                tel_TB.Text = "";
                adres_TB.Text = "";

            }
            DataTable dt = new DataTable();
            con.Open();
            SqlCommand getir = new SqlCommand("select * from musteri_tbl where musteri_tc like '" + tc_CB.SelectedItem + "'", con);
            SqlDataReader bilgioku = getir.ExecuteReader();
            while (bilgioku.Read())
            {
                ad_TB.Text = bilgioku["musteri_ad"].ToString();
                soyad_TB.Text = bilgioku["musteri_soyad"].ToString();
                tel_TB.Text = bilgioku["musteri_tel"].ToString();
                adres_TB.Text = bilgioku["musteri_adres"].ToString();
            }
            bilgioku.Close();
            con.Close();
        }


        private void barkodnogetir()
        {
            con.Open();
            SqlCommand komut = new SqlCommand("select urun_barkod from urun_tbl", con);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                barkodno_CB.Items.Add(oku["urun_barkod"].ToString());
            }
            con.Close();
        }

        private void barkodno_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (barkodno_CB.SelectedIndex == null)
            {
                urunad_TB.Text = "";
                satisfiyat_TB.Text = "";
                toplamfiyat_TB.Text = "0,00";
                miktar_TB.Text = "1";
            }
            DataTable dt = new DataTable();
            con.Open();
            SqlCommand getir = new SqlCommand("select * from urun_tbl where urun_barkod like '" + barkodno_CB.SelectedItem + "'", con);
            SqlDataReader bilgioku = getir.ExecuteReader();
            while (bilgioku.Read())
            {
                urunad_TB.Text = bilgioku["urun_ad"].ToString();
                satisfiyat_TB.Text = bilgioku["satis_fiyat"].ToString();
                stok_TB.Text = bilgioku["miktar"].ToString();
            }
            con.Close();
        }

        private void hesapla()
        {
            try
            {
                con.Open();
                SqlCommand toplam = new SqlCommand("select sum(toplam_fiyat) from sepet_tbl", con);
                sepet_tutar.Text = toplam.ExecuteScalar() + " TL";
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

       
       

        bool kontrol;
        private void barkodkontrol()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

            kontrol = false;
            con.Open();
            SqlCommand komut = new SqlCommand("select * from sepet_tbl", con);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                if (barkodno_CB.SelectedItem == reader["urun_barkod"].ToString())
                {
                    kontrol = true;
                }
            }
            con.Close();
        }


        private void ekle_BTN_Click(object sender, EventArgs e)
        {
            barkodkontrol();
            try
            {
                if (ad_TB.Text == "")
                {
                    MessageBox.Show("Lutfen TC'yi Seçiniz");
                }
                else if (urunad_TB.Text == "")
                {
                    MessageBox.Show("Lutfen Barkod No'yu Seçiniz");
                }
                else if (miktar_TB.Text == "")
                {
                    MessageBox.Show("Lutfen Miktarý Giriniz");
                }
                else if (miktar_TB.Text == "0")
                {
                    MessageBox.Show("Miktar 0 Olamaz Lütfen Kontrol Ediniz");
                }
                else
                {
                    int girilenMiktar = int.Parse(miktar_TB.Text);
                    int stokMiktar = (int.Parse(stok_TB.Text));
                    if (girilenMiktar > stokMiktar)
                    {
                        MessageBox.Show("Stok Miktarýndan Fazla Deðer Girdiniz Kontrol Ediniz");
                    }
                    else
                    {
                        if (kontrol == false)
                        {
                            con.Open();
                            SqlCommand ekle = new SqlCommand("insert into sepet_tbl values(@musteri_tc,@musteri_ad,@musteri_soyad,@urun_barkod,@urun_ad,@urun_miktar,@urun_fiyat,@toplam_fiyat,@sepet_tar)", con);
                            ekle.Parameters.AddWithValue("@musteri_tc", tc_CB.SelectedItem.ToString());
                            ekle.Parameters.AddWithValue("@musteri_ad", ad_TB.Text);
                            ekle.Parameters.AddWithValue("@musteri_soyad", soyad_TB.Text);
                            ekle.Parameters.AddWithValue("@urun_barkod", barkodno_CB.SelectedItem.ToString());
                            ekle.Parameters.AddWithValue("@urun_ad", urunad_TB.Text);
                            ekle.Parameters.AddWithValue("@urun_miktar", int.Parse(miktar_TB.Text));
                            ekle.Parameters.AddWithValue("@urun_fiyat", double.Parse(satisfiyat_TB.Text));
                            ekle.Parameters.AddWithValue("@toplam_fiyat", double.Parse(toplamfiyat_TB.Text));
                            ekle.Parameters.AddWithValue("@sepet_tar", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                            ekle.ExecuteNonQuery();
                            con.Close();
                            hesapla();
                            MessageBox.Show("Ürünler Baþarýyla Sepete Eklenmiþtir");
                            ds.Tables["sepet_tbl"].Clear();
                            sepetgetir();
                            barkodno_CB.SelectedItem = null;
                            urunad_TB.Text = "";
                            miktar_TB.Text = "1";
                            satisfiyat_TB.Text = "";
                            toplamfiyat_TB.Text = "0,00";
                            stok_TB.Text = "";
                        }
                        else
                        {
                            con.Open();
                            SqlCommand guncelle = new SqlCommand("update sepet_tbl set urun_miktar = urun_miktar + @miktar, toplam_fiyat = (urun_miktar + @miktar) * urun_fiyat where urun_barkod = @barkodno", con);
                            guncelle.Parameters.AddWithValue("@miktar", int.Parse(miktar_TB.Text));
                            guncelle.Parameters.AddWithValue("@barkodno", barkodno_CB.SelectedValue.ToString());
                            guncelle.ExecuteNonQuery();
                            con.Close();
                            hesapla();
                            MessageBox.Show("Ürünler Baþarýyla Sepete Eklenmiþtir");
                            ds.Tables["sepet_tbl"].Clear();
                            sepetgetir();
                            barkodno_CB.SelectedValue = null;
                            urunad_TB.Text = "";
                            miktar_TB.Text = "1";
                            satisfiyat_TB.Text = "";
                            toplamfiyat_TB.Text = "0,00";
                            stok_TB.Text = "";
                        }

                    }

                }
            }
            catch (Exception)
            {

            }
        }


        private void miktar_TB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                toplamfiyat_TB.Text = (double.Parse(miktar_TB.Text) * double.Parse(satisfiyat_TB.Text)).ToString();
            }
            catch (Exception)
            {

            }
        }

        private void satisfiyat_TB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                toplamfiyat_TB.Text = (double.Parse(miktar_TB.Text) * double.Parse(satisfiyat_TB.Text)).ToString();
            }
            catch (Exception)
            {

            }
        }

        private void sil_BTN_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand sil = new SqlCommand("delete from sepet_tbl where urun_barkod = @urun_barkod", con);
            sil.Parameters.AddWithValue("@urun_barkod", satis_GridView.CurrentRow.Cells["urun_barkod"].Value.ToString());
            sil.ExecuteNonQuery();
            con.Close();
            hesapla();
            MessageBox.Show("Ürünler Baþarýyla Sepetten Çýkarýlmýþtýr");
            ds.Tables["sepet_tbl"].Clear();
            sepetgetir();


        }



        private void satisonay_BTN_Click(object sender, EventArgs e)
        {
            try
            {

                for (int i = 0; i < satis_GridView.Rows.Count - 1; i++)
                {
                    con.Open();
                    SqlCommand ekle = new SqlCommand("insert into satislar_tbl (musteri_tc, musteri_ad, musteri_soyad, urun_barkod, urun_ad, urun_miktar, urun_fiyat, toplam_fiyat, satis_tar) values (@musteri_tc, @musteri_ad, @musteri_soyad, @urun_barkod, @urun_ad, @urun_miktar, @urun_fiyat, @toplam_fiyat, @satis_tar)", con);
                    ekle.Parameters.AddWithValue("@musteri_tc", tc_CB.SelectedItem.ToString());
                    ekle.Parameters.AddWithValue("@musteri_ad", ad_TB.Text);
                    ekle.Parameters.AddWithValue("@musteri_soyad", soyad_TB.Text);
                    ekle.Parameters.AddWithValue("@urun_barkod", satis_GridView.Rows[i].Cells["urun_barkod"].Value.ToString());
                    ekle.Parameters.AddWithValue("@urun_ad", satis_GridView.Rows[i].Cells["urun_ad"].Value.ToString());
                    ekle.Parameters.AddWithValue("@urun_miktar", int.Parse(satis_GridView.Rows[i].Cells["urun_miktar"].Value.ToString()));
                    ekle.Parameters.AddWithValue("@urun_fiyat", double.Parse(satis_GridView.Rows[i].Cells["urun_fiyat"].Value.ToString()));
                    ekle.Parameters.AddWithValue("@toplam_fiyat", double.Parse(satis_GridView.Rows[i].Cells["toplam_fiyat"].Value.ToString()));
                    ekle.Parameters.AddWithValue("@satis_tar", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    ekle.ExecuteNonQuery();
                    SqlCommand stoktandus = new SqlCommand("update urun_tbl set miktar = miktar - @urun_miktar where urun_barkod = @urun_barkod", con);
                    stoktandus.Parameters.AddWithValue("@urun_miktar", int.Parse(satis_GridView.Rows[i].Cells["urun_miktar"].Value.ToString()));
                    stoktandus.Parameters.AddWithValue("@urun_barkod", satis_GridView.Rows[i].Cells["urun_barkod"].Value.ToString());
                    stoktandus.ExecuteNonQuery();

                    SqlCommand sil = new SqlCommand("delete from sepet_tbl where urun_barkod = @urun_barkod", con);
                    sil.Parameters.AddWithValue("@urun_barkod", satis_GridView.Rows[i].Cells["urun_barkod"].Value.ToString());
                    sil.ExecuteNonQuery();

                    con.Close();
                }

                MessageBox.Show("Ürünler Baþarýyla Satýlmýþtýr");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluþtu: " + ex.Message);
            }

            hesapla();
            ds.Tables["sepet_tbl"].Clear();
            sepetgetir();
        }

    
    }



}

    
   

