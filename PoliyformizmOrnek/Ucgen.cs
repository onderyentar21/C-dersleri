using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliyformizmOrnek
{
    class Ucgen : Sekil
    {
        public int taban { get; set; }
        public int yukseklik { get; set; }
        public Ucgen(String isim,int taban, int yukseklik): base(isim) 
        {
            this.taban = taban;
            this.yukseklik = yukseklik;

        }

        public override void sekilBİlgileriGoster()
        {
            base.sekilBİlgileriGoster();
            Console.WriteLine(getIsim() + " nin tabanı : " + taban);
            Console.WriteLine(getIsim() + " nin yuksekliği : " + yukseklik);
        }
        public override void sekilHesapla()
        {
            base.sekilHesapla();
            Console.WriteLine(getIsim() + " alanı : " +( (taban * yukseklik) / 2));
        }
    }
}
