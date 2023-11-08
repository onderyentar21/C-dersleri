using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassKullanimi
{
    class Program
    {
        /*
          araba1.kapiSayisi = 4;
          araba1.arabaRengi = "Gray";
          araba1.arabaModel = "Ford";
          */
        static void Main(string[] args)
        {
            Araba araba1 = new Araba(3, "Hyundai", "i20");

            araba1.kapilarKilitle();
            araba1.mototCalistir();


            Console.WriteLine("Arabanın kapı sayısı : "+ araba1.kapiSayisi);
            Console.WriteLine("Arabanın rengi : "+ araba1.arabaRengi);
            Console.WriteLine("Arabanın Modeli : "+araba1.arabaModel);


            Console.ReadLine();



        }
    }
}
