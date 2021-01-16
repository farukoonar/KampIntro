using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        // naming convention - isimlendirme kuralları
        // syntax
       
        public void Ekle(Urun urun)
        {
            Console.WriteLine(urun.Ad +" başarıyla sepete eklendi!");
        }

        public void Ekle2(string urunAdı,string urunAciklamasi, double fiyat,int stokAdedi)
        {
            Console.WriteLine(urunAdı + " başarıyla sepete eklendi!");
        }

    }
}
