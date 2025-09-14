<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KullaniciGirisBst.aspx.cs" Inherits="ASPKontrolleri.KullaniciGirisBst" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .tasiyici {
            width: 460px;
            min-height: 200px;
            border: 1px solid silver;
            margin: 200px auto;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="tasiyici">
            <div class="baslik">
                <h3>Giriş Yap </h3>
                <p>Giriş yapmak için Lütfen bilgilerinizi giriniz</p>
            </div>
            <div class="satir">
                <asp:TextBox ID="tb_kadi" runat="server" CssClass="metinKutu"></asp:TextBox>
            </div>
            <div class="satir">
                <asp:TextBox ID="tb_sifre" runat="server" CssClass="metinKutu"></asp:TextBox>
            </div>
            <div class="satir">
                <asp:Button ID="btn_giris" runat="server" Text="Giriş Yap" CssClass="girisButon" />
            </div>
        </div>
    </form>
</body>
</html>
