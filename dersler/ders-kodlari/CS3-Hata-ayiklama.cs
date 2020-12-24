using System;

namespace SEG_Example_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Terminale yazi yazdirma
            Console.WriteLine("SEG Ekibi CS2 Degisken Turleri - Tarih: 23.12.2020");

            Console.WriteLin("SEG Ekibi CSharp Temel Ilk Ders - Tarih: 23.12.2020");

            ////String (yazi) degiskeni
            string ekipIsmi = "SEG Ekibi";
            string tarihYazisi = "Tarih: 23.12.2020";

            Console.WriteLine(ekipIsmi + " CS2 Degisken Turleri - " + tarihYazisi;

            Console.WriteLine(ekipIsmi + " CSharp Temel Ilk Ders - " + tarihYazisi)

            //Integer (tam sayi) degiskenler
            //Hayali karakter
            string karakterIsmi = "Ziya";
            int karakterYasi = 25;

            Console.WriteLine(karakterIsmi + " " + karakterYasi + " yasinda. " + tarihYazisi);

            Console.WriteLine(karakterIsmi + " yasini 5 yas buyuk soyluyor. Soyledigi yas:" + (karakterYasi + 5));
            
            karakterYasi = karakterYasi + 3; //3 yil sonraki yasi
            Console.WriteLine(karakterIsi + " 3 yil sonra " + karakterYasi + " yasinda olacak.");
            Console.WriteLine("Beklediğimiz yaş: 28");

            karakterYasi = karakterYasi + 5; //5 yil sonraki yasi
            Console.WriteLine(karakterIsmi + " 5 yil sonra " + karakterYasi + " yasinda olacak.");
            Console.WriteLine("Beklediğimiz yaş: 30");

            //Boolean (Mantiksal) Degisken
            //bool dogru (true) ya da yanlis (false) bilgisini tutar
            bool karakterCocukMu = false;
            bool karakterYetiskinMi = tru;

            //Float (noktali sayi) Degiskeni
            float yercekimiIvmesi = 9.18;
        }
    }
}