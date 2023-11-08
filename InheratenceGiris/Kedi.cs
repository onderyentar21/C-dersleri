using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheratenceGiris
{
    public class Kedi : Hayvan
    {
        // içerisi boş
        public String goz_rengi;

        public void kediMethod()
        {
            Console.WriteLine("değişik bir göz rengi var..");
        }
    }
}
