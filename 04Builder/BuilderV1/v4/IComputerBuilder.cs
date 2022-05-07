using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderV1.v4
{
    public interface IComputerBuilder
    {
        IComputerBuilder BuildCPU(int cpu);
        IComputerBuilder BuildMotherboard(string name);
        Computer Build();
    }
}
