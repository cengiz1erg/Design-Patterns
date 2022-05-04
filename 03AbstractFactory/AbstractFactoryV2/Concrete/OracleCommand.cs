using AbstractFactoryV2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryV2.Concrete
{
    class OracleCommand : Command
    {
        public override void Execute()
        {
            Console.WriteLine($"Oracle Sorgusu çalıştırıldı.{Query}");
        }
    }
}
