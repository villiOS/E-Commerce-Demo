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
    public partial class Urunler : System.Web.UI.Page
    {
        int KatId;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["KategoriId"]!=null)
            {
                KatId = Convert.ToInt32(Request.QueryString["KategoriId"]);
                UrunGetir();
            }
        }

        private void UrunGetir()
        {
            //SqlCommand UrunGetirCommand = new SqlCommand("Select * from Urunler Where KategoriId=" + @KatId, SanatUrunleriE_Ticaret.VTBaglanti.baglanti);
            //SanatUrunleriE_Ticaret.VTBaglanti.baglanti.Open();
            //SqlDataReader UrunGetirReader;
            //UrunGetirReader = UrunGetirCommand.ExecuteReader();
            //dtlUrunler.DataSource = UrunGetirReader;
            //dtlUrunler.DataBind();
            //UrunGetirReader.Close();

            //SanatUrunleriE_Ticaret.VTBaglanti.baglanti.Close();
            dtlUrunler.DataSource = VTBaglanti.DataTableGetir("Select * from Urunler Where KategoriId=" + @KatId, null);
            dtlUrunler.DataBind();
        }
    }
}