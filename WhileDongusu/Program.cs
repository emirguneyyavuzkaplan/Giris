using System;

namespace WhileDongusu
{
    internal class Program
    {
        /*
             WHILE
             1) For'un parcalanmis halidir...
             2) For ile yapabildiginiz herseyi rahatlikla yapabilirsiniz...
             3) For'dan farki, metotlardan gelen cevaplara gore islem yapabilme yetenegine sahip olmasidir... (ORNEK => ADO.NET konusunda deginecegimiz, "okuyabildigin kadar oku..." metodu gibi... 
           */
        static void Main(string[] args)
        {
            //Asagidaki ornek bir sonsuz dongu ornegidir. Anlatmaya calisilan sey ise, metotlarin dondurecegi bool degerlere gore while'ın karar verebilme yetenegidir...
            //bool sonuc = false;
            //while (!sonuc)
            //{
            //    Console.WriteLine('a');
            //}
            int sayac = 0;
            //while (sayac<10)
            //{
            //    Console.WriteLine("Ali Veli");
            //    sayac++;
            //}

            // 1-100 arasi sayilari toplayalim
            //int toplam = 0;
            //while (sayac <= 100)
            //{

            //    toplam = toplam + sayac;
            //    sayac ++;
            //}
            //Console.WriteLine("Sonuc :"+toplam);

            #region Ornek 1
            //0-100 arasındaki çift ve tek sayıların toplamlarını bulalım
            int tekToplam = 0, ciftToplam = 0;
            while (sayac <= 100)
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
            }
            Console.WriteLine("Tek toplam:" + tekToplam);
            Console.WriteLine("Cift toplam:" + ciftToplam);

            #endregion
            //Console.WriteLine("Hello World!");
        }
    }
}