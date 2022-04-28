<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Kaydol.aspx.cs" Inherits="ders_16032022.Kaydol" %>

<!DOCTYPE html>

<html lang="tr">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <title></title>

    <style>
        #div1 {
            border-radius: 25px;
            background: #C3E5AE;
            padding: 20px;
            width: 500px;
            height: 1000px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" style="padding: 50px">
        <div class="container">
            <div class="row justify-content-center">
                <div class="col-5" id="div1">
                    <br />
                    <img src="logo/car_logo.png" height="100" width="100" class="rounded mx-auto d-block" />
                    <h1 style="text-align: center">Green Araç Kiralama</h1>
                    <h2 style="text-align: center">Kayıt Ol</h2>

                    <asp:Label ID="lbl_tc" runat="server" Text="T.C:"></asp:Label>
                    <asp:Label ID="Label1" runat="server" Text="*" style="color:red"></asp:Label>
                    <br />
                    <asp:TextBox ID="txt_tc" runat="server" CssClass="form-control"></asp:TextBox>

                    <asp:Label ID="lbl_ad" runat="server" Text="Ad:"></asp:Label>
                    <br />
                    <asp:TextBox ID="txt_ad" runat="server" CssClass="form-control"></asp:TextBox>

                    <asp:Label ID="lbl_soyad" runat="server" Text="Soyad:"></asp:Label>
                    <br />
                    <asp:TextBox ID="txt_soyad" runat="server" CssClass="form-control"></asp:TextBox>

                    <asp:Label ID="lbl_eposta" runat="server" Text="Eposta:"></asp:Label>
                    <br />
                    <asp:TextBox ID="txt_eposta" runat="server" TextMode="Email" placeholder="name@example.com" CssClass="form-control"></asp:TextBox>

                    <asp:Label ID="lbl_tel" runat="server" Text="Telefon:"></asp:Label>
                    <br />
                    <asp:TextBox ID="txt_tel" runat="server" TextMode="Phone" CssClass="form-control"></asp:TextBox>

                    <asp:Label ID="lbl_dogum" runat="server" Text="Doğum Tarihi:"></asp:Label>
                    <br />
                    <asp:TextBox ID="txt_dogum" runat="server" TextMode="Date" CssClass="form-control"></asp:TextBox>

                    <asp:Label ID="lbl_surucu" runat="server" Text="Sürücü Belgesi Tarihi:"></asp:Label>
                    <br />
                    <asp:TextBox ID="txt_surucu" runat="server" TextMode="Date" CssClass="form-control"></asp:TextBox>

                    <asp:Label ID="lbl_sifre" runat="server" Text="Şifre belirleyiniz"></asp:Label>
                    <br />
                    <asp:TextBox ID="txt_sifre" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>

                    <asp:Label ID="lbl_sifreTekrar" runat="server" Text="Şifreyi tekrar giriniz"></asp:Label>

                    <asp:TextBox ID="txt_sifreTekrar" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>

                    <br />
                    <asp:Button ID="Button1" runat="server" Text="Kayıt Ol" CssClass="w-50 btn btn-success" OnClick="Button1_Click" />
                    <br />
                    <br />
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Şifreler Uyuşmuyor!!!" ControlToValidate="txt_sifre" ControlToCompare="txt_sifreTekrar" CssClass="alert alert-warning"></asp:CompareValidator>
                    <br />
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="T.C Kimlik No Zorunludur!" CssClass="alert alert-danger" ControlToValidate="txt_tc"></asp:RequiredFieldValidator>



                </div>
            </div>
        </div>
    </form>
    <script src="js/bootstrap.bundle.min.js"></script>
</body>
</html>
