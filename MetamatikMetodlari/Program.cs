using System;

namespace MatematikMetodlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pi sayisi
            Console.WriteLine(Math.PI);

            // Mutlak deger  Abs
            Console.WriteLine(Math.Abs(-27));

            // Yuvarlama : Floor => verilen sayiyi bir alt tam degere
            // yuvarlar
            Console.WriteLine(Math.Floor(12.9));

            //Ceiling => verilen sayiyi bir ust tam sayiya yuvarlar

            Console.WriteLine(Math.Ceiling(12.1));

            //Round => verilen sayinin yaridan fazlasi ise yukari ,
            // yaridan azi ise aşagi yuvarlar
            //Not Sayi .50 ise tek mi cift mi olduguna bakilir.
            // Eger Tek ise yukari ,cift ise aşagi yuvarlama yapilir
            Console.WriteLine(Math.Round(12.55));
            Console.WriteLine(Math.Round(12.45));
            Console.WriteLine(Math.Round(12.50));
            Console.WriteLine(Math.Round(13.50));


            //Truncate => Sayin tam kismini alir. virgulden sonraki kusuratli kisma bakmaz.

            Console.WriteLine(Math.Truncate(22.50));


            //Max Value
            Console.WriteLine(Math.Max(12, 45));


            //Min Value
            Console.WriteLine(Math.Min(12, 45));




        }
    }
}