<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataGridViewKullanimi.aspx.cs" Inherits="ASPKontrolleri.DataGridViewKullanimi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Grid View</h3>
            <p>Koleksiyon içerisindeki veya veritabanı içerisinden alınan verileri tablo şeklinde listelemek için kullanılır</p>
            <p>Tablo yapısını kendisi otomatik olarak oluşturur</p>
            <asp:GridView ID="gv_ogrenciler" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
