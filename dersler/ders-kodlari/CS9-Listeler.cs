using System;
using System.Collections.Generic;
using System.Linq;

namespace SEG_Example_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //CS9 Listeler
            //Liste tanimlama ve olusturma
            List<int> ciftSayilar = new List<int>(){2,4,6,8,10,12,2,6,8};
            List<string> epostaAdresleri = new List<string>(){"eposta-1@SegTeams.com","eposta-2@SegTeams.com",
            "hatali-1SegTeams.com","hatali-2@SegTeamscom","hatali-3SegTeams",
            "eposta-1@SegTeams.com","eposta-2@SegTeams.com","hatali-3SegTeams"};

            Console.WriteLine("\nListemizdeki cift sayilar:");
            foreach(var sayi in ciftSayilar){
                Console.WriteLine(sayi);
            }

            Console.WriteLine("\nListemizdeki epostalar:");
            foreach(var eposta in epostaAdresleri){
                Console.WriteLine(eposta);
            }

            List<int> tekSayilar = new List<int>();

            //Add ve Remove
            tekSayilar.Add(1);
            tekSayilar.Add(3);
            tekSayilar.Add(5);
            tekSayilar.Add(7);
            Console.WriteLine("\nTek sayilar eleman cikarilmadan oncesi:");
            foreach(var sayi in tekSayilar){
                Console.WriteLine(sayi);
            }

            tekSayilar.Remove(5);
            Console.WriteLine("\nTek sayilar eleman cikarildiktan sonra:");
            foreach(var sayi in tekSayilar){
                Console.WriteLine(sayi);
            }

            //FirstOrDefault ve LastOrDefault
            string atIsaretiOlmayanEposta = epostaAdresleri.FirstOrDefault(x => !x.Contains("@"));
            Console.WriteLine("\n@ isareti bulunmayan ilk eposta adresi: " + atIsaretiOlmayanEposta);

            for(int i = 0; i < epostaAdresleri.Count;i++){
                if(!epostaAdresleri[i].Contains("@")){
                    Console.WriteLine("\ndongu ile @ isareti bulunmayan ilk eposta adresi: " + epostaAdresleri[i]);
                    break;
                }
            }

            string atIsaretiOlmayanSonEposta = epostaAdresleri.LastOrDefault(x => !x.Contains("@"));
            Console.WriteLine("\n@ isareti bulunmayan son eposta adresi: " + atIsaretiOlmayanSonEposta);

            for(int i = epostaAdresleri.Count - 1; i >= 0; i--){
                if(!epostaAdresleri[i].Contains("@")){
                    Console.WriteLine("\ndongu ile @ isareti bulunmayan son eposta adresi: " + epostaAdresleri[i]);
                    break;
                }
            }

            //Where
            List<string> atIsaretiBulunmayanEpostaAdresleri = epostaAdresleri.Where(x => !x.Contains("@")).ToList();
            Console.WriteLine("\n@ isareti bulunmayan tum eposta adresleri:");
            foreach(var hataliEposta in atIsaretiBulunmayanEpostaAdresleri){
                Console.WriteLine(hataliEposta);
            }

            //Select
            List<int> arttirilmisCiftSayilar = ciftSayilar.Select(x=>x + 5).ToList();
            Console.WriteLine("\n5 arttirilmis cift sayilar:");
            foreach(var sayi in arttirilmisCiftSayilar){
                Console.WriteLine(sayi);
            }

            List<int> bolunmusCiftSayilar = ciftSayilar.Select(x=>x / 2).ToList();
            Console.WriteLine("\n2'ye bolunmus cift sayilar:");
            foreach(var sayi in bolunmusCiftSayilar){
                Console.WriteLine(sayi);
            }

            //Distinct
            List<int> tekrardanArindirilmisCiftSayilar = ciftSayilar.Distinct().ToList();
            Console.WriteLine("\ntekrar etmeyen cift sayilar:");
            foreach(var sayi in tekrardanArindirilmisCiftSayilar){
                Console.WriteLine(sayi);
            }

            //Intersect
            List<int> tekSayilarIleKesisimKumesi = tekSayilar.Intersect(bolunmusCiftSayilar).ToList();
            Console.WriteLine("\nTek sayilar ile cift sayilar kesisim kumesi:");
            foreach(var sayi in tekSayilarIleKesisimKumesi){
                Console.WriteLine(sayi);
            }

            //OrderBy
            List<int> siralanmisTekSayilar = tekSayilar.OrderBy(x=>x).ToList();
            Console.WriteLine("\nSiralanmis tek sayilar:");
            foreach(var sayi in siralanmisTekSayilar){
                Console.WriteLine(sayi);
            }

            List<int> tersSiralanmisTekSayilar = tekSayilar.OrderByDescending(x=>x).ToList();
            Console.WriteLine("\nTers siralanmis tek sayilar:");
            foreach(var sayi in tersSiralanmisTekSayilar){
                Console.WriteLine(sayi);
            }

            List<string> siralanmisEpostalar = epostaAdresleri.OrderBy(x=>x.Length).ToList();
            Console.WriteLine("\nUzunluguna gore siralanmis epostalar:");
            foreach(var eposta in siralanmisEpostalar){
                Console.WriteLine(eposta);
            }

            //ThenBy
            siralanmisEpostalar = epostaAdresleri.OrderBy(x=>x.IndexOf(".com")).ThenBy(x=>x.Length).ToList();
            Console.WriteLine("\nUzunluguna ve @ isaretinin yerine gore siralanmis epostalar:");
            foreach(var eposta in siralanmisEpostalar){
                Console.WriteLine(eposta);
            }

            //Any
            bool ondanBuyukCiftSayiVarMi = ciftSayilar.Any(x=>x > 10);
            Console.WriteLine("\n10'dan buyuk cift sayi var mi listemizde: " + ondanBuyukCiftSayiVarMi);

            //All
            bool tumCiftSayilarOndanBuyukMu = ciftSayilar.All(x=>x > 10);
            Console.WriteLine("\nTum cift sayilar 10dan buyuk mu: " + tumCiftSayilarOndanBuyukMu);

            bool epostaListemDogruMu = epostaAdresleri.All(x=>x.Contains("@"));
            Console.WriteLine("\nEpostalarin hepsinde @ isareti var mi: " + epostaListemDogruMu);
        }
    }
}
