<%@ Page Title="" Language="C#" MasterPageFile="~/mySite.Master" AutoEventWireup="true" CodeBehind="hakkimizda.aspx.cs" Inherits="ders_140122.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h2>Hakkımızda</h2>
    <asp:ListBox ID="ListBox1" runat="server">
        <asp:ListItem Text="Sayılar"></asp:ListItem>
    </asp:ListBox>
    <br />

    <asp:ListBox ID="ListBox2" runat="server">
        <asp:ListItem Text="While"></asp:ListItem>
    </asp:ListBox>
    <br />
    <asp:ListBox ID="ListBox3" runat="server">
        <asp:ListItem Text="DoWhile"></asp:ListItem>
    </asp:ListBox>

    <br />
    <asp:Button ID="Button1" runat="server" Text="Sırala" OnClick="Button1_Click"/>
</asp:Content>
