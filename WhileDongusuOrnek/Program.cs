using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDongusuOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 den 10'a kadar olan sayıları ekrana yazdırın
            //100 den 1' kadar olan sayıları büyüktrn küçğe sıralayın..
            
            int i = 0;
            while (i <= 100)
            {
                Console.WriteLine(i);
                i++;
            }
            
            

            int a = 100;
            while (a>0 && a <= 100)
            {
                Console.WriteLine(a);

                a -= 2;
            }
            

            Console.ReadLine();

        }
    }
}
