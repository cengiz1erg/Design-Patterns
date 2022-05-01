using FactoryV2Lib;
using System;

namespace FactoryV2Client
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreator creator = Helper.GetCreator(2);
            IOdemeYapabilir odeme = creator.GetOdeme();
            Console.WriteLine(odeme.OdemeYap(300));

            ICreator creator2 = Helper.GetBitcoinCreator("my cuzdan id");
            IOdemeYapabilir odeme2 = creator2.GetOdeme();
            Console.WriteLine(odeme2.OdemeYap(400));

            Console.ReadKey();
        }
    }
}
