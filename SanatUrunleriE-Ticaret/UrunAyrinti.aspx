<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="UrunAyrinti.aspx.cs" Inherits="SanatUrunleriE_Ticaret.UrunAyrinti" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="center_title_bar">
        Motorola 156 MX-VL</div>
    <div class="prod_box_big">
        <div class="top_prod_box_big">
        </div>
        <div class="center_prod_box_big">
            <div class="product_img_big">
                <asp:Image ID="imgUrunResim" Width="150px" Height="120px" runat="server" />
                <%-- <a href="javascript:popImage('<%#"/images/urunler/"+Eval("UrunResim") %>')" title="header=[Zoom] body=[&nbsp;] fade=[on]"><img src="images/laptop.gif" alt="" title="" border="0" /></a>--%>
                <%--  <div class="thumbs">
                 <a href="#" title="header=[Thumb1] body=[&nbsp;] fade=[on]"><img src="images/thumb1.gif" alt="" title="" border="0" /></a>
                 <a href="#" title="header=[Thumb2] body=[&nbsp;] fade=[on]"><img src="images/thumb1.gif" alt="" title="" border="0" /></a>
                 <a href="#" title="header=[Thumb3] body=[&nbsp;] fade=[on]"><img src="images/thumb1.gif" alt="" title="" border="0" /></a>
                 </div>--%>
            </div>
            <div class="details_big_box">
                <div class="product_title_big">
                    <asp:Label ID="lblUrunAdi" runat="server" Text=""></asp:Label></div>
                <div class="specifications">
                    Özellikleri: <span class="blue">
                        <asp:Label ID="lblOzellikler" runat="server" Text=""></asp:Label></span><br />
                </div>
                <div class="prod_price_big">
                    <span class="price">
                       Fiyat: <asp:Label ID="lblFiyat" runat="server" Text=""></asp:Label> TL</span></div>
                <asp:DropDownList ID="drpAdet" runat="server">
                   
                </asp:DropDownList>
              
                <asp:LinkButton ID="lnkSepetEkle" class="addtocart" runat="server" 
                    onclick="lnkSepetEkle_Click">Sepete Ekle</asp:LinkButton>
            </div>
        </div>
        <div class="bottom_prod_box_big">
        </div>
    </div>
    <div class="center_title_bar">
       Aynı Kategori Ürünlerden Bazıları</div>
 <asp:DataList ID="dtlUrunler"  RepeatColumns="3" RepeatDirection="Horizontal" runat="server">
        <ItemTemplate>
        <div class="prod_box">
        	<div class="top_prod_box"></div>
            <div class="center_prod_box">            
               <div class="product_title"><a href ="<%#"UrunAyrinti.aspx?UrunId="+Eval("UrunId") %>"><%#Eval("UrunAdi") %></a>

                 <div class="product_img" ><a href ="<%#"UrunAyrinti.aspx?UrunId="+Eval("UrunId") %>">
                 <img src="<%#"/images/urunler/"+Eval("UrunResim") %>" alt="<%#Eval("UrunAdi") %>" width="150px" height="120px" /></a></div>
                  
                     <div class="prod_price"> <span class="price"><%#Eval("BirimFiyat") %><p> TL</p></span></div>                     
            </div>
            <div class="bottom_prod_box"></div>             
            <div class="prod_details_tab" style="text-align:center; font-size:12px; vertical-align:middle;  line-height: 30px;">

             <a href="#" title="header=[Sepete Ekle] body=[&nbsp;] fade=[on]"><img src="images/cart.gif" alt="" title="" border="0" class="left_bt" /></a>
            <a href="#" title="header=[Rezerve Et] body=[&nbsp;] fade=[on]"><img src="images/favs.gif" alt="" title="" border="0" class="left_bt" /></a>
              <a href ="<%#"UrunAyrinti.aspx?UrunId="+Eval("UrunId") %>">Ayrıntı</a>
            </div>                     
        </div>
        </ItemTemplate>
      
        </asp:DataList>
</asp:Content>
