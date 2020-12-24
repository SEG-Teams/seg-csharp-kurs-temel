using System;

namespace SEG_Example_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //aritmetik islemler yapmamizi saglayan 'operatorler'
            // toplama +, cikarma -, carpma *, bolme /
            int a = 5;
            int b = 2;

            //degiskenini tanimladik ancak deger atamadik
            //integer turundeki degiskenlerin varsayilan degeri 0'dir
            int islemSonucu; 

            //toplama
            islemSonucu = a + b;
            Console.WriteLine("5 + 2 = " + islemSonucu);

            //cikarma
            islemSonucu = a - b;
            Console.WriteLine("5 - 2 = " + islemSonucu);

            //carpma
            islemSonucu = a * b;
            Console.WriteLine("5 * 2 = " + islemSonucu);

            //bolme
            islemSonucu = a / b;
            Console.WriteLine("5 / 2 = " + islemSonucu);

            //C# 'ta islem onceligi
            //ilk oncelik matematikte oldugu gibi parantez icleridir
            //parantezlerden sonraysa aritmetik operator onceligi sirasiyla
            // * > / > +-
            islemSonucu = 2 + 3 * 7 / 5;
            Console.WriteLine("2 + 3 * 7 / 5 = 2 + "+
            "(3 * 7) / 5 = 2 + ((3 * 7) / 5) = " + islemSonucu);

            //bu islemin sonucuysa farkli bir siralamada oldugu farkli cikacaktir
            Console.WriteLine("Asagidaki islem ise farkli bir \n" +
                "siralamada yapilacagindan farkli sonuc verecektir.");
            islemSonucu = (((2 + 3) * 7) / 5);
            Console.WriteLine("(((2 + 3) * 7) / 5) = " + islemSonucu);

            //diger operatorler
            //modulo operatoru % (bir sayinin digerine bolumunden kalani verir)
            islemSonucu = a % b;
            Console.WriteLine("5 (mod 2) = " + islemSonucu);

            //C# in bize verdigi hazir matematik fonksiyonlari
            //Absolute value (mutlak deger): Math.Abs()
            islemSonucu = Math.Abs(b-a);
            Console.WriteLine("|2-5| = |-3| = " + islemSonucu);

            //Buyuk olani getir: Math.Max(tamSayiBir, tamSayiIki)
            islemSonucu = Math.Max(a, b);
            Console.WriteLine("2 ve 5 sayilarindan buyuk olani = " + islemSonucu);

            //Kucuk olani getir: Math.Min(tamSayiBir, tamSayiIki)
            islemSonucu = Math.Min(a, b);
            Console.WriteLine("2 ve 5 sayilarindan kucuk olani = " + islemSonucu);

            //Karekok: Math.Sqrt(tamSayi)
            islemSonucu = (int)Math.Sqrt(a * a);
            Console.WriteLine("25 in karekoku = " + islemSonucu);
        }
    }
}