using System;

namespace VoidMetodlar
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
            // 1-100 arasindaki tek ve cift sayilarin toplamini yapan metod..
            //TekCift();
            // Kisa kenar ve uzun kenar bilgileri ekrandan alacak 
            // ve alan ile cevre hesabi yapacak metodu yaziniz.
            //AlanHesabi();
            // vize1,vize2, final notlarini disaridan alan ve not
            // ortalamasini hesaplayan metodu yaziniz.
            //NotHesaplama();
            // 
            NotHesaplama(50, 50, 50);
            Console.WriteLine("Hello World!");

        }
        static void NotHesaplama()
        {
            int vize1, vize2, final;
            float ortalama = 0;
            Console.WriteLine("1. Vize:");
            vize1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2. Vize:");

            vize2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("final:");
            final = int.Parse(Console.ReadLine());

            ortalama = (vize1 + vize2) / 2 * 0.3f + final * 0.7f;

            Console.WriteLine("Not Ortalamaniz:" + ortalama);
        }
        static void NotHesaplama(int vize1, int vize2, int final)
        {
            float ortalama = 0;
            ortalama = (vize1 + vize2) / 2 * 0.3f + final * 0.7f;

            Console.WriteLine("Not Ortalamaniz:" + ortalama);
        }
        static void AlanHesabi()
        {
            int kisa = 0, uzun = 0;
            Console.WriteLine("Kisa Kenar:");
            kisa = int.Parse(Console.ReadLine());
            Console.WriteLine("Uzun Kenar:");
            uzun = int.Parse(Console.ReadLine());
            Console.WriteLine("Alan :" + (kisa * uzun));
            Console.WriteLine("Cevre:" + (2 * (kisa + uzun)));
        }
        /// <summary>
        /// 1-100 arasindaki sayilarin tek ,cift toplamini verir.
        /// </summary>
        static void TekCift()
        {
            int tekToplam = 0, ciftToplam = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                {

                    ciftToplam += i;
                }
                else
                {
                    tekToplam += i;
                }
            }
            Console.WriteLine("Tek Toplam:" + tekToplam);
            Console.WriteLine("Cift Toplam:" + ciftToplam);
        }
    }
}