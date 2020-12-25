using System;

namespace SEG_Example_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //PART 1

            //Hayali karakterimizi yeniden cagiralim
            string karakterIsmi = "Ziya";
            string karakterSoyIsmi = "Hayali";
            int karakterYasi = 25;

            //string birlestirme (concat) islemi : + operatoru
            string karakterTamIsmi = karakterIsmi + " " + karakterSoyIsmi;
            Console.WriteLine(karakterTamIsmi+"\n");

            //string formatlama methodu : Format()
            Console.WriteLine("{0} {1}. Karakterimizin yasi:{2}.", 
                karakterIsmi, karakterSoyIsmi, karakterYasi);

            string formatlanmisYazi = string.Format("{0} {1}. Karakterimizin yasi:{2}.\n", 
                karakterIsmi, karakterSoyIsmi, karakterYasi);
            Console.WriteLine(formatlanmisYazi);

            Console.WriteLine("{0} \"{1}\".\nKarakterimizin yasi:{2}.\n",
                karakterIsmi, karakterSoyIsmi, karakterYasi);

            //stringin uzunluk degeri : Length
            Console.WriteLine("Karakterin tam ismi:{0}.\nTam ismin uzunlugu:{1}-Hatali.\n",
                karakterTamIsmi, karakterTamIsmi.Length);

            //karakter veya kelimenin uzerine yazma methodu: Replace()
            //karakter silme
            var bosluksuzTamIsim = karakterTamIsmi.Replace(" ", "");
            Console.WriteLine("Karakterin tam ismi:{0}.\nTam ismin uzunlugu:{1}-Dogru.\n",
                bosluksuzTamIsim, bosluksuzTamIsim.Length);

            //karakter degistirme
            var harfDegismisTamIsim = karakterTamIsmi.Replace("a", "e");
            Console.WriteLine("Karakterin harf degismis tam ismi:{0}." +
                "\nTam ismin uzunlugu:{1}-Dogru.\n",
                harfDegismisTamIsim, harfDegismisTamIsim.Length);

            //kelime degistirme
            var kelimeDegismisTamIsim = karakterTamIsmi.Replace("Ziya", "Mehmet");
            Console.WriteLine("Karakterin kelime degismis tam ismi:{0}." +
                "\nTam ismin uzunlugu:{1}-Dogru.\n",
                kelimeDegismisTamIsim, kelimeDegismisTamIsim.Length);

            //stringe donusturme methodu: ToString()
            string bugununTarihiYazi = DateTime.Now.ToString();
            Console.WriteLine("Bugunun tarihi: {0}.\n", bugununTarihiYazi);

            //PART 2
            //terminal uzerinden kullanicidan girdi (input) alma
            Console.WriteLine("Lutfen eposta adresinizi girin.");
            string eposta = Console.ReadLine();
            Console.WriteLine("Kullanicinin girdigi eposta:{0}", eposta);

            //yazinin sonundaki ve basindaki boslugu silme methodu : Trim()
            eposta = eposta.Trim();
            Console.WriteLine("Trimlenmis eposta:{0}\n", eposta);

            //yaziyi tamamen buyuk harfe cevirme methodu: ToUpper()
            eposta = eposta.ToUpper();
            Console.WriteLine("Buyultulmus eposta:{0}\n", eposta);

            //yaziyi tamamen kucuk harfe cevirme methodu: ToLower()
            eposta = eposta.ToLower();
            Console.WriteLine("Kucultulmus eposta:{0}\n", eposta);

            //karakter ya da kelimenin ilk rastlandigi indexi bulma methodu: IndexOf()
            string aradigimizKarakter = "@";
            int ilkIndex = eposta.IndexOf(aradigimizKarakter);
            Console.WriteLine("Aradigimiz karakter {0}'in ilk indexi:{1}\n", 
                aradigimizKarakter, ilkIndex);

            aradigimizKarakter = "ya";
            ilkIndex = eposta.IndexOf(aradigimizKarakter);
            Console.WriteLine("Aradigimiz karakter {0}'in ilk indexi:{1}\n",
                aradigimizKarakter, ilkIndex);

            //karakter ya da kelimenin son rastlandigi indexi bulma methodu: LastIndexOf()
            int sonIndex = eposta.LastIndexOf(aradigimizKarakter);
            Console.WriteLine("Aradigimiz karakter {0}'in son indexi:{1}\n",
                aradigimizKarakter, sonIndex);

            //stringin istenilen kismini alma methodu: Substring()
            aradigimizKarakter = "@";
            ilkIndex = eposta.IndexOf(aradigimizKarakter);
            string atIsaretininOncesi = eposta.Substring(0, ilkIndex);
            Console.WriteLine("@ isaretinden oncesi: \"{0}\".", atIsaretininOncesi);

            string atIsaretindenSonrasi = 
                eposta.Substring(ilkIndex + 1, eposta.Length - ilkIndex - 1);
            Console.WriteLine("@ isaretinden sonrasi: \"{0}\".", atIsaretindenSonrasi);

            string yenidenOlusturulmusEposta = string.Format("Yeniden olusturduk: {0}{1}{2}", 
                atIsaretininOncesi, aradigimizKarakter, atIsaretindenSonrasi);
            Console.WriteLine(yenidenOlusturulmusEposta);
        }
    }
}