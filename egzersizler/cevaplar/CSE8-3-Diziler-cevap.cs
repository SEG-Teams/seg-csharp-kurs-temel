using System;
using System.Collections.Generic;
using System.Linq;

namespace SEG_Example_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //CSE8-3 Dizi icerisindeki en buyuk uc pozitif sayiyi bulma
            int[] sayilar = { 7, 3, 9, 13, 13, 5, 6, 14, 2 };

            //Yukarida verilen diziyi kullanarak icinde bulunan en buyuk 3 sayiyi
            //bulup terminale yazdirin
            //Bu ornegi cozmenin diger orneklerde oldugu gibi birden fazla yolu var
            //onemli olan dogru sonucu elde edebilmek
            //buldugunuz sonuc 14,13,9 olmali
            
            //Cozum 1
            //dizinin icerisindeki sayilari dongu kullanarak tek tek
            //kiyaslayacagiz

            //En buyuk 3 sayiyi tutacak dizimizi olusturuyoruz
            int[] enBuyukUcSayi = new int[3]{0,0,0};

            //sayilari birbirini tekrar etmemesi icin duzenlememiz gerekiyor
            //yoksa en buyuk iki ya da uc sayi da birbirinin aynisi olabilir
            sayilar = sayilar.Distinct().ToArray();
            for (int i = 0; i < sayilar.Length; i++)
            {
                //olusturdugumuz en buyuk uc sayi dizisinin elemanlariyla kiyasliyoruz 
                for (int j = 0; j < enBuyukUcSayi.Length; j++)
                {
                    if(enBuyukUcSayi[j] < sayilar[i]){
                        //eger en buyuk uc sayi dizisindeki sayilardan birinden buyukse
                        //o sayinin uzerine yaziyoruz ve bu donguyu 
                        //ayni sayiyi birden fazla kez yazmamak icin break ile bitiriyoruz
                        enBuyukUcSayi[j] = sayilar[i];

                        //diziyi tekrardan siraliyoruz ki her zaman en kucuk sayinin uzerine yazsin
                        enBuyukUcSayi = enBuyukUcSayi.OrderBy(x=>x).ToArray();
                        break;
                    }
                }
            }

            Console.WriteLine("Cozum bir - en buyuk uc sayi:");
            //En buyuk uc sayiyi terminale yazdirma
            for (int i = 0; i < enBuyukUcSayi.Length; i++)
            {
                Console.Write(" " + enBuyukUcSayi[i]);
            }
            
            //Cozum 2
            //Diziyi buyukten kucuge siralayarak ilk uc elemani almak

            //En buyuk 3 sayiyi tutacak dizimizi olusturuyoruz
            int[] enBuyukUcSayiIki = new int[3]{0,0,0};

            //sayilari tekrardan arindirip buyukten kucuge olacak sekilde siraliyoruz
            sayilar = sayilar.Distinct().OrderByDescending(x=>x).ToArray();

            //sayilar dizisindeki en buyuk uc sayiyi kendi dizimize aktariyoruz
            for (int i = 0; i < enBuyukUcSayiIki.Length; i++)
            {
                enBuyukUcSayiIki[i] = sayilar[i];
            }

            Console.WriteLine("\n\nCozum iki - en buyuk uc sayi:");
            //En buyuk uc sayiyi terminale yazdirma
            for (int i = 0; i < enBuyukUcSayiIki.Length; i++)
            {
                Console.Write(" " + enBuyukUcSayiIki[i]);
            }
        }
    }
}