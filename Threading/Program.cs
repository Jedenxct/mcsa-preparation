using System;
using System.Threading;

namespace Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            // thread takes a delegate of an entry point method
            var thread = new Thread(NewMain);
            thread.Start();

            // parametrized
            var parametrizedThread = new Thread(ParametrizedMethod);
            var processorCount = Environment.ProcessorCount;
            parametrizedThread.Start(processorCount);
        }

        static void NewMain()
        {
            Console.WriteLine("Main has moved here huh.");
        }

        static void ParametrizedMethod(object parameter)
        {
            Console.WriteLine("Processor count: " + parameter);
        }
    }
}
