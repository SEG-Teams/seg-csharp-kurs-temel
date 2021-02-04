using System;
using System.Collections.Generic;
using System.Linq;
using SEG_Example_Console.Domain;

namespace SEG_Example_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //CS11 Class ornekleri Part 2
            var yeniKullanici = new Kullanici();

            yeniKullanici.YeniKullaniciKaydiBaslat();
            yeniKullanici.BilgileriYazdir();

            if(yeniKullanici.KayitliMi){
                yeniKullanici.GirisYapmayiBaslat();
            }            

            if(yeniKullanici.GirisYaptiMi)
            {
                Console.WriteLine("Kullanici en son {0} tarihinde giris yapti.", 
                yeniKullanici.SonGirisTarihi);
            }
            else{
                Console.WriteLine("Kullanici giris yapmamis.");
            }
        }
    }

    public class Kullanici
    {
        public string Isim;

        public string Soyisim;

        public string Eposta;

        public string Sifre;

        public DateTime DogumTarihi;

        public DateTime KayitTarihi;

        public DateTime SonGirisTarihi;

        public bool KayitliMi;

        public bool GirisYaptiMi;

        public bool YeniKullaniciKaydiBaslat(){
            //Kullaniciya kayit basladigina dair geridonus
            Console.WriteLine("Lutfen kayit olmak icin asagida istenen bilgileri giriniz.");

            //dongu ile kullanicidan bilgilerini al
            //en fazla kullaniciya 3 kez bilgilerini sor
            //kayit basarili olmadigi surece tekrarla
            int kayitBilgisiIstemeSayisi = 0;
            bool kayitBasarili = false;
            while (!kayitBasarili && kayitBilgisiIstemeSayisi < 3)
            {
                Console.WriteLine("Lutfen isminizi giriniz:");
                var isimGirdisi = Console.ReadLine();

                Console.WriteLine("Lutfen soyisim giriniz:");
                var soyisimGirdisi = Console.ReadLine();

                Console.WriteLine("Lutfen e-posta adresinizi giriniz:");
                var epostaGirdisi = Console.ReadLine();

                Console.WriteLine("Lutfen sifre giriniz:");
                var sifreGirdisi = Console.ReadLine();

                Console.WriteLine("Lutfen sifrenizi tekrar giriniz:");
                var onaySifreGirdisi = Console.ReadLine();

                Console.WriteLine("Lutfen dogum tarihinizi asagida giriniz:");
                Console.WriteLine("Dogdugunuz gun:");
                var gunGirdisi = Console.ReadLine();
                int gun;
                int.TryParse(gunGirdisi, out gun);

                Console.WriteLine("Dogdugunuz ay:");
                var ayGirdisi = Console.ReadLine();
                int ay;
                int.TryParse(ayGirdisi, out ay);

                Console.WriteLine("Dogdugunuz yil:");
                var yilGirdisi = Console.ReadLine();
                int yil;
                int.TryParse(gunGirdisi, out yil);

                var dogumTarihi = new DateTime(yil, ay, gun);

                var hatalar = KayitKontroluYap(isimGirdisi, soyisimGirdisi, epostaGirdisi,
                    sifreGirdisi, onaySifreGirdisi, dogumTarihi);

                if(hatalar.Count > 0){
                    Console.WriteLine();
                    for (int i = 0; i < hatalar.Count; i++)
                    {
                        Console.WriteLine(hatalar[i]);
                    }
                    if(kayitBilgisiIstemeSayisi < 2){
                        Console.WriteLine("\nKayit islemi tekrar baslatilacaktir.\n");
                    }
                }
                else{
                    kayitBasarili = true;
                    Kaydet(isimGirdisi, soyisimGirdisi, epostaGirdisi,
                        sifreGirdisi, dogumTarihi);
                    Console.WriteLine("Kayit basarili.");
                }

                kayitBilgisiIstemeSayisi++;
            }

            //kayit basariliysa kullanicinin bilgilerini kaydet
            //kaydin basarili olup olmadigini soyle
            if(!kayitBasarili){
                Console.WriteLine("\nKayit basarisiz oldu.");
            }

            return kayitBasarili;
        }


        private void Kaydet(string isim, string soyisim, string eposta, 
            string sifre, DateTime dogumTarihi)
        {
            Isim = isim;
            Soyisim = soyisim;
            Eposta = eposta;
            Sifre = sifre;
            DogumTarihi = dogumTarihi;
            KayitliMi = true;
            KayitTarihi = DateTime.Now;
        }

        public List<string> KayitKontroluYap(string isim, string soyisim, string eposta, string sifre, 
            string onaySifresi, DateTime dogumTarihi)
        {
            List<string> hatalar = new List<string>();
            //isim soyisim kontrolu, en az 2 karakter icermeli
            if(string.IsNullOrWhiteSpace(isim) || string.IsNullOrWhiteSpace(soyisim)){
                hatalar.Add("Isim soyisim bos olamaz.");
            }
            else if(isim.Length < 2 || soyisim.Length < 2){
                hatalar.Add("Isim ve soyisim 2 karakterden uzun olmalidir.");
            }

            //eposta kontrolu, @ isareti olmali, oncesinde ve sonrasinda en az iki karakter olmali
            if(string.IsNullOrWhiteSpace(eposta)){
                hatalar.Add("Eposta bos olamaz.");
            }
            else{
                if(!eposta.Contains("@")){
                    hatalar.Add("Eposta adresinde @ isareti bulunmalidir.");
                }
                else{
                    int atIsaretininIndexi = eposta.IndexOf("@");

                    bool atIsaretindenOnceIkiKarakterVarMi = atIsaretininIndexi >= 2;
                    bool atIsaretindenSonraBesKarakterVarMi = eposta.Length - (atIsaretininIndexi + 1) >= 5;

                    if(!atIsaretindenOnceIkiKarakterVarMi || !atIsaretindenSonraBesKarakterVarMi){
                        hatalar.Add("Eposta adresi cok kisa.");
                    }
                }
            }

            //sifre kontrolu, sifre en az 6 karakter icermeli, onay sifresiyle ayni olmali
            if(string.IsNullOrWhiteSpace(sifre) || string.IsNullOrWhiteSpace(onaySifresi)){
                hatalar.Add("Sifre ve onay sifresi bos olmamalidir.");
            }
            else if(!string.Equals(sifre, onaySifresi)){
                hatalar.Add("Onaylamak icin girilen sifre ile sifreniz ayni olmalidir.");
            }
            else if(sifre.Length < 6){
                hatalar.Add("Sifre 6 karakterden uzun olmalidir.");
            }

            //dogum tarihi kontrolu, kullanici en az 13 yasinda olmali
            bool kullanicininYasiOnUctenBuyukMu = dogumTarihi.AddYears(13) <= DateTime.Now;
            if(!kullanicininYasiOnUctenBuyukMu)
            {
                hatalar.Add("Kayit olmak icin kullanici 13 yasindan buyuk olmalidir.");
            }

            return hatalar;
        }

        public bool GirisYapmayiBaslat()
        {
            Console.WriteLine("Giris yapmak icin istenilen bilgileri giriniz.");

            int girisDenemeSayisi = 0;
            bool girisYapmaBasariliMi = false;
            while (girisDenemeSayisi < 3 && !girisYapmaBasariliMi)
            {
                Console.WriteLine("Lutfen eposta adresinizi giriniz:");
                var epostaGirdisi = Console.ReadLine();

                Console.WriteLine("Lutfen sifrenizi giriniz.");
                var sifreGirdisi = Console.ReadLine();

                girisYapmaBasariliMi = GirisKontroluYap(epostaGirdisi, sifreGirdisi);

                if(girisYapmaBasariliMi){
                    SonGirisTarihi = DateTime.Now;
                    GirisYaptiMi = true;
                    Console.WriteLine("Giris yapma basarili oldu.");
                }
                else{
                    Console.WriteLine("Girdiginiz bilgiler hatali.\n"
                        +"Lutfen bilgilerinizi dogru bir sekilde giriniz.\n");
                }

                girisDenemeSayisi++;
            }

            if(!girisYapmaBasariliMi){
                Console.WriteLine("Giris basarisiz oldu.");
            }

            return girisYapmaBasariliMi;
        }

        public bool GirisKontroluYap(string eposta, string sifre)
        {
            //eposta ve sifrenin kayitli olanlarla ayni olup olmadigi
            if(string.IsNullOrWhiteSpace(eposta) || string.IsNullOrWhiteSpace(sifre)){
                return false;
            }

            if(!string.Equals(eposta, Eposta) || !string.Equals(sifre, Sifre)){
                return false;
            }

            return true;
        }

        public void BilgileriYazdir(){
            if(KayitliMi){
                Console.WriteLine("{0} {1} kullanicisi {2} tarihinde kaydoldu.",
                    Isim, Soyisim, KayitTarihi);
            }
            else{
                Console.WriteLine("Kullanici henuz kayitli degil.");
            }
        }
    }
}
