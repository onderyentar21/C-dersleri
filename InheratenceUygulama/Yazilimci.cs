using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheratenceUygulama
{
public class Yazilimci : Calisan
    {
        // burda miras aldığım için constroctor kullandım ve constrtor parametrelerini tanımladım. ve bu parametreli base clastan alı
        //alıp buraya tanımladım yani :Base() içine parametre belirttim ya bu bi nebi this gibi  yada javada Super() gibi.

        private String diller;

        public Yazilimci(int id, String name,String soyisim,string diller):base(id, name, soyisim)
        {
            this.diller = diller;
        }
        public void format_at(String isletim_sistemi)
        {
            Console.WriteLine(getName()+" "+isletim_sistemi+" işletim sistemine format atıyor...");
        }
    }
}
