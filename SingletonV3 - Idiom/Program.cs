using System;

namespace SingletonV3___Idiom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Singleton
    {
        private static readonly Singleton _instance = new Singleton();
        protected Singleton()
        {

        }

        public Singleton GetInstance()
        {
            return _instance;
        }
    }
}
