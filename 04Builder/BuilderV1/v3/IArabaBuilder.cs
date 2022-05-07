using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderV1.v3
{
    public interface IArabaBuilder
    {
        Araba BuildAraba(string marka, string model);
    }
}
