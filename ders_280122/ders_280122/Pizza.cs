using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ders_280122
{
    public class Pizza
    {
        public string ad;
        public string aciklama;
        public double kBoyFiyat;
        public double oBoyFiyat;
        public double bBoyFiyat;
        public string[] urunler;

        public Pizza()
        {

        }
        public Pizza(string pizzaAd, string pizzaAciklama, double kbFiyat, double obFiyat, double bbFiyat, string[] urunler)
        {
            this.ad = pizzaAd;
            this.aciklama = pizzaAciklama;
            this.kBoyFiyat = kbFiyat;
            this.oBoyFiyat = obFiyat;
            this.bBoyFiyat = bbFiyat;
            this.urunler = urunler;

        }
        public Pizza(string pizzaAd, string pizzaAciklama, string[] urunler)
        {
            this.ad = pizzaAd;
            this.aciklama = pizzaAciklama;
            this.urunler = urunler;
        }

        public void indirimUygula(double indirimOrani)
        {
            this.kBoyFiyat *= (1 - indirimOrani);
            this.oBoyFiyat *= (1 - indirimOrani);
            this.bBoyFiyat *= (1 - indirimOrani);
        }

    }
}