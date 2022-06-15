using System;

namespace TarihMetodlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime baslangic = DateTime.Now;

            // Gunun Tarih ve Zamani almak
            Console.WriteLine(DateTime.Now);

            //Sadece gun.ay.yill verir
            Console.WriteLine(DateTime.Now.ToShortDateString());

            //tarih ve saat ile beraber gun isminide verir
            Console.WriteLine(DateTime.Now.ToLongDateString());


            //Tarih Formatlama

            Console.WriteLine(DateTime.Now.Month + "/" + DateTime.Now.Day + "/" + DateTime.Now.Year);

            //Artik Yil Kontrolu 

            bool artikYilmi = DateTime.IsLeapYear(2022);

            // Son 10 yilin artik yillari hangileridir bulunuz 
            for (int i = 2000; i < DateTime.Now.Year; i++)
            {
                artikYilmi = DateTime.IsLeapYear(i);
                if (artikYilmi)
                    Console.WriteLine(i);
            }

            // Haftanin gunu 
            Console.WriteLine(DateTime.Now.DayOfWeek);

            // Yilin gunu

            Console.WriteLine(DateTime.Now.DayOfYear);
            DateTime trh = DateTime.Now.AddDays(10);
            Console.WriteLine(trh);
            //TimeSpan

            DateTime bora = new DateTime(1994, 9, 13);
            DateTime simdi = DateTime.Now;

            TimeSpan tarihFarki = simdi - bora;
            Console.WriteLine("Bora " + tarihFarki.Days + " gundur hayatta");
            Console.WriteLine("Bora " + tarihFarki.TotalHours + " saattir yasiyor");

            DateTime bitis = DateTime.Now;
            tarihFarki = bitis - baslangic;
            Console.WriteLine("Program " + tarihFarki.TotalMilliseconds + " ms  calismistir");
            //Console.WriteLine("Hello World!");
        }
    }
}