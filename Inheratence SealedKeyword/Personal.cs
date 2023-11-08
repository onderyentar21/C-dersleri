using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheratence_SealedKeyword
{
    // sealed anahtar kelimesi bir clası mühürler yani kimse o clası inheratence ( miras) alamaz.
    public sealed class Personal
    {
        public int personal_id { get; set; }
        public String personal_name { get; set; }
        public String personal_lastname { get; set; }
        public int personal_maas{ get; set; }

        public void PersonalBilgiler()
        {
            Console.WriteLine("Personal information: ");
            Console.WriteLine("Personal id: "+personal_id);
            Console.WriteLine("personal name: "+personal_name);
            Console.WriteLine("personal LastName: "+personal_lastname);
            Console.WriteLine("personal maas: "+ personal_maas);
        }
    }
}
