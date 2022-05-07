using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderV1.v1
{
    public class Agency
    {
        IPolicyBuilder _policyBuilder;
        //public Agency(IPolicyBuilder policyBuilder)
        //{
        //    _policyBuilder = policyBuilder;
        //}
        public Agency()
        {
            _policyBuilder = new PolicyBuilder();
        }
        public Policy Construct(string insuredName, string insurerName)
        {
            return _policyBuilder.BuildPolicy(insuredName, insurerName);
        }
    }
}
