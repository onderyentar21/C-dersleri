using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodlaraGiris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            onder();
            salih();

           
        }

        
         static void onder()
        {
            Console.WriteLine("onder bu metodu oluşturdu ve bu method geriye deger döndürmeyen bir methods..");
            Console.ReadLine();

        }
        static String salih()
        {
            Console.WriteLine("lütfen ismi giriniz!!");

            String saliss = Console.ReadLine();
          
           
            Console.WriteLine("isminiz : "+saliss);
            Console.ReadLine();
            return saliss;
        }
    }
}
