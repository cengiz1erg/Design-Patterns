using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderV1.v1
{
    public interface IPolicyBuilder
    {
        Policy BuildPolicy(string insuredName, string insurerName);
    }
}
