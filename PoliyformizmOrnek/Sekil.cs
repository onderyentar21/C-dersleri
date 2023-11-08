using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliyformizmOrnek
{
    class Sekil// base class
    {
        public string isim { get; set; }

        public Sekil(string isim)
        {
            this.isim = isim;
        }
        public string getIsim()
        {
            return isim;
        }
        public void setIsim(String isim)
        {
            this.isim = isim;
        }
        public virtual void sekilHesapla()
        {
            Console.WriteLine("şeklin alanı hesaplanıyor...");
        }
        public virtual void sekilBİlgileriGoster()
        {
            Console.WriteLine(getIsim() + " nin bilgileri...");
        }
    }
}
