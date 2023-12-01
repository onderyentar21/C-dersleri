using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrakClasslariKullanmak
{
    public class Program
    {
        static void Main(string[] args)
        {

            AyAbstrackt mart = new March();

            Console.WriteLine(mart.yilinKacinciAyi());
            Console.WriteLine(mart.gunSayisi());
            //-----------------------------------

            AyAbstrackt ocak = new Ocak();
            Console.WriteLine("ocak gün sayisi: "+ocak.gunSayisi());

            Console.WriteLine("---------------------------------");


            AyAbstrackt february = new February();
            Console.WriteLine("fevruary day : "+ february.gunSayisi());


            Console.ReadLine();

        }
    }
}
