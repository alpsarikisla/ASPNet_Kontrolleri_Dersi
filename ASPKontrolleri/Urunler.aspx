<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Urunler.aspx.cs" Inherits="ASPKontrolleri.Urunler" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ürünler</title>
    <link href="css/GridViewStil.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="tasiyici">
            <div class="baslik">
                <h2>Ürünler Listesi</h2>
            </div>
            <div class="filtre">
                Kategori =
                <asp:DropDownList ID="ddl_kategoriler" runat="server" DataTextField="Isim" DataValueField="ID" AppendDataBoundItems="true">
                    <asp:ListItem Value="-1">Tüm Ürünler</asp:ListItem>
                </asp:DropDownList>
                <asp:Button ID="btn_filtrele" runat="server" Text="Filtrele" OnClick="btn_filtrele_Click"/>
            </div>
            <div class="icerik">
                <asp:GridView ID="gv_urunler" runat="server" AutoGenerateColumns="false">
                    <Columns>
                        <asp:BoundField HeaderText="Ürün No" DataField="ProductID" />
                        <asp:BoundField HeaderText="Ürün Adı" DataField="ProductName" />
                        <asp:BoundField HeaderText="Kategori" DataField="CategoryName" />
                        <asp:BoundField HeaderText="Tedarikçi Firma" DataField="CompanyName" />
                        <asp:BoundField HeaderText="Paketleme" DataField="QuantityPerUnit" />
                        <asp:BoundField HeaderText="Stok Miktarı" DataField="UnitsInStock" />
                        <asp:BoundField HeaderText="Güvenlik Stoğu" DataField="ReorderLevel" />
                        <asp:BoundField HeaderText="Ürün Fiyat" DataField="UnitPrice" />
                        <asp:BoundField HeaderText="Satış Durum" DataField="SatistaMi" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </form>
</body>
</html>
