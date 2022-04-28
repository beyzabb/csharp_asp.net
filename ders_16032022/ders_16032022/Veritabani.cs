using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace ders_16032022
{
    public class Veritabani
    {
        SqlConnection baglanti = new SqlConnection();

        public void Baglan()
        {
            string machineName = HttpContext.Current.Server.MachineName;
            string baglantiCumlesi = "Data Source=" + machineName + "; Initial Catalog=AracKiralama; Integrated Security=True; ";

            baglanti.ConnectionString = baglantiCumlesi;
            baglanti.Open();
        }

        public DataTable AracBilgileriniListele()
        {
            //Baglan();
            string sqlkomutu = @"SELECT [id]
                              ,[modeli]
                              ,[resimyolu]
                              ,[aciklama]
                              ,[klima]
                              ,[vites]
                              ,[yakitTuru]
                              ,[kapasite]
                              ,[kapi]
                              ,[yasSiniri]
                              ,[ehliyetSureSiniri]
                              ,[absOzellik]
                              ,[yolcuAirbag]
                               FROM [Arac] where isAktif=1";

            //SqlCommand komut = new SqlCommand();
            //komut.CommandText = sqlkomutu;
            //komut.Connection = baglanti;

            //SqlDataAdapter adapter = new SqlDataAdapter();
            //adapter.SelectCommand = komut;

            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);
            //baglanti.Close();

            //return dataTable;
            return Listeleme(sqlkomutu);
        }
        public DataTable AracBilgileriniListelePasif()
        {
            //Baglan();
            string sqlkomutu = @"SELECT [id]
                              ,[modeli]
                              ,[resimyolu]
                              ,[aciklama]
                              ,[klima]
                              ,[vites]
                              ,[yakitTuru]
                              ,[kapasite]
                              ,[kapi]
                              ,[yasSiniri]
                              ,[ehliyetSureSiniri]
                              ,[absOzellik]
                              ,[yolcuAirbag]
                               FROM [Arac] where isAktif=0";
            return Listeleme(sqlkomutu);
        }

        public DataTable Listeleme(string sqlkomutu)
        {
            Baglan();
            SqlCommand komut = new SqlCommand();
            komut.CommandText = sqlkomutu;
            komut.Connection = baglanti;

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = komut;

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            baglanti.Close();

            return dataTable;
        }

        public DataTable KullaniciBilgileriListele()
        {
            //Baglan();
            string sqlkomutu = @"SELECT [eposta] as Eposta
                              ,[tel] as Telefon
                              ,[kullaniciAdi] as 'Kullanıcı Adı'
                              ,[ad] as Ad
                              ,[soyad] as Soyad
                              ,[tc] as 'T.C. Kimlik No'
                              ,[surucuBelgesiTarihi] as 'Sürücü Belgesi Tarihi'
                              ,[dogumTarihi] as 'Doğum Tarihi'
                              ,[isAktif]
                              ,[isAktifDegistirmeTarihi]
                                FROM[AracKiralama].[dbo].[Kullanici] where isAktif=1";

            //SqlCommand komut = new SqlCommand();
            //komut.CommandText = sqlkomutu;
            //komut.Connection = baglanti;

            //SqlDataAdapter adapter = new SqlDataAdapter();
            //adapter.SelectCommand = komut;

            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);
            //baglanti.Close();

            //return dataTable;
            return Listeleme(sqlkomutu);

        }

        public DataTable KullaniciBilgileriListelePasif()
        {

            string sqlkomutu = @"SELECT [eposta] as Eposta
                              ,[tel] as Telefon
                              ,[kullaniciAdi] as 'Kullanıcı Adı'
                              ,[ad] as Ad
                              ,[soyad] as Soyad
                              ,[tc] as 'T.C. Kimlik No'
                              ,[surucuBelgesiTarihi] as 'Sürücü Belgesi Tarihi'
                              ,[dogumTarihi] as 'Doğum Tarihi'
                                FROM[AracKiralama].[dbo].[Kullanici] where isAktif=0";
            return Listeleme(sqlkomutu);

        }

        public void eklemeGuncelleme(string komutText)
        {
            Baglan();
            SqlCommand komut = new SqlCommand();
            komut.CommandText = komutText;
            komut.Connection = baglanti;

            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        public void KullaniciKaydet(string eposta, string tel, string ad, string soyad, string sifre, string tc, string surucu, string dogum)
        {
            string kullaniciAdi = ad + soyad;                                           //Beyza Mirza Çiçekçi
            kullaniciAdi = kullaniciAdi.ToLower();                                       //beyza mirza çiçekçi
            kullaniciAdi = kullaniciAdi.Replace(" ", "");                                //beyzamirzaçiçekçi

            string turkceKarakter = "ğıüşç";
            string normal = "giusc";
            for (int i = 0; i < turkceKarakter.Length; i++)
            {
                kullaniciAdi = kullaniciAdi.Replace(turkceKarakter[i], normal[i]);        //beyzamirzacicekci
            }
            Random rastgele = new Random();
            kullaniciAdi = kullaniciAdi + rastgele.Next(10, 9999);                           //beyzamirzacicekci23

            sifre = Sifrele.HashMD5(sifre);

            string komutText = @"INSERT INTO[Kullanici]
                               ([eposta]
                               ,[tel]
                               ,[kullaniciAdi]
                               ,[ad]
                               ,[soyad]
                               ,[sifre]
                               ,[tc]
                               ,[surucuBelgesiTarihi]
                               ,[dogumTarihi]
                               ,[isAktif])
                         VALUES
                               ('" + eposta + "', '" + tel + "', '" + kullaniciAdi + "','" + ad + "', '" + soyad + "', '" + sifre + "', '" + tc + "', '" + surucu + "', '" + dogum + "', 1)";

            eklemeGuncelleme(komutText);

            MailGonder mail = new MailGonder();
            mail.Gonder("Kullanıcı Kayıt İşlemi", "Hoşgeldin " + ad, eposta);

        }


        public void AracKaydet(string model, string resimyolu, string aciklama, bool klima, string vitesTuru, string yakitTuru, string kapasite, string kapi, int yasSiniri, int ehliyetSiniri, bool abs, bool airbag)
        {
            string komutText = @"INSERT INTO[Arac]
                               ([modeli]
                               ,[resimyolu]
                               ,[aciklama]
                               ,[klima]
                               ,[vites]
                               ,[yakitTuru]
                               ,[kapasite]
                               ,[kapi]
                               ,[yasSiniri]
                               ,[ehliyetSureSiniri]
                               ,[absOzellik]
                               ,[yolcuAirbag]
                               ,[isAktif])
                         VALUES
                               ('" + model + "', '" + resimyolu + "', '" + aciklama + "', '" + klima + "', '" +
                               vitesTuru + "', '" + yakitTuru + "', '" + kapasite + "', '" + kapi + "', " + yasSiniri + ", " + ehliyetSiniri + ", '" + abs + "', '" + airbag + "', 1)";

            eklemeGuncelleme(komutText);
        }

        public void KullaniciGuncelleme(string eposta, string tel, string ad, string soyad, string tc, string surucu, string dogum)
        {
            string komutString = @"update Kullanici set tel='" + tel + "', ad='" + ad + "', soyad='" + soyad + "', tc='" + tc + "', surucuBelgesiTarihi='" + surucu + "', dogumTarihi='" + dogum + "' where eposta = '" + eposta + "'";

            eklemeGuncelleme(komutString);


        }

        public void KullaniciSil(string eposta)
        {
            string sorgu = "update Kullanici set isAktif=0 where eposta='" + eposta + "'";
            eklemeGuncelleme(sorgu);
        }

        public void SilinenKullaniciyiEkle(string eposta)
        {
            string sorgu = "update Kullanici set isAktif=1 where eposta='" + eposta + "'";
            eklemeGuncelleme(sorgu);
        }

        public void AracGuncelleme(string model, string resimyolu, string aciklama, bool klima, string vitesTuru, string yakitTuru, string kapasite, string kapi, int yasSiniri, int ehliyetSiniri, bool abs, bool airbag, int id)
        {
            string sorgu = @"update Arac set modeli='" + model + "', resimyolu='" + resimyolu + "', aciklama='" + aciklama + "', klima='" + klima + "', vites='" + vitesTuru + "', yakitTuru='" + yakitTuru + "',kapasite = " + kapasite + ", kapi = " + kapi + ", yasSiniri = " + yasSiniri + ", ehliyetSureSiniri = "
                            + ehliyetSiniri + ", absOzellik = '" + abs + "', yolcuAirbag = '" + airbag + "' where id = " + id;

            eklemeGuncelleme(sorgu);
        }

        public void AracSil(int id)
        {
            string sorgu = "update Arac set isAktif = 0 where id = " + id + "";
            eklemeGuncelleme(sorgu);
        }
        public void SilinenAraciEkle(int id)
        {
            string sorgu = "update Arac set isAktif = 1 where id = " + id + "";
            eklemeGuncelleme(sorgu);
        }

        public DataTable FiloGoruntule()
        {
            string sorgu = @"SELECT [modeli]
                          ,[resimyolu]
                          , t1.[aciklama]
                          ,[klima]
                          ,t_vitesTuru.aciklama as vites
                          ,t_yakitTuru.aciklama as yakit
                          ,[kapasite]
                          ,[kapi]
                          ,[yasSiniri]
                          ,[ehliyetSureSiniri]
                          ,[absOzellik]
                          ,[yolcuAirbag]
                          ,[isAktif]
                          ,t_Aractipi.aciklama 
                      FROM(select * from Arac where isAktif = 1) as t1
                      inner join t_vitesTuru on t_vitesTuru.id = t1.vitesTuruId
                      inner join t_yakitTuru on t_yakitTuru.id = t1.yakitTuruId
                      inner join t_Aractipi on t_Aractipi.id = t1.aractipiId";
            return Listeleme(sorgu);

        }

        public string KisiyiBul(string bilgi, string sifre)
        {
            sifre = Sifrele.HashMD5(sifre);
            string sorgu = @"SELECT *  FROM [Kullanici] where (eposta='" + bilgi + "' or tel='" + bilgi + "' or kullaniciAdi='" + bilgi + "') and sifre='" + sifre + "' and isAktif=1";

            Baglan();
            SqlCommand komut = new SqlCommand();
            komut.CommandText = sorgu;
            komut.Connection = baglanti;

            SqlDataReader reader = komut.ExecuteReader();

            string kAdi = "Kullanıcı Bulunamadı";
            if (reader.Read())
            {
                kAdi = reader["kullaniciAdi"].ToString();
            }
            baglanti.Close();
            return kAdi;
        }

        public DataTable vitesListele()
        {
            string sorgu = "SELECT [id],[aciklama] FROM [t_vitesTuru]";
            return Listeleme(sorgu);
        }

        public DataTable yakitListele()
        {
            string sorgu = "SELECT [id],[aciklama] FROM [t_yakitTuru]";
            return Listeleme(sorgu);
        }

        public DataTable alanListele()
        {
            string sorgu = "SELECT  id, [aciklama] FROM [t_Alanlar]";
            return Listeleme(sorgu);
        }
        public DataTable EkHizmetlerListele()
        {
            string sorgu = @"SELECT[id]
                          ,[ad]
                          ,[aciklama]
                          ,[tutar]
                          ,[gunluk]
                                FROM[t_EkHizmetler]";
            return Listeleme(sorgu);
        }

        public string sorguUreten(List<string> veri)
        {
            string sorgu = "";
            if (veri.Count >= 1)
            {
                sorgu += " where aciklama='" + veri[0] + "' ";
                for (int i = 1; i < veri.Count; i++)
                {
                    sorgu += " or aciklama='" + veri[i] + "' ";
                }
            }
            return sorgu;
        }

        public DataTable FiloGoruntuleSorgu(List<string> vites, List<string> yakit)
        {
            string vitesSorgusu = sorguUreten(vites);
            string yakitSorgusu = sorguUreten(yakit);

            string sorgu = @"SELECT
                       [modeli]
                      ,[resimyolu]
                      , t1.[aciklama]
                      ,[klima]
                      ,table1.aciklama as vites
                      ,table2.aciklama as yakit
                      ,[kapasite]
                      ,[kapi]
                      ,[yasSiniri]
                      ,[ehliyetSureSiniri]
                      ,[absOzellik]
                      ,[yolcuairbag]
                      ,t_Aractipi.aciklama
                      From(select * FROM[Arac] where  isAktif = 1) as t1
                      inner join(select* from t_vitesTuru "+vitesSorgusu+@") as table1 on table1.id = t1.vitesTuruId
                      inner join(select* from t_yakitTuru "+yakitSorgusu+@") as table2 on table2.id = t1.yakitTuruId
                      inner join t_Aractipi on t_Aractipi.id = t1.aractipiId";

            return Listeleme(sorgu);

        }


    }
}