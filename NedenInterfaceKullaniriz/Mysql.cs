using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedenInterfaceKullaniriz
{
    public class Mysql : IMusteri

    {
       

        public void ekle()
        {
            Console.WriteLine("mysql eklendi");
        }

        public void guncelle()
        {

            Console.WriteLine("mysql guncellendi");
        }

        public void sil()
        {

            Console.WriteLine("mysql silindi");
        }


    }
}
