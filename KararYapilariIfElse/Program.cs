using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapilariIfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter your nots ?");
                String not = Console.ReadLine();
                int not1 = Convert.ToInt32(not);
                if (not1 > 50)
                {
                    Console.WriteLine("You pass the class!!!");

                }else if(65<not1&&not1<89){
                    Console.WriteLine("ders durumunuz orlamnın üzerinde tebrikler!!");

                }
                else
                {
                    Console.WriteLine("You failed class!!");
                }



                Console.ReadLine();
            }
        }
    }
}
