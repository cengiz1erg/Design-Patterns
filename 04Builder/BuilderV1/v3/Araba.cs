using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderV1.v3
{
    //immutable nesne
    public class Araba
    {
        //public string Marka { get; private set; }
        string _marka;
        string _model;

        protected Araba(string marka, string model)
        {
            _marka = marka;
            _model = model;
        }

        public static IArabaBuilder GetArabaBuilder()
        {
            return new ArabaBuilder();
        }

        private class ArabaBuilder : IArabaBuilder //Nested Type, member of another class
        {
            public Araba BuildAraba(string marka, string model)
            {
                throw new NotImplementedException(); //return new Araba(marka, model);
            }
        }
    }
}
