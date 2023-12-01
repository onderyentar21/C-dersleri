using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceKullanimi
{
    class MusteriClass : IMusteri,IPersonal
    {
        public void ekle()
        {
            Console.WriteLine("Musteri eklendi...");
        }

        public void getir()
        {
            Console.WriteLine("musteri getirildi..");
        }

        public void guncelle()
        {
            Console.WriteLine("musteri guncellendi..");
        }

        public int personal()
        {
            return 12;
        }

        public void sil()
        {
            Console.WriteLine("musteri silind..");

        }
    }
}
