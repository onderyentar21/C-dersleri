using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifies
{
    internal class Ogrenci
    {
        private int id = 1;
        private string name = "Onder";
        public string lastName = "yentar";
        public string school = "UCF";

        private void writename()
        {
            Console.WriteLine( "name AND LAST NAME : "+ name+ lastName);
        }
        public void writeSchool()
        {
            Console.WriteLine("your school name : "+school);
        }
    }
}
