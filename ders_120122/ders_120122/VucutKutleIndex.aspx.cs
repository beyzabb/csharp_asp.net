using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ders_120122
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            lbl_sonucBaslik.Visible = true;
            lbl_sonucİcerik.Visible = true;

            int kilo = Convert.ToInt32(txt_kilo.Text);
            int boy = Convert.ToInt32(txt_boy.Text);
            double oran = 0;


            if (kilo > 0 && boy > 0)
            {
                oran = kilo / (boy * boy * 0.0001);
                if (oran <= 18.4)
                {
                    lbl_sonucBaslik.Text = "Zayıf";
                    lbl_sonucİcerik.Text = "Aşırı Zayıf";
                }
                else if (oran > 18.5 && oran < 24.9)
                {
                    lbl_sonucBaslik.Text = "Standart";
                    lbl_sonucİcerik.Text = "Standart";
                }
                else if (oran > 25 && oran < 29.9)
                {
                    lbl_sonucBaslik.Text = "Fazla Kilolu";
                    lbl_sonucİcerik.Text = "Fazla Kilolu";
                }
                else if (oran > 30 && oran < 34.9)
                {
                    lbl_sonucBaslik.Text = "Şişman";
                    lbl_sonucİcerik.Text = "Birinci derece obez";
                }
                else if (oran > 35 && oran < 44.9)
                {
                    lbl_sonucBaslik.Text = "Şişman";
                    lbl_sonucİcerik.Text = "İkinci derece obez";
                }
                else
                {
                    lbl_sonucBaslik.Text = "Aşırı Şişman";
                    lbl_sonucİcerik.Text = "Game Over :(";
                }
            }
            else
            {
                lbl_sonucBaslik.Text = "Hata!";
                lbl_sonucİcerik.Text = "Kilo ve boy bilgisi sıfırdan büyük olmalı!";
            }




        }
    }
}