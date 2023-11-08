using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DizilerGiris_arrays_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] number = new int[4];

            number[0] = 12;
            number[1] = 13;
            number[2] = 14;
            number[3] = 15;
            for(int i=0; i<number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }

            Console.ReadLine();
            */
            //bunun anlamı şu anda dizimi tanımladım daha son r deger tanımlamadı yapacaqğım.
            //String[] names = new string[5];
            // bunun anlamı ise diziyi oluşturduğum gibi deger ataması yapacağım.
            String[] names = { "onder", "Mahir", "ergin", "serpil", "hesina", "damla", "tahir" };
            double[] number = { 12.4, 54.432, 124.543, 23.0 };
            char[] character = { 'O', 'N', 'D', 'E', 'R' };

            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine("------------------------");
            int a = 0;
            while (a<number.Length)
            {
                Console.WriteLine(number[a]);
                a++;

            }
            int b = 0;
            Console.WriteLine("------------------------------");
            do
            {
                Console.WriteLine(character[b]);
                b++;

            } while (b<character.Length);

           



            Console.ReadLine();
        }
    }
}
