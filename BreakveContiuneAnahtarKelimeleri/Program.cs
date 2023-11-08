using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakveContiuneAnahtarKelimeleri
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            for(int a = 1; a<=10; a++){

                if (a == 8)
                {
                    // break anahtar kelimesi demek döngüyü kır demek sonrası olamsın demektir
                    // contiune ise sadece belirtilen değeri atla demek ama diğerlerini devam et.

                    // break;
                    continue;
                }
                Console.WriteLine("a nın degeri: " + a);

            }
            Console.ReadLine();
        }
    }
}
