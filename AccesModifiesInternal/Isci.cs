using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesModifiesInternal
{
    class Isci
    {
        public int id = 1;
        public string isim = "onder";
        public string soyiism { get; set; }

        public void biligleriGoster()
        {
            Console.WriteLine("id : "+id);
            Console.WriteLine("isim : "+isim);
            Console.WriteLine("soyisim: "+soyiism);
            deneme();
        }
        private void deneme()
        {
            Console.WriteLine(  "this is deneme.");
        }
    }
}
