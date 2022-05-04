using AbstractFactoryV2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryV2.Concrete
{
    class OracleConnection : Connection
    {
        public override void Close()
        {
            Console.WriteLine($"Oracle bağlantısı kapandı. : {ConnectionString}");
        }

        public override void Open()
        {
            Console.WriteLine($"Oracle bağlantısı açıldı. : {ConnectionString}");
        }
    }
}
