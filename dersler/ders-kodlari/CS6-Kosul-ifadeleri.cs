using System;

namespace SEG_Example_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //CS6 Kosullar
            int birinciSayi = 7;
            int ikinciSayi = 6;
            int ucuncuSayi = 8;
            bool dogruMu = birinciSayi <= ikinciSayi;

            //> buyuktur, < kucuktur
            //>= buyuk esittir, <= kucuk esittir
            //== esittir (atama operatoru olan =)

            //< operatorunun tersi >=
            //> operatorunun tersi <=
            //== operatorunun tersi !=

            //kontrol eder, yanlissa bir sonraki kosula gecer
            //dogruysa icindeki kodu calistirir
            //if, else if, else kisimlarindan biri calistirildiginda 
            //bagli kosullarin icleri calistirilmadan devam edilir
            //yani if kosulu dogruysa ve kodun ici calistirilirsa
            //else if ve else e hic bakilmadan cikilir
            if (birinciSayi < ikinciSayi)
            {
                Console.WriteLine("{0} kucuktur {1}!", birinciSayi, ikinciSayi);
            }
            else if (birinciSayi == ikinciSayi)
            {
                Console.WriteLine("{0} esittir {1}!", birinciSayi, ikinciSayi);
            }
            else
            {
                Console.WriteLine("{0} esittir {1}!", birinciSayi, ikinciSayi);
            }
            Console.WriteLine();

            //&& ve
            //|| veya
            //kontrol edilmeye parantez iclerinden baslanir
            //ve soldan saga dogru kontrol edilir
            if (birinciSayi == ikinciSayi && ikinciSayi == ucuncuSayi)
            {
                Console.WriteLine("Tum sayilar birbirine esit!");
            }
            else if (birinciSayi == ikinciSayi || ikinciSayi == ucuncuSayi || birinciSayi == ucuncuSayi)
            {
                Console.WriteLine("Sayilardan biri birbirine esit.");
            }
            else
            {
                Console.WriteLine("Sayilardan hícbiri birbirine esit degil!");
            }

            //dogru veya yanlis veya yanlis = dogru
            //yanlis veya yanlis veya yanlis = yanlis

            //dogru ve dogru ve dogru = dogru
            //dogru ve dogru ve yanlis = yanlis

            //if(!(sayi1 > sayi2)) = if(sayi1 <= sayi2)
            //if(!(sayi1 <= sayi2)) = if(sayi1 > sayi2)
            //if(!(sayi1 < sayi2 && sayi2 < sayi3)) = if(sayi1 >= sayi2 || sayi2 >= sayi3)

            //if(!dogru degilse) = if(!false) = if(true)

            Console.WriteLine();
            if (!(birinciSayi == ikinciSayi || ikinciSayi == ucuncuSayi 
                || birinciSayi == ucuncuSayi))
            {
                Console.WriteLine("Sayilardan hicbiri birbirine esit degil!\n");
            }

            int tekSayi = 107;
            int ciftSayi = 124;
            //bir sayi cift mi tek mi bulalim
            //bir sayinin mod 2 sinden kalan 0 sa cifttir
            //degilse tektir
            if(ciftSayi % 2 == 0)
            {
                Console.WriteLine("Cift sayi!");
            }
            else
            {
                Console.WriteLine("Tek sayi!");
            }

            //Part 2
            //stringler ile kosullu kodlama
            string epostaBir = "eposta1.haYali@SegTeams.com ";
            string epostaIki = " hayali@Segteams.com  ";
            string isim = "Hayali";

            //stringlerle calismak icin hazirlik
            epostaBir = epostaBir.Trim().ToLower();
            epostaIki = epostaIki.Trim().ToLower();
            isim = isim.Trim().ToLower();

            //iki stringin birbirine esitligi
            if (string.Equals(epostaBir, epostaIki))
            {
                Console.WriteLine("Epostalar ayni!");
            }
            else
            {
                Console.WriteLine("Epostalar farkli!");
            }

            //stringin icerisinde karakter ya da kelime geciyor mu kontrolu
            if (epostaBir.Contains(isim))
            {
                Console.WriteLine("Kullanici {0} eposta adresi {1}", isim, epostaBir);
            }
            else if (epostaIki.Contains(isim))
            {
                Console.WriteLine("Kullanici {0} eposta adresi {1}", isim, epostaIki);
            }
            
            Console.WriteLine("\nTest icin yazi giriniz.");
            string input = Console.ReadLine();

            //string bos mu ya da bosluklardan mi olusuyor kontrolu
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Lutfen uygun bir icerik giriniz.");
                input = Console.ReadLine();
            }
        }
    }
}