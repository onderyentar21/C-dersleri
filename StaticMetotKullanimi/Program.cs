using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMetotKullanimi
{
     class Program
    {
        static void Main(string[] args)
        {
            Personal.isimSoyisimYazdir();
            

          int deger =  Personal.topla(12, 34);
            Console.WriteLine(deger+12);


            Console.ReadLine();

        }
    }
}
