using System;

namespace SEG_Example_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //CSE7-1 Donguler

            //Donguleri kullanarak kullanicidan bir tam sayi alin ve bu sayinin tek olup olmadigini dogrulayin
            //Eger kullanicinin girdigi tam sayi 0 dan buyuk degilse veya tek degilse kullanicidan
            //tekrar girdi isteyin. Bu islemi kullanici istenilen kritere uygun sayi girene kadar surdurun
            //ve istenilen kritere uygun girdi girildiginde konsola bir mesaj yazarak uygulamayi sonlandirin.

            int tekSayi = 1;
            bool tamSayiIstenilenKritereUygun = false;
            if (!tamSayiIstenilenKritereUygun)
            {
                Console.WriteLine("Lutfen sifirdan buyuk ve tek bir tam sayi giriniz.");
                string tamSayiGirdisi = Console.ReadLine();
                int tamSayi = 0;

                int.TryParse(tamSayiGirdisi, out tamSayi);
                if(tamSayi > 0 && tamSayi % 2 == 1)
                {
                    tekSayi = tamSayi;
                    tamSayiIstenilenKritereUygun = true;
                }
            }

            Console.WriteLine("Girmis oldugunuz tek sayi: {0}", tekSayi);
        }
    }
}