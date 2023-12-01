using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerikClassNedir
{
    internal class Repository<T>
    {
        public List<T> Getir()
        {
            //veri tabanindan ilgili tabana git ve oradaki katirlari getir.
            return null;


        }
        public string ekle(T data)
        {
            // veri tabanına git ilgili tabloya şu T tipindeki datayı ekle.
            return "degerler basarili bir sekilde eklendi";
 
        }

    }
}
