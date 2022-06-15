using System;
using System.Collections;

namespace Array_List
{
    internal class Program
    {/*
        * ARRAYLIST
        * 
        * Su zamana dek gordugumuz ilkel dizilerin 
        * (veriTipi[] olarak tanimlanan) en buyuk iki ozelligi;
        * TİP BAĞIMLILIĞI ve ELEMAN SAYISI ZORUNLULUĞU idi...
        * 
        * Ancak, ArrayList nesnesiyle birlikte bu bagimliliklar ortadan kalktı. Bir ArrayList'i meydana getirirken ne eleman sayisi vermek zorundasiniz ne de bir veri tipi belirtmek zorundasiniz..
        * 
        * Dezavantajı nedir?
        * ArrayList icerisindeki elemanlari otomatik olarak object veri tipine dondurme ozelligine sahiptir. Dolayisiyla bu verileri geri almak istediginiz mecburen bir "cast" ya da "convert" işlemine gerek duymaktasiniz... Bu da ekstra iki kat is demektir... (object => bilinene : unboxing islemi)
        * 
        * ArrayList'i kullanima acabilmek icin namespace'lere using System.Collections; ibaresini eklemelisiniz...
        */

        //Dizinizi asagidaki gibi olustursaniz, eleman sayisi belirtmis olarak olusturmus olursunuz...
        //ArrayList yeniDizi = new ArrayList(20); 

        static void Main(string[] args)
        {
            ArrayList dizi = new ArrayList();
            dizi.Add("Adana");
            dizi.Add(1);
            dizi.Add(new DateTime());
            dizi.Add(true);
            dizi.Add("Urfa");
            dizi.Add("Bursa");
            dizi.Add("Edirne");
            dizi.Add("Izmir");
            dizi.Add("Ayse");
            dizi.Add("Fatma");

            // Araya eleman eklemek istersek
            dizi.Insert(3, "Ali");
            dizi.Insert(5, "Veli");
            //Verilen elemani listeden kaldirmak icin 

            dizi.Remove("Veli");
            //ArrayList'i siralamak icin .short() kullanilir.

            // dizi.Sort();


            // O anki kapasiteyi o anki eleman sayisina esitlemek icin 
            dizi.TrimToSize();
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Hello World!");
        }
    }
}