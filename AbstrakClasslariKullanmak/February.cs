using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrakClasslariKullanmak
{
    internal class February : AyAbstrackt
    {
        public override int gunSayisi()
        {
            return 28;
        }

        public override int yilinKacinciAyi()
        {
            return 2;
        }
    }
}
