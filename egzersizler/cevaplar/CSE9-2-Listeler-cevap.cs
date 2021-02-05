using System;
using System.Collections.Generic;
using System.Linq;

namespace SEG_Example_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //CSE9-2 Listeler
            //Bu egzersizde size verilmis olan listeyi kullanarak asagida 
            //bu liste uzerinden istenilen degerleri bulmak icin gerekli
            //islemleri yapmalisiniz
            List<int> duzenlenmemisTamSayilarBir = new List<int>()
                {3,6,7,11,4,5,7,12,8,14,19,21,23,37,28,32,14,17,21};

            List<int> duzenlenmemisTamSayilarIki = new List<int>()
                {37,28,32,14,15,20,41,42,50,62,47,45,29,32,36};


            //Ipucu: Listelerde Linq methodu kullandiktan sonra ToList() methodunu kullanarak
            //dondurulen tur hatasini cozebilirsiniz

            //1) Listeleri icerisindeki degerler tekrar etmeyecek sekilde
            //guncelleyin ve terminale yazdirin
            //Sonraki asamalarda da guncellediginiz listeleri kullanin
            //Ipucu: Distinct() metodu
            List<int> duzenlenmisTamSayilarBir = duzenlenmemisTamSayilarBir.Distinct().ToList();
            List<int> duzenlenmisTamSayilarIki = duzenlenmemisTamSayilarIki.Distinct().ToList();

            Console.WriteLine("Birinci listenin duzenlenmis hali:");
            for (int i = 0; i < duzenlenmisTamSayilarBir.Count; i++)
            {
                Console.WriteLine(duzenlenmisTamSayilarBir[i]);
            }

            Console.WriteLine("Ikinci listenin duzenlenmis hali:");
            for (int i = 0; i < duzenlenmisTamSayilarIki.Count; i++)
            {
                Console.WriteLine(duzenlenmisTamSayilarIki[i]);
            }

            //2) Birinci listeyi kucukten buyuge, 
            //ikinci listeyi buyukten kucuge siralayarak guncelleyin
            //ve terminale yazdirin
            //sonraki asamalarda da guncellenmis listeleri kullanin
            //Ipucu: OrderBy() ve OrderByDescending metotlari
            duzenlenmisTamSayilarBir = duzenlenmisTamSayilarBir.OrderBy(x=>x).ToList();
            duzenlenmisTamSayilarIki = duzenlenmisTamSayilarIki.OrderByDescending(x=>x).ToList();

            Console.WriteLine("Birinci listenin kucuktan buyuge siralanmis hali:");
            for (int i = 0; i < duzenlenmisTamSayilarBir.Count; i++)
            {
                Console.WriteLine(duzenlenmisTamSayilarBir[i]);
            }

            Console.WriteLine("Ikinci listenin buyukten kucuge siralanmis hali:");
            for (int i = 0; i < duzenlenmisTamSayilarIki.Count; i++)
            {
                Console.WriteLine(duzenlenmisTamSayilarIki[i]);
            }


            //3) Iki listede de bulunan ortak elemanlari bulup
            //terminale yazdirin
            //Ipucu: Intersect() metodu
            List<int> ortakSayilar = 
                duzenlenmisTamSayilarBir.Intersect(duzenlenmisTamSayilarIki).ToList();
            Console.WriteLine("Iki listede bulunan ortak elemanlar:");
            for (int i = 0; i < ortakSayilar.Count; i++)
            {
                Console.WriteLine(ortakSayilar[i]);
            }
        }
    }
}