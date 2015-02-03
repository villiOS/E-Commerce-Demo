<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Kategoriler.aspx.cs" Inherits="SanatUrunleriE_Ticaret.Kategoriler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="center_title_bar">
    <asp:Label ID="lblKategoriAdi" runat="server" Text="Label"></asp:Label></div>
    
    	<div class="prod_box_big">
        
                    
                 
        <%--<asp:Repeater ID="rptKategori" runat="server">
        <HeaderTemplate><ul></HeaderTemplate>
        <ItemTemplate>
     <li><a href ="<%#"Urunler.aspx?KategoriId="+Eval("KategoriId") %>"><%#Eval("KategoriAdi") %></a></li></ItemTemplate>
        <FooterTemplate></ul></FooterTemplate>
  
        </asp:Repeater>--%>
                 
        <asp:DataList ID="dtlKategori"  RepeatColumns="3" RepeatDirection="Horizontal" runat="server">
     
        <ItemTemplate>
        <div class="prod_box">
        	<div class="top_prod_box"></div>
            <div class="center_prod_box">            
              
                 <div class="product_img" ><a href ="<%#"Urunler.aspx?KategoriId="+Eval("KategoriId") %>">
                 <img src="<%#"/images/urunler/"+Eval("ResimYolu") %>" alt="<%#Eval("KategoriAdi") %>" width="150px" height="120px" /></a></div>
                                      
            </div>
            <div class="bottom_prod_box"></div>             
            <div class="prod_details_tab" style="text-align:center; font-size:12px; vertical-align:middle;  line-height: 30px;">
              <a href ="<%#"Urunler.aspx?KategoriId="+Eval("KategoriId") %>"><%#Eval("KategoriAdi") %></a>
            </div>                     
        </div>
        </ItemTemplate>
      
        </asp:DataList>

                                             
            
                                            
        </div>
    
</asp:Content>
