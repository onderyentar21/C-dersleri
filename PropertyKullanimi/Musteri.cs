using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyKullanimi
{
     class Musteri
    {

        // prop yazıp 2 defa tab tuşuna bastığımda hazır kalıp gelecektir.
        private int kilo;

        public int KILO {
            get
            {
                return kilo;

            }

            set
            {
                if (value < 0)
                    kilo = 0;

                 else
                 kilo = value;
            }
        }
    }
}
