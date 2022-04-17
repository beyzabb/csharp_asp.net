<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Pizzalar.aspx.cs" Inherits="ders_280122.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row justify-content-center">

            <div class="col">
                <div class="card" style="width: 18rem;">
                    <img src="pizza_resimleri/akdenizli.jpg" class="card-img-top" alt="...">
                    <div class="card-body">
                        <h5 class="card-title">AKDENİZLİ</h5>
                        <p class="card-text">Pizza Sosu, Mozarella Peyniri, Beyaz Peynir, Küp Domates, Siyah Zeytin, Kekik</p>
                        <%--<a href="#" class="btn btn-primary">Sepete Ekle</a>--%>
                        <asp:Button ID="Button1" runat="server" Text="Sepete Ekle" OnClick="Button1_Click" CssClass="btn btn-danger" />
                    </div>
                </div>
            </div>

            <div class="col">
                <div class="card" style="width: 18rem;">
                    <img src="pizza_resimleri/sucuklu.jpg" class="card-img-top" alt="...">
                    <div class="card-body">
                        <h5 class="card-title">DOPDOLU SUCUKLU</h5>
                        <p class="card-text">Pizza Sosu, Mozarella Peyniri, Sucuk</p>
                        <%--<a href="#" class="btn btn-primary">Sepete Ekle</a>--%>
                        <asp:Button ID="Button2" runat="server" Text="Sepete Ekle" OnClick="Button2_Click" CssClass="btn btn-danger" />
                    </div>
                </div>
            </div>

            <div class="col">
                <div class="card" style="width: 18rem;">
                    <img src="pizza_resimleri/kaburgali.jpg" class="card-img-top" alt="...">
                    <div class="card-body">
                        <h5 class="card-title">KABURGALI</h5>
                        <p class="card-text">Barbekü Sos, Mozarella Peyniri, Fırınlanmış Patlıcan, Füme Kaburga, Soğan, Mantar, Susam, Kekik</p>
                        <%--<a href="#" class="btn btn-primary">Sepete Ekle</a>--%>
                        <asp:Button ID="Button3" runat="server" Text="Sepete Ekle" OnClick="Button3_Click" CssClass="btn btn-danger" />
                    </div>
                </div>
            </div>

        </div>

    </div>
</asp:Content>
