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
            Console.WriteLine("Lutfen 0 disinda bir tam sayi giriniz.");
            string kullanicidanAlinanGirdi = Console.ReadLine();
            int sayi = 0;

            //stringleri tam sayiya cevirmek icin
            //int.Parse ya da int.TryParse kullaniyoruz
            //bu methodun icine stringimizi ve tam sayi degiskenimizi veriyoruz
            //tam sayi degiskenimize stringin sayiya cevrilmis halini atiyor
            int.TryParse(kullanicidanAlinanGirdi, out sayi);


            //egzersiz kodu baslangici

            //sayinin pozitif, negatif ya da sifira esit oldugunu bulma

            //sayinin yukarida belirtilen 3 tipten hangisine dahil
            //oldugunu bulun ve terminalde bilgilendirmek icin yazin
            if (sayi == 0)
            {
                Console.WriteLine("Girdiginiz sayi {0} sifira esit.", sayi);
            }
            else if (sayi > 0)
            {
                Console.WriteLine("Girdiginiz sayi {0} pozitif.", sayi);
            }
            else
            {
                Console.WriteLine("Girdiginiz sayi {0} negatif.", sayi);
            }


            //sayinin tek veya cift oldugunu bulma

            //kullanicidan terminalden alinan sayinin tek veya cift oldugunu kontrol edin
            //ve terminale sayinin tek ya da cift olduguna dair bilgilendirmek
            //icin bir yazi yazin
            //not:0'i cift sayi olarak kabul edelim.
            if (sayi % 2 == 0)
            {
                Console.WriteLine("Girdiginiz sayi {0} cifttir.", sayi);
            }
            else
            {
                Console.WriteLine("Girdiginiz sayi {0} tektir.", sayi);
            }

            //egzersiz kodu bitisi
        }
    }
}
