using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryV3Lib
{
    internal class BilisimAFactory : IFactory
    {
        public Islemci IslemciYarat()
        {
            return new AmdIslemci();
        }

        public Monitor MonitorYarat()
        {
            return new SamsungMonitor();
    }
}
