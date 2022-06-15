using System;

namespace tryCatch
{
    internal class Program
    {      /*
          * ISTISNA TIPLERI
          * 
          * Calisma Zamani Hataları (Runtime Exception) => Cogunlukla kullanici kaynakli hatalardir. (Verinin yanlis, eksik ya da bos girilmesi). Cozum Yolu, try-catch ile hatalari ele alabilirsiniz...
          * 
          * Derleme Zamani Hatalari (Compile Exception) => Tamamen yazilimci kaynakli hatalardir. Yazim hatalari meydana geldiginde devreye girer. En kolay cozulen hata tipidir. Visual Studio sizi uyarir (asagidaki Error List penceresi ile). Ilgili hataya cift tiklayip detaya gidebilir ve hatayi aninda duzeltebilirsiniz...
          * 
          * Mantiksal Hatalar => Tamamen programci kaynakli hatalardir. Uygulamanin algoritmasinda meydana gelir. Ornegin bolme yapilacak yerde islem unutulmasi, degerin yanlis bir degerle degistirilmesi... Cozulmesi en zor hatalardir. Anlik olarak derleme asamasini takip etmeli ve degerlerinizi gozlemlemelisiniz. Bu konuda Visual Studio size sagladigi tool'larla yardimci olur. (Immediate Window, Watch, Breakpoint)
          */

        /*
         * BREAKPOINT => Derleme asamasina adim adim dahil olmak icin kullandigimiz yardimci tool'dur. Yapmaniz gereken tek sey, hangi satirdan derleme anina dahil olmak istiyorsaniz, ilgili satirin en sol kismina gelip (gri alan) mouse'un sol tusuyla bir kırmızı top yerlestirmek. Artik derleyici bu satira geldigi zaman sizi olaya dahil edecektir...
         * F11 ile adim ilerleyebilirsiniz. Degiskenlerin, nesnelerin uzerine gelip o anki degerlerini ogrenebilirsiniz, islemin bittigine inanıyorsaniz F5'e basip breakpoint'ten cikabilir ve islemin kendisini devam ettirmesini saglayabilirsiniz.
         * Sol blokta cikan sari ok, derlenen satirin isaretcisidir. Mouse yardimiyla ileri ya da geri oynatabilir yani adimlari atlayabilir ya da tekrarlatabilirsiniz...
         */

        /*
         * WATCH
         * Yalnizca run-time'da - calisma zamani - kullanabilecegimiz bir tool'dur. Dolayisiyla pencereyi sadece calisma zamaninda gorursunuz...
         * İlk ayarlarinizda Watch penceresi kapali olabilir. Uygulamanizi calistirip "CTRL+ALT+W" ardindan 1'e basarsaniz Watch penceresini getirirsiniz...
         * Run-time'de elinizde olan degerleri (kontrol degerler, degisken degerleri) degistirmenize, izlemenize olanak saglayan yardimci tool'dur. Acilan penceredeki "Name" alanina ilgili degiskenin adini yazip Enter'a basarsaniz, "Value" alaninda o anki degerini gozlemleyebilirsiniz. Hatta degistirebilirsiniz...
         * "Name" alanina degeri ilk yazmaya basladiginizda intellisense size destek vermez. Ancak "CTRL+Space" kombinasyonu ile intellisense'i aktif hale getirebilirsiniz. Hatta cogu zaman kendisi otomatik olarak tamamlar. 
         * Noktalar, virgüller, noktali virgüller - yani tum yazim kurallari - watch penceresi icin de gecerlidir...
         */

        //Eger disaridan bir veri aliyorsaniz, verinin tutarligindan emin de degilseniz, orada mutlaka hata riski vardır!

        static void Main(string[] args)
        {
            //5321112233,05322223366,905425556677,+90
            //Console.Write("Telefon Numarası: ");
            //int gelenDeger = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Tebrikler! Doğru telefon formatı girdiniz!");

            #region ornek1
            //try
            //{
            //    //Bu alana hata riski olan kodlar yazilir...
            //    Console.Write("Telefon Numarası: ");
            //    int gelenDeger = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Tebrikler! Doğru telefon formatı girdiniz!");
            //}
            //catch
            //{
            //    //Try blogu icerisine yazmis oldugunuz kodlarda herhangi bir hata meydana gelirse, catch blogu devreye girer...
            //    Console.WriteLine("Telefon numarası yazmayı bile beceremedin!");
            //}
            #endregion
            #region ornek 2
            //try
            //{
            //    Console.Write("Telefon Numarası: ");
            //    int gelenDeger = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Tebrikler! Doğru formatı girdiniz!");
            //}
            //catch (Exception hata)
            //{
            //    //catch ifadesinin yanindaki "Exception"ın kelime anlami => Istisna..
            //    //Uygulamanizin kararligini bozan istisnai durumla ilgili size detaylari teslim eden nesnedir...
            //    Console.WriteLine(hata.Message);  //Hata'nın sistem tarafindan atanan mesajini size teslim eder...
            //}
            #endregion

            #region Ornek 3
            //int sayi1, sayi2;
            //float sonuc;
            //try
            //{
            //    Console.Write("1.Sayiyi Giriniz:");
            //    sayi1 = int.Parse(Console.ReadLine());


            //    Console.Write("2.Sayiyi Giriniz:");
            //    sayi2 = int.Parse(Console.ReadLine());

            //    sonuc = sayi1 / sayi2;
            //    Console.WriteLine("Sonuc:" + sonuc);

            //}

            //catch (OverflowException ex)
            //{
            //    Console.WriteLine("Girilen Sayi int tipine sigmiyor.Daha kucuk bir sayi giriniz");
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Sifira bolme Hatasi");
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Düzgün veri giriniz.. Girdiginiz veri sayisal degil");
            //}
            //catch (Exception ex)
            //{
            //    //Input string was not in a correct format.
            //    //Attempted to divide by zero.
            //    //Value was either too large or too small for an Int32
            //    Console.WriteLine("Hata Olustu:" + ex.Message);
            //}


            #endregion


            #region Ornek 4

            DateTime dogumTarihi;
            string input;
            try
            {
                Console.Write("Dogum Tarihini Giriniz:");
                input = Console.ReadLine();
                dogumTarihi = DateTime.Parse(input);
                Console.WriteLine("Dogum Tarihiniz:" + dogumTarihi.ToString());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Girilen deger dogru formatta degil");
            }

            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


            #endregion
            Console.ReadLine();
        }
    }
}