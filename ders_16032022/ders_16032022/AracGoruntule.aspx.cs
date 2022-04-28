using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ders_16032022
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TabloGuncelle();
                Temizle();
                TabloPasifGuncelle();
                Session["AracGuncellemeId"] = 0;

            }
        }

        public void TabloGuncelle()
        {
            Veritabani vt = new Veritabani();
            DataTable tablo = vt.AracBilgileriniListele();
            GridView1.DataSource = tablo;
            GridView1.DataBind();
        }

        public void TabloPasifGuncelle()
        {
            Veritabani vt = new Veritabani();
            DataTable tablo = vt.AracBilgileriniListelePasif();
            GridView2.DataSource = tablo;
            GridView2.DataBind();
        }

        public void Temizle()
        {
            txt_aciklama.Text = " ";
            txt_ehliyetSiniri.Text = "1";
            txt_kapasite.Text = "5";
            txt_kapi.Text = "4";
            txt_model.Text = " ";
            txt_yasSiniri.Text = "21";
            chck_abs.Checked = false;
            chck_airbag.Checked = false;
            chck_klima.Checked = false;
            DropDownList1.SelectedIndex = 0;
            DropDownList2.SelectedIndex = 0;


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string model = txt_model.Text;
            string aciklama = txt_aciklama.Text;
            string kapasite = txt_kapasite.Text;
            string kapi = txt_kapi.Text;
            int yasSiniri = Convert.ToInt32(txt_yasSiniri.Text);
            int ehliyetSureSiniri = Convert.ToInt32(txt_ehliyetSiniri.Text);

            bool klima = chck_klima.Checked;
            bool abs = chck_abs.Checked;
            bool airbag = chck_airbag.Checked;

            string resimYolu = " ";
            if (FileUpload1.HasFile)                                                      //fileuopload.hasfile ifadesi boolean değerir true olarak alıyor şu an
            {
                resimYolu = "resimler/ " + FileUpload1.FileName;                          //alt gr + ü + çift tıkla = ~ 7
                FileUpload1.SaveAs(Server.MapPath("~/" + resimYolu));                     // FileName = kullanicinin kaydettigi sekilde resimler klasorune o sekilde ekleyecek
            }

            string vitesTuru = "";
            if (DropDownList1.SelectedIndex != 0)
            {
                vitesTuru = DropDownList1.SelectedValue;
            }

            string yakitTuru = "";
            if (DropDownList2.SelectedIndex != 0)
            {
                yakitTuru = DropDownList2.SelectedValue;
            }

            Veritabani vt = new Veritabani();

            if (Convert.ToInt32(Session["AracGuncellemeId"]) > 0) //guncelleme
            {
                vt.AracGuncelleme(model, resimYolu, aciklama, klima, vitesTuru, yakitTuru, kapasite, kapi, yasSiniri,
                    ehliyetSureSiniri, abs, airbag, Convert.ToInt32(Session["AracGuncellemeId"]));
                Session["AracGuncellemeId"] = 0;
            }
            else if (Convert.ToInt32(Session["AracGuncellemeId"]) == 0) //yeni kayit
            {
                vt.AracKaydet(model, resimYolu, aciklama, klima, vitesTuru, yakitTuru, kapasite,
                    kapi, yasSiniri, ehliyetSureSiniri, abs, airbag);
            }
            TabloGuncelle();
            Temizle();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Guncelle")
            {

                int index = Convert.ToInt32(e.CommandArgument);
                txt_aciklama.Text = HttpUtility.HtmlDecode(GridView1.Rows[index].Cells[3].Text);
                txt_ehliyetSiniri.Text = GridView1.Rows[index].Cells[12].Text;
                txt_kapasite.Text = GridView1.Rows[index].Cells[9].Text;
                txt_kapi.Text = GridView1.Rows[index].Cells[10].Text;
                txt_model.Text = HttpUtility.HtmlDecode(GridView1.Rows[index].Cells[3].Text);
                txt_yasSiniri.Text = GridView1.Rows[index].Cells[11].Text;


                //chck_abs.Checked = false;
                //chck_airbag.Checked = false;
                //chck_klima.Checked = false;


                if (GridView1.Rows[index].Cells[7].Text.Equals("Otomatik"))
                {
                    DropDownList1.SelectedIndex = 2;
                }
                else if (GridView1.Rows[index].Cells[7].Text.Equals("Manuel"))
                {
                    DropDownList1.SelectedIndex = 1;
                }

                if (GridView1.Rows[index].Cells[8].Text.Equals("Benzin"))
                {
                    DropDownList2.SelectedIndex = 1;
                }
                else if (GridView1.Rows[index].Cells[8].Text.Equals("LPG"))
                {
                    DropDownList2.SelectedIndex = 2;
                }
                else if (GridView1.Rows[index].Cells[8].Text.Equals("Dizel"))
                {
                    DropDownList2.SelectedIndex = 3;
                }
                else if (GridView1.Rows[index].Cells[8].Text.Equals("Hybrid"))
                {
                    DropDownList2.SelectedIndex = 4;
                }

                Session["AracGuncellemeId"] = GridView1.Rows[index].Cells[2].Text;

            }
            else
            {
                Veritabani vt = new Veritabani();
                int index = Convert.ToInt32(e.CommandArgument);
                vt.AracSil(Convert.ToInt32(GridView1.Rows[index].Cells[2].Text));
                TabloGuncelle();
                TabloPasifGuncelle();

            }
        }

        protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            Veritabani vt = new Veritabani();
            vt.SilinenAraciEkle(Convert.ToInt32(GridView2.Rows[index].Cells[1].Text));
            TabloGuncelle();
            TabloPasifGuncelle();

        }
    }
}