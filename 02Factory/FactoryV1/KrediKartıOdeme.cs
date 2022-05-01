using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryV1
{
    class KrediKartıOdeme
    {
        public string OdemeYap(decimal tutar)
        {
            return $"{tutar} kredi kartı ile ödendi";
        }
    }   
}
