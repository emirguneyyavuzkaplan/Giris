sing System;

namespace Diziler
{
    internal class Program
    { //ARRAY - DİZİ
      //Birden fazla aynı tipteki veriyi bir arada tutmamizi saglayan nesnelerimizdir...

        //EĞER;
        //Index was outside the bounds of the array.
        //hatası aliyorsaniz, bilin ki dizinin boyutlarini asacak sekilde eleman ekleme cabasindasiniz... Hata nerde diye bakma, eleman ekleme islemlerine git!

        static void Main(string[] args)
        {
            // ilk deger atamasi seklinde dizi tanimi 
            //                          0  ,  1    ,  2    ,    3
            string[] sinifTakiler = { "Ali", "Veli", "Ayse", "Fatma" };
            int[] vize1 = { 30, 40, 50, 35 };
            int[] vize2 = { 50, 40, 45, 50 };
            int[] final = { 50, 55, 60, 50 };

            // Ayseyi ekran print etmek istiyorum. 
            // Bunun icin Aysenin dizideki index numarasini bilmem lazim
            // Ayse dizide 2. siradadir (dikkat diziler 0'dan başlar)
            Console.WriteLine(sinifTakiler[2]);

            //Aysenin 1.Vizesi kactir ? 
            // vize1 dizisinin 2. Elemani aysenini vize notudur.
            Console.WriteLine(vize1[2]);

            // Aysenin 2. vize notu yanlis girilmiş. Olmasi gereken 55 
            // Vize2 notunu degistirmek icin 

            vize2[2] = 55;
            //vize2[6] = 55; Burasi Index was out of array hatasi verecektir.

            // siniftakileri ekrana foreach ile yazdiralim
            Console.WriteLine("----------- For Each dongusu-----------");
            foreach (string ogrenci in sinifTakiler)
            {
                Console.WriteLine(ogrenci);
            }
            // for ile ekrana yazdiralm
            Console.WriteLine("----------- For dongusu-----------");
            for (int i = 0; i < sinifTakiler.Length; i++)
            {
                Console.WriteLine(sinifTakiler[i]);
            }

            Console.WriteLine("----------- While dongusu-----------");
            int sayac = 0;
            while (sayac < sinifTakiler.Length)
            {

                Console.WriteLine(sinifTakiler[sayac]);
                sayac++;
            }

            Console.WriteLine("----------- Do While dongusu-----------");
            sayac = 0;
            do
            {

                Console.WriteLine(sinifTakiler[sayac]);
                sayac++;
            } while (sayac < sinifTakiler.Length);

            //sifittakiler dizisinin son elenimini ekrana yazin 
            Console.WriteLine(sinifTakiler[sinifTakiler.Length - 1]);


            // sinifin vize ortalamalari nedir ?
            // 1. Yol foreach 
            float ortalama1 = 0, ortalama2 = 0;
            //vize1 icin 
            foreach (int not in vize1)
            {
                ortalama1 = ortalama1 + not;
            }
            ortalama1 = ortalama1 / 4;
            foreach (int not in vize2)
            {
                ortalama2 = ortalama2 + not;
            }
            ortalama2 = ortalama2 / 4;

            Console.WriteLine("Birinci Vize Ortalamasi :" + ortalama1);
            Console.WriteLine("ikinci Vize Ortalamasi :" + ortalama2);
            Console.WriteLine("---------------------------");
            // 2. Yol For ile 
            ortalama1 = 0;
            ortalama2 = 0;
            for (int i = 0; i < 4; i++)
            {
                ortalama1 = ortalama1 + vize1[i];
                ortalama2 = ortalama2 + vize2[i];
            }
            ortalama1 = ortalama1 / 4;
            ortalama2 = ortalama2 / 4;
            Console.WriteLine("Birinci Vize Ortalamasi :" + ortalama1);
            Console.WriteLine("ikinci Vize Ortalamasi :" + ortalama2);

            //siniftakilerin tek tek vize ortalamalari nedir?
            float ortalama;
            for (int i = 0; i < sinifTakiler.Length; i++)
            {
                ortalama = ((vize1[i] + vize2[i]) / 2 * 30 / (float)100 + final[i] * 70 / (float)100);
                Console.WriteLine(sinifTakiler[i] + " - " + ortalama);
            }


            //Console.WriteLine("Hello World!");
        }
    }
}