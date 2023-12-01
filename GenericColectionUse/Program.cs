using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericColectionUse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            List<int> rlist = new List<int>();
            rlist.Add(1);
            rlist.Add(2);
            rlist.Add(3);
            rlist.Add(4);
            rlist.Add(5);
            rlist.Add(6);
            rlist.Add(7);
            rlist.Add(8);
            rlist.Add(9);
            foreach (int deger in rlist)
            {
                Console.WriteLine(deger);
            }
           Console.ReadLine();
            */

            List<Musteri> musteriler = new List<Musteri>();

            musteriler.Add(new Musteri(1,"Onder","Yentar."));
            musteriler.Add(new Musteri(2, "Mahir", "Yentar."));
            musteriler.Add(new Musteri(3, "Ergin", "Yentar."));

            Console.WriteLine("index deger : "+ musteriler.Count());
            musteriler.Except(musteriler);
            musteriler.Remove(musteriler.First());
            bool degerss = musteriler.Contains(musteriler.First());
            Console.WriteLine(degerss);


            foreach (Musteri deger in musteriler)
            {

                Console.WriteLine("deger : "+ deger);
            }
            Console.ReadLine();
        }
    }
}
