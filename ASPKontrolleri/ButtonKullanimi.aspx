<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ButtonKullanimi.aspx.cs" Inherits="ASPKontrolleri.ButtonKullanimi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Buton Kullanımı</title>
    <style>
        .yakisikliButon{
            background-color:#09a916;/*Arkaplan Rengi*/
            color:white;/*Yazı Rengi*/
            padding:10px 30px;/*iç boşluk (padding:üst-alt sağ-sol)*/
            font-weight:900;/*Yazı kalınlığı*/
            font-size:15pt;/*Yazı boyutu*/
            border:1px solid #056b0d;/*Çerçeve*//*border: kalınlık tip renk*/
            border-radius:10px;/*çerçeve köşe yuvarlama*/
        }
    </style>
</head>
<body>
    <%-- asp.net kontrollerinin çalışabilmesi için form etiketinin içinde olması gerekir --%>
    <form id="form1" runat="server">
        <div>
            Her asp.net kontrolü ID'ye sahip olmak zorundadır<br />
            Her asp.net kontrolu runat attributuna sahip olmak zorundadır.<br />
            <asp:Button ID="btn_tikla" Text="Tıkla" runat="server" CssClass="yakisikliButon"/>
            <br />
            <asp:Button ID="btn_degistir" Text="Title Değiştir" runat="server" OnClick="btn_degistir_Click" />
            <br />
            <asp:LinkButton ID="lbtn_tikla" Text="Link Görünümlü Buton" runat="server"></asp:LinkButton>

        </div>
    </form>
</body>
</html>
