using System;

namespace SEG_Example_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //CS7 Donguler
            //for
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            string eposta = "ziya.hayali@SegTeams.com";
            bool epostaUygunMu = false;
            if (!string.IsNullOrWhiteSpace(eposta))
            {
                if (eposta.Contains("@"))
                {
                    epostaUygunMu = true;
                }
            }

            //while
            while (!epostaUygunMu)
            {
                Console.WriteLine("While calisti");
                Console.WriteLine("Lutfen eposta adresinizi giriniz.");
                eposta = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(eposta))
                {
                    if (eposta.Contains("@"))
                    {
                        epostaUygunMu = true;
                    }
                }
            }

            //do while
            do
            {
                Console.WriteLine("Do while calisti.");
                Console.WriteLine("Lutfen eposta adresinizi giriniz.");
                eposta = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(eposta) && eposta.Contains("@"))
                {
                    epostaUygunMu = true;
                }
                else
                {
                    epostaUygunMu = false;
                }
            } while (!epostaUygunMu);

            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        if (i % 4 == 0)
                        {
                            Console.WriteLine("{0} 3,4 ve 5in kati.", i);
                            break;
                        }
                        else if (i % 2 == 0)
                        {
                            continue;
                        }

                        Console.WriteLine("{0} hem 3'un hem de 5'in kati.", i);
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("{0} 3'un kati.", i);
                    }
                    else
                    {
                        Console.WriteLine("{0} 5'un kati.", i);
                    }
                }
            }

            //nested loops
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    Console.Write(i * j + " ");
                }
                Console.Write("\n");
            }
        }
    }
}