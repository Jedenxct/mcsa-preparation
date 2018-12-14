using System;
using System.Threading;
using Threading.Interfaces;

namespace Threading
{
    public class BackgroundThreads : IExample
    {
        public void Run()
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.IsBackground = true;
            t.Start();
        }

        private void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hello thread iteration: {0}", i);
                Thread.Sleep(1000);
            }
        }
    }
}
