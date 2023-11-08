using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheratenceUygulama
{
    public class Yonetici : Calisan
    {
        private int sorumlukisisayisi;
        public Yonetici(int id, string name, string soyisim,int sorumluKisiSayisi) : base(id, name, soyisim)
        {

            this.sorumlukisisayisi = sorumluKisiSayisi;
        }
        public void zamYap(int zamMiktar)
        {
            Console.WriteLine(getName()+" "+zamMiktar+ " Tl çalışanlara zam yapıyor..");
        }
    }
}
