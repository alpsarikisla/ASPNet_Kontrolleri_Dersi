<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KayitOl.aspx.cs" Inherits="ASPKontrolleri.KayitOl" %>

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
                <h1>Kayıt Ol</h1>
                <p>Kayıt olmak için lütfen bilgileri eksiksiz doldurunuz</p>
            </div>
            <div class="satir">
                <asp:TextBox ID="tb_isim" runat="server" CssClass="metinKutu" placeholder="Adınız"></asp:TextBox>
                <asp:Label ID="lbl_isimMesaj" runat="server" CssClass="mesaj" Visible="false"></asp:Label>
            </div>
            <div class="satir">
                <asp:TextBox ID="tb_soyisim" runat="server" CssClass="metinKutu" placeholder="Soyadınız"></asp:TextBox>
            </div>
            <div class="satir">
                <asp:TextBox ID="tb_kullaniciAdi" runat="server" CssClass="metinKutu" placeholder="Kullanıcı Adınız"></asp:TextBox>
                <asp:Label ID="lbl_kullaniciAdiMesaj" runat="server"  CssClass="mesaj" Visible="false"></asp:Label>
            </div>
            <div class="satir">
                <asp:TextBox ID="tb_mail" runat="server" CssClass="metinKutu" placeholder="Mail Adresiniz"></asp:TextBox>
                 <asp:Label ID="lbl_mailMesaj" runat="server"  CssClass="mesaj" Visible="false"></asp:Label>
            </div>
            <div class="satir">
                <asp:TextBox ID="tb_telefon" runat="server" CssClass="metinKutu" placeholder="Telefon Numaranız"></asp:TextBox>
            </div>
            <div class="satir">
                <asp:TextBox ID="tb_sifre" runat="server" CssClass="metinKutu" placeholder="Şifre"></asp:TextBox>
                 <asp:Label ID="lbl_sifreMesaj" runat="server"  CssClass="mesaj" Visible="false"></asp:Label>
            </div>
            <div class="satir">
                <asp:TextBox ID="tb_sifreTekrar" runat="server" CssClass="metinKutu" placeholder="Şifre Tekrar"></asp:TextBox>
                 <asp:Label ID="lbl_sifreTekrarMesaj" runat="server" CssClass="mesaj" Visible="false"></asp:Label>
            </div>
            <div class="satir">
                <asp:Button ID="btn_kayitOl" runat="server" CssClass="girisButon" OnClick="btn_kayitOl_Click" Text="Kaydımı Gerçekleştir" />
            </div>
            <div class="satir">
                <asp:Label ID="lbl_mesaj" runat="server" CssClass="mesaj"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
