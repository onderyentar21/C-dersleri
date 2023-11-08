using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheratenceGiris
{
     class Program
    {
        static void Main(string[] args)
        {
            Kedi kedi = new Kedi();
            kedi.hayvan_isim = "Matilda";
            kedi.hayvan_cinsiyet = "dişi";
            kedi.hayvan_rengi = "Orange";
            kedi.hayvan_yas = 12;
            kedi.kediMethod();
            kedi.goz_rengi = "mavi";
            kedi.hayvanBİlgileriGoster();
          

            Console.ReadLine();
        }
    }
}
