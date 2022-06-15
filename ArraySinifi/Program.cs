using System;

namespace ArraySinifi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] sehirler = { "Adana", "Ankara", "Bursa", "izmir" };
            //string yeniSehir = "GOP";
            //string[] yeniDizi = new string[sehirler.Length + 1];
            //for (int i = 0; i < sehirler.Length; i++) 
            //{ 
            //    yeniDizi[i]= sehirler[i];
            //}
            //yeniDizi[sehirler.Length] = yeniSehir;

            //foreach (var item in yeniDizi)
            //{
            //    Console.WriteLine(item);
            //}
            //siralama icin gerekli olan metod Short metodudur.
            //Array.Sort(yeniDizi);

            // Diziyi yeniden boyulandirmak icin gerekli metod Resize()
            //Array.Resize(ref yeniDizi, yeniDizi.Length+5);
            //yeniDizi[6] = "Bağcilar";

            #region Array.Clear
            // Clear Metodu : diziden eleman silmek icin kullanilir.
            //Array.Clear(yeniDizi, 2, 3);
            /*
             1. Parametre üzerinde islem yapilacak dizi
             2. Parametre dizide hangi index'ten başlayacagini ,
             3. Parametre kaç adet silecegini belirtir.
             */

            //Butun diziyi silmek icin 
            //Array.Clear(yeniDizi, 0, yeniDizi.Length);
            //for (int i = 0; i < yeniDizi.Length; i++)
            //{
            //    yeniDizi[i] = null;
            //}

            //foreach (var item in yeniDizi)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Array.Copy
            // string[] enyeniSehirler = new string[4];
            //Array.Copy(yeniDizi, enyeniSehirler, 4);
            //Array.Copy(yeniDizi, 2, enyeniSehirler, 1, 2);
            //foreach (var item in enyeniSehirler)
            //{
            //    Console.WriteLine(item);
            //}

            //for (int i = 0; i < enyeniSehirler.Length; i++)
            //{
            //    Console.WriteLine(enyeniSehirler[i]);
            //}
            #endregion


            #region Array.IndexOf()
            /*
             dizide aradimiz elemanin index numarasini bize doner
             Eger Aradimiz elaman dizide yoksa -1 döner.
             Eger aranan eleman birden fazla olursa ilk buludugu 
             index degerini döner
             */
            //string[] arabalar = { "Bmw", "Audi", "Fiyat", "Toyota", "Honda", "Alfa Romeo", "Subaru" };
            //Console.WriteLine("Aradiginiz Arac ?");
            //string arananAraba = Console.ReadLine();
            //int index = Array.IndexOf(arabalar, arananAraba);
            //// 1. Parametre kaynak dizi 
            //// 2. Parametre Aranacak olan deger. Burada tip onemli. Dikkat 
            //if (index == -1)
            //{
            //    Console.WriteLine("Aradiginiz "+ arananAraba+ " Listede yoktur");
            //}
            //else
            //{
            //    Console.WriteLine("Aradiginiz " + arananAraba + " " + index + ". siradadir");
            //}

            //index = Array.IndexOf(arabalar, arananAraba, 2);
            // Burada aram işlemi 2. index'ten başlayacaktir.


            #endregion

            #region Array.Reverse 
            // Bu metod diziyi tersine cevirir. Ama siralama yapmaz.
            string[] arabalar = { "Subaru", "Bmw", "Audi", "Fiyat", "Toyota", "Honda", "Alfa Romeo", "Peugeot", "Reno" };
            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Array.Sort(arabalar);
            Array.Reverse(arabalar);
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }

            #endregion

            Console.WriteLine("Hello World!");
        }
    }
}