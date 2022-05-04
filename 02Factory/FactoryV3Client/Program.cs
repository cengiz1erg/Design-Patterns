using FactoryV3Lib;
using System;

namespace FactoryV3Client
{
    class Program
    {
        static void Main(string[] args)
        {
            LoggerManager loggerManager = new();
            ILoggerFactory loggerFactory = loggerManager.CreateFactory(LogType.DbLogger);
            ILogger logger = loggerFactory.Create();
            Console.WriteLine(logger.Log("Selam"));
        }
    }
}
