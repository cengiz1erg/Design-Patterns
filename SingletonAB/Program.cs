using System;
using System.Threading.Tasks;

namespace SingletonAB
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 8;
            Task[] tasks = new Task[size];
            for (int i = 0; i < size; i++)
            {
                tasks[i] = Task.Run(() => MemoryCache.Create());
            }
            Task.WaitAll(tasks);
        }
    }
}
