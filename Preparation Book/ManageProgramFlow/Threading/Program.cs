using System;
using System.Threading;
using Threading.Interfaces;

namespace Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            IExample background = new BackgroundThreads();
            background.Run();
        }
    }
}
