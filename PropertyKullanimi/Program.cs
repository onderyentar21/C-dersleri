using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Musteri musteri = new Musteri();
            musteri.KILO = 85;
            Console.WriteLine("kilo: "+ musteri.KILO);
            

            Kullanici kullanici = new Kullanici();
            kullanici.yas2 = 19;
            kullanici.yas = 19;
            Console.WriteLine("poroperty ile alınan: "+ kullanici.yas2);
            Console.WriteLine("field(değişken) ile alınan: "+kullanici.yas);
            *
            */

            PersonelInfo personelInfo = new PersonelInfo();
            personelInfo.TCKIMLIKNO = "11111111111";

            Console.WriteLine("Tc kimlik Numaranı : "+personelInfo.TCKIMLIKNO);


            Console.ReadLine();



        }
    }
}
