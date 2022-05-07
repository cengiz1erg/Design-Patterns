using BuilderV1.v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderV1.V2
{
    public class PolicyBuilder2 : IPolicyBuilder2
    {
        public List<Coverage> BuildCoverages(decimal price)
        {
            List<Coverage> coverages = new List<Coverage>();
            coverages.Add(new Coverage());
            return coverages;
        }

        public Insured BuildInsured(string name)
        {
            Insured insured = new Insured();
            insured.Name = name;
            return insured;
        }

        public Insurer BuildInsurer(string name)
        {
            Insurer insurer = new Insurer();
            insurer.Name = name;
            return insurer;
        }

        public Policy BuildPolicy(string insurerName, string insuredName, decimal price)
        {
            Policy policy = new Policy();
            policy.Insured = BuildInsured(insuredName);
            policy.Insurer = BuildInsurer(insurerName);
            policy.Coverages = BuildCoverages(price);
            return policy;
        }
    }
}
