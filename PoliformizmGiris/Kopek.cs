using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliformizmGiris
{
    internal class Kopek : Hayvan
    {
        public Kopek(string isim):base(isim) 
        {
            

        }
        public override void konus()
        {
            //base.konus();
            Console.WriteLine(getIsim()+"   havlıyor");
        }
    }
}
