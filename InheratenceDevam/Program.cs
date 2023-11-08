using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheratenceDevam
{
     class Program
    {
        static void Main(string[] args)
        {
            var kedi = new Kedi();

            kedi.isim = "matilda";
            kedi.kilo = "3 kilo";
            kedi.renk = "Karışık renk";
            kedi.ayakSayisi = 4;
            kedi.cinsiyet = "Dişi";
            kedi.sesCıkar();
            kedi.HayvanBilgileriGoster();

            Console.ReadLine();
           
        }
    }
}
