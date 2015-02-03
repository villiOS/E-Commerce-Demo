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
    public partial class Kategoriler : System.Web.UI.Page
    {
        int KatId;
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["KategoriID"] != null)
            {
                KatId=Convert.ToInt32(Request.QueryString["KategoriID"]);
                AltKategoriGetir();
                KategoriAdiGetir();
            }
        }

        private void KategoriAdiGetir()
        {
            //SqlCommand KategoriAdiCommand = new SqlCommand("Select KategoriAdi from Kategori Where KategoriId=" + @KatId, SanatUrunleriE_Ticaret.VTBaglanti.baglanti);
            //SanatUrunleriE_Ticaret.VTBaglanti.baglanti.Open();

            //SqlDataReader KategoriAdiReader;
            //KategoriAdiReader = KategoriAdiCommand.ExecuteReader();
            //while (KategoriAdiReader.Read())
            //{
            //    lblKategoriAdi.Text = Convert.ToString(KategoriAdiReader["KategoriAdi"]);
            //}

            //KategoriAdiReader.Close();
            //SanatUrunleriE_Ticaret.VTBaglanti.baglanti.Close();
            DataRow kategoriadi = VTBaglanti.DataRowGetir("Select KategoriAdi from Kategori Where KategoriId=" + @KatId, null);
            lblKategoriAdi.Text=Convert.ToString(kategoriadi["KategoriAdi"]);
        }

        private void AltKategoriGetir()
        {
            //SqlCommand AltKategoriCommand = new SqlCommand("Select * from Kategori Where Gorunum=1 and UstKategoriId="+@KatId, SanatUrunleriE_Ticaret.VTBaglanti.baglanti);
            //SanatUrunleriE_Ticaret.VTBaglanti.baglanti.Open();
            //SqlDataReader AltKategoriReader;
            //AltKategoriReader = AltKategoriCommand.ExecuteReader();
            //dtlKategori.DataSource = AltKategoriReader;
            //dtlKategori.DataBind();
            //AltKategoriReader.Close();
            //SanatUrunleriE_Ticaret.VTBaglanti.baglanti.Close();

            dtlKategori.DataSource = VTBaglanti.DataTableGetir("Select * from Kategori Where Gorunum=1 and UstKategoriId=" + @KatId, null);
            dtlKategori.DataBind();
        }
    }
}