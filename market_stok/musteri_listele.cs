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
    public partial class musteri_listele : Form
    {
        public musteri_listele()
        {
            InitializeComponent();
            tc_TB.ReadOnly = true;
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-G7IR143;Initial Catalog=marketstok_db;Integrated Security=True;");

        DataSet ds = new DataSet();


        private void musteri_listele_Load(object sender, EventArgs e)
        {
            kayit_goster();
        }

        private void kayit_goster()
        {
            con.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from musteri_tbl", con);
            dataAdapter.Fill(ds, "musteri_tbl");
            musteriler_GridView.DataSource = ds.Tables["musteri_tbl"];
            con.Close();
        }

        private void musteriler_GridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tc_TB.Text = musteriler_GridView.CurrentRow.Cells["musteri_tc"].Value.ToString();
            ad_TB.Text = musteriler_GridView.CurrentRow.Cells["musteri_ad"].Value.ToString();
            soyad_TB.Text = musteriler_GridView.CurrentRow.Cells["musteri_soyad"].Value.ToString();
            tel_TB.Text = musteriler_GridView.CurrentRow.Cells["musteri_tel"].Value.ToString();
            adres_TB.Text = musteriler_GridView.CurrentRow.Cells["musteri_adres"].Value.ToString();
        }

        private void guncelle_BTN_Click(object sender, EventArgs e)
        {
            if (ad_TB.Text == "" || soyad_TB.Text == "" ||  tel_TB.Text == "" || adres_TB.Text == "")
            {
                MessageBox.Show("Lütfen Bilgileri Giriniz");
            }
            else
            {
                con.Open();
                SqlCommand guncelle = new SqlCommand("update musteri_tbl set musteri_ad=@musteri_ad,musteri_soyad=@musteri_soyad,musteri_tel=@musteri_tel,musteri_adres=@musteri_adres where musteri_tc=@musteri_tc ", con);
                guncelle.Parameters.AddWithValue("@musteri_tc", tc_TB.Text);
                guncelle.Parameters.AddWithValue("@musteri_ad", ad_TB.Text);
                guncelle.Parameters.AddWithValue("@musteri_soyad", soyad_TB.Text);
                guncelle.Parameters.AddWithValue("@musteri_tel", tel_TB.Text);
                guncelle.Parameters.AddWithValue("@musteri_adres", adres_TB.Text);
                guncelle.ExecuteNonQuery();
                con.Close();
                ds.Tables["musteri_tbl"].Clear();
                kayit_goster();
                MessageBox.Show("Müşteri Kaydı Başarıyla Güncellendi");
            }
     

            foreach (Control degerler in this.Controls)
            {
                if (degerler is MaskedTextBox or TextBox)
                {
                    degerler.Text = "";
                }
            }
        }

        private void sil_BTN_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand sil = new SqlCommand("delete from musteri_tbl where musteri_tc = @musteri_tc", con);
            sil.Parameters.AddWithValue("@musteri_tc", musteriler_GridView.CurrentRow.Cells["musteri_tc"].Value.ToString());
            sil.ExecuteNonQuery();
            con.Close();
            ds.Tables["musteri_tbl"].Clear();
            kayit_goster();
            MessageBox.Show("Müşteri Kaydı Başarıyla Silindi");
            foreach (Control degerler in this.Controls)
            {
                if (degerler is MaskedTextBox or TextBox)
                {
                    degerler.Text = "";
                }
            }
        }

        private void tcara_TB_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from musteri_tbl where musteri_ad like '%" + adara_TB.Text + "%'", con);
            sqlDataAdapter.Fill(dt);
            musteriler_GridView.DataSource = dt;
            con.Close();
        }
    }
}
   
    

