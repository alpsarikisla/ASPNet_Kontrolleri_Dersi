<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KullaniciGirisBst.aspx.cs" Inherits="ASPKontrolleri.KullaniciGirisBst" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/GirisKayitFormStil.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="tasiyici">
            <div class="baslik">
                <h1>Giriş Yap </h1>
                <p>Giriş yapmak için Lütfen bilgilerinizi giriniz</p>
            </div>
            <div class="satir">
                <%-- <label>Kullanıcı Adı</label>--%>
                <asp:TextBox ID="tb_kadi" runat="server" CssClass="metinKutu" placeholder="Kullanıcı Adı"></asp:TextBox>
                <asp:Label ID="lbl_kadiMesaj" runat="server" CssClass="mesaj"></asp:Label>
            </div>
            <div class="satir">
                <%--<label>Şifre</label>--%>
                <asp:TextBox ID="tb_sifre" runat="server" CssClass="metinKutu" placeholder="Şifre"></asp:TextBox>
                <asp:Label ID="lbl_sifreMesaj" runat="server" CssClass="mesaj"></asp:Label>
            </div>
            <div class="satir">
                <asp:Button ID="btn_giris" runat="server" Text="Giriş Yap" CssClass="girisButon" OnClick="btn_giris_Click"/>
            </div>
            <div class="satir">
                <asp:Label ID="lbl_mesaj" runat="server" CssClass="mesaj"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
