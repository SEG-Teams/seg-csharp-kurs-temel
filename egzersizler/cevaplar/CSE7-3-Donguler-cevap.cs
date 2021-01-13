using System;

namespace SEG_Example_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //CSE7-3 Donguler

            //Bu egzersizin amaci donguleri kullanarak ekrana cizdirebileceginiz sekil orneklerini gormek
            //dongu kullaniminin farkli bir seklini gormek ve bu sekilleri cizmek icin analitik
            //bir sekilde dusunmek

            //baslangicta bu iki degiskene kendiniz deger atayarak egzersizi yapin
            //en  son bu girdilerin de kullanicidan alinacagi sekilde guncelleyebilirsiniz
            //cizimlerinizi farkli sembollerle buradan degistirerek deneyebilirsiniz
            //ve satirSayisi nin degerini 5 ve 7 olacak sekilde iki durumda da deneyin
            //kolonlara sembolleri yazdirirken sembollere bir bosluk da ekleyerek yazdirin
            //aksi halde ortaya cikansonuc daha karisik olacaktir.
            string sembol = "f";
            int satirSayisi = 7;

            //Tum sekilleri ic ice gecmis (cok katmanli) donguler (nested loops)
            //kullanarak cizdirebilirsiniz

            //Bu egzersizdeki cevap kodunun disinda bircok farkli versiyonla istenilen
            //sekiller cizilebilir (bircok programda oldugu gibi). 
            //Sizin yazdiginiz kodun bu kodla ayni olmasina gerek yok.
            //Onemli olan sekilleri istenilen rakamlar icin cizdirebilmis olmaniz.

            Console.WriteLine("\n1)Sola dayanmis dik ucgen:\n");
            //1 numarali sekli cizdirmek icin kodu buraya yazin

            //int i is the current row
            //int j is inline characters
            for (int i = 0; i < satirSayisi; i++)
            {
                //second for loop that control inline characters
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" " + sembol);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n2)Saga dayanmis dik ucgen:\n");
            //2 numarali sekli cizdirmek icin kodu buraya yazin
            for (int i = 0; i < satirSayisi; i++)
            {
                for (int s = 0; s < satirSayisi - i - 1; s++)
                {
                    string space = new string(' ', sembol.Length + 1);
                    Console.Write(space);
                }

                //second for loop that control inline characters
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" " + sembol);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n3)Yukari ikizkenar ucgen:\n");
            //3 numarali sekli cizdirmek icin kodu buraya yazin

            //int i is the current row
            //int s is the speace satirSayisi based on row
            //int j is the sembol satirSayisi based on row
            for (int i = 0; i < satirSayisi; i++)
            {
                //inline space characters
                for (int s = 0; s < satirSayisi - i - 1; s++)
                {
                    string space = new string(' ', sembol.Length + 1);
                    Console.Write(space);
                }

                //second for loop that control inline character=s
                for (int j = 0; j < (2 * (i + 1) - 1); j++)
                {
                    Console.Write(" " + sembol);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n4)Asagi ikizkenar ucgen:\n");
            //4 numarali sekli cizdirmek icin kodu buraya yazin

            //int i is the current row
            //int s is the speace satirSayisi based on row
            //int j is the sembol satirSayisi based on row
            for (int i = 0; i < satirSayisi; i++)
            {
                //inline space characters
                //first row 0, second 1, last row 2
                for (int s = 0; s < i; s++)
                {
                    string space = new string(' ', sembol.Length + 1);
                    Console.Write(space);
                }

                //second for loop that control inline characters
                for (int j = 0; j < ((satirSayisi * 2) - 1) - (2 * i); j++)
                {
                    Console.Write(" " + sembol);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n5)Sola dayanmis ikizkenar ucgen:\n");
            //5 numarali sekli cizdirmek icin kodu buraya yazin

            //int i is the current row
            //int j is the inline character satirSayisi
            for (int i = 0; i < satirSayisi; i++)
            {
                //second for loop that control inline characters
                if (i < (satirSayisi + 1) / 2)
                {
                    for (int j = 0; j < i + 1; j++)
                    {
                        Console.Write(sembol + " ");
                    }
                }
                else
                {
                    for (int j = 0; j < satirSayisi - i; j++)
                    {
                        Console.Write(sembol + " ");
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine("\n6)Saga dayanmis ikizkenar ucgen:\n");
            //6 numarali sekli cizdirmek icin kodu buraya yazin

            //int i is the current row
            //int j is the inline character satirSayisi
            //int s is the inline space satirSayisi
            //first row space is 2, second 1, third 0,fourth 1, fifth 2
            for (int i = 0; i < satirSayisi; i++)
            {
                //second for loop that control inline characters
                if (i < (satirSayisi + 1) / 2)
                {
                    for (int s = 0; s < (satirSayisi / 2) - i; s++)
                    {
                        string space = new string(' ', sembol.Length + 1);
                        Console.Write(space);
                    }
                    for (int j = 0; j < i + 1; j++)
                    {
                        Console.Write(sembol + " ");
                    }
                }
                else
                {
                    for (int s = 0; s < i - (satirSayisi / 2); s++)
                    {
                        string space = new string(' ', sembol.Length + 1);
                        Console.Write(space);
                    }
                    for (int j = 0; j < satirSayisi - i; j++)
                    {
                        Console.Write(sembol + " ");
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine("\n7)45 derece dondurulmus kare:\n");
            //7 numarali sekli cizdirmek icin kodu buraya yazin

            //int i is the current row
            //int j is the inline character satirSayisi
            //int s is the inline space satirSayisi
            //first row space is 2, second 1, third 0,fourth 1, fifth 2
            for (int i = 0; i < satirSayisi; i++)
            {
                //second for loop that control inline characters
                if (i < (satirSayisi + 1) / 2)
                {
                    for (int s = 0; s < (satirSayisi / 2) - i; s++)
                    {
                        string space = new string(' ', sembol.Length + 1);
                        Console.Write(space);
                    }
                    for (int j = 0; j < (2 * i + 1); j++)
                    {
                        Console.Write(sembol + " ");
                    }
                }
                else
                {
                    for (int s = 0; s < i - (satirSayisi / 2); s++)
                    {
                        string space = new string(' ', sembol.Length + 1);
                        Console.Write(space);
                    }
                    for (int j = 0; j < ((satirSayisi * 2) + 1) - (2 * (i+1)); j++)
                    {
                        Console.Write(sembol + " ");
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine("Press any key to close the program.");
            Console.ReadKey();
        }
    }
}