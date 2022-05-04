using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryV3Lib
{
    public class Manager
    {
        static Dictionary<Bilisim, IFactory> sirketler;
        public Manager()
        {
            sirketler = new();
            sirketler.Add(Bilisim.A, new BilisimAFactory());
            sirketler.Add(Bilisim.B, new BilisimBFactory());
        }
        public static IFactory CreateFactory(Bilisim bilisim)
        {
            return sirketler[bilisim];
        }

    }
    public enum Bilisim
    {
        A,
        B
    }
}
