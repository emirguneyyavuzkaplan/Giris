using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericList
{
    internal class Program
    {//  List<> içerisine (<T>) verilen tipe bürünerek, o tipte bir koleksiyon oluşturmamıza olanak sağlayan dizi çeşididir. daha önceki diziler gibi boyut arttırma işlemine gerek duymadan eleman ekleyebildiğimiz ve Array sınıfını kullanmamıza gerek kalmadan üzerinde işlem yapabildiğimiz gelişmiş bir sınıftır.
        static void Main(string[] args)
        {
            //int[] sayilar = { 1, 2, 3, 40, 5, 6 };

            ArrayList cuval = new ArrayList();
            cuval.Add("ali");
            cuval.Add(12);

            List<string> sehirler = new List<string>();
            sehirler.Add("Adana");
            sehirler.Add("Urfa");
            sehirler.Add("Bursa");


            List<int> sayilar = new List<int>();

            //Console.WriteLine("Kaç eleman gireceksiniz:");
            //int elelmanSayisi = int.Parse(Console.ReadLine());

            ////Bu dongu girilen elelman sayisi kadar veri ekleyecektir.
            //Random rnd = new Random();
            //int tekSayi = 0, ciftSayi = 0,gecici=0;
            //for (int i = 0; i < elelmanSayisi; i++)
            //{
            //    gecici = rnd.Next(1, 50);
            //    if (gecici % 2 == 0)
            //        ciftSayi++;
            //    else
            //        tekSayi++;

            //    sayilar.Add(gecici);
            //}
            //Console.WriteLine("Tek sayi Adedi:"+tekSayi);
            //Console.WriteLine("cift sayi Adedi:" + ciftSayi);

            #region ornek1
            /*
             1-Bir siniftaki kisilerin ad ve soyadlari tutan Listeyi yaziniz.
             2- Ayni sinifin vize ve final notlarini tutacak listeyi yaziniz. 
             3- Siniftakilerin gecip kalma durumlarini hesaplayainiz.
             */

            List<string> siniflistesi = new();
            List<int> vize1 = new();
            List<int> vize2 = new();
            List<int> final = new();
            List<float> sonuclar = new();

            // Sinif Listesi Olusturuluyor.
            siniflistesi.Add("ali");
            siniflistesi.Add("veli");
            siniflistesi.Add("ayse");
            siniflistesi.Add("fatma");
            //Vize1 notlari giriliyor
            vize1.Add(40);
            vize1.Add(45);
            vize1.Add(50);
            vize1.Add(55);
            //vize2 notlari giriliyor
            vize2.Add(45);
            vize2.Add(50);
            vize2.Add(55);
            vize2.Add(60);

            // final notlari giriliyor
            final.Add(50);
            final.Add(50);
            final.Add(50);
            final.Add(50);
            float not = 0;

            //Geçip Kalma Notlari Hesaplaniyor
            for (int i = 0; i < vize1.Count; i++)
            {
                not = (vize1[i] + vize2[i]) / 2 * 0.3f + final[i] * 0.7f;
                sonuclar.Add(not);
            }

            for (int i = 0; i < sonuclar.Count; i++)
            {
                Console.WriteLine(siniflistesi[i] + " Geçme Notu:" + sonuclar[i]);
            }


            #endregion

        }
    }
}