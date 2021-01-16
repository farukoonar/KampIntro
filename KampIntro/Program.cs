using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //do not repeat yourself - kendini tekrarlama

            //değer tutucu , alias
            string kategoriEtiketi = "Kategori";
            int ogrenciSayıcı = 32000;
            bool sistemeGirisYapildiMi = false;
            double dolarDun= 7.55, dolarBugun= 7.45;

            Console.WriteLine(kategoriEtiketi);

            //şart bloğu - artış azalış oku
            if (dolarBugun>dolarDun)
            {
                Console.WriteLine("Artış Oku");
            }
            else if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Oku");
            }
            else
            {
                Console.WriteLine("Ok Yok");
            }

            //şart bloğu - giriş şartı
            if (sistemeGirisYapildiMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            

        }
    }
}
