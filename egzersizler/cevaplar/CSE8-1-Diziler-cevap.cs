using System;
using System.Collections.Generic;
using System.Linq;

namespace SEG_Example_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //CSE8-1 Dizi icerisinde verilen pozitif sayilardan en kucugunu bulma
            int[] sayilar = { 7, -3, 9, 14, 13, 5, -6, -14, 2 };

            //Cozum 1 - dongu ile

            //dizideki ilk elemani alarak varsayilan bir deger atiyoruz
            //elle bir deger atamak dizide negatif ve pozitif sayilar oldugu icin
            //hatali bir sonuca sebep olabilir
            int enKucukSayi = sayilar[0];

            //tek tek dizideki her sayiyi bizim degiskenimizdeki sayidan kucuk mu diye
            //kontrol ediyoruz, eger kucukse degiskenimize bu sayiyi atarak en kucuk sayiyi
            //degiskenimizde tutuyoruz
            for (int i = 0; i < sayilar.Length; i++)
            {
                if(enKucukSayi > sayilar[i]){
                    enKucukSayi = sayilar[i];
                }
            }

            //degiskenimizdeki degeri terminale yazdiriyoruz
            Console.WriteLine("Cozum 1 - dizideki en kucuk sayi: " + enKucukSayi);

            //Cozum 2 - Siralama ile
            
            //diziyi kucukten buyuge gidecek sekilde siraliyoruz
            sayilar = sayilar.OrderBy(x=>x).ToArray();

            //dizideki ilk yani en kucuk elemanin degerini degiskenimize atiyoruz
            int enKucukSayiIki = sayilar[0];
            
            //degiskenimizdeki degeri terminale yazdiriyoruz
            Console.WriteLine("Cozum 2 - dizideki en kucuk sayi: " + enKucukSayiIki);

            //Cozum 3 - Hazir metot kullanarak
            //diziler icin varolan en kucuk degeri bulma metodunu kullanarak tek satirda
            //en kucuk degeri bulup kendi degiskenimize atiyoruz
            int enKucukSayiUc = sayilar.Min();

            //degiskenimizdeki degeri terminale yazdiriyoruz
            Console.WriteLine("Cozum 3 - dizideki en kucuk sayi: " + enKucukSayiUc);
        }
    }
}