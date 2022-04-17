using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ders_190122
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string[] aracTipi = { "Seçiniz", "Otomobil", "Motorsiklet", "Minibüs", "Panel Van ve Motorlu Karavanlar", "Otobüs", "Kamyon" };
        string[] otomobilAracYasi = { "1 - 3 yaş", "4 - 6 yaş", "7 - 11 yaş", "12 - 15 yaş", "16 ve yukarı yaş" };

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) //sayfa ilk defa yukleniyorsa yani bir veri gelmediyse
            {
                lbl_aracTipi.Text = "Araç Tipi";

                for (int i = 0; i < aracTipi.Length; i++)
                {
                    DropDownList1.Items.Add(aracTipi[i]);
                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList2.Items.Clear();
            lbl_ikinci.Visible = true;
            DropDownList3.Visible = true;
            DropDownList3.Items.Clear();
            DropDownList4.Items.Clear();
            string aractipiSecimi = DropDownList1.SelectedValue;
            lbl_ucuncu.Visible = false;
            DropDownList4.Visible = false;



            if (aractipiSecimi == "Otomobil")
            {
                lbl_ucuncu.Visible = true;
                DropDownList4.Visible = true;
                lbl_birinci.Text = "Motor Silindir Hacmi (cm³)";
                string[] otomobilMotorSilindirHacmi = { "1300 cm³ ve aşağısı", "1301 - 1600 cm³'e kadar", "1601 - 1800 cm³'e kadar", "1801 - 2000 cm³'e kadar", "2001 - 2500 cm³'e kadar", "2501 - 3000 cm³'e kadar", "3001 - 3500 cm³'e kadar", "3501 - 4000 cm³'e kadar", "4001 cm³ ve yukarısı" };
                for (int i = 0; i < otomobilMotorSilindirHacmi.Length; i++)
                {
                    DropDownList2.Items.Add(otomobilMotorSilindirHacmi[i]);
                }

                lbl_ikinci.Text = "Araç Yaşı";
                for (int i = 0; i < otomobilAracYasi.Length; i++)
                {
                    DropDownList3.Items.Add(otomobilAracYasi[i]);
                }


                lbl_ucuncu.Text = "Araç Tescil Yılı";
                string[] otomobilAracTescilYili = { "2018'den Önce Alınan Otomobiller", "2018'den Sonra Alınan Otomobiller" };
                for (int i = 0; i < otomobilAracTescilYili.Length; i++)
                {
                    DropDownList4.Items.Add(otomobilAracTescilYili[i]);
                }
            }


            else if (aractipiSecimi == "Motorsiklet")
            {
                lbl_birinci.Text = "Motor Silindir Hacmi (cm³)";
                string[] motorsikletMotorSilindirHacmi = { "100 - 250 cm³'e kadar", "251 - 650 cm³'e kadar", "651 - 1200 cm³'e kadar", "1201 cm³ ve yukarısı" };
                for (int i = 0; i < motorsikletMotorSilindirHacmi.Length; i++)
                {
                    DropDownList2.Items.Add(motorsikletMotorSilindirHacmi[i]);
                }

                lbl_ikinci.Text = "Araç Yaşı";
                string[] motorsikletAracYasi = { "1 - 3 yaş", "4 - 6 yaş", "7 - 11 yaş", "12 - 15 yaş", "16 ve yukarı yaş" };
                for (int i = 0; i < motorsikletAracYasi.Length; i++)
                {
                    DropDownList3.Items.Add(motorsikletAracYasi[i]);
                }


            }


            else if (aractipiSecimi == "Minibüs")
            {
                lbl_ikinci.Visible = false;
                DropDownList3.Visible = false;
                lbl_birinci.Text = "Araç Yaşı";
                string[] minibusAracYasi = { "1-6 yaş", "7-15 yaş", "16 ve yukarı" };
                for (int i = 0; i < minibusAracYasi.Length; i++)
                {
                    DropDownList2.Items.Add(minibusAracYasi[i]);
                }


            }


            else if (aractipiSecimi == aracTipi[4])
            {
                lbl_birinci.Text = "Motor Silindir Hacmi (cm³)";
                string[] panelvanMotorSilindirHacmi = { "1900 cm³ ve aşağısı", "1901 cm³ ve yukarısı" };
                for (int i = 0; i < panelvanMotorSilindirHacmi.Length; i++)
                {
                    DropDownList2.Items.Add(panelvanMotorSilindirHacmi[i]);
                }

                lbl_ikinci.Text = "Araç Yaşı";
                string[] panelvanAracYasi = { "1 - 6 yaş", "7 - 15 yaş", "16 ve yukarı yaş" };
                for (int i = 0; i < panelvanAracYasi.Length; i++)
                {
                    DropDownList3.Items.Add(panelvanAracYasi[i]);
                }

            }


            else if (aractipiSecimi == aracTipi[5])
            {
                lbl_birinci.Text = "Oturma Yeri";
                string[] otobusOturmaYeri = { "25 kişiye kadar", "26 - 35  kişiye kadar ", "36 - 45  kişiye kadar", "46 kişi ve yukarısı" };
                for (int i = 0; i < otobusOturmaYeri.Length; i++)
                {
                    DropDownList2.Items.Add(otobusOturmaYeri[i]);
                }

                lbl_ikinci.Text = "Araç Yaşı";
                string[] otobusAracYasi = { "1 - 6 yaş", "7 - 15 yaş", "16 ve yukarı yaş" };
                for (int i = 0; i < otobusAracYasi.Length; i++)
                {
                    DropDownList3.Items.Add(otobusAracYasi[i]);
                }
            }


            else if (aractipiSecimi == aracTipi[6])
            {
                lbl_birinci.Text = "Azami Toplam Ağırlık";
                string[] kamyonAzamiAgirlik = { "1.500 kg'a kadar", "1.501 - 3.500 kg'a kadar", "3.501 - 5.000 kg'a kadar", "5.001 - 10.000 kg'a kadar", "10.001 - 20.000 kg'a kadar", "20.001 kg ve yukarısı" };
                for (int i = 0; i < kamyonAzamiAgirlik.Length; i++)
                {
                    DropDownList2.Items.Add(kamyonAzamiAgirlik[i]);
                }


                lbl_ikinci.Text = "Araç Yaşı";
                string[] kamyonAracYasi = { "1 - 6 yaş", "7 - 15 yaş", "16 ve yukarı yaş" };
                for (int i = 0; i < kamyonAracYasi.Length; i++)
                {
                    DropDownList3.Items.Add(kamyonAracYasi[i]);
                }

            }
        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string aracYasiSecimi = DropDownList3.SelectedValue;


            if (aracYasiSecimi == otomobilAracYasi[0])
            {

                DropDownList4.Visible = true;
                lbl_ucuncu.Visible = true;

            }
            else
            {
                DropDownList4.Visible = false;
                lbl_ucuncu.Visible = false;
                DropDownList5.Visible = false;
                lbl_dorduncu.Visible = false;
            }




        }

        protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList5.Visible = false;
            lbl_dorduncu.Visible = false;
            //DropDownList5.Items.Clear();
            string secilenTescilYili = DropDownList4.SelectedValue;

            lbl_dorduncu.Text = "Araç Değeri";

            if (secilenTescilYili == "2018'den Sonra Alınan Otomobiller")
            {
                DropDownList5.Visible = true;
                lbl_dorduncu.Visible = true;

                //DropDownList5.Items.Add("56.500'i aşmayanlar");
                //DropDownList5.Items.Add("56.500'i aşıp 99.000'i aşmayanlar");
                //DropDownList5.Items.Add("99.000 aşanlar");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //secilen durumlara gore tuttarlari yazdirma

            int secilenYasindexsi = DropDownList3.SelectedIndex;
            int msİndex = DropDownList2.SelectedIndex;
            int index = (msİndex * 5) + secilenYasindexsi;

            if (DropDownList1.SelectedValue == "Otomobil")
            {


                int[] otomobilVergisi = { 1313, 916, 512, 386, 136, 2287, 1715, 995, 703, 270, 4042, 3157, 1860, 1132, 438, 6368, 4908, 2882, 1715, 676, 9550, 6933, 4332, 2587, 1023, 13318, 11585, 7237, 3891, 1428, 20282, 18250, 10992, 5486, 2012, 31891, 27537, 16217, 7237, 2882, 52195, 39140, 23180, 10416, 4042 };
                lbl_sonuc.Text = otomobilVergisi[index] + " ₺";

            }
            else if (DropDownList1.SelectedValue == "Motorsiklet")
            {

                int[] motorsikletVergisi = { 245, 183, 135, 83, 32, 506, 383, 245, 135, 83, 1306, 776, 383, 245, 135, 3168, 2093, 1306, 1037, 506 };
                lbl_sonuc.Text = motorsikletVergisi[index] + " ₺";


            }
            else if (DropDownList1.SelectedValue == aracTipi[3])
            {
                int[] minibusVergisi = { 1570, 1037, 506 };
                lbl_sonuc.Text = minibusVergisi[msİndex] + " ₺";
            }
            else if (DropDownList1.SelectedValue == aracTipi[4])
            {
                index = (msİndex * 3) + secilenYasindexsi;
                int[] panelvanVergisi = { 2093, 1306, 776, 3151, 2093, 1306 };
                lbl_sonuc.Text = panelvanVergisi[index] + " ₺";
            }
            else if (DropDownList1.SelectedValue == aracTipi[5])
            {
                index = (msİndex * 3) + secilenYasindexsi;
                int[] otobusVergisi = { 3965, 2368, 1037, 4755, 3965, 1570, 5292, 4488, 2093, 6348, 5292, 3168 };
                lbl_sonuc.Text = otobusVergisi[index] + " ₺";
            }
            else
            {
                index = (msİndex * 3) + secilenYasindexsi;
                int[] kamyonVergisi = { 1408, 935, 458, 2851, 1652, 935, 4283, 3565, 1408, 4750, 4038, 1893, 5715, 4755, 2851, 7148, 5715, 3321 };
                lbl_sonuc.Text = kamyonVergisi[index] + " ₺";
            }

        }
    }
}