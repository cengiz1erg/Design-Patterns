using System;
using System.Threading;

namespace v1
{
    class Program
    {
        private const int number = 100;
        static void Main(string[] args)
        {
            Thread t = new Thread(MyDelegate);
            t.Start();
            for (int i = 0; i < number; i++)
            {
                Console.Write(1);
            }
        }
        static void MyDelegate()
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write(0);
            }
        }
    }
}
