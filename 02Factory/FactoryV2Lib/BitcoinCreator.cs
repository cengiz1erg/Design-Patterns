using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryV2Lib
{
    class BitcoinCreator : ICreator
    {
        public string SogukCuzdanId { get; set; }
        public BitcoinCreator(string cuzdanId)
        {
            SogukCuzdanId = cuzdanId;
        }
        public IOdemeYapabilir GetOdeme()
        {
            return new BitcoinOdeme(SogukCuzdanId);
        }
    }
}
