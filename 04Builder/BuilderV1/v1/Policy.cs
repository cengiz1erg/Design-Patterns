using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderV1.v1
{
    // Agency(Acenta) içerisinde builder pattern'i Policy Class'ı için uygulanacak.
    public class Policy
    {
        public Insured Insured { get; set; }
        public Insurer Insurer { get; set; }
        public List<Coverage> Coverages { get; set; }
        public string Print()
        {
            return $"Poliçe basıldı. Sigorta ettiren {Insurer.Name} Sigorta edilen {Insured.Name}";
        }
    }
}
