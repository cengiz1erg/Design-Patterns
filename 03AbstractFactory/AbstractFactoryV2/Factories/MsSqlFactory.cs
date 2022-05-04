using AbstractFactoryV2.Abstract;
using AbstractFactoryV2.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryV2.Factories
{
    class MsSqlFactory : IDbFactory
    {
        public Command GetCommand()
        {
            return new MsSqlCommand();
        }

        public Connection GetConnection()
        {
            return new MsSqlConnection();
        }
    }
}
