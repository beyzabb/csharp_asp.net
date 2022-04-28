using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ders_16032022
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TabloGuncelle();
                Session["KullaniciGuncelle"] = false;
                TabloPasifGuncelle();
            }
        }

        public void TabloGuncelle()
        {
            Veritabani vt = new Veritabani();
            DataTable tablo = vt.KullaniciBilgileriListele();
            GridView1.DataSource = tablo;
            GridView1.DataBind();
        }

        public void TabloPasifGuncelle()
        {
            Veritabani vt = new Veritabani();
            DataTable tablo = vt.KullaniciBilgileriListelePasif();
            GridView2.DataSource = tablo;
            GridView2.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string ad = txt_ad.Text;
            string soyad = txt_soyad.Text;
            string tc = txt_tc.Text;
            string eposta = txt_eposta.Text;
            string surucu = txt_surucu.Text;
            string dogum = txt_dogum.Text;
            string tel = txt_tel.Text;

            if (txt_eposta.Enabled == false)
            //Convert.ToBoolean(Session["KullaniciGuncelle"]) == true) //var olan kullaniciyi guncelleme
            {
                Veritabani vt = new Veritabani();
                vt.KullaniciGuncelleme(eposta, tel, ad, soyad, tc, surucu, dogum);
                Session["KullaniciGuncelle"] = false;

            }
            else   //yeni kullanici kaydetme
            {
                
                Random rastgele = new Random();
                string sifreKarakterleri = "asdfghjkliqwertyuıopzxcvbnm12345789?+-*/";
                string sifre = " ";
                int sayi = 0;
                for (int i = 0; i < 6; i++)
                {
                    sayi = rastgele.Next(0, sifreKarakterleri.Length);
                    sifre = sifre + sifreKarakterleri[sayi];

                }

                Veritabani vt = new Veritabani();
                vt.KullaniciKaydet(eposta, tel, ad, soyad, sifre, tc, surucu, dogum);
            }
            TabloGuncelle();
            Temizle();
            txt_eposta.Enabled = true;
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Guncelle") //guncelleme 
            {
                int index = Convert.ToInt32(e.CommandArgument);
                txt_eposta.Text = GridView1.Rows[index].Cells[2].Text;
                txt_eposta.Enabled = false;                                                 //eposta disabled konuma getirildi (gorunuyor ama tiklama islemi yapilamiyor)
                txt_tel.Text = GridView1.Rows[index].Cells[3].Text;
                txt_ad.Text = HttpUtility.HtmlDecode(GridView1.Rows[index].Cells[5].Text); //kullanicinin girdigi gibi ad ve soyadı direkt alir (turkce karakterler dahil)
                txt_soyad.Text = HttpUtility.HtmlDecode(GridView1.Rows[index].Cells[6].Text);
                txt_tc.Text = GridView1.Rows[index].Cells[7].Text;
                txt_surucu.Text = Convert.ToDateTime(GridView1.Rows[index].Cells[8].Text).ToString("yyyy-MM-dd"); //surucu tarihini date time da yil/ay/gun olacak sekilde cevir
                txt_dogum.Text = Convert.ToDateTime(GridView1.Rows[index].Cells[9].Text).ToString("yyyy-MM-dd");
                //Session["KullaniciGuncelle"] = true;

            }
            else //sil
            {
                Veritabani vt = new Veritabani();
                int index = Convert.ToInt32(e.CommandArgument);
                vt.KullaniciSil(GridView1.Rows[index].Cells[2].Text);
                TabloGuncelle();
                TabloPasifGuncelle();
            }
        }

        public void Temizle()
        {
            txt_eposta.Text = " ";
            txt_ad.Text = " ";
            txt_soyad.Text = " ";
            txt_tel.Text = " ";
            txt_tc.Text = " ";
            txt_surucu.Text = " ";
            txt_dogum.Text = " ";
        }

        protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            Veritabani vt = new Veritabani();
            vt.SilinenKullaniciyiEkle(GridView2.Rows[index].Cells[1].Text);
            TabloGuncelle();
            TabloPasifGuncelle();

        }
    }
}
