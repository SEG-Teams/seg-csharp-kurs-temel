using System;
using System.Collections.Generic;
using System.Linq;

namespace SEG_Example_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //CSE8-4 Iki boyutlu bir dizide her satiri kendi icinde toplayarak
            //tek boyuta indirme

            //Asagida size verilen iki boyutlu diziyi ic ice dongu kullanin.
            //Her satirdaki elemanlari toplayarak tek boyutlu bir diziye atayin
            int[,] ikiBoyutluDizi = new int[,]{{1,5,9,3},{2,5,7,11},{13,6,4,8}};

            //Hatirlatma: ikiBoyutluDizi.GetLength(0) ile satir sayisi, 
            //ikiBoyutluDizi.GetLength(1) ile sutun sayisi bulunuyor
            Console.WriteLine("Iki boyutlu dizi:");
            for (int i = 0; i < ikiBoyutluDizi.GetLength(0); i++)
            {
                for (int j = 0; j < ikiBoyutluDizi.GetLength(1); j++)
                {
                    Console.Write(ikiBoyutluDizi[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Cozum
            
        }
    }
}