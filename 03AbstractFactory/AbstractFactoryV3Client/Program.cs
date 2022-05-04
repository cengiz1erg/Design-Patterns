using AbstractFactoryV3Lib;
using System;

namespace AbstractFactoryV1Client
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = Manager.CreateFactory(Bilisim.A);
            Islemci islemci = factory.IslemciYarat();
            Monitor monitor = factory.MonitorYarat();

            //Gerisi istemciye kalır. 
            Console.ReadKey();
        }
    }
}
