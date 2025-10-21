<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TablosuzListView.aspx.cs" Inherits="ASPKontrolleri.TablosuzListView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ürünler</title>
    <link href="css/ListViewStil.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="tasiyici">
            <div class="baslik">
                <h2>Ürünler Listesi</h2>
            </div>
            <div class="icerik">
                <asp:ListView ID="lv_urunler" runat="server">
                    <LayoutTemplate>
                        <asp:PlaceHolder ID="ItemPlaceHolder" runat="server"></asp:PlaceHolder>
                    </LayoutTemplate>
                    <ItemTemplate>
                        <div class="urunKutu">
                            <img src="Resimler/yertutucu.jpg" style="width:100%"/>
                            <h4><%# Eval("ProductName") %></h4>
                            <%# Eval("CategoryName") %>
                            <%# Eval("CompanyName") %>
                            <h4><%# Eval("UnitPrice") %> ₺</h4>
                            Stok Adet =<%# Eval("UnitsInStock") %> 
                        </div>
                    </ItemTemplate>
                </asp:ListView>
            </div>
        </div>
    </form>
</body>
</html>
