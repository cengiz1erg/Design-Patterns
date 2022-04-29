using System;

namespace SingletonA
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton2 = Singleton.GetInstance();
            Singleton singleton1 = Singleton.GetInstance();
            if (singleton1 == singleton2)
            {
                Console.WriteLine("Esittir.");
            }
        }
    }
}
