using System;
using System.Collections.Generic;
using System.Linq;

namespace SEG_Example_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //CSE9-1 Listeler
            //Bu egzersizde size verilmis olan listeyi kullanarak asagida 
            //bu liste uzerinden istenilen degerleri bulmak icin gerekli
            //islemleri yapmalisiniz
            List<string> duzenlenmemisEpostalar = new List<string>()
                {"test1@test.com","test2@test.net","test3@test.com","test4@test.com",
                "test5@test.com","test9test.net","test13@test.com","test17@test.net",
                "test6@test.com","test10@test.com","test14@test.com","test18@test.com",
                "test7@test.com","test11@test.net","test5@test.com","test19test.net",
                "test8@testiki.org","test6@test.com","test16@test.com","test13@test.com"};


            //Ipucu: Listelerde Linq methodlarini kullandiktan sonra ToList() methodunu kullanarak
            //dondurulen tur hatasini cozebilirsiniz

            //1) Listede birden fazla bulunan degerleri filtreleyin
            //Ipucu: Distinct() methodu

            //Bu asamadan itibaren kullanacaginiz listede 
            //degerlerin tekrar etmemesi gerekiyor
            List<string> duzenlenmisEpostalar = duzenlenmemisEpostalar.Distinct().ToList();

            
            //2) Listede @ isareti bulunmayan epostalari bulup terminale yazdirin
            //Ipucu: Where() ve Contains() metodu
            List<string> yanlisEpostalar = 
                duzenlenmisEpostalar.Where(x=>!x.Contains("@")).ToList();

            Console.WriteLine("@ isareti bulunmayan epostalar:");
            for (int i = 0; i < yanlisEpostalar.Count; i++)
            {
                Console.WriteLine(yanlisEpostalar[i]);
            }

            //3) Listede @ isareti bulunmayan epostalari listeden cikarin ve bu epostalari
            //terminale yazdirin
            //Ipucu: Where() ve Contains() metodu

            //Bu asamadan sonraki islemleri sadece @ isareti bulunan epostalar ile yapin
            duzenlenmisEpostalar = duzenlenmisEpostalar.Where(x=>x.Contains("@")).ToList();

            Console.WriteLine("\n@ isareti bulunan epostalar:");
            for (int i = 0; i < duzenlenmisEpostalar.Count; i++)
            {
                Console.WriteLine(duzenlenmisEpostalar[i]);
            }

            //4) @ isareti bulunan ve tekrar etmemesi icin duzenlediginiz eposta listesini
            //(yani guncel halini) siralayin ve terminale yazdirin
            //Ipucu: OrderBy() metodu (varsayilan olarak alfabetik siralama yapacaktir)
            duzenlenmisEpostalar = duzenlenmisEpostalar.OrderBy(x=>x).ToList();

            Console.WriteLine("\nEposta listesinin siralanmis hali:");
            for (int i = 0; i < duzenlenmisEpostalar.Count; i++)
            {
                Console.WriteLine(duzenlenmisEpostalar[i]);
            }
            
            //5) Listede '.net' ile biten epostalari bulup yazdirin
            //Ipucu: Where() ve Contains() methodu
            List<string> netUzantiliEpostalar = 
                duzenlenmisEpostalar.Where(x=>x.Contains(".net")).ToList();

            Console.WriteLine("\n.net uzantili epostalar:");
            for (int i = 0; i < netUzantiliEpostalar.Count; i++)
            {
                Console.WriteLine(netUzantiliEpostalar[i]);
            }


            //6) Listede icerisinde 'testiki.org' yazan tek epostayi bulup yazdirin
            //Ipucu: FirstOrDefault() ve Contains() methodlari
            string testIkiEposta = 
                duzenlenmisEpostalar.FirstOrDefault(x=>x.Contains("testiki.org"));
            
            Console.WriteLine("\ntestiki.org ile biten eposta: " + testIkiEposta);


        }
    }
}