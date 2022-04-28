using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ders_16032022
{
    public partial class Kaydol : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (txt_sifre.Text == txt_sifreTekrar.Text)
            {

                string ad = txt_ad.Text;
                string soyad = txt_soyad.Text;
                string tc = txt_tc.Text;
                string eposta = txt_eposta.Text;
                string tel = txt_tel.Text;
                string dogum = txt_dogum.Text;
                string surucu = txt_surucu.Text;
                string sifre = txt_sifre.Text;
                Veritabani vt = new Veritabani();
                vt.KullaniciKaydet(eposta, tel, ad, soyad, sifre, tc, surucu, dogum);
                Response.Redirect("Giris.aspx");

            }
            

            
            
        }
    }
}