<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CokBasitHesapMakinesi.aspx.cs" Inherits="ASPKontrolleri.CokBasitHesapMakinesi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .baslik {
            margin: 0;
            padding: 0;
            margin-bottom: 20px;
        }

        .kutu {
            width: 220px;
            min-height: 200px;
            border: 1px solid silver;
            padding: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="kutu">
            <h3 class="baslik">Çok Basit Hesap Makinesi</h3>
            <label>Sayı 1: </label>
            <asp:TextBox ID="tb_sayi1" runat="server" Text="0"></asp:TextBox>
            <br />
            <br />
            <label>Sayı 2:</label>
            <asp:TextBox ID="tb_sayi2" runat="server" Text="0"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btn_topla" runat="server" Text="Topla" OnClick="btn_topla_Click" />
         
            <asp:Button ID="btn_cikar" runat="server" Text="Çıkar" OnClick="btn_cikar_Click" />
           
            <asp:Button ID="btn_carp" runat="server" Text="Çarp" OnClick="btn_carp_Click" />
          
            <asp:Button ID="btn_bol" runat="server" Text="Böl" OnClick="btn_bol_Click" />
            <br />
            <br />
            <label>Sonuç:</label>
            <asp:TextBox ID="tb_sonuc" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lbl_mesaj" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
