using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOrnek
{
    class Ogrenci
    {
        private int ogrenciNo;
        private String isim;
        private string soyisim;
        private int vize1;
        private int vize2;
        private int final;
        private string okulIsmi;

        public Ogrenci(int ONo, string isim, string soyisim, int v1, int v2, int fnl, string okulI)
        {
            this.ogrenciNo = ONo;
            this.isim = isim;
            this.soyisim = soyisim;
            this.vize1 = v1;
            this.vize2 = v2;
            this.final = fnl;
            this.okulIsmi = okulI;


        }

        public void ogrenciBilgileriGoster()
        {

            Console.WriteLine("ogrenci ismi: "+isim);
            Console.WriteLine("ogrenci soyisim: " + soyisim);
            Console.WriteLine("ogrenci no: " + ogrenciNo);

            
        }
        public double ogrenciOrtalamaBul()
        {
            double ortlama = (vize1 * 0.3) + (vize2 * 0.3) + (final * 0.4);
            Console.WriteLine("ogrencinin ortalaması: " + ortlama);
            Console.ReadLine();

            return ortlama;

        }
        public void okulGetir()
        {
            Console.WriteLine("ogrencinin okulu: "+okulIsmi);
            Console.ReadLine();
        }

    }
}