using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //
            /*
            do while dongusu koşul sağlamasa bile dongü bir defa dahi olsa çalışırç

            int a = 1;
            do
            {
                Console.WriteLine(a);
                a++;

            } while (a<=10);
            */
            int a = 0;
            int toplam = 0;
            do
            {
                toplam = toplam + a;
                a++;


            } while (a<=100);
            Console.WriteLine("1 den 100 kadar olan sayiların toplamı: "+toplam);
            Console.ReadLine();
        }
    }
}
