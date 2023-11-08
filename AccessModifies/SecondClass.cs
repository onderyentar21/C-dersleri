using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifies
{
   public class SecondClass
    {
        private void privateMethod()
        {
            Console.WriteLine("this is a priva class..");
            Console.ReadLine();
        }
        protected void protectedMethod()
        {
            Console.WriteLine("this is protected class.");

            Console.ReadLine();
        }
    }
}
