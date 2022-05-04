using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryV3Lib
{
    class DbLogger : ILogger
    {
        public string Log(string info)
        {
            return $"Veritabanına {info} atıldı.";
        }
    }
}
