using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonAB
{
    class MemoryCache
    {
        private static int i = 0;
        private static MemoryCache _instance;
        private MemoryCache()
        {
            Console.WriteLine($"Created {i++}");
        }
        public static MemoryCache Create()
        {
            return _instance ?? (_instance = new MemoryCache());
        }

    }
}
