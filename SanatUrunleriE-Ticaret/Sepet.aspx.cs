using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace SanatUrunleriE_Ticaret
{
    public partial class Sepet : System.Web.UI.Page
    {
        List<SepetSinif> sepet = new List<SepetSinif>();
        int UrunId;
        int Stok;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
            
            if (Session["SessionSepet"] != null)
            {
                sepet = Session["SessionSepet"] as List<SepetSinif>;
            }
            else
            {
                Session["SessionSepet"]=sepet;
            }
            
            SepeteYaz();
        }

        private void SepeteYaz()
        {
            //grdSepet.DataSource = sepet;
            //grdSepet.DataBind();

            rptSepet.DataSource = sepet;
            rptSepet.DataBind();
            
         
        }

        protected void rptSepet_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.FindControl("drpAdet") != null)
            {
                DropDownList drp = e.Item.FindControl("drpAdet") as DropDownList;
                //drp.SelectedValue = drp.ToolTip;
                //drp.SelectedItem = drp.ToolTip;
                //drp.Text = Convert.ToString(2);

                foreach (var item in sepet)
                {
                    UrunId = Convert.ToInt32(item.UrunId);
                    DataRow urunayrinti = VTBaglanti.DataRowGetir("Select * from Urunler Where UrunId=" + @UrunId, null);
                    Stok = Convert.ToInt32(urunayrinti["Stok"]);
                    //drp.SelectedValue = Convert.ToString(item.Adet);
                    drp.SelectedItem.Text = Convert.ToString(item.Adet);
                }
                for (int i = 1; i <= Stok; i++)
                {
                    ListItem adetliste = new ListItem(Convert.ToString(i));
                    drp.Items.Add(adetliste);
                }

               
            }
        }

        
    }
}