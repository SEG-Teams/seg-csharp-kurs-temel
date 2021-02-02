using System;
using System.Collections.Generic;
using System.Linq;

namespace SEG_Example_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //CS11 Metotlar
            var benimArabam = new Araba("35 TEST 43", 50, 4, 1);
            var komsununArabasi = new Araba("35 TEST2 20", 60, 4, 2);

            int yarisBitisMesafesi = 140;
            while(benimArabam.BulunduguMesafe < yarisBitisMesafesi &&
            komsununArabasi.BulunduguMesafe < yarisBitisMesafesi){
                benimArabam.Ilerlet();
                komsununArabasi.Ilerlet();
            }

            Araba kazananAraba = null;
            if(benimArabam.BulunduguMesafe > komsununArabasi.BulunduguMesafe){
                kazananAraba = benimArabam;
            }
            else if(komsununArabasi.BulunduguMesafe > benimArabam.BulunduguMesafe){
                kazananAraba = komsununArabasi;
            }

            if(kazananAraba != null){
                Console.WriteLine("Kazanan araba {0} plakali arac.",kazananAraba.Plaka);
            }
            else{
                Console.WriteLine("Kazanan arac yok. Yaris berabere ya da araclar bitis cizgisine ulasamadi.");
            }

            benimArabam.YakitEkle(4);
            komsununArabasi.YakitEkle(4);
        }
    }

    class Araba{
        public string Plaka;
        public int BulunduguMesafe;
        public int Hiz;
        public int YakitTankiKapasitesi;
        public int MevcutYakitMiktari;
        public int YakitTuketimi;

        public Araba(string plaka, int hiz, int yakitTankiKapasitesi, int yakitTuketimi)
        {
            Plaka = plaka;
            Hiz = hiz;
            YakitTankiKapasitesi = yakitTankiKapasitesi;
            MevcutYakitMiktari = YakitTankiKapasitesi;
            YakitTuketimi = yakitTuketimi;
        }

        public void Ilerlet(){
            if(YeterliYakitVarMi()){
                BulunduguMesafe += Hiz;
                Console.WriteLine("{0} plakali arac {1} birim ilerleyerek {2}. mesafeye geldi."
                ,Plaka, Hiz, BulunduguMesafe);

                YakitTuket();
            }
            else{
                Console.WriteLine("Arabada yeterli yakit yok.");
            }
        }

        public bool YeterliYakitVarMi(){
            return MevcutYakitMiktari >= YakitTuketimi;
        }

        public void YakitTuket(){
            if(!YeterliYakitVarMi())
                return;
            
            MevcutYakitMiktari -= YakitTuketimi;
        }

        public void YakitEkle(int eklenecekMiktar){
            MevcutYakitMiktari += eklenecekMiktar;
            if(MevcutYakitMiktari > YakitTankiKapasitesi){
                MevcutYakitMiktari = YakitTankiKapasitesi;
            }
            Console.WriteLine("{0} plakali araca yakit eklendi. Mevcut yakit miktari: {1} litre.",
                Plaka, MevcutYakitMiktari);
        }

    }
}
