using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectedInheratence
{
    public class Bitki // mirası vren anlamına gelir buda base class yada super class denir.
    {
        public int bitki_id { get; set; }
        protected String bitki_isim { get; set; }
        protected String bitki_resim { get; set; }
    }
}
