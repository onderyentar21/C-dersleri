using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliyformizmOrnek
{
      class Dikdorgen : Sekil
    {
        public int kisaKenar { get; set; }
        public int uzunKenar{ get; set; }
        public Dikdorgen(String isim,int kisaKenar, int uzunKenar ): base(isim) 
        {
            this.kisaKenar = kisaKenar;
            this.uzunKenar = uzunKenar;
            
        }

        public override void sekilHesapla()
        {
            base.sekilHesapla();
            Console.WriteLine(getIsim()+" nin alanı: "+(kisaKenar*uzunKenar));
        }
        public override void sekilBİlgileriGoster()
        {
            base.sekilBİlgileriGoster();
            Console.WriteLine(getIsim()+" nin kısa kenarı : "+ kisaKenar);
            Console.WriteLine(getIsim() + " nin uzun kenarı : " + uzunKenar);
        }
    }
}
