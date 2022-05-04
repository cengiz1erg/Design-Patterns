using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryV2.Abstract
{
    public abstract class Command
    {
        //public Connection connection { get; set; }
        public string Query { get; set; }
        public abstract void Execute();
    }
}
