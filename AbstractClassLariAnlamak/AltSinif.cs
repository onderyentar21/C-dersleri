using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassLariAnlamak
{
    public class AltSinif : TemelSinif
    {
        // abstrack classlar inheretd edildiğinde abstrack method ovveride eklenir interfscede bu yok 

        public override void metot2()
        {
            Console.WriteLine("bu override edilmiş method");
        }
    }
}
