using System;

namespace doWhile
{
    internal class Program
    {

        /*
            DOWHILE
            While'ın isleyis prensibi olarak tam tersi mantıkla calisir...
            Oncelikle isleminizi sarta bakmaksizin en az bir defa calistirir, daha sonraki tum islemlerine sarta bagimli olarak gerceklestirir. Bu sebeple, DİKKATLİ KULLANMAKTA FAYDA VAR!
            Cok sık tercih edilen bir dongu tipi degildir...
      */
        static void Main(string[] args)
        {
            #region Ornek 1

            int sayac = 0;
            //do
            //{
            //    Console.WriteLine(" Ali veli");
            //    sayac++;

            //} while (sayac<=10);

            int ciftToplam = 0, tekToplam = 0;
            sayac = 0;
            do
            {
                if (sayac % 2 == 0)
                {
                    ciftToplam += sayac;
                }
                else
                {
                    tekToplam += sayac;

                }
                sayac++;
            } while (sayac <= 100);

            Console.WriteLine("Tek toplmalar :" + tekToplam);
            Console.WriteLine("Cift toplamlar :" + ciftToplam);



            #endregion
            #region Faktorel
            //decimal faktoryel=1, b=5;
            //Console.WriteLine("Bir Sayi girin");
            //b = int.Parse(Console.ReadLine());

            //do
            //{
            //    faktoryel = faktoryel * b;
            //    b--;
            //} while (b>0);

            //Console.WriteLine("Sonuc:" + faktoryel);  
            #endregion

            Console.WriteLine("Hello World!");
        }
    }
}