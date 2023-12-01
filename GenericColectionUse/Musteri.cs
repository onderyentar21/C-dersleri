using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericColectionUse
{
    internal class Musteri
    {
        public int id;
        public string isim { get; set; }
        public string soyisim { get; set; }


        public Musteri(int id, string isim, string soyisim) {
        
            this.id = id;
            this.isim = isim;
            this.soyisim = soyisim;
        }

        public override string ToString()
        {
            return "id:  "+id +"   isim   : " + isim + "  soyisim :  " + soyisim;
        }

    }
}
