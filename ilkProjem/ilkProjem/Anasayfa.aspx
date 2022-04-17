<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Anasayfa.aspx.cs" Inherits="ilkProjem.Anasayfa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Sitem</title>
    <style>
        h1{
            color: deeppink;
                background-color: aqua;         
            
        }
        h2 {
            color: white;
            background-color: blue;
            
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="ilk örnek ilk label"></asp:Label>
            <br /><br />

            <asp:Label ID="Label2" runat="server" Text="ikinci label"></asp:Label>
            <br /><br />

            <asp:Button ID="Button1" runat="server" Text="Tıkla" OnClick="Button1_Click" />


            <h1>İlk başlık</h1>
            <h2>İkinci alt başlık</h2>
            <h2 style="background-color:red; color:blueviolet" >İkinci alt başlık tekrar</h2>
            <p>Paragraf</p>
        </div>
    </form>
</body>
</html>
