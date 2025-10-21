<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListViewKullanimi.aspx.cs" Inherits="ASPKontrolleri.ListViewKullanimi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>List View Kullanımı</title>
    <link href="css/GridViewStil.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="tasiyici">
            <div class="baslik">
                <h2>Ürünler Listesi</h2>
            </div>
            <div class="filtre">
                <asp:DropDownList ID="ddl_kategoriler" runat="server" OnSelectedIndexChanged="ddl_kategoriler_SelectedIndexChanged" AutoPostBack="true" AppendDataBoundItems="true" DataTextField="Isim" DataValueField="ID">
                    <asp:ListItem Value="-1" Text="Tüm Ürünler"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="icerik">
                <asp:ListView ID="lv_urunler" runat="server">
                    <layouttemplate>
                        <table border="1" cellspacing="0">
                            <thead>
                                <tr>
                                    <th>ÜrünNo</th>
                                    <th>Ürün Adı</th>
                                    <th>kategori</th>
                                    <th>Tedarikçi</th>
                                    <th>Stok Miktarı</th>
                                    <th>Fiyatı</th>
                                    <th>Satış Durum</th>
                                </tr>
                            </thead>
                            <tbody>
                                <asp:PlaceHolder ID="ItemPlaceHolder" runat="server"></asp:PlaceHolder>
                            </tbody>
                        </table>
                    </layouttemplate>
                    <itemtemplate>
                        <tr>
                            <td><%# Eval("ProductID") %></td>
                            <td><%# Eval("ProductName") %></td>
                            <td><%# Eval("CategoryName") %></td>
                            <td><%# Eval("CompanyName") %></td>
                            <td><%# Eval("UnitsInStock") %></td>
                            <td><%# Eval("UnitPrice") %> ₺</td>
                            <td><%# Eval("SatistaMi") %></td>
                        </tr>
                    </itemtemplate>
                </asp:ListView>
            </div>
        </div>
    </form>
</body>
</html>
