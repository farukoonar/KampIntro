using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad = "Faruk ONAR";
            int yas = 20;

            Kurs kurs1 = new Kurs();
            kurs1.Ad = "Yazılım Geliştirici Yetiştirme Kampı";
            kurs1.Egitmen = "Engin DEMİROĞ";
            kurs1.IzlenmeOranı = 36;

            Kurs kurs2 = new Kurs();
            kurs2.Ad = "Programlamaya Giriş İçin Temel Kurs";
            kurs2.Egitmen = "Engin DEMİROĞ";
            kurs2.IzlenmeOranı = 0;

            Kurs kurs3 = new Kurs();
            kurs3.Ad = "Python";
            kurs3.Egitmen = "Berkay BİLGİN";
            kurs3.IzlenmeOranı = 89;

            //Console.WriteLine(kurs1.Ad + " : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3};
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.Ad + " : " + kurs.Egitmen);
            }

        }
    }
    class Kurs
    {
        public string Ad { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOranı { get; set; }

    }

}
