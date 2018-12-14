using System;
using System.Threading;
using Threading.Interfaces;
using Threading.Examples;

namespace Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            IExample background = new BackgroundThreads();
            background.Run();

            IExample parametrized = new ParametrizedThread();
            parametrized.Run();

            IExample threadStatic = new ThreadStatic();
            threadStatic.Run();
        }
    }
}
