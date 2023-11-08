using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliformizmGiris
{
    class Hayvan
    {
      
        public string isim { get; set; }
        public Hayvan(string isim)
        {
            this .isim = isim;
        }

        public string getIsim()
        {
            return isim;
        }
        public void setIsım(String isim)
        {
            this.isim = isim;
        }

        public virtual void konus()
        {
            Console.WriteLine("Hayvan konuşuyor....");
        }
    }
}
