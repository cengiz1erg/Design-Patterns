using AbstractFactoryV2.Abstract;
using AbstractFactoryV2.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryV2.Factories
{
    public class OracleFactory : IDbFactory
    {
        public Command GetCommand()
        {
            return new OracleCommand();
        }

        public Connection GetConnection()
        {
            return new OracleConnection();
        }
    }
}
