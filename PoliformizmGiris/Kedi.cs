using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliformizmGiris
{
    internal class Kedi : Hayvan
    {
        public Kedi(String kedi):base(kedi) { 


        } 
       
        public override void konus()
        {
            Console.WriteLine(getIsim()+"  miyavlıyor..");
        }
    }
}
