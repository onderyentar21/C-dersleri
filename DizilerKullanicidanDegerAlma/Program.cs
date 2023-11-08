using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DizilerKullanicidanDegerAlma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dizinin elemanlarını kullanıcıdan alma ve ekrana yazdırma..
            int[] sayilar = new int[4];

            for(int i =0; i < sayilar.Length; i++)
            {
                Console.WriteLine("sayilar Dizisinin "+(i)+" index degerini giriniz : ");
                sayilar[i]=Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("-----------------------------------");
            for(int i =0; i< sayilar.Length; i++)
            {
                Console.WriteLine("sayilar: "+sayilar[i]);
            }
            Console.ReadLine();
        }
    }
}
