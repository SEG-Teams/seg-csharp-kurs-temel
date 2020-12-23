using System;

namespace SEG_Example_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Terminale yazi yazdirma
            Console.WriteLine("SEG Ekibi CS1 Degisken Turleri - Tarih: 23.12.2020");

            Console.WriteLine("SEG Ekibi CSharp Temel Ilk Ders - Tarih: 23.12.2020");

            //SIK kullanacagimiz degiskenler
            //String (yazi) degiskeni
            string ekipIsmi = "SEG Ekibi";
            string tarihYazisi = "Tarih: 23.12.2020";

            Console.WriteLine(ekipIsmi + " CS1 Ekrana Yazdirma - " + tarihYazisi);

            Console.WriteLine(ekipIsmi + " CSharp Temel Ilk Ders - " + tarihYazisi);

            //Integer (Tam sayi) degiskeni
            //Hayali karakter hakkinda yazdirma
            string karakterIsmi = "Fatih ";
            int karakterYasi = 24;

            Console.WriteLine(karakterIsmi + karakterYasi + " yasinda.");
            Console.WriteLine("Ama " + karakterIsmi + "'in gosterdigi yas: " + (karakterYasi - 10));
            Console.WriteLine("Hayata bakis acisiysa " + (karakterYasi + 20) + "yasinda birisine ait olmali.");

            //Hayali karakterimiz 3 yil sonra kac yasinda olacak
            karakterYasi = karakterYasi + 3;
            Console.WriteLine(karakterIsmi +"3 yil sonra " + karakterYasi + " yasinda olacak.");

            //Boolean (Mantiksal) Degiskeni
            //bool dogru ve yanlisi bilgisini tutar
            bool fatihCocukMu = false; 
            bool fatihYetiskinMi = true;

            //Float (noktali sayi) Degiskeni
            float yercekimiIvmesi = 9.81f;
            
        }
    }
}