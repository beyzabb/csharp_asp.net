<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="EkHizmetler.aspx.cs" Inherits="ders_16032022.WebForm7" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row justify-content-center">
            <div class="col-12">
                <h2 style="text-align: center">Ek Sigorta Hizmetleri</h2>
                <br />
                <asp:Image ID="Image1" src="logo/ek_sigorta.jpg" Style="height: 350px; width: 1295px" runat="server" />
            </div>

            <div class="row justify-content-center">
                <div class="col-3">
                    <div class="container" style="background-color: green; color: white; border-radius: 10px; text-align: center; font-size: x-large">
                        <asp:Label ID="Label4" runat="server" Text="İndirimli Fiyat"></asp:Label>
                    </div>
                </div>
                <div class="col-3">
                    <div class="container" style="background-color: green; color: white; border-radius: 10px; text-align: center; font-size: x-large">
                        <asp:Label ID="Label5" runat="server" Text="89,00 TL/Gün"></asp:Label>
                    </div>
                    <br />
                    <asp:Button ID="Button1" runat="server" Text=" + Ekle" CssClass="w-100 btn btn-light" Style="text-align: center; border-color: green" />

                </div>
                <div class="col-3">
                    <div class="container" style="background-color: green; color: white; border-radius: 10px; text-align: center; font-size: x-large">
                        <asp:Label ID="Label6" runat="server" Text="139.00 TL/Gün"></asp:Label>
                    </div>
                    <br />
                    <asp:Button ID="Button2" runat="server" Text=" + Ekle" CssClass="w-100 btn btn-light" Style="text-align: center; border-color: green" />
                </div>
                <div class="col-3">
                    <div class="container" style="background-color: green; color: white; border-radius: 10px; text-align: center; font-size: x-large">
                        <asp:Label ID="Label7" runat="server" Text="159.00 TL/Gün"></asp:Label>
                    </div>
                    <br />
                    <asp:Button ID="Button3" runat="server" Text=" + Ekle" CssClass="w-100 btn btn-light" Style="text-align: center; border-color: green" />
                </div>
            </div>
        </div>
        <br />
        <div class="row justify-content-center">
            <div class="col-12">
                <h2 style="text-align: center">Ek Hizmetler</h2>
                <br />
                <asp:Repeater ID="rpt_ekHizmet" runat="server">
                    <ItemTemplate>
                        <div class="accordion" id="accordionExample">
                            <div class="accordion-item">
                                <h2 class="accordion-header" id="headingOne">
                                    <button class="accordion-button" type="button" data-bs-toggle="collapse" data-bs-target="#collapseOne" aria-expanded="true" aria-controls="collapseOne">
                                        <div class="row">
                                            <div class="col-5">
                                                <asp:Label ID="Label1" runat="server" Text='<%#Eval("ad") %>'></asp:Label>
                                            </div>
                                            <div class="col-5">
                                                <asp:Label ID="Label2" runat="server" Text='<%#Eval("tutar")%>'></asp:Label>
                                            </div>
                                            <div class="col-2">
                                                <asp:Label ID="Label3" runat="server" Text='Ayrıntılar'></asp:Label>
                                            </div>
                                        </div>
                                    </button>
                                </h2>
                                <div id="collapseOne" class="accordion-collapse collapse show" aria-labelledby="headingOne" data-bs-parent="#accordionExample">
                                    <div class="accordion-body">
                                        <%#Eval("aciklama") %>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <br />
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>
</asp:Content>
