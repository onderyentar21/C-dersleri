using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheratenceUygulama
{
    public class Calisan
    {
        private int id;
        private string name;
        private string soyiIsim;

        public Calisan(int id, string name, string soyisim)
        {
            this.id = id;
            this.name = name;
            this.soyiIsim = soyisim;
        }

        public int getId()
        {
            return this.id;
        }
        public void SetId(int id)
        {
            this.id=id;
        }
        public String getName()
        {
            return this.name;
        }
        public void setName(String name)
        {
            this.name=name;
        }
        public string getSoyiIsim()
        {
            return this.soyiIsim;
        }
        public void setSoyisim(String soyisim)
        {
            this.soyiIsim=soyisim;
        }

        public void bilgileriGoster()
        {
            Console.WriteLine("id : "+this.id);
            Console.WriteLine("isim: "+this.name);
            Console.WriteLine("soyisim: "+this.soyiIsim);
        }
    }
}
