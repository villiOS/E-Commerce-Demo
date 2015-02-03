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
    public partial class Site : System.Web.UI.MasterPage
    {
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
            //SqlCommand KategoriCommand = new SqlCommand("Select * from Kategori Where Gorunum=1 AND UstKategoriId=0", SanatUrunleriE_Ticaret.VTBaglanti.baglanti);
            //SanatUrunleriE_Ticaret.VTBaglanti.baglanti.Open();
            //SqlDataReader KategoriReader;
            //KategoriReader = KategoriCommand.ExecuteReader();
            //rptKategori.DataSource = KategoriReader;
            //rptKategori.DataBind();
            //SanatUrunleriE_Ticaret.VTBaglanti.baglanti.Close();
            SepeteEkle();

            rptKategori.DataSource = VTBaglanti.DataTableGetir("Select * from Kategori Where Gorunum=1 AND UstKategoriId=0", null);
            rptKategori.DataBind();
        }

        private void SepeteEkle()
        {
            double ToplamTutar=0;
            int UrunSayisi = 0;
            foreach (var item in sepet)
            {
                ToplamTutar += item.Tutar;
                UrunSayisi += item.Adet;

            }
            LblToplam.Text = ToplamTutar.ToString();
            lblUrunSayisi.Text = UrunSayisi.ToString();
        }
    }
}