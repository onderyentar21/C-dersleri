using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheratence_SealedKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Musteri musteri= new Musteri();
            musteri.personal_id = 1;
            musteri.personal_name = "ali";
            musteri.personal_lastname = "garip";
            musteri.personal_maas = 8800;
            musteri.PersonalBilgiler();
            Console.ReadLine();
        }
    }
}
