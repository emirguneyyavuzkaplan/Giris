using System;

namespace AritmetikIslemler
{

    internal class Program
    {

        // Main("ali veli") 
        static void Main(string[] args)
        {
            //f(x) = 2x+1
            //f(1) = 3

            #region Matematiksel Islemler

            int sayi1 = 5;
            int sayi2 = 3;
            int sonuc = 0;
            // Toplama işlemi 

            sonuc = sayi1 + sayi2;
            /*
             Yorum satrina almak icin ctrl+k+c
             Yorum satirindan cikartmak icin ctrl +k +u
             */
            Console.WriteLine("----- işlem yapilacak sayilar  5,3 ---- ");
            Console.WriteLine("Toplam :" + sonuc); //Sonuc:8
            //Console.WriteLine("Toplam :" + sayi1 + sayi2);//sonuc :53
            //Console.WriteLine("Toplam :" + (sayi1 + sayi2));//sonuc :8
            //Console.WriteLine("Toplam :" + (sayi2 + sayi1));//sonuc :8
            Console.WriteLine("----------------Çıkarma -----------------");

            //int fark = sayi1 - sayi2;
            //Console.WriteLine("Fark :"+fark);
            //Console.WriteLine("Fark :" + (sayi1 - sayi2));


            Console.WriteLine("----------------Çarpma -----------------");

            //int carpim= sayi1 * sayi2;
            //Console.WriteLine("Carpim:" + carpim);
            //Console.WriteLine("Carpim :" + (sayi1 * sayi2));

            Console.WriteLine("----------------Bolme -----------------");

            //int Bolum = sayi1 / sayi2; //Sonuc = 1
            //Eger sonuc kusuratli gormek istiyorsak ,float veri tipine yada decimal veri tipine cevirmek gerekir.
            // Asagidaki ornek float veri tipine gore yazilmisitr
            //float Bolum = sayi1 / Convert.ToSingle(sayi2);
            // 0'a bolme hatasi

            //sayi2 = 0;
            //if (sayi2 == 0) // sayi2 0'a esit mi?
            //{
            //    Console.WriteLine("Bolen sayi 0 olamaz..");
            //}
            //else
            //{
            //    Bolum = sayi1 / sayi2;
            //}
            //Console.WriteLine("Bolum:" + Bolum);
            //Console.WriteLine("Bolum:" + (sayi1 / sayi2));

            //Console.WriteLine("--------Arttirma--------");


            //sayi1 = sayi1 + 1;
            //Console.WriteLine("Sayi:" + sayi1);
            //sayi1 += 1; // Buda sayi1 degiskenini 1 artitir
            //Console.WriteLine("Sayi:" + sayi1);
            //sayi1++; // Buda sayi1 degiskenini 1 artitir;
            //Console.WriteLine("Sayi:" + sayi1);


            //Console.WriteLine("--------Çıkartma--------");


            //sayi1 = sayi1 - 1;
            //Console.WriteLine("Sayi:" + sayi1);
            //sayi1 -= 1; // Buda sayi1 degiskenini 1 eksiltir
            //Console.WriteLine("Sayi:" + sayi1);
            //sayi1--; // Buda sayi1 degiskenini 1 eksiltir;
            //Console.WriteLine("Sayi:" + sayi1);
            #endregion

            #region Ekrandan deger okuma
            /*
             *  ekrandan deger okumak icin Console.ReadLine() kullanilir
             * 
             *  Bu metod geriye her zaman string döner. 
             *  Sayisal veri almak istiyor isek bu string'i Cevirmek (Convert) lazim.  Örnekler aşagıdadir
             *  
             */

            //string input,input2;
            //Console.Clear();

            //Console.WriteLine("Birşeyler giriniz:");//Ekrana mesaj basar
            //input = Console.ReadLine(); // Ekrandan deger okur.String'tir
            //sayi1=Convert.ToInt32(input);// Girilen Degeri integer tipine cevirir

            //Console.WriteLine("Başka Birşeyler daha giriniz:");//Ekrana mesaj basar
            //input2 = Console.ReadLine(); // Ekrandan deger okur.String'tir
            //sayi2 =Convert.ToInt32(input2);// Girilen Degeri integer tipine cevirir


            //Console.WriteLine("Girilen Deger:"+input + input2);
            //Console.WriteLine("Girilenlerin toplami:" + (sayi1 + sayi2));
            //int sayi3 = Convert.ToInt32(Console.ReadLine());


            #endregion

            #region Örnek1
            //Soru 1: disaridan alinan 2 sayinin toplamiyla ,farkinin birbirlerine bolumunden kalanin sonucu kactir ? 
            // Ekran ciktisi aşagidaki gibi olacak
            // 1. Sayiyi Gir:
            // 2. Sayiyi Gir:
            // Sonuc : xyz
            // Soru 2 : Farkin toplama bolumunden kalan kactir

            //string input="";
            //Console.WriteLine("1. Sayiyi Giriniz:");
            //input = Console.ReadLine();
            //sayi1 = Convert.ToInt32(input);
            //sayi1 = int.Parse(input);
            //Console.WriteLine("2. Sayiyi Giriniz:");
            //input = Console.ReadLine();
            //sayi2 =Convert.ToInt32(input);

            //float toplam = sayi1 + sayi2;
            //float fark = sayi1 - sayi2;
            //float bolumkalan = toplam % fark;
            //Console.WriteLine("Sonuc :" +bolumkalan);
            //Console.WriteLine("Farkin Toplama Bolumunden Kalan:" + (fark % toplam));
            #endregion


            #region Ornek 2
            /*
             Dişaridan girilen bir sayinin 10 eksiginin 20 fazlasinin 2'ye 
             bolumunden kalanin karesi kaçtir
             */
            //Console.WriteLine("Sayi giriniz:");
            //string input = Console.ReadLine();
            //sayi1 = int.Parse(input);
            //sayi1 = sayi1 - 10; // 10 eksigi
            //sayi1 += 20; // 20 fazlasi
            //sayi1 = sayi1 % 2; // 2 ye bolumunden kalan
            //Console.WriteLine("Sonuc :"+sayi1*sayi1); //sonuc
            #endregion
            #region Ornek 3
            /*
             Dişaridan girilen 2 sayinin kareleri toplami ile kareleri farki kaçtir ?
             */

            //Console.Write("1. Sayi giriniz:");
            //string input = Console.ReadLine();
            //sayi1 = int.Parse(input);
            //Console.Write("2. Sayi giriniz:");
            //input = Console.ReadLine();
            //sayi2 = int.Parse(input);

            //int kareToplam, kareFark;
            //kareToplam = sayi1*sayi1 + sayi2*sayi2;
            //kareFark = sayi1*sayi1 - sayi2*sayi2;

            //Console.WriteLine("Kare Farki:"+kareFark);
            //Console.WriteLine("Kare Toplam:" + kareToplam);

            ////2.Yol 

            //double sonucdbl = Math.Pow(sayi1,2)+Math.Pow(sayi2,2);
            //Console.WriteLine("Kare Toplami:"+sonucdbl);

            // sonucdbl = Math.Pow(sayi1,2) - Math.Pow(sayi2,2);
            //Console.WriteLine("Kare Farki:" + sonucdbl);

            #endregion
            #region Ornek 4
            /*
             2 vize %30, 1 final notu %70 ile ogrencinin not ortalamasini bulununz.
             Dikkat : Notlar ondalik'li olabilir.
             */
            //float vize1, vize2, final, ortalama;

            //Console.Write("1. Vize:");
            //vize1 = float.Parse(Console.ReadLine());

            //Console.Write("2. Vize:");
            //vize2 = float.Parse(Console.ReadLine());

            //Console.Write("Final:");
            //final = float.Parse(Console.ReadLine());

            ////ortalama = (vize1 + vize2) / 2 * 30 / 100 + final * 70 / 100;
            //ortalama = (vize1 + vize2) / 2 * 0.3f+ final * 0.7f;


            //Console.WriteLine("Not Ortalamaniz :"+ortalama);
            #endregion
            #region Ornek 5
            /*
                dişaridan girilen ad ve soyad bilgileri ayri ayri alinarak,
                ad.soyad@gmail.com adresi olusturunuz .
            
             */
            //string ad, soyad, email;

            //Console.Write("Adiniz:");
            //ad = Console.ReadLine();

            //Console.Write("Soyadiniz:");
            //soyad = Console.ReadLine();
            //email = ad + "." + soyad + "@gmail.com";
            //Console.WriteLine("Email adresiniz."+email);

            #endregion

            #region Ornek 6
            /*
                Dişaridan girilen 2 sayinin bolumunu ondalikli olarak ekrana basiniz.
                Dikkat: bolen 0 olmayacak. Bu kontrolu yapiniz.
            
             */
            Console.Write("1. Sayi giriniz:");
            string input = Console.ReadLine();
            sayi1 = int.Parse(input);

            Console.Write("2. Sayi giriniz:");
            input = Console.ReadLine();
            sayi2 = int.Parse(input);

            if (sayi2 != 0)
            {
                float bolum = sayi1 / (float)sayi2;
                Console.WriteLine("Sonuc=" + bolum);
            }
            else
            {
                Console.WriteLine("Bolen 0 olamaz");
            }



            #endregion


        }
    }
}