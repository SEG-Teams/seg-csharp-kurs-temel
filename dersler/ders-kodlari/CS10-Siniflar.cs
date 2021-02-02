using System;
using System.Collections.Generic;
using System.Linq;

namespace SEG_Example_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //CS10 Sinif odakli yazilim
            List<int> ogrenciNumaralari = new List<int>(){111,112,113,114,115,116,117,118,119};
            List<string> ogrenciIsimleri = new List<string>(){"TT", "BT", "CT", "ZT", "ST"};

            for (int i = 0; i < ogrenciIsimleri.Count; i++)
            {
                Console.WriteLine("{0} numarali ogrenci {1}", ogrenciNumaralari[i], ogrenciIsimleri[i]);
            }

            Console.WriteLine();
            ogrenciNumaralari = ogrenciNumaralari.OrderByDescending(x=>x).ToList();
            for (int i = 0; i < ogrenciIsimleri.Count; i++)
            {
                Console.WriteLine("{0} numarali ogrenci {1}", ogrenciNumaralari[i], ogrenciIsimleri[i]);
            }

            List<Ogrenci> okulunOgrencileri = new List<Ogrenci>();

            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Isim = "TT";
            ogrenci1.OkulNumarasi = 11;
            ogrenci1.KayitTarihi = DateTime.Now;
            okulunOgrencileri.Add(ogrenci1);

            Ogrenci ogrenci2 = new Ogrenci(){Isim = "BT", OkulNumarasi = 112,
                KayitTarihi = new DateTime(2020, 12, 1)};
            okulunOgrencileri.Add(ogrenci2);

            Ogrenci ogrenci3 = new Ogrenci(){Isim = "CT", OkulNumarasi = 113,
                KayitTarihi = new DateTime(2020, 1, 1)};
            okulunOgrencileri.Add(ogrenci3);

            Ogrenci ogrenci4 = new Ogrenci(){Isim = "ZT", OkulNumarasi = 114,
                KayitTarihi = new DateTime(2020, 1, 5)};
            okulunOgrencileri.Add(ogrenci4);

            Ogrenci ogrenci5 = new Ogrenci(){Isim = "ST", OkulNumarasi = 115,
                KayitTarihi = new DateTime(2020, 1, 15)};
            okulunOgrencileri.Add(ogrenci5);

            Console.WriteLine("\nOkulun ogrencileri:");
            for (int i = 0; i < okulunOgrencileri.Count; i++)
            {
                Console.WriteLine("{0} numarali ogrenci {1}, {2} tarihinde kaydoldu"
                    ,okulunOgrencileri[i].OkulNumarasi, okulunOgrencileri[i].Isim,
                    okulunOgrencileri[i].KayitTarihi);
            }

            okulunOgrencileri = okulunOgrencileri.OrderByDescending(x=>x.OkulNumarasi).ToList();
            Console.WriteLine("\nOkulun ogrencilerinin numaraya gore ters siralanmis hali:");
            for (int i = 0; i < okulunOgrencileri.Count; i++)
            {
                Console.WriteLine("{0} numarali ogrenci {1}, {2} tarihinde kaydoldu"
                    ,okulunOgrencileri[i].OkulNumarasi, okulunOgrencileri[i].Isim,
                    okulunOgrencileri[i].KayitTarihi);
            }

            okulunOgrencileri = okulunOgrencileri.OrderByDescending(x=>x.KayitTarihi).ToList();
            Console.WriteLine("\nOkulun ogrencilerinin kayit tarihine gore ters siralanmis hali:");
            for (int i = 0; i < okulunOgrencileri.Count; i++)
            {
                Console.WriteLine("{0} numarali ogrenci {1}, {2} tarihinde kaydoldu"
                    ,okulunOgrencileri[i].OkulNumarasi, okulunOgrencileri[i].Isim,
                    okulunOgrencileri[i].KayitTarihi);
            }
            
        }
    }

    public class Ogrenci
    {
        public string Isim;

        public int OkulNumarasi;

        public DateTime KayitTarihi;

    }
}
