using BuilderV1.v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderV1.V2
{
    public interface IPolicyBuilder2
    {
        Insurer BuildInsurer(string name);
        Insured BuildInsured(string name);
        List<Coverage> BuildCoverages(decimal price);
        Policy BuildPolicy(string insurerName, string insuredName, decimal price);
    }
}
