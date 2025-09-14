<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LabelKullanimi.aspx.cs" Inherits="ASPKontrolleri.LabelKullanimi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Label programlanabilir dinamik yazı yazdırma aracıdır. şuan okuduğunuz bu yazı asp:Label olmadığı için değiştirilemez statik'tir.
            <br />
            <asp:Label ID="lbl_mesaj" runat="server">asp:label dinamik(Değiştirilebilir) yazı aracıdır</asp:Label>
            <br />
            <asp:Button ID="btn_degistir" runat="server" OnClick="btn_degistir_Click" Text="yazı değiştir"/>
        </div>
    </form>
</body>
</html>
