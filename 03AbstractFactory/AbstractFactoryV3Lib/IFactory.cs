using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryV3Lib
{
    public interface IFactory
    {
        Monitor MonitorYarat();
        Islemci IslemciYarat();
    }
}
