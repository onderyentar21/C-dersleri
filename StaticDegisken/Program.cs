using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDegisken
{
     class Program
    {
        static void Main(string[] args)
        {

            Calisan calisan = new Calisan();
            calisan.calisanId = 1;
            calisan.isim = "Onder";
            calisan.soyisim = "yentar";
            Calisan.maas = 8600;

            Console.WriteLine("çalisan ID :"+calisan.calisanId);
            Console.WriteLine("calisan isim: "+calisan.isim);
            Console.WriteLine("calisan soyisim: "+calisan.soyisim);
            Console.WriteLine("calisan maas: "+Calisan.maas);

            Console.ReadLine();

        }
    }
}
