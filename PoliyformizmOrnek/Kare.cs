using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliyformizmOrnek
{
    class Kare : Sekil
    {
        public int kareKenar { get; set; }
        public Kare(String isim,int kareKenar): base(isim)
        {
            
            this.kareKenar = kareKenar;

        }
        public override void sekilBİlgileriGoster()
        {
            base.sekilBİlgileriGoster();
            Console.WriteLine(getIsim()+"nin kenar uzunluğu:"+kareKenar);
        }
        public override void sekilHesapla()
        {
            base.sekilHesapla();
            Console.WriteLine(getIsim()+" nin alanı: "+(kareKenar*kareKenar));
        }
    }
}
