using System;

namespace SEG_Example_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //CS8 Diziler (Array)
            string[] otomobilMarkalariBir = { "Volvo", "Mazda", "BMW", "Mazda", "Ford" };

            string[] otomobilMarkalariIki;
            otomobilMarkalariIki = new string[] { "Volvo", "Mazda", "BMW", "Mazda", "Ford" };

            int[] asalSayilarBir = { 2, 3, 5, 7, 11, 5, 5, 11, 7 };

            int[] asalSayilarIki;
            asalSayilarIki = new int[] { 2, 3, 5, 7, 11, 5 };

            //Sabit buyukluklu dizi tanimlama
            string[] sabitOtomobilMarkalariBir =
                new string[5] { "Volvo", "Mazda", "BMW", "Mazda", "Ford" };
            string[] sabitOtomobilMarkalariIki = new string[5];

            //Dongu icerisinde kullanma
            Console.WriteLine("For dongusu icerisinde dizi yazdirma.");
            for (int i = 0; i < otomobilMarkalariBir.Length; i++)
            {
                Console.WriteLine(otomobilMarkalariBir[i]);
            }

            //foreach dongusu icerisinde dizi kullanma
            Console.WriteLine("\nForeach dongusu icerisinde dizi yazdirma.");
            foreach (var marka in otomobilMarkalariBir)
            {
                Console.WriteLine(marka);
            }

            //Diziyi tersine cevirme
            Console.WriteLine("\nDizinin en bastaki halinin tersine cevirilmis hali.");
            Array.Reverse(otomobilMarkalariBir);
            for (int i = 0; i < otomobilMarkalariBir.Length; i++)
            {
                Console.WriteLine(otomobilMarkalariBir[i]);
            }

            //Diziyi siralama
            Console.WriteLine("\nDizinin siralanmis hali.");
            Array.Sort(otomobilMarkalariBir);
            for (int i = 0; i < otomobilMarkalariBir.Length; i++)
            {
                Console.WriteLine(otomobilMarkalariBir[i]);
            }

            //Diziyi tersine cevirme
            Console.WriteLine("\nDizinin tersine cevirilmis hali.");
            Array.Reverse(otomobilMarkalariBir);
            for (int i = 0; i < otomobilMarkalariBir.Length; i++)
            {
                Console.WriteLine(otomobilMarkalariBir[i]);
            }

            //Diziyi tersine cevirme
            Console.WriteLine("\nDizinin tekrardan arindirilmis hali (her eleman ozel).");
            otomobilMarkalariBir = otomobilMarkalariBir.Distinct().ToArray();
            for (int i = 0; i < otomobilMarkalariBir.Length; i++)
            {
                Console.WriteLine(otomobilMarkalariBir[i]);
            }

            Console.WriteLine("\nAsal sayi dizisinin dongu ile yazdirilmasi.");
            for (int i = 0; i < asalSayilarBir.Length; i++)
            {
                Console.WriteLine(asalSayilarBir[i]);
            }

            Console.WriteLine("\nAsal sayi dizisinin tekrardan arindirilmis hali " +
                "(her eleman ozel).");
            asalSayilarBir = asalSayilarBir.Distinct().ToArray();
            for (int i = 0; i < asalSayilarBir.Length; i++)
            {
                Console.WriteLine(asalSayilarBir[i]);
            }

            Console.WriteLine("\nDizilerde cok kullanilan Linq kutuphaneleri.");
            Console.WriteLine("Dizimizin icerisindeki en buyuk tam sayi:" + asalSayilarBir.Max());
            int dizidekiEnBuyukTamSayi = asalSayilarBir[0];
            for (int i = 0; i < asalSayilarBir.Length; i++)
            {
                if (asalSayilarBir[i] > dizidekiEnBuyukTamSayi)
                    dizidekiEnBuyukTamSayi = asalSayilarBir[i];
            }
            Console.WriteLine("Dizimizin icerisindeki en buyuk tam sayi:" + dizidekiEnBuyukTamSayi);

            int dizidekiEnKucukTamSayi = asalSayilarBir[0];
            for (int i = 0; i < asalSayilarBir.Length; i++)
            {
                if (asalSayilarBir[i] < dizidekiEnKucukTamSayi)
                    dizidekiEnKucukTamSayi = asalSayilarBir[i];
            }
            Console.WriteLine("\nDizimizin icerisindeki en kucuk tam sayi:" 
                + dizidekiEnKucukTamSayi);
            Console.WriteLine("Dizimizin icerisindeki en kucuk tam sayi:" 
                + asalSayilarBir.Min());
            Console.WriteLine("\nDizimizin icerisindeki elemanlarin toplami:" 
                + asalSayilarBir.Sum());
            Console.WriteLine("Dizimizin icerisindeki elemanlarin ortalamasi:" 
                + asalSayilarBir.Average());

            //Iki boyutlu dizi tanimlama
            int[,] ikiBoyutluArrayBir;
            ikiBoyutluArrayBir = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

            Console.WriteLine("\nIki boyutlu diziyi for dongusu ile yazdirmak.");
            for (int i = 0; i < ikiBoyutluArrayBir.GetLength(0); i++)
            {
                for (int j = 0; j < ikiBoyutluArrayBir.GetLength(1); j++)
                {
                    Console.Write(ikiBoyutluArrayBir[i, j] + " ");
                }
                Console.WriteLine();
            }

            int[,,] ucBoyutluDiziBir = new int[4,2,3];
        }
    }
}