<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Giris.aspx.cs" Inherits="ders_16032022.Giris" %>

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
  width: 400px;
  height: 500px;
}
</style>
</head>
<body>
    <form id="form1" runat="server" style="padding:150px">
        <div class="container">
            <div class="row justify-content-center">
                <div class="col-8" id="div1" >

                    <img src="logo/car_logo.png"  height="100" width="100" class="rounded mx-auto d-block" />

                    <h1 style="text-align:center">Green Araç Kiralama</h1>
                    <h2 style="text-align:center">Giriş Yap</h2>

                    <asp:TextBox ID="txt_kullaniciAdi" runat="server" CssClass="form-control" placeholder="Kullanıcı adı, telefon veya email"></asp:TextBox>
                    <br />
                    
                    <asp:TextBox ID="txt_sifre" runat="server" CssClass="form-control" placeholder="Şifre" TextMode="Password"></asp:TextBox>
                    
                    <asp:CheckBox ID="chck_benihatirla" runat="server" Text="Beni Hatırla" style="background-color:#C3E5AE"/>
                    <br />
                    <asp:Button ID="Button1" runat="server" Text="Giriş" CssClass="w-100 btn btn-success" OnClick="Button1_Click" /> 

                    <asp:Label ID="lbl_sonuc" runat="server" Text="Label"></asp:Label>
                </div>
            </div>
        </div>
    </form>
    <script src="js/bootstrap.bundle.min.js"></script>
</body>
</html>
<!-- sifremi unuttum kısmını tc kontrolu ile yapacağız-->
<!-- sifre hatasında çıkan alert kısmını c# harici başka yöntem-->
<!-- sifre farklı yöntemle karşılaştırma-->
<!-- ARAC BULUNAMADI  -->
<!-- GİRİS KISMININ SAĞA ÇEKECEZ  -->
