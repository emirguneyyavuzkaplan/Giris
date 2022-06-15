using System;

namespace ForDongusu
{
    internal class Program
    {
        //Bir baslangic degeri olan, belirli bir kosul gerceklesene
        //dek suren ve bu surec icerisinde bir takim islemleri
        //tekrarli olarak gerceklestiren nesnelere "dongu" adini vermekteyiz.
        //FOR - FOREACH - WHILE - DOWHILE

        static void Main(string[] args)
        {
            //Donguye ilk giris aninda derleyici baslangic degerine
            //bakar ve bir daha asla bu bloga ugramaz. 
            //Bundan sonraki islemler once arttir, daha sonra kosula
            //bak, kosul uygunsa dongunun kod blogunu harekete
            //gecir, uygun degilse donguden cik...
            int sayi = 0;
            #region
            //for(BaslangicDegeri; BitisKosulu; Artis-AzalisMiktari)
            //for (int deger = 1; deger <= 1000; deger++)
            //{
            //    Console.WriteLine(deger);
            //}
            #endregion
            #region ornek 1

            // bir ila 10 arasindaki cift sayilari ekrana mod almadan basiniz .
            //for (int i = 0; i <= 10; i=i+2)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Ornek 2
            //azalma ornegi

            // 1-10 arasindaki tek sayilari tersten sirali sekilde ekrana bassin
            //for (int i = 9; i >0; i=i-2)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Ornek 3

            // Ayin ilk gunu pazartesi olarak kabul edilginde
            // 30 gunluk takvimde pazar gunlerini ekrana basin

            //for (int i = 0; i < 30; i=i+7)
            //{
            //    if (i == 0)
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("--------------------------");
            //for (int i = 28; i > 0; i = i - 7)
            //{
            //    if (i == 0)
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("--------------------------");
            //for (int i = 0; i < 30; i++)
            //{
            //    if (i == 0)
            //        continue;

            //    if(i%7==0)
            //        Console.WriteLine(i);
            //}

            #endregion

            #region Ornek 4
            // Char'lar arkaplanda ASCII degerler barindirirlar...
            // Char'ları Int32'ye cevirirseniz size ASCII degerlerini teslim ederler...

            //for (char c = 'A'; c <= 'Z'; c++)
            //{
            //    Console.WriteLine(c + "-"+Convert.ToInt32(c));
            //}



            #endregion


            #region Ornek 5

            // Console.WriteLine(DateTime.Now);
            // Console.WriteLine("Yil:"+DateTime.Now.Year);
            // Console.WriteLine("Ay:" + DateTime.Now.Month);
            // Console.WriteLine("Gun:" + DateTime.Now.Day);
            // Console.WriteLine("Haftanin Kacinci Gunu:" + DateTime.Now.DayOfWeek);
            // Console.WriteLine("Yilin Kacinci Gunu:" + DateTime.Now.DayOfYear);


            // for (int i = 2010; i <= DateTime.Now.Year; i++)
            // {
            //     //pandemi yillarini es gecelim 2020-2021
            //     //if(!(i==2020 || i==2021))
            //     //Console.WriteLine(i);

            //     if (i == 2020 || i==2021)
            //         continue;

            //     Console.WriteLine(i);
            //}


            #endregion

            //for (int i = 0; i < 100; i++)
            //{
            //    if (i % 12 != 0)
            //        continue;
            //    else
            //        Console.WriteLine(i);
            //}

            // Break kullanimi 

            for (int i = 0; i < 10; i++)
            {
                if (i == 1)
                    continue;
                //break;
                //return;
            }

            Console.WriteLine("Hello World!");
        }
    }
}