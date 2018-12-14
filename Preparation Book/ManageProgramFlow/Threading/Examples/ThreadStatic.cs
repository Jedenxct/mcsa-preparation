using System;
using System.Threading;
using Threading.Interfaces;

namespace Threading.Examples
{
    public class ThreadStatic : IExample
    {
        public static int _commonCounter = 0;

        [ThreadStatic]
        public static int _threadStaticCounter = 0;

        public void Run()
        {
            // shared counter with no attribute
            new Thread(new ParameterizedThreadStart(IncrementCounter)).Start("A");
            new Thread(new ParameterizedThreadStart(IncrementCounter)).Start("B");

            // unique counter for both threads
            new Thread(new ParameterizedThreadStart(IncrementThreadStaticCounter)).Start("A");
            new Thread(new ParameterizedThreadStart(IncrementThreadStaticCounter)).Start("B");
        }

        private void IncrementCounter(object name)
        {
            for (int i = 0; i < 10; i++)
            {
                _commonCounter++;
                Console.WriteLine($"{name}: Common counter {_commonCounter}");
            }
        }

        private void IncrementThreadStaticCounter(object name)
        {
            for (int i = 0; i < 10; i++)
            {
                _threadStaticCounter++;
                Console.WriteLine($"{name}: Unique counter {_threadStaticCounter}");
            }
        }
    }
}
