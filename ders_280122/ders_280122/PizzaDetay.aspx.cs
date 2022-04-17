using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ders_280122
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string urunKodu = Request.QueryString["UrunKodu"].ToString();

                if (urunKodu == "1") //akdenizli n       
                {
                    lbl_baslik.Text = "Akdenizli";
                    Image1.ImageUrl = "pizza_resimleri/akdenizli.jpg";
                    lbl_icerik.Text = "Pizza Sosu, Mozarella Peyniri, Beyaz Peynir, Küp Domates, Siyah Zeytin, Kekik";
                }
                else if (urunKodu == "2") //sucuklu
                {
                    lbl_baslik.Text = "Sucuklu";
                    Image1.ImageUrl = "pizza_resimleri/sucuklu.jpg";
                    lbl_icerik.Text = "Pizza Sosu, Mozarella Peyniri, Sucuk";
                }
                else if (urunKodu == "3")//kaburgali
                {
                    lbl_baslik.Text = "Kaburgalı";
                    Image1.ImageUrl = "pizza_resimleri/kaburgali.jpg";
                    lbl_icerik.Text = "Barbekü Sos, Mozarella Peyniri, Fırınlanmış Patlıcan, Füme Kaburga, Soğan, Mantar, Susam, Kekik";
                }
            }
        }
    }
}