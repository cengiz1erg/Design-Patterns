using AbstractFactoryV2.Factories;
using System;

namespace AbstractFactoryV2
{
    class Program
    {
        static void Main(string[] args)
        {
            DbClient dbClient = new DbClient(new OracleFactory(), "Server:.;Database:Blabla....");
            dbClient.Do("SELECT * FROM Products");
            Console.ReadKey();
        }
    }
}
