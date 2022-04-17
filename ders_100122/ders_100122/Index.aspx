<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ders_100122.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Vize Notunu Giriniz:" Width="200px"></asp:Label>
            <asp:TextBox ID="txt_vize" runat="server" Text=""></asp:TextBox>

            <br /><br />

            <asp:Label ID="Label2" runat="server" Text="Final Notunu Giriniz:" Width="200px"></asp:Label>
            <asp:TextBox ID="txt_final" runat="server"></asp:TextBox>

            <br /><br />

            <asp:Button ID="Button1" runat="server" Text="Ortalamayı Hesapla" OnClick="Button1_Click" BorderColor="Blue"/>

            <br /><br />

            <asp:Label ID="lbl_sonuc" runat="server" Text=""></asp:Label>




        </div>
    </form>
</body>
</html>
