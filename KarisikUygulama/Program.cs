using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarisikUygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a number ? ");
            int number = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            for(int i =0; i<=number; i++)
            {
                toplam += i;
            }
            Console.WriteLine("sayilarin toplami : "+ toplam);
                int sonuc =toplam/number;
            Console.WriteLine("toplamın girilen sayiya bölündüğündeki sonuc :" + sonuc);
                if (sonuc > 50)
                {
                    Console.WriteLine("Avarge bigger than 50!!! ");
                
                }
                else
                {
                    Console.WriteLine("Avarage litle then 50!!  ");
                }
           
            Console.ReadLine();
        }
    }
}
