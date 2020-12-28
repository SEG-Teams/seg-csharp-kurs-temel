using System;

namespace SEG_Example_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bu egzersizle ilgili kodlarinizi asagida belirtilen
            //egzersiz kodu baslangici ve bitisi yorumlarinin
            //arasina yazin, oncesindeki kisim hazir bir sekilde verildi

            int sayiBir = 0;
            int sayiIki = 0;
            int sayiUc = 0;

            //kullanicidan sayi girdisi alma
            Console.WriteLine("Lutfen birinci tam sayiyu giriniz.");
            string kullanicidanAlinanGirdi = Console.ReadLine();

            //stringleri tam sayiya cevirmek icin
            //int.Parse ya da int.TryParse kullaniyoruz
            //bu methodun icine stringimizi ve tam sayi degiskenimizi veriyoruz
            //tam sayi degiskenimize stringin sayiya cevrilmis halini atiyor
            int.TryParse(kullanicidanAlinanGirdi, out sayiBir);

            //kullanicidan sayi girdisi alma
            Console.WriteLine("Lutfen ikinci tam sayiyi giriniz.");
            kullanicidanAlinanGirdi = Console.ReadLine();
            //alinan yazi turundeki girdiyi tam sayiya cevirme
            int.TryParse(kullanicidanAlinanGirdi, out sayiIki);

            //kullanicidan sayi girdisi alma
            Console.WriteLine("Lutfen ucuncu tam sayiyi giriniz.");
            kullanicidanAlinanGirdi = Console.ReadLine();
            //alinan yazi turundeki girdiyi tam sayiya cevirme
            int.TryParse(kullanicidanAlinanGirdi, out sayiUc);


            //egzersiz kodu baslangici

            //bu satirin altindaki satirlarda kullanicidan alinan 3 sayidan
            //en buyugunu bulup terminal uzerinde yazdirin

            if(sayiBir < sayiIki) //sayiIki sayiBirden buyukse
            {
                if(sayiIki > sayiUc) //sayiIki hem sayiBir den hem de sayiUcten buyuk
                {
                    Console.WriteLine("Girdiginiz sayilardan en buyugu: {0}",sayiIki);
                }
                else //sayiIki sayiBirden buyukse ve sayiUc sayiIki den buyukse sayuUc en buyuk
                {
                    Console.WriteLine("Girdiginiz sayilardan en buyugu: {0}", sayiUc);
                }
            }
            else //sayiBir sayiIki den buyuktur(veya esittir ama onemi yok)
            {
                if (sayiBir > sayiUc) //sayiBir hem sayiIki den hem de sayiUcten buyuk
                {
                    Console.WriteLine("Girdiginiz sayilardan en buyugu: {0}", sayiBir);
                }
                else //sayiIki sayiBirden buyukse ve sayiUc sayiIki den buyukse sayuUc en buyuk
                {
                    Console.WriteLine("Girdiginiz sayilardan en buyugu: {0}", sayiUc);
                }
            }

            //egzersiz kodu bitisi
        }
    }
}