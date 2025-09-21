<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DropDownListKontrolu.aspx.cs" Inherits="ASPKontrolleri.DropDownListKontrolu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        div{
            margin:20px 0;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label>Sorumlu Seçiniz:</label>
            <asp:DropDownList ID="ddl_Sorumlu" runat="server">
                <asp:ListItem Text="Poyraz Salih" Value="510"></asp:ListItem>
                <asp:ListItem Text="Cemrenaz Türkanoğlu" Value="515"></asp:ListItem>
                <asp:ListItem Text="Nisa Nur Uçar" Value="522"></asp:ListItem>
                <asp:ListItem Text="Kaan Aydıngör" Value="514"></asp:ListItem>
                <asp:ListItem Text="Alperen Efe Düz" Value="509"></asp:ListItem>
                <asp:ListItem Text="Arda Çırak" Value="568"></asp:ListItem>
                <asp:ListItem Text="Alişan Çakır" Value="516"></asp:ListItem>
            </asp:DropDownList>
            <asp:Button ID="btn_sec" runat="server" Text="Seç" OnClick="btn_sec_Click" />
            <br />
            <asp:Label ID="lbl_secilen" runat="server"></asp:Label>
        </div>
        <div>
            <label>Sınıf Başkanı Seçiniz:</label>
            <asp:DropDownList ID="ddl_sinifBaskani" runat="server" OnSelectedIndexChanged="ddl_sinifBaskani_SelectedIndexChanged" AutoPostBack="true">
                <asp:ListItem Text="Poyraz Salih" Value="510"></asp:ListItem>
                <asp:ListItem Text="Cemrenaz Türkanoğlu" Value="515"></asp:ListItem>
                <asp:ListItem Text="Nisa Nur Uçar" Value="522"></asp:ListItem>
                <asp:ListItem Text="Kaan Aydıngör" Value="514"></asp:ListItem>
                <asp:ListItem Text="Alperen Efe Düz" Value="509"></asp:ListItem>
                <asp:ListItem Text="Arda Çırak" Value="568"></asp:ListItem>
                <asp:ListItem Text="Alişan Çakır" Value="516"></asp:ListItem>
                 <asp:ListItem Text="İbrahim Savaş" Value="518"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="lbl_secilenBaskan" runat="server"></asp:Label>
        </div>
        <div>
            <label>Eklenecek Veri</label>
            <asp:TextBox ID="tb_eklenecek" runat="server"></asp:TextBox>
            <asp:Button ID="btn_eklenecek" runat="server" OnClick="btn_eklenecek_Click" Text="Ekle"/>
            <br />
            <asp:DropDownList ID ="ddl_ekleneler" runat="server"></asp:DropDownList>
            <asp:Button ID="btn_yazdir" runat="server" Text="Yazdır" OnClick="btn_yazdir_Click"/>
            <br />
            <asp:Label ID="lbl_secilmis" runat="server" ></asp:Label>
        </div>
    </form>
</body>
</html>
