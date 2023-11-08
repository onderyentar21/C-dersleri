using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheratenceGiris
{
   public class Hayvan
    {
        public String hayvan_isim;
        public String hayvan_cinsiyet;
        public String hayvan_rengi;
        internal int hayvan_yas;

        public void hayvanBİlgileriGoster()
        {
            Console.WriteLine("Hayvanın ismi : "+ hayvan_isim);
            Console.WriteLine("Hayvan cinsiyet : "+ hayvan_cinsiyet);
            Console.WriteLine("haayvan rengi: " + hayvan_rengi);
            Console.WriteLine("Hayvan yaşı: "+hayvan_yas);
        }

    }
}
