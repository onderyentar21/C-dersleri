using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifies
{
     class Program
    {
        static void Main(string[] args)
        {
            // protected: BUlunduğu classs içerisinde erişilen ve bulunduğu classı miras alan classlar içinde erişebilir.
            //Internal: BUlunduğu proje içinde her yerden erişilebilen bir erişim belirleyicisidir.
            //public: Hiç kısıtlaması olmayan her yerden erişmemize olanak sağlayan erişim belirleyicisidir.


            var ogrenci = new Ogrenci();

            Console.WriteLine(ogrenci.lastName);

            ogrenci.writeSchool();




         //   Console.WriteLine( "onder");
            Console.ReadLine();
        }
    }
}
