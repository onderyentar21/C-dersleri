using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EnumlaraGiris
{
    public class Program
    {
        static void Main(string[] args)
        {
          Gunler gun =  Gunler.Sali;   
            
            
            if(gun.Equals(Gunler.Pazartesi))
            {
                Console.WriteLine("Gun pazartesidir.");
            }
            else if(gun.Equals(Gunler.Sali)){
                Console.WriteLine("Sali");
            }
            else if (gun.Equals(Gunler.Carsamba))
            {
                Console.WriteLine("Carşambadır.");
            }
            else if (gun.Equals(Gunler.Persembe))
            {
                Console.WriteLine("Perşembedir.");
            }
            else if (gun.Equals(Gunler.Cuma))
            {
                Console.WriteLine("Cumadir.");
            }
            else if (gun.Equals(Gunler.Cumartesi))
            {
                Console.WriteLine("Cumartesidir.");
            }
            else if (gun.Equals(Gunler.Pazar))
            {
                Console.WriteLine("Pazardır.");
            }
            else
            {
                Console.WriteLine("plase enter a valid day...");
            }

            Console.ReadLine();
        }
      

    }
}
