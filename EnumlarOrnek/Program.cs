using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumlarOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri(11,"Onder","Yentar","Erkek","onder@gmail.com");
          MusteriDurum gelenKod =  musteri.musteriEkle(musteri);

            if (gelenKod.Equals(MusteriDurum.KayitBasarili))
            {
                Console.WriteLine("musteri basarılı bir sekilde eklenmiştir.");
                Console.ReadLine();
            }
        }
    }
}
