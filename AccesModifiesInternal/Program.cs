using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test12;

namespace AccesModifiesInternal
{
    internal class Program
    {
        static void Main(string[] args)

            // internal erişim belirleyicisi sadece bulunduğu proje içerisinde erişilebilir.
        {
            Musteri musteri = new Musteri();
            musteri.publicMetot();

            Isci isci1 = new Isci();
            Console.WriteLine(isci1.soyiism="Yentar");
            isci1.biligleriGoster();







            Console.ReadLine();
        }
    }
}
