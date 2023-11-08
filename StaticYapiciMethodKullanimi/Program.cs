using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticYapiciMethodKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Kullanici K1 = new Kullanici(11,"Onder","Yentar");
            Kullanici K2 = new Kullanici(1, "Ergin", "Yentar");

            K1.bilgileriGoster();
            K1.zamYap(3200);
            

            Console.ReadLine();
            

        }
    }
}
