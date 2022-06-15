using System;
using System.IO;
using System.Text;

namespace System_IO // System Input/Output Kutuphanesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DriveInfo => bilgisayarinizdaki surucu bilgilerine erisim imkani verir
            DriveInfo[] driveInfos = DriveInfo.GetDrives();

            foreach (var drive in driveInfos)
            {
                Console.WriteLine(drive.Name);
                Console.WriteLine(drive.TotalSize);
                Console.WriteLine(drive.DriveType);
                Console.WriteLine(drive.TotalFreeSpace);
                Console.WriteLine(drive.DriveFormat);
                Console.WriteLine(drive.IsReady);
            }

            //DirectoryInfo => Suruculerdeki Klasor'leri Verir


            //if (!Directory.Exists(@"c:\BenimKlasorum"))
            //{
            //    Directory.CreateDirectory(@"c:\BenimKlasorum");

            //}

            //string[] dirs = Directory.GetDirectories(@"c:\");

            //foreach (var item in dirs)
            //{
            //    Console.WriteLine(item);
            //}


            DosyaOlustur();


            //Console.WriteLine("Hello World!");
        }

        private static void DosyaOlustur()
        {
            //File:Statik bir dosya kontrol sınıfıdır.Directory ile aynı methodlara sahip olmasına ragmen file=>dosyalarda kullanılır.Directory ise klasörlerde. 


            //Dosya Oluşturma.Bu işlem dosyayı yazmaya yarayan FileStream Sınıfı ile yapılabilir.
            FileStream fi = File.Create(@"c:\BenimKlasorum\test.txt");



            Byte[] buffer = new UTF8Encoding(true).GetBytes(@"File:Statik bir dosya kontrol sınıfıdır.Directory ile aynı methodlara sahip olmasına ragmen file=>dosyalarda kullanılır.Directory ise klasörlerde. "); //Dışarıdan oluşturdugumuz yazıyı GetBytes ile asci kodları haline dönüştürüyoruz ve bir byte dizisine atıyoruz.burada kullandıgımız UTF8Encoding(true) ile Türkçe karakterlere destek versin diye kullanıyoruz.


            fi.Write(buffer);
            fi.Close(); //yapılan yazma işlemi yada oluşturma işlemi kapatılmalıdır.Yoksa yazılma işlemi yapılmıyor. 



            //Dosya Okumak icin 
            File.ReadAllText(@"c:\BenimKlasorum\test.txt");

            //Dosya Silmek icin
            // File.Delete(@"c:\BenimKlasorum\test.txt");
        }
    }
}