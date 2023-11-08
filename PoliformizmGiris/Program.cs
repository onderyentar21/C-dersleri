using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliformizmGiris
{
     class Program
    {
        static void Main(string[] args)
        {
           
            Hayvan hayvan = new Hayvan("Hayvan");
            hayvan.konus();

            Hayvan kedi = new Kedi("Matilda");
            kedi.konus();

            Hayvan kopek = new Kopek("karabaş");
            kopek.konus();

            HayvanlariKonustur(new Kedi("matoşş"));
            HayvanlariKonustur(new Kopek("deves"));


            Console.ReadLine();

        }
        public static void HayvanlariKonustur(Hayvan hayvan)
        {
       
            hayvan.konus();
        }
    }
}
