using BuilderV1.v1;
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

            IPolicyBuilder policyBuilder = new PolicyBuilder();
            Policy policy = policyBuilder.BuildPolicy("abc", "def");

            Console.ReadKey();
        }
    }
}
