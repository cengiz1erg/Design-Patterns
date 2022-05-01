using System;
using System.Threading;

// Multithread Architecture
namespace SingletonV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(MyFunc);
            t.Start();
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Main Thread");
                Singleton.GetInstance();
            }
        }

        public static void MyFunc()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Another Thread");
                Singleton.GetInstance();
            }
        }
    }

    class Singleton
    {
        private static Singleton _instance;
        private static Object _lock = new();
        private static int _counter = 1;
        private Singleton()
        {
            Console.WriteLine($"{_counter++}th instance created.");
        }

        public static Singleton GetInstance()
        {
            if(_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }
            }
            return _instance;
        }
    }
}
