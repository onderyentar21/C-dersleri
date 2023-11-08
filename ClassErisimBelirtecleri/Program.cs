using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassErisimBelirtecleri
{
     class Program
    {
        static void Main(string[] args)
        {
            // public, private, protected, internal...

            Musteri musteri1 = new Musteri();

            musteri1.isim = "onder";
            musteri1.soyisim = "yentar";
            musteri1.maas = 10000;
            musteri1.cinsiyet = "Erkek";
            musteri1.musteriBilgileriGoster();

            Console.ReadLine();
        }
    }
}
