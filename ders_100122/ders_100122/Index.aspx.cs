using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ders_100122
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int vize, final;
            String harfNotu;
            vize = Convert.ToInt32(txt_vize.Text);
            final = Convert.ToInt32(txt_final.Text);
            double ort;
            ort = vize * 0.6 + final * 0.4;
            
            

            if (ort<=100 && ort>=90)
            {
                harfNotu = "AA";
            }
            else if (ort < 90 && ort >= 80)
            {
                harfNotu = "BA";
            }
            else if (ort < 80 && ort >= 70)
            {
                harfNotu = "BB";
            }
            else
            {
                harfNotu = "FF";
            }
            lbl_sonuc.Text = "Ders Ortalamanız = " + ort;
            lbl_sonuc.Text += " Harf Notunuz = " + harfNotu;

            ort += 10;
            double sozlu = vize * 2 - final * 0.5;
            if (sozlu<0)
            {
                sozlu *= -1;
            }
            if (sozlu > 100)
            {
                sozlu = 100;
            }

            lbl_sonuc.Text += " sözlü puanı= " + sozlu;
        }
    }
}