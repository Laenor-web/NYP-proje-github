using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market_stok
{
    public partial class satislarim : Form
    {
        public satislarim()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-G7IR143;Initial Catalog=marketstok_db;Integrated Security=True;");
        DataSet ds = new DataSet();


        private void toplamucret()
        {
            int ucrettoplami = 0;
            for (int i = 0; i < satis_GridView.Rows.Count; i++)
            {
                ucrettoplami += Convert.ToInt32(satis_GridView.Rows[i].Cells["toplam_fiyat"].Value);
            }
            sepet_tutar.Text = "Toplam Satış=" + ucrettoplami + "TL";
        }

        private void satislistele()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from satislar_tbl", con);
            dataAdapter.Fill(ds, "satislar_tbl");
            satis_GridView.DataSource = ds.Tables["satislar_tbl"];
            con.Close();
        }
        private void satislarim_Load(object sender, EventArgs e)
        {
            satislistele();
            toplamucret();

        }




        private void sil_BTN_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand ekle = new SqlCommand("update urun_tbl set miktar = miktar + @miktar where urun_barkod = @urun_barkod", con);
            ekle.Parameters.AddWithValue("@miktar", int.Parse(satis_GridView.CurrentRow.Cells["urun_miktar"].Value.ToString()));
            ekle.Parameters.AddWithValue("@urun_barkod", satis_GridView.CurrentRow.Cells["urun_barkod"].Value.ToString());
            ekle.ExecuteNonQuery();

            SqlCommand sil = new SqlCommand("delete from satislar_tbl where satis_id = @satis_id", con);
            sil.Parameters.AddWithValue("@satis_id", satis_GridView.CurrentRow.Cells["satis_id"].Value.ToString());
            sil.ExecuteNonQuery();
            con.Close();
            ds.Tables["satislar_tbl"].Clear();
            satislistele();
            MessageBox.Show("Satış Başarıyla Silindi");
        }

        private void tcfiltre()
        {
            DataTable dt = new DataTable();
            con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from satislar_tbl where musteri_tc like '" + tcara_TB.Text + "%'", con);
            sqlDataAdapter.Fill(dt);
            satis_GridView.DataSource = dt;
            con.Close();
        }
        private void tcara_TB_TextChanged(object sender, EventArgs e)
        {
            tcfiltre();
        }


        private void tariharaligi()
        {
            DataTable dt = new DataTable();
            con.Open();
            SqlCommand tarih = new SqlCommand("select * from satislar_tbl where satis_tar between @ilkTarih and @ikinciTarih", con);
            tarih.Parameters.AddWithValue("@ilkTarih", ilkTarih.Value.Date);
            tarih.Parameters.AddWithValue("@ikinciTarih", ikinciTarih.Value.Date);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(tarih);
            sqlDataAdapter.Fill(dt);
            satis_GridView.DataSource = dt;
            con.Close();
            toplamucret();
        }




        private void ilkTarih_ValueChanged(object sender, EventArgs e)
        {
            tariharaligi();
        }

        private void ikinciTarih_ValueChanged(object sender, EventArgs e)
        {
            tariharaligi();
        }

        private void satis_GridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            stok_TB.Text = satis_GridView.CurrentRow.Cells["urun_miktar"].Value.ToString();
        }
    }
}
