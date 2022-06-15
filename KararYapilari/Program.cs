using System;

namespace KararYapilari
{
    internal class Program
    {
        /*
        KARAR YAPILARI
          Uygulamanizin calismasi esnasinda farkli senaryolara gore farkli yonlendirmeler yapmaniz gerekebilir.Ornegin, kullanicidan gelen degerin araligina gore, uygulamadaki mantiksal islerinizin sonuclarina gore yonlendirmeler yapabiliriz.
          3 temel karar yapısı karsimiza cikar => IF-ELSE ~SWITCH-CASE ~TERNARY OPERATORU
      */

        /*
         * KARSILASTIRMA OPERATORLERI
         * 1) ==  (Karsilikli iki degerin birbiriyle esit olmasi durumu)
         * 2) !=  (Karsilikli iki degerin birbiriyle esit olmamasi durumu)
         * 3) <   (Soldaki degerin sagdaki degerden kucuk olmasi durumu)
         * 4) >   (Soldaki degerin sagdaki degerden buyuk olmasi durumu)
         * 5) <=  (Soldaki degerin sagdaki degere esit ya da ondan kucuk olmasi durumu)
         * 6) >=  (Soldaki degerin sagdaki degere esit ya da ondan buyuk olmasi durumu)
         */

        static void Main(string[] args)
        {
            #region Ornek 1
            //string kod;
            //Console.WriteLine("İçecek Kodunu giriniz:");
            //kod = Console.ReadLine();

            //if (kod == "Ç" || kod=="ç")
            //{
            //    Console.WriteLine("çay");
            //}
            //else if (kod == "M" || kod=="m")
            //{

            //    Console.WriteLine("Meyve Suyu");
            //}
            //else if (kod == "L" || kod == "l")
            //{
            //    Console.WriteLine("Limonata");
            //}
            //else
            //{
            //    Console.WriteLine("girilen kod çözülemedi");
            //} 
            #endregion

            // && ve operatoru , || veya operatoru
            // Ekrandan kullanici Adi ve parola alinacak. 
            // Dogru girmis ise hosgeldiniz mesajı versin 
            // Diger turlu hangisinin hatali oldugunu ekrana yazsin.
            // kullaniciAdi : Admin ,parola : qweasd
            //string kullaniciAdi, parola;
            //Console.WriteLine("Kullanici adiniz:");
            //kullaniciAdi = Console.ReadLine();
            //Console.WriteLine("Parolaniz:");
            //parola = Console.ReadLine();
            // Normalde olmasi gereken budur
            //if (kullaniciAdi == "Admin" && parola=="qweasd")
            //{
            //    Console.WriteLine("Hosgeldin Sahip..");
            //}
            //else
            //{
            //    Console.WriteLine("Kullanici Kodunuz yada sifre hatali");
            //}


            // Detayli bilgi icin 1. Yol
            #region 1.Yol

            //if (kullaniciAdi == "Admin")
            //{
            //    if (parola == "qweasd")
            //    {
            //        Console.WriteLine("Hosgeldiniz...");
            //    }
            //    else
            //    {
            //        Console.WriteLine("KullaniciAdi Dogrudur. ancak Parola yanlistir.");
            //    }
            //}
            //else
            //{

            //    if (parola == "qweasd")
            //    {
            //        Console.WriteLine("Parola Dogru ancak Kullanici Kodu Hatalidir");

            //    }
            //    else
            //    {
            //        Console.WriteLine("Parolada yanliş Kullanici Kodu da yanlis");

            //    }
            //} 
            #endregion
            #region 2. Yol
            // kod dogru sifre dogru
            // kod dogru sifre yanlis
            // kod yanlis sifre yanlis
            // kod yanlis sifre dogru

            //if (kullaniciAdi == "Admin" && parola == "qweasd")
            //{
            //    Console.WriteLine("Hosgeldiniz");
            //}
            //else if (kullaniciAdi == "Admin" && parola != "qweasd")
            //{
            //    Console.WriteLine("Kullanici dogru , Sifre yanliş");
            //}
            //else if (kullaniciAdi != "Admin" && parola != "qweasd")
            //{
            //    Console.WriteLine("Butun bilgiler yanliştir");
            //}
            //else if (kullaniciAdi != "Admin" && parola == "qweasd")
            //{
            //    Console.WriteLine("Kullanici yanliş ,Parola dogru.");
            //}

            #endregion
            #region Ornek 2

            //Girilen not 0 - 30 araligi ise "FF" 30 - 50 araligi
            // "DD" 50 - 70 "BB" 70 - 100 "AA" aldınız seklinde
            // kullaniciyi uyariniz..
            //Console.WriteLine("Notunuz:");
            //int not = int.Parse(Console.ReadLine());    
            //if (not >= 0 && not < 30)
            //{
            //    Console.WriteLine("Notunuz:FF");
            //}
            //else if (not >= 30 && not < 50)
            //{
            //    Console.WriteLine("Notunuz:DD");

            //}
            //else if (not >= 50 && not < 70)
            //{
            //    Console.WriteLine("Notunuz:BB");
            //}
            //else if (not >= 70 && not <= 100)
            //{
            //    Console.WriteLine("Notunuz:AA");

            //}
            //else
            //{
            //    Console.WriteLine("Boyle bir not yok..");   
            //}

            #endregion

            #region Ornek 3
            //Disaridan urun adi girilecek, kasiyer bize urunun hangi reyonda oldugunu soyleyecek...
            //Domates, Biber, Patlican => Sebze Reyonu
            //Diş Macunu, Parfüm, Şampuan => Kozmetik Reyonu
            //Cep Telefonu, Bilgisayar, Ses Sistemi => Teknoloji Reyonu
            //Başka bir ürün girilirse "Bu ürün bizde yok!" uyarisi verilsin!
            //string input;
            //Console.WriteLine("Ne ariyorsunuz:");
            //input = Console.ReadLine();

            //if (input == "Domates" || input == "Biber" || input == "Patlican") 
            //{
            //    Console.WriteLine("Lutfen Manav Reyonuna Gidiniz");
            //}
            //else if (input == "Diş Macunu" || input == "Parfüm" || input == "Şampuan")
            //{
            //    Console.WriteLine("Lutfen Kozmetik Reyonuna  Gidiniz");
            //}
            //else if (input == "Cep Telefonu" || input == "Bilgisayar" || input == "Ses Sistemi")
            //{
            //    Console.WriteLine("Lutfen Teknoloji Reyonuna Gidiniz");
            //}
            //else
            //{
            //    Console.WriteLine("Bu ürün bizde yok! ");
            //}
            #endregion
            #region Ornek 4
            //Disaridan siparis alinacak olan kitap miktari girilsin.
            //Sipari sayisi 20'den azsa toplam ucretten %5,
            //20 - 50 araliginda ise %10, 50-100 araligi ise %15,
            //100'den fazla ise %25 indirim yapilsin.
            //Kitabın birim fiyatı => 5 TLdir...
            //Amac => Odenecek tutari kullaniciya gostermek...

            int kitapSayisi, fiyat = 5;
            float indirim = 0;
            Console.WriteLine("Kitap Adedi:");
            kitapSayisi = int.Parse(Console.ReadLine());

            if (kitapSayisi < 20)
            {
                indirim = fiyat * kitapSayisi * 5 / 100;
            }

            else if (kitapSayisi >= 20 && kitapSayisi < 50)
            {
                indirim = fiyat * kitapSayisi * 10 / 100;
            }
            else if (kitapSayisi >= 50 && kitapSayisi < 100)
            {
                indirim = fiyat * kitapSayisi * 15 / 100;

            }
            else if (kitapSayisi >= 100)
            {
                indirim = fiyat * kitapSayisi * 25 / 100;

            }
            Console.WriteLine($"Normal Tutar :{kitapSayisi * fiyat} ");
            Console.WriteLine($"indirim Tutari :{indirim} ");
            Console.WriteLine($"Odenecek Tutar :{(kitapSayisi * fiyat) - indirim}");




            #endregion
            #region Sorular
            /*
             Kullanicidan 2 sayi alin
             Birde Ekrana [+,-,/,*] 
            Bunlardan hangisini girdi ise ona gore işlem yapin
             */

            // Soner Kurnaz Çözümü
            int sayi1, sayi2;
            string input;
            Console.Write("1.Sayıyı giriniz: ");
            sayi1 = int.Parse(Console.ReadLine());

            Console.Write("2.Sayıyı giriniz: ");
            sayi2 = int.Parse(Console.ReadLine());

            Console.Write("İşlem seçiniz: (+,-,/,*): ");
            input = Console.ReadLine();
            if (input == "+")
            {
                //Console.WriteLine("Sonuç: " + (sayi1 + sayi2));
                Console.WriteLine($"Sonuç: {sayi1 + sayi2}");
            }
            else if (input == "-")
            {
                Console.WriteLine("Sonuç: " + (sayi1 - sayi2));
            }
            else if (input == "*")
            {
                Console.WriteLine("Sonuç: " + (sayi1 * sayi2));
            }
            else if (input == "/")
            {
                if (!(sayi2 == 0))
                {
                    Console.WriteLine("Sonuç: " + (sayi1 / sayi2));
                }
                // Ternary If ile yapilirsa 
                Console.WriteLine("Sonuç: " + (sayi1 / (sayi2 == 0 ? 1 : sayi2)));


            }
            else
            {
                Console.WriteLine("Yanlış girdi.");
            }


            /*
             Soru 2: Ekrandan girilen mevsime gore aylari bastirin.
             */
            //string input;

            // Soner Kurnaz Çözümü


            Console.Write("Mevsim giriniz: ");
            input = Console.ReadLine();

            if (input == "Kış" || input == "KIŞ" || input == "kış" || input == "Kis" || input == "Kiş" || input == "KIS")
            {
                Console.WriteLine("ARALIK,OCAK,ŞUBAT");
            }
            else if (input == "İlkbahar" || input == "İLKBAHAR" || input == "ilkbahar")
            {
                Console.WriteLine("MART,NİSAN,MAYIS");
            }
            else if (input == "Yaz" || input == "YAZ" || input == "yaz")
            {
                Console.WriteLine("HAZİRAN,TEMMUZ,AĞUSTOS");
            }
            else if (input == "Sonbahar" || input == "SONBAHAR" || input == "sonbahar")
            {
                Console.WriteLine("EYLÜL,EKİM,KASIM");
            }
            else
            {
                Console.WriteLine("Böyle bir mevsim yok!");
            }
            /*
             Ekrandan suyun sicakligini alin. Ve Kati ,sivi ,Gaz halini belirleyin
             */

            /*
             Girilen bir tam sayinin kaç basamakli oldugunu ekrana yaziniz.
             
             */

            #endregion


        }
    }
}