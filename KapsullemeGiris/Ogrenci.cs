using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsullemeGiris
{
     class Ogrenci
    {
        private String isim;
        private String Tc;

        public void setIsım(String isim )
        {
            this.isim = isim;

        }
        public String getIsim()
        {
            return isim;
        }
        public void setTc(String Tc)
        {
            this.Tc = Tc;
        }
        public String getTc()
        {
            return Tc;
        }
    }
}
