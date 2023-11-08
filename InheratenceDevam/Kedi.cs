using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheratenceDevam
{
   public class Kedi : Kopek
    {
        public void sesCıkar()
        {
            Console.WriteLine(  "Kedi miyavlıyor..");
        }
        public void HayvanBilgileriGoster()
        {
            Console.WriteLine("Hayvan ismi : "+isim);
            Console.WriteLine("Hayvan Renk : "+renk);
            Console.WriteLine("Hayvan kilo: "+kilo);
            Console.WriteLine("Hayvan Ayaksayisi: "+ayakSayisi);
            Console.WriteLine("Hayvan Cİnsiyet: " + cinsiyet);
        }

    }
}
