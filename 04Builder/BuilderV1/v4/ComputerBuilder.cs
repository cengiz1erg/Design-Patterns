using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderV1.v4
{
    public class ComputerBuilder : IComputerBuilder
    {
        Computer computer;
        public ComputerBuilder()
        {
            computer = new Computer();
        }

        public Computer Build()
        {
            return computer;
        }

        public IComputerBuilder BuildCPU(int cpu)
        {
            computer.CPU = cpu;
            return this;
        }

        public IComputerBuilder BuildMotherboard(string name)
        {
            //if (computer.CPU == default(int))
            //{
            //    throw new Exception();
            //}
            computer.Motherboard = name;
            return this;
        }


    }
}
