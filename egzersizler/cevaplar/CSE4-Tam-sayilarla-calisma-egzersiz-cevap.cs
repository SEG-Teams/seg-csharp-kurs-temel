using System;

namespace SEG_Example_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //araba saatte 1 birim yakıt tüketmektedir
            //ve arabaninHizi kadar birim yol gitmektedir
            int arabaninHizi = 30; //1 saatte gittiği birim sayısı
            int gidilecekMesafe  = 180; //birim
            int depodakiYakit = 5; //birim
            int yakitTüketimi = 1; //1 saatte tükettiği yakıt miktarı
            int kalanSure = gidilecekMesafe / arabaninHizi;

            //başlangıçtaki bilgileri terminale yazdıralım
            Console.WriteLine("Başlangıçta arabanın hızı: " + arabaninHizi + " birim.");
            Console.WriteLine("Başlangıçta gidilecek mesafe: " + gidilecekMesafe + " birim.");
            Console.WriteLine("Başlangıçta depoda kalan yakıt: " + depodakiYakit + " birim.");
            Console.WriteLine("Başlangıçta arabanın varmasına kalan süre: " + kalanSure + " saat.");

            //araba bir saat sonra 20 birim daha hızlanacaktır
            //arabanın bir saat sonraki değerlerini ilgili değişkenlere
            //atayarak hesaplayın
            gidilecekMesafe = gidilecekMesafe - arabaninHizi;
            arabaninHizi = arabaninHizi + 20;
            depodakiYakit = depodakiYakit - yakitTüketimi;
            kalanSure = gidilecekMesafe / arabaninHizi;

            //1 saat sonrası için hesapladığınız yeni bilgileri terminale yazdıralım
            Console.WriteLine("Arabanın mevcut hızı: " + arabaninHizi + " birim.");
            Console.WriteLine("Doğru değer: 50 birim.");
            Console.WriteLine("Gidilecek mesafe: " + gidilecekMesafe + " birim.");
            Console.WriteLine("Doğru değer: 150 birim.");
            Console.WriteLine("Depoda kalan yakıt: " + depodakiYakit + " birim.");
            Console.WriteLine("Doğru değer: 4 birim.");
            Console.WriteLine("Arabanın varmasına kalan süre: " + kalanSure + " saat.");
            Console.WriteLine("Doğru değer: 3 birim.");
        }
    }
}