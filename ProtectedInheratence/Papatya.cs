using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectedInheratence
{
    public class Papatya : Bitki// mirası alan classs sub class denilir.
    {
        public void papatya_bilgiler()
        {
            bitki_id = 1;
            bitki_isim = "papatya";
            bitki_resim = "sarı ve beyaz";
            
            Console.WriteLine("Bitki id: "+bitki_id);
            Console.WriteLine("bitki ismi: "+bitki_isim);
            Console.WriteLine("bitki rengi: "+bitki_resim);
        }
    }
}
