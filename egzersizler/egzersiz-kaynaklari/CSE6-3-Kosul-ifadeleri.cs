using System;

namespace SEG_Example_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bu egzersizle ilgili kodlarinizi asagida belirtilen
            //egzersiz kodu baslangici ve bitisi yorumlarinin
            //arasina yazin, oncesindeki kisim hazir bir sekilde verildi

            int ucgenIcAciBir = 0;
            int ucgenIcAciIki = 0;
            int ucgenIcAciUc = 0;

            //kullanicidan sayi girdisi alma
            Console.WriteLine("Lutfen ucgenin birinci ic acisini giriniz.");
            string kullanicidanAlinanGirdi = Console.ReadLine();

            //stringleri tam sayiya cevirmek icin
            //int.Parse ya da int.TryParse kullaniyoruz
            //bu methodun icine stringimizi ve tam sayi degiskenimizi veriyoruz
            //tam sayi degiskenimize stringin sayiya cevrilmis halini atiyor
            Int32.TryParse(kullanicidanAlinanGirdi, out ucgenIcAciBir);

            //kullanicidan tam sayi girdisi alma
            Console.WriteLine("Lutfen ucgenin ikinci ic acisini giriniz.");
            kullanicidanAlinanGirdi = Console.ReadLine();
            //alinan yazi turundeki girdiyi tam sayiya cevirme
            int.TryParse(kullanicidanAlinanGirdi, out ucgenIcAciIki);

            //kullanicidan tam sayi girdisi alma
            Console.WriteLine("Lutfen ucgenin ucuncu ve son ic acisini giriniz.");
            kullanicidanAlinanGirdi = Console.ReadLine();
            //alinan yazi turundeki girdiyi tam sayiya cevirme
            int.TryParse(kullanicidanAlinanGirdi, out ucgenIcAciUc);

            
            //egzersiz kodu baslangici

            //bu satirin altindaki satirlarda kullanicidan alinan 3 ic acinin once
            //sifira esit olmadigini kontrol edip, eger sifir olan varsa terminale
            //uyari yazdirin

            //bu kisimda eger acilardan hicbiri sifir degilse uc ic acinin toplaminin
            //180e esit olup olmadigina bakin
            //esitse bunun bir ucgene ait oldugunu degilse bunun bir ucgene ait olmadigina
            //dair terminale bilgilendirmek icin yazi yazdirin

            //egzersiz kodu bitisi
        }
    }
}
