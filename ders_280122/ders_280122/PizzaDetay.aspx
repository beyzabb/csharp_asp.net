<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="PizzaDetay.aspx.cs" Inherits="ders_280122.WebForm4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-8" style="color: white">
                <asp:Image ID="Image1" runat="server" CssClass="rounded-circle" />
                <br />

                <asp:Label ID="lbl_baslik" runat="server" Text="Label"></asp:Label>
                <br />

                <asp:Label ID="lbl_icerik" runat="server" Text="Label"></asp:Label>
                <br />
                 

                <div class="accordion" id="accordionExample">

                    <div class="accordion-item">
                        <h2 class="accordion-header" id="headingOne">
                            <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#collapseOne" aria-expanded="false" aria-controls="collapseOne">
                                Ürün Boyutu
                            </button>
                        </h2>
                        <div id="collapseOne" class="accordion-collapse collapse" aria-labelledby="headingOne" data-bs-parent="#accordionExample">
                            <div class="accordion-body">
                                <div class="row" style="color: black">
                                    <div class="col-4">
                                        <div class="card">
                                            <img src="pizza_resimleri/kucuk_dopdolu_sucuklu.jpg" class="card-img-top" alt="...">
                                            <div class="card-body">
                                                <p class="card-text">Küçük Boy</p>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-4">
                                        <div class="card">
                                            <img src="pizza_resimleri/kucuk_dopdolu_sucuklu.jpg" class="card-img-top" alt="...">
                                            <div class="card-body">
                                                <p class="card-text">Orta Boy</p>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-4">
                                        <div class="card">
                                            <img src="pizza_resimleri/kucuk_dopdolu_sucuklu.jpg" class="card-img-top" alt="...">
                                            <div class="card-body">
                                                <p class="card-text">Büyük Boy</p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class="accordion-item">
                        <h2 class="accordion-header" id="headingTwo">
                            <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#collapseTwo" aria-expanded="false" aria-controls="collapseTwo">
                                Hamur Tipi
                            </button>
                        </h2>
                        <div id="collapseTwo" class="accordion-collapse collapse" aria-labelledby="headingTwo" data-bs-parent="#accordionExample" style="color: black">
                            <div class="accordion-body">

                                <div class="row">
                                    <div class="col-6">
                                        <div class="card mb-3" style="max-width: 540px;">
                                            <div class="row g-0">
                                                <div class="col-md-4">
                                                    <img src="pizza_resimleri/margarita.jpg" class="img-fluid rounded-start" alt="...">
                                                </div>
                                                <div class="col-md-8">
                                                    <div class="card-body">
                                                        <h5 class="card-title">Klasik Hamur</h5>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-6">
                                        <div class="card mb-3" style="max-width: 540px;">
                                            <div class="row g-0">
                                                <div class="col-md-4">
                                                    <img src="pizza_resimleri/margarita.jpg" class="img-fluid rounded-start" alt="...">
                                                </div>
                                                <div class="col-md-8">
                                                    <div class="card-body">
                                                        <h5 class="card-title">İnce Hamur</h5>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-6">
                                        <div class="card mb-3" style="max-width: 540px;">
                                            <div class="row g-0">
                                                <div class="col-md-4">
                                                    <img src="pizza_resimleri/margarita.jpg" class="img-fluid rounded-start" alt="...">
                                                </div>
                                                <div class="col-md-8">
                                                    <div class="card-body">
                                                        <h5 class="card-title">Klasik Hamur Simit Kenar</h5>
                                                        <p class="card-text">+5.99</p>

                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-6">
                                        <div class="card mb-3" style="max-width: 540px;">
                                            <div class="row g-0">
                                                <div class="col-md-4">
                                                    <img src="pizza_resimleri/margarita.jpg" class="img-fluid rounded-start" alt="...">
                                                </div>
                                                <div class="col-md-8">
                                                    <div class="card-body">
                                                        <h5 class="card-title">Klasik Hamur Peynirli Kenar</h5>
                                                        <p class="card-text">+5.99</p>

                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                    </div>
                    <div class="accordion-item">
                        <h2 class="accordion-header" id="headingThree">
                            <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#collapseThree" aria-expanded="false" aria-controls="collapseThree">
                                Malzeme
                            </button>
                        </h2>
                        <div id="collapseThree" class="accordion-collapse collapse" aria-labelledby="headingThree" data-bs-parent="#accordionExample">
                            <div class="accordion-body">
                                <div class="container">
                                    <div class="row">
                                        <div class="col-4">
                                            <asp:Button ID="Button1" runat="server" Text="Beyaz Peynir" CssClass="btn btn-outline-danger" />
                                        </div>
                                        <div class="col-4">
                                            <asp:Button ID="Button2" runat="server" Text="Cheddar Peyniri" CssClass="btn btn-outline-danger" />
                                        </div>
                                        <div class="col-4">
                                            <asp:Button ID="Button3" runat="server" Text="Kekik" CssClass="btn btn-outline-danger" />
                                        </div>
                                        <div class="col-4">
                                            <asp:Button ID="Button4" runat="server" Text="Parmesan Peyniri" CssClass="btn btn-outline-danger" />
                                        </div>

                                    </div>

                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="accordion-item">
                        <h2 class="accordion-header" id="headingFour">
                            <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#collapseFour" aria-expanded="false" aria-controls="collapseFour">
                                Ekstra Malzeme
                            </button>
                        </h2>
                        <div id="collapseFour" class="accordion-collapse collapse" aria-labelledby="headingFour" data-bs-parent="#accordionExample">
                            <div class="accordion-body">
                                <div class="container">
                                    <div class="row" style="color: black">
                                        <div class="col-4">
                                            <asp:CheckBox ID="CheckBox1" runat="server" Text=" Brokoli" />
                                            <asp:Label ID="Label1" runat="server" Text="+3,00 " ForeColor="Red"></asp:Label>
                                            <br />
                                            <asp:CheckBox ID="CheckBox2" runat="server" Text=" Füme Kaburga" />
                                            <asp:Label ID="Label2" runat="server" Text=" +4,00 " ForeColor="Red"></asp:Label>

                                        </div>

                                        <div class="col-4">
                                            <asp:CheckBox ID="CheckBox3" runat="server" Text=" Domates " />
                                            <asp:Label ID="Label3" runat="server" Text="+3,00 " ForeColor="Red"></asp:Label>
                                            <br />
                                            <asp:CheckBox ID="CheckBox4" runat="server" Text=" Jalapeno Biber" />
                                            <asp:Label ID="Label4" runat="server" Text=" +4,00 " ForeColor="Red"></asp:Label>
                                        </div>

                                        <div class="col-4">
                                            <asp:CheckBox ID="CheckBox5" runat="server" Text=" Extra Mozarella " />
                                            <asp:Label ID="Label5" runat="server" Text="+3,00 " ForeColor="Red"></asp:Label>
                                            <br />
                                            <asp:CheckBox ID="CheckBox6" runat="server" Text=" Kavurma" />
                                            <asp:Label ID="Label6" runat="server" Text=" +4,00 " ForeColor="Red"></asp:Label>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <div class="col-4">
                <div class="card">
                    <div class="card-header">
                        <asp:Label ID="lbl_baslik2" runat="server" Text="Terra Pizza"></asp:Label>
                    </div>
                    <ul class="list-group list-group-flush">
                        <li class="list-group-item">
                            <asp:Label ID="Label7" runat="server" Text="Ürün Boyutu"></asp:Label>
                            <asp:Label ID="lbl_urunBoyutu" runat="server" Text="Küçük" ForeColor="Red"></asp:Label>
                        </li>

                        <li class="list-group-item">
                            <asp:Label ID="Label8" runat="server" Text="Hamur"></asp:Label>
                            <asp:Label ID="lbl_hamur" runat="server" Text="İnce Hamur" ForeColor="Red"></asp:Label>
                        </li>

                        <li class="list-group-item">
                            <asp:Label ID="Label9" runat="server" Text="Malzeme"></asp:Label>
                            <asp:Label ID="lbl_malzeme" runat="server" Text="Sucuk" ForeColor="Red"></asp:Label>
                        </li>

                        <li class="list-group-item">
                            <asp:Label ID="Label10" runat="server" Text="Ekstra Malzeme"></asp:Label>
                            <asp:Label ID="lbl_ekstraMalzeme" runat="server" Text="Mısır" ForeColor="Black"></asp:Label>
                        </li>
                    </ul>
                    <asp:Button ID="Button5" runat="server" Text="Sepete Ekle" CssClass="btn btn-warning" />
                </div>
            </div>

        </div>
        <br />
        <br />
</asp:Content>
