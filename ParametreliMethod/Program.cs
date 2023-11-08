using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametreliMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            toplamaYap(12,43);
            carpmaYap(10,32,456);
            IsımSoyisim("onder", "Yentar");




            Console.ReadLine();

        }

        static void toplamaYap(int number1, int number2)
        {
            int sonuc = number1+number2;
            Console.WriteLine("Sonuc : "+sonuc);
            

        }
        static void carpmaYap(int sayi1,int sayi2, int sayi3)
        {
            Console.WriteLine("This tree number plus equls to this: "+ (sayi1*sayi2*sayi3));
        }
        static void IsımSoyisim(String isim, String soyisim )
        {

            Console.WriteLine("isim ve soyisim: " + isim + " " + soyisim);
        }
    }
}
