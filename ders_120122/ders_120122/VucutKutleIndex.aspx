<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="VucutKutleIndex.aspx.cs" Inherits="ders_120122.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="color:white">
        <asp:Label ID="Label3" runat="server" Text="Cinsiyetinizi seçiniz"></asp:Label>
        <br />
        <asp:RadioButton ID="RadioButton1" runat="server" Text="Kadın"/>
        <br />
        <asp:RadioButton ID="RadioButton2" runat="server" Text="Erkek"/>
        <br />


        <asp:Label ID="Label1" runat="server" Text="Vücut Ağırlığı(kg): " Width="150px" ></asp:Label>
        <asp:TextBox ID="txt_kilo" runat="server" placeHolder="Örn.50" TextMode="Number"></asp:TextBox>
        <%--<asp:Label ID="Label3" runat="server" Text="(Örn.50)"></asp:Label>--%>
        <br />

        <asp:Label ID="Label2" runat="server" Text="Boy Uzunluğu(cm): " Width="150px" ></asp:Label>
        <asp:TextBox ID="txt_boy" runat="server" placeHolder="Örn.100" TextMode="Number"></asp:TextBox>
        <%--<asp:Label ID="Label4" runat="server" Text="(Örn.100)"></asp:Label>--%>
        <br />

        <asp:Button ID="Button1" runat="server" Text="Hesapla" OnClick="Button1_Click" />
        <br />
        <asp:Label ID="lbl_sonucBaslik" runat="server" Text="Label" Visible="false"></asp:Label>
        <br />
        <asp:Label ID="lbl_sonucİcerik" runat="server" Text="Label" Visible="false"></asp:Label>
    </div>


</asp:Content>
