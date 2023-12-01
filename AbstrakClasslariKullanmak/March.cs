using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrakClasslariKullanmak
{
    internal class March : AyAbstrackt
    {
        public override int gunSayisi()
        {
            return 31;
        }

        public override int yilinKacinciAyi()
        {
            return 3;
        }
    }
}
