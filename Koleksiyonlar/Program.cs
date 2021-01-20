using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler1 = new string[] { "Kerem", "Engin", "Murat", "Halil" };
            //Console.WriteLine(isimler1[0]);
            //Console.WriteLine(isimler1[1]);
            //Console.WriteLine(isimler1[2]);
            //Console.WriteLine(isimler1[3]);
            //Console.WriteLine(isimler1[4]);

            List<string> isimler2 = new List<string> { "Kerem", "Engin", "Murat", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            isimler2.Add("BERKAYYYYYYYY");
            Console.WriteLine(isimler2[5]);
        }
    }
}
