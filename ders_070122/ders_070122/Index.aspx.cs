using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ders_070122
{
    public partial class Index : System.Web.UI.Page
    {
        //Bu alanda yani classın içinde sadece değişken tanımlaması yapılabilir
        //string kullaniciAdi = "Username";
        //char cinsiyet = 'e';
        //int hisettiginYas = 6;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Fonksiyonun içerisinde hem değişken ataması hem de diğer özellikler kullanılabilir

            //double benzinFiyati = 13.5;
            //bool hayatpahali = true;       //bool ve boolean aynı işlevi görür
            //label1.text = kullaniciadi;
            //textbox1.text = convert.tostring(hisettiginyas);
            //textbox2.text = "" + benzinfiyati;


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //string textboxOku = TextBox2.Text;
            //if (cinsiyet=='k')
            //{
            //    Label1.Text = "Hoşgeldiniz " + textboxOku + " Hanım!";
            //}
            //if (cinsiyet=='e')
            //{
            //    Label1.Text= "Hoşgeldiniz " + textboxOku + " Bey!";
            //}
            //Label1.Text = kullaniciAdi + " " + textboxOku + " "+ cinsiyet + " " + hisettiginYas;

            string isim = txt_ad.Text;
            char cinsiyetBilgisi = Convert.ToChar(txt_cinsiyet.Text);
            if (cinsiyetBilgisi == 'k')
            {
                lbl_sonuc.Text = "Hoşgeldiniz " + " " + isim + " " + "Hanım :)";
            }
            if (cinsiyetBilgisi == 'e')
            {
                lbl_sonuc.Text = "Hoşgeldiniz " + " " + isim + " " + "Bey :)";
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int yas = Convert.ToInt32(txt_yas.Text);
            if (yas <= 18)
            {
                lbl_sonuc.Text = "You shall not PASS!";
            }
            if (yas > 18)
            {
                lbl_sonuc.Text = "Welcome my dear FRODO";
            }


        }
    }
}