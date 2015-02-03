using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace SanatUrunleriE_Ticaret
{
    public partial class UrunAyrinti : System.Web.UI.Page
    {
        int UrunId;
        int Adet;
        int KategoriId;
        List<SepetSinif> sepet = new List<SepetSinif>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SessionSepet"] != null)
            {
                sepet = Session["SessionSepet"] as List<SepetSinif>;
            }
            else
            {
                Session["SessionSepet"] = sepet;
            }

            if (Request.QueryString["UrunId"] != null)
            {
                UrunId = Convert.ToInt32(Request.QueryString["UrunId"]);
                UrunAyrintiGetir();
                AdetBelirle();
                DigerUrunlerGetir();
            }
        }

        private void DigerUrunlerGetir() //sayıda sınırlama yooooooooookkkkkkkk!!!!!!!!!
        {
            DataRow kategori = VTBaglanti.DataRowGetir("Select KategoriId from Urunler Where UrunId=" + @UrunId, null);
            KategoriId = Convert.ToInt32(kategori["KategoriId"]);

            dtlUrunler.DataSource = VTBaglanti.DataTableGetir("Select * from Urunler Where KategoriId=" + @KategoriId+"and UrunId!="+@UrunId, null);
            dtlUrunler.DataBind();

        }

        private void AdetBelirle()
        {
            for (int i = 1; i <= Adet; i++)
            {
               ListItem adetliste = new ListItem(Convert.ToString(i));
               drpAdet.Items.Add(adetliste);
            }   
        }

        private void UrunAyrintiGetir()
        {
            //SqlCommand UrunAyrintiGetirCommand = new SqlCommand("Select * from Urunler Where UrunId=" + @UrunId, SanatUrunleriE_Ticaret.VTBaglanti.baglanti);
            //SanatUrunleriE_Ticaret.VTBaglanti.baglanti.Open();
            //SqlDataReader UrunAyrintiGetirReader;
            //UrunAyrintiGetirReader = UrunAyrintiGetirCommand.ExecuteReader();
            //while (UrunAyrintiGetirReader.Read())
            //{
            //    lblUrunAdi.Text = Convert.ToString(UrunAyrintiGetirReader["UrunAdi"]);
            //    lblOzellikler.Text = Convert.ToString(UrunAyrintiGetirReader["Ozellikler"]);
            //    lblFiyat.Text = Convert.ToString(UrunAyrintiGetirReader["BirimFiyat"]);
            //    imgUrunResim.ImageUrl = "../images/urunler/" + UrunAyrintiGetirReader["UrunResim"];
            //    imgUrunResim.AlternateText = Convert.ToString(UrunAyrintiGetirReader["UrunAdi"]);
            //    Adet = Convert.ToInt32(UrunAyrintiGetirReader["Stok"]);
            //}
           
            //UrunAyrintiGetirReader.Close();

            //SanatUrunleriE_Ticaret.VTBaglanti.baglanti.Close();
            DataRow urunayrinti = VTBaglanti.DataRowGetir("Select * from Urunler Where UrunId=" + @UrunId, null);
            lblUrunAdi.Text = Convert.ToString(urunayrinti["UrunAdi"]);

            lblOzellikler.Text = Convert.ToString(urunayrinti["Ozellikler"]);
            lblFiyat.Text = Convert.ToString(urunayrinti["BirimFiyat"]);
            imgUrunResim.ImageUrl = "../images/urunler/" + urunayrinti["UrunResim"];
            imgUrunResim.AlternateText = Convert.ToString(urunayrinti["UrunAdi"]);
            Adet = Convert.ToInt32(urunayrinti["Stok"]);
        }

        protected void lnkSepetEkle_Click(object sender, EventArgs e)
        {
            DataRow urunayrinti = VTBaglanti.DataRowGetir("Select * from Urunler Where UrunId=" + @UrunId, null);
            sepet.Add(new SepetSinif()
            {
                UrunId = UrunId,
                UrunAdi = Convert.ToString(urunayrinti["UrunAdi"]),
                BirimFiyat = Convert.ToDouble(urunayrinti["BirimFiyat"]),
                Adet = Convert.ToInt32(drpAdet.SelectedItem.Text),
                UrunResim = Convert.ToString(urunayrinti["UrunResim"]),
                Tutar = Convert.ToDouble(urunayrinti["BirimFiyat"]) * Convert.ToInt32(drpAdet.SelectedItem.Text)
            });

            Session["SessionSepet"] = sepet;
            Response.Redirect(Request.RawUrl);

        }
    }
}