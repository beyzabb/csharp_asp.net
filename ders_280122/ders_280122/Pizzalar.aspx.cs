using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ders_280122
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] urunler = {"kekik", "kimyon" };
            Pizza p1 = new Pizza("Akdenizli", "Pizza Sosu, Mozarella Peyniri, Beyaz Peynir, Küp Domates, Siyah Zeytin, Kekik", 12.99 , 45.99 , 78.49, urunler);
            Pizza p2 = new Pizza();
            p2.ad = "Dopdolu Sucuklu";
            p2.indirimUygula(0.25);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Akdenizli Pizza
            Response.Redirect("PizzaDetay.aspx?UrunKodu=1");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Dopdolu Sucuklu Pizza
            Response.Redirect("PizzaDetay.aspx?UrunKodu=2");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //Kaburgali Pizza
            Response.Redirect("PizzaDetay.aspx?UrunKodu=3");
        }
    }
}