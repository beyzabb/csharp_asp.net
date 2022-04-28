<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="KullaniciGoruntule.aspx.cs" Inherits="ders_16032022.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">

        <div class="row justify-content-center">
            <div class="col-12">
                <asp:GridView ID="GridView1" runat="server" OnRowCommand="GridView1_RowCommand" CssClass="table-primary">
                    <Columns>
                        <asp:ButtonField ButtonType="Button" CommandName="Guncelle" Text="Güncelle" ControlStyle-CssClass="btn btn-success" />
                        <asp:ButtonField ButtonType="Button" CommandName="Sil" Text="Sil" ControlStyle-CssClass="btn btn-danger" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>

        <div class="row justify-content-center">
            <div class="col-5">
                <asp:Label ID="Label1" runat="server" Text="E-postanızı giriniz: "></asp:Label>
                <asp:TextBox ID="txt_eposta" runat="server" TextMode="Email" CssClass="form-control"></asp:TextBox>
                <br />

                <asp:Label ID="Label2" runat="server" Text="Telefon numaranızı giriniz: "></asp:Label>
                <asp:TextBox ID="txt_tel" runat="server" TextMode="Phone" CssClass="form-control"></asp:TextBox>
                <br />

                <asp:Label ID="Label3" runat="server" Text="İsminiz: "></asp:Label>
                <asp:TextBox ID="txt_ad" runat="server" CssClass="form-control"></asp:TextBox>
                <br />

                <asp:Label ID="Label4" runat="server" Text="Soy isminiz: "></asp:Label>
                <asp:TextBox ID="txt_soyad" runat="server" CssClass="form-control"></asp:TextBox>
                <br />

                <asp:Label ID="Label5" runat="server" Text="T.C: "></asp:Label>
                <asp:TextBox ID="txt_tc" runat="server" CssClass="form-control"></asp:TextBox>
                <br />

                <asp:Label ID="Label7" runat="server" Text="Doğum tarihi: "></asp:Label>
                <asp:TextBox ID="txt_dogum" runat="server" TextMode="Date"></asp:TextBox>
                <br />

                <asp:Label ID="Label6" runat="server" Text="Sürücü belgesi tarihi: "></asp:Label>
                <asp:TextBox ID="txt_surucu" runat="server" TextMode="Date"></asp:TextBox>
                <br />

                <asp:Button ID="Button1" runat="server" Text="Kaydet" CssClass="btn btn-success" OnClick="Button1_Click" />
                <br />


            </div>
        </div>

        <div class="row justify-content-center">
            <div class="col-12">
                <asp:GridView ID="GridView2" runat="server" OnRowCommand="GridView2_RowCommand" CssClass="table-primary">
                    <Columns>
                        <asp:ButtonField ButtonType="Button" CommandName="Aktif" Text="Aktiflestir" ControlStyle-CssClass="btn btn-success" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>

    </div>
</asp:Content>
