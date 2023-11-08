using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsullemeGiris
{
     class Program
    {
        static void Main(string[] args)
        {

            Ogrenci ogrenci = new Ogrenci();
            ogrenci.setTc( "2222222222");
            ogrenci.setIsım("Onder Yentar.");

            String gelenisim = ogrenci.getIsim();
            String gelenTc = ogrenci.getTc();
            
            if(gelenisim.Equals("Onder Yentar.")&&gelenTc.Equals("2222222222"))
            {
                Console.WriteLine("Başalırı!!!");
            }
            else
            {
                Console.WriteLine("Başarısız..");
            }



            Console.ReadLine();
        }

    }
}
