using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryV3Lib
{
    class DbLoggerFactory : ILoggerFactory
    {
        public ILogger Create()
        {
            return new DbLogger();
        }
    }
}
