using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ders_5012022
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label3.Text = "merhaba";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string isim = TextBox1.Text;
            Label3.Text = "hosgeldin " + isim ;
        }
    }
}