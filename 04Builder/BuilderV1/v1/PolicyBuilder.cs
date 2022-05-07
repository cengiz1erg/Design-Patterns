using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderV1.v1
{
    public class PolicyBuilder : IPolicyBuilder
    {
        private Policy policy;
        void BuildInsured(string name)
        {
            Insured insured = new Insured { Name = name };
            policy.Insured = insured;
        }
        void BuildInsurer(string name)
        {
            Insurer insurer = new Insurer { Name = name };
            policy.Insurer = insurer;
        }
        void BuildCoverages()
        {
            List<Coverage> coverages = new();
            policy.Coverages = coverages;
        }
        public Policy BuildPolicy(string insuredName, string insurerName)
        {
            policy = new Policy();
            BuildInsured(insuredName);
            BuildInsurer(insurerName);
            BuildCoverages();
            return policy;
        }
    }
}
