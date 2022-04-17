<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ders_5012022.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>anasayfa</title>
    <style>
        h3{
            color: aqua;
            background-color: pink;
            font-family: 'Lucida Bright';
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label3" runat="server" Text="Hesaplama"></asp:Label>
            <br />
            
            <asp:Label ID="Label1" runat="server" Text="Kullanıcı Adı:" style="font-size:large" width="200px"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />

            <asp:Label ID="Label2" runat="server" Text="Şifre:" style="font-size:large" width="200px"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />

            <asp:CheckBox ID="CheckBox1" runat="server" Text="Beni Hatırla" Checked="true" />


            <!--
            <h1 style="color: violet;">Başlık</h1>
            <br />
            yorum satırı 
            <h2>Alt Başlık</h2>
            <h3>Üçüncü alt başlık</h3>
            <h4 style="color: red; background-color:green; font-family: 'Agency FB'">Dördüncü alt başlık</h4>
            <h5>beşinci</h5>
            <h6>altıncı</h6>-->

            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Giriş Yap" style="background-color:deepskyblue; color:white"  OnClick="Button1_Click" />

            <%--<p>
                Paragraf 1
                <br />
                Paragraf 2
                Paragraf 3

            </p>-->--%>
        </div>
    </form>
</body>
</html>
