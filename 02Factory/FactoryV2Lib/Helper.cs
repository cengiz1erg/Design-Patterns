using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryV2Lib
{
    //Factory pattern'e uygun bir class çünkü client artık abstract yapılar aracılığıyla işler yapacak. Fakat Open-Close'a uygun değil.
    public static class Helper
    {
        public static ICreator GetCreator(int creatorType)
        {
            if (creatorType == 1)
            {
                return new KrediKartiCreator();
            }
            else if (creatorType == 2)
            {
                return new HavaleCreator();
            }
            else
            {
                return null;
            }
        }

        public static ICreator GetBitcoinCreator(string cuzdanId)
        {
            return new BitcoinCreator(cuzdanId);
        }
    }
}
