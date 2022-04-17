<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="mtvHesaplama.aspx.cs" Inherits="ders_190122.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lbl_aracTipi" runat="server" Text="Araç Tipi"></asp:Label>
    <br />
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        <%--<asp:ListItem Text="Seçiniz"></asp:ListItem>
                <asp:ListItem Text="Otomobil"></asp:ListItem>
                <asp:ListItem Text="Motorsiklet"></asp:ListItem>
                <asp:ListItem Text="Minibüs"></asp:ListItem>
                <asp:ListItem Text="Otobüs"></asp:ListItem>
                <asp:ListItem Text="Kamyon"></asp:ListItem>--%>
    </asp:DropDownList>

    <br />
    <asp:Label ID="lbl_birinci" runat="server" Text="Motor Silindir Hacmi (cm³) "></asp:Label>
    <br />
    <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
    <br />


    <asp:Label ID="lbl_ikinci" runat="server" Text="Araç Yaşı" Visible="true"></asp:Label>
    <br />
    <asp:DropDownList ID="DropDownList3" runat="server" Visible="true" AutoPostBack="true" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged"></asp:DropDownList>
    <br />

    <asp:Label ID="lbl_ucuncu" runat="server" Text="Araç Tescil Yılı"></asp:Label>
    <br />
    <asp:DropDownList ID="DropDownList4" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList4_SelectedIndexChanged"></asp:DropDownList>
    <br />


    <asp:Label ID="lbl_dorduncu" runat="server" Text="Label" Visible="false"></asp:Label>
    <br />
    <asp:DropDownList ID="DropDownList5" runat="server" Visible="false">
        <asp:ListItem>56.500'i aşmayanlar</asp:ListItem>
        <asp:ListItem>56.500'i aşıp 99.000'i aşmayanlar</asp:ListItem>
        <asp:ListItem>99.000 aşanlar</asp:ListItem>
    </asp:DropDownList>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Hesapla" OnClick="Button1_Click" />
    <br />
    <div style="background-color: lightblue; font-family: Arial">
        <p style="font-family:Arial; color:Highlight"><strong>2022</strong> Yılı İçin Ödenmesi Gereken MTV Tutarı</p>
        <hr color="blue"/>
        <asp:Label ID="lbl_sonuc" runat="server" Font-Size="XX-Large" style="color:Highlight"></asp:Label>
        <br />
    </div>


</asp:Content>
