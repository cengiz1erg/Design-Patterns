using System;

namespace FactoryV1
{
    class Program
    {
        static void Main(string[] args)
        {
            OdemeTipleri odemeTipi = OdemeTipleri.KrediKarti;
            OdemeHelper odemeHelper = new OdemeHelper();
            Console.WriteLine(odemeHelper.Ode(400, odemeTipi)); 
            Console.ReadKey();
        }
    }
}
