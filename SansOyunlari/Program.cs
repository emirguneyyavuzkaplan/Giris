using System;

namespace SansOyunlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             ekrandan Deneme Sayisi alinacak.
              Deneme sayisi kadar bir dizi olusturulacak
              dizinin icerisine 0 yada 1 degeri atanacak 
              Gelen degerler toplanip olasilik hesabi yapilacak
             */
            //int deneme = 0;
            //Console.WriteLine("Deneme Sayisi Giriniz:");

            //deneme = int.Parse(Console.ReadLine());
            //Random rnd = new Random();
            //int[] yaziTura = new int[deneme];
            //for (int i = 0; i < deneme; i++)
            //{
            //    yaziTura[i] = rnd.Next(2);
            //}
            //int yazi=0, tura = 0;

            //for (int i = 0; i < deneme; i++)
            //{
            //    if (yaziTura[i] == 0)
            //        yazi = yazi + 1;
            //    else 
            //        tura = tura + 1;
            //}
            //Console.WriteLine("Yazi :"+yazi);
            //Console.WriteLine("Tura :"+tura);
            /*
             
             Deneme sayisi ekran dan alincak .
             Her atilan basket  sonucu bir dizide tutulacak.
             iki takimin musabakasini yapiniz.
             Sonucu da ekrana yaziniz            
             */

            int denemeSayisi = 150;

            byte[] FenerBahce = new byte[denemeSayisi];
            byte[] Galatasaray = new byte[denemeSayisi];
            Random random = new Random();


            // Maçin yapildigi döngü burasi
            for (int i = 0; i < denemeSayisi; i++)
            {
                //Burada her 15 denemede bir hile yapiliyor
                if (i % 15 == 0)
                {
                    FenerBahce[i] = (byte)random.Next(4);
                    Galatasaray[i] = (byte)random.Next(1, 4);
                }
                else
                {
                    FenerBahce[i] = (byte)random.Next(4);
                    Galatasaray[i] = (byte)random.Next(4);
                }


            }
            int bos = 0, serbestAtis = 0, ikiliAtis = 0, uclukAtis = 0;
            int gsBos = 0, gsSerbest = 0, gsikili = 0, gsucluk = 0;


            // Maç Sonu istatistikleri
            for (int i = 0; i < denemeSayisi; i++)
            {
                switch (FenerBahce[i])
                {
                    case 0:
                        bos = bos + 1;
                        break;
                    case 1:
                        serbestAtis = serbestAtis + 1;
                        break;
                    case 2:
                        ikiliAtis = ikiliAtis + 1;
                        break;
                    case 3:
                        uclukAtis = uclukAtis + 1;
                        break;
                    default:
                        break;
                }
                switch (Galatasaray[i])
                {
                    case 0:
                        gsBos = gsBos + 1;
                        break;
                    case 1:
                        gsSerbest = gsSerbest + 1;
                        break;
                    case 2:
                        gsikili = gsikili + 1;
                        break;
                    case 3:
                        gsucluk = gsucluk + 1;
                        break;
                    default:
                        break;
                }
            }
            int fenerToplam = serbestAtis + ikiliAtis + uclukAtis;
            int gsToplam = gsikili + gsSerbest + gsucluk;
            Console.WriteLine("Çekilen Şut      Fenerbahce      Galatasaray");
            Console.WriteLine("-----------      ----------      ------------");
            Console.WriteLine($"Boş              {bos}              {gsBos}");
            Console.WriteLine($"Serbest          {serbestAtis}              {gsSerbest}");
            Console.WriteLine($"ikilik           {ikiliAtis}                {gsikili}");
            Console.WriteLine($"üçlük            {uclukAtis}                {gsucluk}");
            Console.WriteLine($"Maç Sonucu       {fenerToplam}              {gsToplam} ");
            Console.WriteLine("Hello World!");
        }
    }
}