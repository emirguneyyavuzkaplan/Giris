using System;

namespace SwitchCase
{
    internal class Program
    {  /*
         * SWITCH - CASE
         * IF-Else mantigiyle calisan bir kontrol mekanizmasidir. Aradaki fark, if-else yapisi buyukluk-kucukluk gibi durumlari kontrol ederken,
         * switch-case yalnizca esitlik durumlarini kontrol edebilen karar yapimizdir.. Kendisine ait bir index mekanizmasi ile kosullari algilar, 
         * siraya koyar ve otomatik olarak yuzlerce kosulunuz olsa bile herbirine bakmadan hangisine uydugunu bulabilir. Bu da performansı direktman etkiler...
         * Switch blogu icerisine yazdiginiz veri tipiniz ne ise, case (durum) olarak belirttiginiz tum veriler de ayni veri tipinde olmalıdır!
         * break => Kosul saglandi, artik karar yapisindan kendini disari atabilirsin mesajini sisteme verir...
         */
        static void Main(string[] args)
        {

            #region Ornek 1
            string plaka = "";
            Console.WriteLine("Plaka Kodunu giriniz:");
            plaka = Console.ReadLine();

            if (plaka == "1" || plaka == "01")
            {
                Console.WriteLine("Adana");
            }
            else if (plaka == "2" || plaka == "02")
            {
                Console.WriteLine("Adiyaman");
            }
            else if (plaka == "3" || plaka == "03")
            {
                Console.WriteLine("Afyon");
            }
            else if (plaka == "4" || plaka == "04")
            {
                Console.WriteLine("Agri");
            }
            else if (plaka == "5" || plaka == "05")
            {
                Console.WriteLine("Amasya");
            }
            else if (plaka == "6" || plaka == "06")
            {
                Console.WriteLine("Ankara");
            }


            switch (plaka)
            {
                case "1" or "01":
                    Console.WriteLine("Adana");
                    break;
                case "2" or "02":
                    Console.WriteLine("Adiyaman");
                    break;
                case "3" or "03":
                    Console.WriteLine("Afyon");
                    break;
                case "4" or "04":
                    Console.WriteLine("Agri");
                    break;
                case "5" or "05":
                    Console.WriteLine("Amasya");
                    break;
                case "6" or "06":
                    Console.WriteLine("Anakara");
                    break;
                default:
                    break;
            }
            #endregion

            #region ornek 2
            //Eger kullanıcı "Admin","Moderator","Yonetici","CEO","Baskan" degerleri girilirse "Yönetim Paneline Yönlendiriliyorsunuz..."
            //"Uye" girilirse "Ana Sayfaya Yonlendiriliyorsunuz...";
            //Harici bir durumda "Bu Sayfayı Görme Yetkiniz Yok!";

            //Bir string metodu olan ToLower, ilgili metinsel ifadenin tamamini kucuk harfe cevirmekle yukumludur...
            Console.WriteLine("Kullanici :");
            string kullanici = Console.ReadLine();
            switch (kullanici)
            {

                case "Admin" or "ADMIN" or "admIn" or "admin":
                case "Moderator" or "Moderatör":
                case "Yönetici" or "yönetici" or "YONETICI":
                case "CEO":
                case "Başkan" or "Baskan" or "BAŞKAN":
                    Console.WriteLine("Yönetim Paneline Yönlendiriliyorsunuz...");
                    break;
                case "Uye" or "Üye" or "üye":
                    {
                        Console.WriteLine("Uye paneline yonlendiriliyorsunuz..");

                    }
                    break;
                default:
                    Console.WriteLine("Bu sayfayi gorme yetkiniz yoktur..");
                    break;
            }
            #endregion

            #region Ornek 3
            //İç içe switch kullanarak kullanıcı adını ve şifresini kontrol ediniz.eğer kullanıcı kullanıcıadını ve şifresini doğru girerse "Tebrikler, hem kullanıcı adı hemde şifreniz doğru" uyarısı
            //Kullanıcı adı doğru şifre yanlışsa "Kullanıcı adınız doğru ancak şifreniz yanlış!" uyarısı
            //kullanıcı adı yanlışsa "Kullanıcı adınızı yanlış girdiniz, şifreye bakmadım bile!" uyarusını kullanıcıya veriniz.

            //KullaniciAdi = "bilgeadam";
            //Sifre = "1234";

            Console.WriteLine("Kullanici adini giriniz:");
            string kullaniciAdi = Console.ReadLine();

            Console.WriteLine("Parola giriniz:");
            string parola = Console.ReadLine();

            switch (kullaniciAdi)
            {
                case "bilgeadam":
                    switch (parola)
                    {
                        case "12334":
                            Console.WriteLine("Kullanici Adi ve parola dogrudur");
                            break;

                        default:
                            Console.WriteLine("Kullanici Adi Dogru ,Parola Yanlistir");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Kullanici Adin yanlistir");
                    break;
            }
            #endregion

            Console.WriteLine("Hello World!");
        }
    }
}