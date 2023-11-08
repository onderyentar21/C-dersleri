using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassKullanimi
{
    public class Araba
    {
       
        public int kapiSayisi;
        public String arabaModel;
        public string arabaRengi;

        public Araba() {
        
        }
        public Araba(int kapiSayisi, String arabaModel, String arabaRengi) { 
        
            // this olmadanda bunu atayabilirz eğer contraktor degeri değişkenlerini farklı bir isimde taanımlasaydık.
            this.kapiSayisi= kapiSayisi;
            this.arabaModel= arabaModel;
            this.arabaRengi= arabaRengi;
        
        }

        public void mototCalistir()
        {
            Console.WriteLine("Motor çalışıyor..");
        }
        public void kapilarKilitle()
        {
            Console.WriteLine("kapilar kilitleniyor.");
        }

    }
}
