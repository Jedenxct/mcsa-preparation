using System;
using System.Threading;
using System.Threading.Tasks;
using Threading.Interfaces;

namespace Threading.Examples
{
    public class ParallelExample : IExample
    {
        public void Run()
        {
            Parallel.For(0, 10, (i) => WriteNumber(i)); // quick

            for (int i = 0; i < 10; i++) // stupidly slow
            {
                WriteNumber(i);
            }
        }

        private void WriteNumber(int num)
        {
            Thread.Sleep(1000);
            Console.WriteLine(num);
        }
    }
}
