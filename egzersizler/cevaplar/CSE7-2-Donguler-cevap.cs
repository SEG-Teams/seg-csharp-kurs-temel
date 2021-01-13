using System;

namespace SEG_Example_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //CSE7-2 Donguler
            Console.WriteLine("Lutfen ortalamasinin bulunmasini istediginiz sayilari tek tek giriniz.");
            Console.WriteLine("Islemi sonlandirmak ve sonucu goruntulemek icin -1 degerini giriniz.");

            int toplam = 0;
            int girdiSayisi = 0;
            int ortalama = 0;
            //Dongu ile kullanicidan surekli olarak bir tam sayi alin
            //Bunun icin kullanacaginiz method onceki videolarda kullandigimiz Console.ReadLine()
            //Tam sayiyi aldiktan sonra aldiginiz girdi string turunde oldugu icin bu girdiyi int turune cevirmelisiniz
            //bunun icin CSE6-1 de kullandigimiz int.TryParse(kullanicidanAlinanGirdi, out sayi);
            //seklinde int.TryParse methodunu kullanabilirsiniz
            //kosul ifadeleri ile bu tam sayinin sifirdan buyuk esit oldugunu kontrol edin
            //Eger sifira esitse ya da buyukse bu sayiyi girilen sayilari toplamak icin kullandiginiz 'toplam' degiskene toplayin
            //ve girdiSayisi degiskeninizi bir arttirin
            //eger girilen sayi 0dan kucukse dongunuzu bitirip toplam / girdiSayisi islemi ile ortalamayi bulabilirsiniz
            //ancak buldugunuz ortalama kusuratli degil tam sayi olacaktir, bunu su an icin boyle kullanabilirsiniz
            //ortalamayi konsola yazdirarak programi bitirin
            //dikkat edilmesi gereken hata: girdiSayisi 0 sa bolme islemi hata verecektir
            bool donguyeDevamEt = true;
            while (donguyeDevamEt)
            {
                string tamSayiGirdisi = Console.ReadLine();
                int tamSayi = -1;

                //TryParse i if in icinde kullanmanin sebebi eger kullanici sayidan farkli bir deger girdiyse
                //sayiya otomatik olarak sifir degerinin atanmasi
                //Bunu yapmis olmaniz sart degil
                if (int.TryParse(tamSayiGirdisi, out tamSayi) && tamSayi >= 0)
                {
                    toplam += tamSayi; //ayni ifade 'toplam = toplam + tamsayi' seklinde yazilabilir
                    girdiSayisi++; //ayni ifade 'girdiSayisi = girdiSayisi +1' veya 'girdiSayisi +=1' seklinde yazilabilir
                }
                else
                {
                    donguyeDevamEt = false;
                }
            }

            //sonucu hesaplayarak kullaniciya gosterelim
            if (girdiSayisi != 0)
            {
                ortalama = toplam / girdiSayisi;
                Console.WriteLine("Girilen {0} tam sayinin ortalamasi: {1}'dir.", girdiSayisi, ortalama);
            }
            else
            {
                Console.WriteLine("Hic tam sayi girilmedigi icin ortalama hesaplanamadi.");
            }
        }
    }
}