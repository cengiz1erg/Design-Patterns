using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryV1
{
    class HavaleOdeme
    {
        public string OdemeYap(decimal tutar)
        {
            return $"{tutar} havale ile ödendi";
        }
    }
}
