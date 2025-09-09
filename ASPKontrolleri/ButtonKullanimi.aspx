<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ButtonKullanimi.aspx.cs" Inherits="ASPKontrolleri.ButtonKullanimi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Buton Kullanımı</title>
</head>
<body>
    <%-- asp.net kontrollerinin çalışabilmesi için form etiketinin içinde olması gerekir --%>
    <form id="form1" runat="server">
        <div>
            Her asp.net kontrolü ID'ye sahip olmak zorundadır<br />
            Her asp.net kontrolu runat attributuna sahip olmak zorundadır.<br />
            <asp:Button ID="btn_tikla" Text="Tıkla" runat="server" />
        </div>
    </form>
</body>
</html>
