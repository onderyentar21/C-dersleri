using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeeachDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] isimler = { "onder", "mahir", "ergin", "damlanur" };
            foreach (String isim in isimler)
            {
                Console.WriteLine(isim);
            }
            Console.ReadLine();
        }
    }
}
