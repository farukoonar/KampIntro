using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Ad = "Elma";
            urun1.Fiyat = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Ad = "Karpuz";
            urun2.Fiyat = 80;
            urun2.Aciklama = "Kelek karpuz";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Ad);
                Console.WriteLine(urun.Fiyat);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------------------");
            }

            Console.WriteLine("------------------------Metotlar---------------------------------");

            //instance - örnek oluşturma
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12,1);
            sepetManager.Ekle2("Elma", "Yeşil Karpuz", 12,9);

        }
    }
}


// Don't Repeat Yourself - DRY 
// Clean Code 
// Best Practice