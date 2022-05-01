using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryV2Lib
{
    public interface ICreator
    {
        IOdemeYapabilir GetOdeme();
    }
}
