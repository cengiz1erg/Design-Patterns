using AbstractFactoryV2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryV2
{
    public interface IDbFactory
    {
        Connection GetConnection();
        Command GetCommand();
    }
}
