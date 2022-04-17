using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ders_140122
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {
            string secilenMenu = e.Item.Value;        //secilne itemin value degerini secilenMenu degiskenine atar

            if (secilenMenu=="baskanaMesaj")
            {
                Response.Redirect("mesaj.aspx");
            }
            else if (secilenMenu=="hakkimizda")
            {
                Response.Redirect("hakkimizda.aspx");
            }
            else if (secilenMenu=="iletisim")
            {
                Response.Redirect("iletisim.aspx");
            }
            else
            {
                Response.Redirect("default.aspx");
            }

        }
    }
}