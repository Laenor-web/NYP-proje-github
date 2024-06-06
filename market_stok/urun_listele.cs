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
    public partial class urun_listele : Form
    {
        public urun_listele()
        {
            InitializeComponent();
            barkodno_TB.ReadOnly = true;
            urunler_GridView.ReadOnly = true;
           
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-G7IR143;Initial Catalog=marketstok_db;Integrated Security=True;");
        DataSet ds = new DataSet();

        private void urun_listele_Load(object sender, EventArgs e)
        {
            kategoriyigetir();
            kayit_goster();
        }



        private void kayit_goster()
        {
            con.Open();
            ds.Clear();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from urun_tbl", con);
            dataAdapter.Fill(ds, "urun_tbl");
            urunler_GridView.DataSource = ds.Tables["urun_tbl"];
            con.Close();
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

        private void urunler_GridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            barkodno_TB.Text = urunler_GridView.CurrentRow.Cells["urun_barkod"].Value.ToString();
            marka_CB.Text = urunler_GridView.CurrentRow.Cells["urun_marka"].Value.ToString();
            urunad_TB.Text = urunler_GridView.CurrentRow.Cells["urun_ad"].Value.ToString();
            kategori_CB.Text = urunler_GridView.CurrentRow.Cells["kategori"].Value.ToString();
            miktar_TB.Text = urunler_GridView.CurrentRow.Cells["miktar"].Value.ToString();
            alisfiyat_TB.Text = urunler_GridView.CurrentRow.Cells["alis_fiyat"].Value.ToString();
            satisfiyat_TB.Text = urunler_GridView.CurrentRow.Cells["satis_fiyat"].Value.ToString();
            skt.Text = urunler_GridView.CurrentRow.Cells["sontuketim_tarihi"].Value.ToString();

        }

        private void guncelle_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (urunad_TB.Text == "" || miktar_TB.Text == "" || alisfiyat_TB.Text == "" || satisfiyat_TB.Text == "" || kategori_CB.SelectedItem == null || marka_CB.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen Bilgileri Giriniz");
                }
                else
                {
                    con.Open();
                    SqlCommand guncelle = new SqlCommand("update urun_tbl set urun_marka=@urun_marka,urun_ad=@urun_ad,kategori=@kategori,miktar=@miktar,alis_fiyat=@alis_fiyat,satis_fiyat=@satis_fiyat,sontuketim_tarihi=@sontuketim_tarihi where urun_barkod=@urun_barkod ", con);
                    guncelle.Parameters.AddWithValue("@urun_barkod", barkodno_TB.Text);
                    guncelle.Parameters.AddWithValue("@urun_marka", marka_CB.SelectedItem.ToString());
                    guncelle.Parameters.AddWithValue("@urun_ad", urunad_TB.Text);
                    guncelle.Parameters.AddWithValue("@kategori", kategori_CB.SelectedItem.ToString());
                    guncelle.Parameters.AddWithValue("@miktar", int.Parse(miktar_TB.Text));
                    guncelle.Parameters.AddWithValue("@alis_fiyat", int.Parse(alisfiyat_TB.Text));
                    guncelle.Parameters.AddWithValue("@satis_fiyat", int.Parse(satisfiyat_TB.Text));
                    guncelle.Parameters.AddWithValue("@sontuketim_tarihi", skt.Value.Date);
                    guncelle.ExecuteNonQuery();
                    con.Close();
                    ds.Tables["urun_tbl"].Clear();
                    kayit_goster();
                    MessageBox.Show("Ürün Kaydı Başarıyla Güncellendi");
                }
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

     

        private void sil_BTN_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand sil = new SqlCommand("delete from urun_tbl where urun_barkod = @urun_barkod", con);
            sil.Parameters.AddWithValue("@urun_barkod", urunler_GridView.CurrentRow.Cells["urun_barkod"].Value.ToString());
            sil.ExecuteNonQuery();
            con.Close();
            ds.Tables["urun_tbl"].Clear();
            kayit_goster();
            MessageBox.Show("Ürün Kaydı Başarıyla Silindi");
            foreach (Control degerler in this.Controls)
            {
                if (degerler is MaskedTextBox or TextBox or ComboBox)
                {
                    degerler.Text = "";
                }
            }
        }
    }
}
