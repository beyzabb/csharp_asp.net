<%@ Page Title="" Language="C#" MasterPageFile="~/mySite.Master" AutoEventWireup="true" CodeBehind="mesaj.aspx.cs" Inherits="ders_140122.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Mesaj</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server">
        <h1>Başvuru Formu</h1>
        <br />

        <asp:Label ID="Label1" runat="server" Text="T.C Kimlik Numarası:"></asp:Label>
        <br />
        <asp:TextBox ID="txt_kimlikNo" runat="server"></asp:TextBox>
        <br />

        <asp:Label ID="Label2" runat="server" Text="Adınız:"></asp:Label>
        <br />
        <asp:TextBox ID="txt_ad" runat="server"></asp:TextBox>
        <br />

        <asp:Label ID="Label3" runat="server" Text="Soyadınız:"></asp:Label>
        <br />
        <asp:TextBox ID="txt_soyad" runat="server"></asp:TextBox>
        <br />

        <asp:Label ID="Label4" runat="server" Text="Telefon Numarası:"></asp:Label>
        <br />
        <asp:TextBox ID="txt_telefon" runat="server" TextMode="Phone"></asp:TextBox>
        <br />

        <asp:Label ID="Label5" runat="server" Text="Email Adresi:"></asp:Label>
        <br />
        <asp:TextBox ID="txt_email" runat="server" TextMode="Email"></asp:TextBox>
        <br />

        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged1">
            <asp:ListItem Text="SEÇİNİZ" Value="seciniz"></asp:ListItem>
            <asp:ListItem Text="ANKARA" Value="ankara"></asp:ListItem>
            <asp:ListItem Text="İSTANBUL" Value="istanbul"></asp:ListItem>
            <asp:ListItem Text="İZMİR" Value="izmir"></asp:ListItem>
        </asp:DropDownList>

        <br />

        <asp:Label ID="Label7" runat="server" Text="İlçe Seçiniz"></asp:Label>

        <br />

        <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
        <br />

        <br />
        <asp:Button ID="Button1" runat="server" Text="Gönder" />

    </asp:Panel>

</asp:Content>
