using System;

namespace HazirMetodlar
{
    internal class Program
    {
        /*
      * Sahip oldugunuz metinsel degerlerin ozelliklerini degistirmek icin kullanilan metotlardir. Ornegin, kelimeleri parcalamak, eklemek, harflerin yerlerini degistirmek, bosluk temizlemek vs...
      */

        static void Main(string[] args)
        {
            //OrnekCompare();
            //OrnekStartWith();

            //OrnekIndexOf();
            //OrnekRemove();
            //OrnekReplace();
            //OrnekSplit();
            //OrnekInsert();
            //OrnekToUpperToLower();
            //OrnekToCharArray();
            //OrnekTrim(); 
            OrnekSubString();
            // Console.WriteLine("Hello World!");
        }

        private static void OrnekSubString()
        {
            //Substring (1.Kullanım) => Metninizden, parametrede gonderdiginiz indexten
            //baslayarak, geri kalan kismi cekip almaniza olanak saglar...
            //Substring (2.Kullanım) => Metninizden, ilk parametrede verdiginiz indexten
            //baslayip, ikinci parametrede verdiginiz deger kadarlik kismi cekip almaniza
            //olanak saglar..

            string ornekMetin = "Bugun hava çok guzel";
            //1. Kullanim
            string yenietin = ornekMetin.Substring(5);
            Console.WriteLine(yenietin);
            //2. Kullanim
            Console.WriteLine(ornekMetin.Substring(6, 4));

        }

        private static void OrnekTrim()
        {
            //Trim => Metninizin saginda ya da solundaki tum bosluklari
            //temizlemenize olanak saglayan metottur...

            string ornekMetin = "       Bugun hava çok guzel           ";
            Console.WriteLine(ornekMetin.Trim());

        }

        private static void OrnekToCharArray()
        {
            string ornekMetin = "Bugun hava çok guzel";
            char[] harfler = ornekMetin.ToCharArray();
            foreach (var harf in harfler)
            {
                Console.WriteLine(harf);
            }
        }

        private static void OrnekToUpperToLower()
        {
            string ornekMetin = "Bugun hava çok guzel";
            Console.WriteLine(ornekMetin.ToLower());
            Console.WriteLine(ornekMetin.ToUpper());
        }

        private static void OrnekInsert()
        {
            //Insert => Bir metinsel degerin herhangi bir pozisyonuna (index)
            //yeni bir degeri ilistirmek istiyorsaniz bu metodu kullanabilirsiniz.
            //İlk parameterde kacinci indexten sonra ekleyecegini, ikinci parametrede
            //ise hangi metni ekleyecegini sorar...

            string ornekMetin = "Bugun hava çok guzel";
            string yeniMetin = ornekMetin.Insert(11, "çok ");
            Console.WriteLine(yeniMetin);

        }

        private static void OrnekSplit()
        {
            //Split => Metninizi ozel bir karakterden birden fazla parcaya ayirmaniza
            //olanak saglayan metottur. Ayni anda birden fazla ozel
            // karakter de verebilirsiniz...

            string ornekMetin = "İstanbul Sultangazi’de bir çocuk 5 katlı binanın çatısına çıkarak temizlik yaptı. Hiçbir güvenlik önleminin alınmadığı o anlarda çocuk, hortumla gider borusunu temizledi. Tehlikeli anları karşı apartmandaki bir komşu cep telefonuyla kaydetti.";

            string[] cumleler = ornekMetin.Split(".");
            foreach (string cumle in cumleler)
            {
                string[] kelimeler = cumle.Split(" ");
                Console.WriteLine(cumle);

                foreach (string kelime in kelimeler)
                {
                    Console.WriteLine(kelime);
                }

            }
        }

        private static void OrnekReplace()
        {
            //Replace => Metniniz icerisindeki bir karakteri ya da
            //bir bolumu yeni bir karakter - bolum - ile degistirmenize olanak saglar..

            string ornekMetin = "Bugun hava çok guzel";
            string yeniMetin = ornekMetin.Replace("guzel", "berbat");
            Console.WriteLine(ornekMetin);
            Console.WriteLine(yeniMetin);

        }

        private static void OrnekRemove()
        {
            //NOT => Bir string uzerinde yaptiginiz degisiklikler o string'i
            //degistirmez, size yeni bir kopyasini teslim eder...

            //Remove (1.Kullanım) => Verdiginiz index numarasi dahil, o indexteki
            //ve sonraki tum karakterleri ortadan kaldirir...

            //Remove (2.Kullanım) => Verdiginiz index numarasi dahil, o
            //indexteki elemandan baslayarak, ikinci parametrede gonderdiginiz
            //deger kadar eleman siler...
            string ornekMetin = "Bugun hava çok guzel";
            string yeniMetin = ornekMetin.Remove(5);
            Console.WriteLine(ornekMetin);
            Console.WriteLine(yeniMetin);
            yeniMetin = ornekMetin.Remove(5, 5);
            Console.WriteLine(yeniMetin);

        }

        static void OrnekIndexOf()
        {
            //IndexOf => Dizilerde gordugumuz metodun ayni
            //prensibleriyle calisir. Eger harf varsa harfin indexini,
            //yoksa -1 degerini, harf birden fazla var ise ilk harfin indexini dondurur...
            string ornekMetin = "Bugun hava çok guzel";
            int index = ornekMetin.IndexOf('u');
            Console.WriteLine("Index Numarasi :" + index);
            index = ornekMetin.LastIndexOf('u');
            Console.WriteLine("LastIndex Numarasi :" + index);

        }

        public static void OrnekStartWith()
        {
            //StartsWith => Kelimenizin parametrede gonderdiginiz
            //degerle baslayip baslamadigini size "bool" olarak dondurur...
            string ornekMetin = Console.ReadLine();
            bool sonuc = ornekMetin.StartsWith("bil");
            if (sonuc)
            {
                Console.WriteLine("Cumle bil ile başlamaktadir");
            }
            else
            {
                Console.WriteLine("Cumle bil ile başlamamaktadir");

            }

            Console.WriteLine(sonuc ? "Cumle bil ile başlamaktadir" : "Cumle bil ile başlamamaktadir");

        }
        private static void OrnekCompare()
        {
            string ornekMetin;
            #region
            //CompareTo => Metodu kullandiginiz string degerle metoda verdiginiz
            //parametredeki string degeri sozluk mantigiyla karsilastirir...
            //Eger sozlukte ayni lokasyonlardasa 0, parametredeki deger,
            //ana degerimizden sozlukte onceyse -1; sonraysa 1 degerini
            //dondurur...

            ornekMetin = Console.ReadLine();
            int sonuc = ornekMetin.CompareTo("bilgeadam");

            string mesaj = "";

            switch (sonuc)
            {
                case -1:
                    mesaj = "Kelime diğer kelime ile eşleşmektedir. " +
                        "Eksik karakter var";
                    break;
                case 0:
                    mesaj = "Tebrikler! Kelimeler eşleşmektedir";
                    break;
                case 1:
                    mesaj = "Kelime diğer kelime ile eşleşmemektedir. Fazla karakter var";
                    break;
                default:
                    break;
            }
            Console.WriteLine(mesaj);
            #endregion
        }
    }
}