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

            //Cozum - Her boyut icin bir dongu kullanarak matrixi terminale yazdirma isleminde
            //yaptigimizi bu sefer satirdaki elemanlari toplayip 
            //Satir ve sutun lari icin iki donguyu ic ice kullanip, satirdaki elemanlari bir
            //degiskende toplayarak yeni bir diziye atayacagiz

            //dizimizin boyutunu iki boyutlu dizinin satir sayisi 
            //olacak sekilde ayarliyoruz
            int[] tekBoyutluDizi = new int[ikiBoyutluDizi.GetLength(0)];

            //satirlarda dolasmak icin ilk dongu
            for (int i = 0; i < ikiBoyutluDizi.GetLength(0); i++)
            {
                //her satirda toplam degeri sifirliyoruz
                int satirToplami = 0;

                //satir icerisinde sutunlarda dolasmak icin ikinci dongu
                for (int j = 0; j < ikiBoyutluDizi.GetLength(1); j++)
                {
                    satirToplami += ikiBoyutluDizi[i,j];
                }

                //tek boyutlu dizimize satir toplamini atiyoruz
                tekBoyutluDizi[i] = satirToplami;
            }

            //tek boyutlu dizimizi ekrana yazdiralim
            Console.WriteLine("Satirlarin toplanmis hali:");
            for (int i = 0; i < tekBoyutluDizi.Length; i++)
            {
                Console.WriteLine(tekBoyutluDizi[i]);
            }
        }
    }
}