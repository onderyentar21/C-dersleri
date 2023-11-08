using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsalSayiOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("please enter a number111!");
                int deger = int.Parse(Console.ReadLine());

                if (Isprime(deger))
                {
                    Console.WriteLine("number is prime!!");

                }
                else
                {
                    Console.WriteLine("Number is not prime");

                }

                Console.ReadLine();
            }


        }
        static Boolean Isprime(int number)
        {
            bool result = true;
            //number-1 anlamı kendisine bölünmesin diye öyle yaptık yapmayabilirdikte..
            for (int i = 2; i < number-1; i++) {
            
            
                if(number % i == 0)
                {
                    result = false;

                }

            
            }
            return result;


        }
  

    }
}
