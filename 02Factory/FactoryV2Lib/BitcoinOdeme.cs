using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryV2Lib
{
    class BitcoinOdeme : IOdemeYapabilir
    {
        public string SogukCuzdanId { get; set; }
        public BitcoinOdeme(string cuzdanId)
        {
            SogukCuzdanId = cuzdanId;
        }
        public string OdemeYap(decimal tutar)
        {
            return $"{tutar} bitcoin {SogukCuzdanId} id ile ödendi.";
        }
    }
}
