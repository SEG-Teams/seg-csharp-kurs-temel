using System;
using System.Collections.Generic;
using System.Linq;

namespace SEG_Example_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //CSE8-2 Size verilen dizi icerisindeki sayilarin 
            //asal olup olmadigini bulma ve her sayiyi terminale asal 
            //veya degil seklinde yazdirma
            int[] asalSayilar = new int[]{3,5,7,9,11,15};

            //Hatirlatma: Asal sayilar sadece 1'e ve kendilerine tam bolunen sayilardir
            //baska bir sayiya tam bolunen sayilar asal degildir

            //Hatirlatma: Tam bolunen bir sayinin kalani 0'dir

            //Hatirlatma: % mod operatoru

            //Cozum - Dizideki sayilari 2 den baslayarak kendilerine kadar
            //tum sayilara bolunup bolunmedigini test etme

            //dizideki sayilarda tek tek gitmek icin for dongusu olusturuyoruz
            for (int i = 0; i < asalSayilar.Length; i++)
            {
                int bolen = 2;
                bool sayiAsalMi = true;

                //sayinin asal olmadigini bulmadigimiz surece
                //ve sayiyi bolmeye calistigimiz sayi kendisinden kucuk oldugu surece
                //donguye devam edecegiz
                while (sayiAsalMi && asalSayilar[i] > bolen)
                {
                    //eger sayi bolene kalansiz bolunuyorsa ve bolen sayi
                    //dizideki sayiya esit degilse bu sayi asal degildir
                    //bunu bulduktan sonra donguyu break ile birakip sonucu yazdirabiliriz
                    if(asalSayilar[i] % bolen == 0 && asalSayilar[i] != bolen){
                        sayiAsalMi = false;
                        break;
                    }

                    //boleni dongunun her turunda bir arttirarak asal sayiya
                    //kadar olan tum degerleri almasini sagliyoruz
                    bolen++;
                }

                //sayinin asal olup olmadigini terminale yazdirma
                if(sayiAsalMi){
                    Console.WriteLine("{0} asal bir sayidir.",asalSayilar[i]);
                }
                else{
                    Console.WriteLine("{0} asal bir sayi degildir.",asalSayilar[i]);
                }
            }
        }
    }
}