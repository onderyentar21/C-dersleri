using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExamps
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            Console.WriteLine("PLEASE ENTER A NUMBER: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

             int degerKontrol=Square(sayi);
            if (degerKontrol > 25) {

                Console.WriteLine("Sayinin karesi 25'ten büyüktür..");
                Console.WriteLine("Sayinin karesi : " + Square(sayi));

            }
            else
            {
                Console.WriteLine("karesi 25'ten küçüktür..");
                Console.WriteLine("Sayinin karesi : " + Square(sayi));
            }
            
            Console.WriteLine("PLEASE ENTER A NUMBER: ");
            int sayiIlk = Convert.ToInt32(Console.ReadLine());

            bool deger = TekmiCiftmi(sayiIlk);
            Console.WriteLine(deger);
            */
            Console.WriteLine("please enter first number: ");
            int Number1 =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine( "please enter number 2 :");
            int Number2 = Convert.ToInt32(Console.ReadLine());

            Kontrol(Number1,Number2);
            



            Console.ReadLine();

        }
        public static int Square(int number)
        {

            int numberSquare = number * number;
            return numberSquare;
        }

        static bool TekmiCiftmi(int sayi)
        {
            bool result = false;
           
            if (sayi %2 ==0) { 
            
                result = true;
                Console.WriteLine("sayi cifftir");

            }
            else
            {
                result = false;
                Console.WriteLine("sayi tektir");
            }
            return result;
        }

        public static void Kontrol(int sayi1, int sayi2)
        {
            if (sayi1 > sayi2)
            {
                Console.WriteLine("sayi bir sayi2 den büyüktür: sayi>sayi2");
            }
            else
            {
                Console.WriteLine("sayi2 sayi1 den büyüktür: sayi2>sayi1");
            }

        }
    }

   
        
   
}
