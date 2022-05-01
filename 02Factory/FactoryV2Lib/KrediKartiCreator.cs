using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryV2Lib
{
    class KrediKartiCreator : ICreator
    {
        public IOdemeYapabilir GetOdeme()
        {
            return new KrediKartiOdeme();
        }
    }
}
