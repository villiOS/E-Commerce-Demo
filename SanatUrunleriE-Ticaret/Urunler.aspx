<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Urunler.aspx.cs" Inherits="SanatUrunleriE_Ticaret.Urunler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<%--<div class="prod_box">
        	<div class="top_prod_box"></div>
            <div class="center_prod_box">            
                 <div class="product_title"><a href="UrunAyrinti.aspx">Motorola 156 MX-VL</a></div>
                 <div class="product_img"><a href="UrunAyrinti.aspx"><img src="images/laptop.gif" alt="" title="" border="0" /></a></div>
                 <div class="prod_price"><span class="reduce">350$</span> <span class="price">270$</span></div>                        
            </div>
            <div class="bottom_prod_box"></div>             
            <div class="prod_details_tab">
            <a href="#" title="header=[Sepete Ekle] body=[&nbsp;] fade=[on]"><img src="images/cart.gif" alt="" title="" border="0" class="left_bt" /></a>
            <a href="#" title="header=[Rezerve Et] body=[&nbsp;] fade=[on]"><img src="images/favs.gif" alt="" title="" border="0" class="left_bt" /></a>
          
            <a href="UrunAyrinti.aspx" class="prod_details">Ayrıntı</a>            
            </div>                     
        </div>
--%>



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
