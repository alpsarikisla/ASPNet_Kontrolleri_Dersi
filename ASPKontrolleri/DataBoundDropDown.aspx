<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataBoundDropDown.aspx.cs" Inherits="ASPKontrolleri.DataBoundDropDown" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Dropdown List - Data Bound</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddl_ogrenciler" runat="server"></asp:DropDownList>
            <asp:Button ID="btn_sec" runat="server" Text="Seç" OnClick="btn_sec_Click"/>
            <br /><br />
            <asp:Label ID="lbl_secilen" runat="server">Lütfen Öğrenci Seçiniz</asp:Label>
        </div>
        <div>
            <h2>Veritabanı Kullanmak</h2>
            <asp:DropDownList ID="ddl_kategoriler" runat="server" DataTextField="Isim" DataValueField="ID"></asp:DropDownList>
        </div>
    </form>
</body>
</html>
