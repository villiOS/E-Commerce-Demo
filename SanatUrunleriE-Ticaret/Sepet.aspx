<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Sepet.aspx.cs" Inherits="SanatUrunleriE_Ticaret.Sepet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<%--    <asp:GridView ID="grdSepet" runat="server">
    </asp:GridView>
    --%>
    <asp:Repeater ID="rptSepet" runat="server" 
        onitemdatabound="rptSepet_ItemDataBound">
    <HeaderTemplate> <table class="tablosepet"> <tr><th>Ürün Resim</th><th>Ürün Adı</th><th>Adet</th><th>Birim Fiyat</th><th>Tutar</th></tr></HeaderTemplate>
    <ItemTemplate>
   
        <tr>
            <td style="width:100px;">
             <img src="<%#"images/urunler/"+Eval("UrunResim")%>"  alt="<%#Eval("UrunAdi") %>" width="100px" height="80px" /></td>
       
            <td>
             <p>   <%#Eval("UrunAdi") %></p></td>
            <td>
           
                <asp:DropDownList ID="drpAdet" runat="server" ToolTip='<%#Eval("Adet") %>' DataTextField='<%#Eval("Adet") %>'>
                </asp:DropDownList> </td>
            <td>
              <p>  <%#Eval("BirimFiyat") %></p></td>
                 <td>
             <p>  <%#Eval("Tutar") %></p> </td>
        </tr>
    
    
    </ItemTemplate>
  
    <FooterTemplate></table></FooterTemplate>
    <SeparatorTemplate>
        <tr>
            <td colspan="5" style="background-color: #E1E1E1">
            </td>
        </tr>
    </SeparatorTemplate>

    
    </asp:Repeater>
</asp:Content>
