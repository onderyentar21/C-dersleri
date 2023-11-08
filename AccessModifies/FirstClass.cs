using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifies
{
    //c# claslar böyle miras alınır : ve miras etmek istediğimiz class ın ismini yazıyoruz.S
   public class FirstClass : SecondClass
    {
        public FirstClass()
        {
            protectedMethod();
        }


    }
}
