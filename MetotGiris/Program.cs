using System;

namespace MetodGiris
{



    internal class Program
    {
        /*
       Geriye deger dondurmeyen, yalnizca uzerine dusen isi yapan işlemlerle void metotlar ya da subrutinler denir...
       1) Tekrarlı kodlari engellemek...
       2) Kod kalabaligindan kurtulup daha esnek kodlar yazabilmek...
       3) Merkeziyetci kod yapisini hedef haline getirebilmek. Yani, herhangi bir problem ya da degisiklik durumunda birden fazla yeri kontrol etmek yerine, merkez yapiya mudahele ederek en kısa ve en net sekilde sorunlari cozmek..
     */


        static void Main(string[] args)
        {
            int toplam = Topla(3, 5);
            Console.WriteLine(toplam);
            Console.WriteLine(Topla("Ali ", " Veli"));
            EkranaYaz("laksdfşlaj f asş");
            Console.WriteLine("Hello World!");


        }

        /// <summary>
        /// Verilen string tipinden mesaji consola yazar.
        /// </summary>
        /// <param name="mesaj">string tipinden mesaj</param>
        public static void EkranaYaz(string mesaj)
        {
            Console.WriteLine(mesaj);
        }

        // Bütün metodlar Class icerisinde olmak zorundadir.
        // Aşagidaki metodun geri donus tipi integer,aldigi 2 adet parametre vardir. her ikiside integer 'dir
        public static int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        //Asagidaki metodun ismi yukaridaki ile ayni olmasina
        //ragmen , aldigi parametreler farkli oldugundan hata vermez.
        // Buna metod overloading denir.
        public static float Topla(float sayi1, float sayi2)
        {
            return ((sayi1 + sayi2));
        }
        /// <summary>
        /// Verilen 2 adet string'i birlestirir.
        /// </summary>
        /// <param name="a">String tipinden ilk deger</param>
        /// <param name="b">String tipinden ikinci deger</param>
        /// <returns>iki string'i birlestirip geri doner</returns>
        public static string Topla(string a, string b)
        {
            return a + b;
        }

        public static decimal Topla(decimal sayi1, decimal sayi2)
        {
            return ((sayi1 + sayi2));
        }

    }

}