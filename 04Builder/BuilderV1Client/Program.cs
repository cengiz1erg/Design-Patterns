using BuilderV1.v1;
using BuilderV1.V2;
using BuilderV1.v3;
using BuilderV1.v4;
using System;

namespace BuilderV1Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //Agency agency = new Agency();
            //Policy policy = agency.Construct("Cengiz", "Jennifer");
            //Console.WriteLine(policy.Print());

            //IPolicyBuilder policyBuilder = new PolicyBuilder();
            //Policy policy = policyBuilder.BuildPolicy("abc", "def");

            //-------------------------------------------------------

            //IPolicyBuilder2 policyBuilder2 = new PolicyBuilder2();
            //Policy policy = policyBuilder2.BuildPolicy("cen", "giz", 10);

            //IPolicyBuilder2 policyBuilder2 = new PolicyBuilder2();
            //Insurer insurer = policyBuilder2.BuildInsurer("asdasd");

            //-------------------------------------------------------

            //Araba araba =  Araba.GetArabaBuilder().BuildAraba("BMV", "i3");

            //-------------------------------------------------------

            IComputerBuilder computerBuilder = new ComputerBuilder();
            var computer = computerBuilder.BuildCPU(5).BuildMotherboard("MOM").Build();

            Console.ReadKey();
        }
    }
}
