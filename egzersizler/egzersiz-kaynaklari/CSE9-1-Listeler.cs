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

            
            //2) Listede @ isareti bulunmayan epostalari bulup terminale yazdirin
            //Ipucu: Where() ve Contains() metodu
            

            //3) Listede @ isareti bulunmayan epostalari listeden cikarin ve bu epostalari
            //terminale yazdirin
            //Ipucu: Where() ve Contains() metodu

            //Bu asamadan sonraki islemleri sadece @ isareti bulunan epostalar ile yapin
            

            //4) @ isareti bulunan ve tekrar etmemesi icin duzenlediginiz eposta listesini
            //(yani guncel halini) siralayin ve terminale yazdirin
            //Ipucu: OrderBy() metodu (varsayilan olarak alfabetik siralama yapacaktir)
            
            
            //5) Listede '.net' ile biten epostalari bulup yazdirin
            //Ipucu: Where() ve Contains() methodu


            //6) Listede icerisinde 'testiki.org' yazan tek epostayi bulup yazdirin
            //Ipucu: FirstOrDefault() ve Contains() methodlari
            
        }
    }
}