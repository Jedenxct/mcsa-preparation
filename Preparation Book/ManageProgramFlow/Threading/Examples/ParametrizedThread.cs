using System.Threading;
using Threading.Interfaces;
using System;

namespace Threading.Examples
{
    public class ParametrizedThread : IExample
    {
        public void Run()
        {
            // takes a delegate with obj parameter
            // note: I wonder why there is no generic for ParametrizedThreadStart...
           
            Thread thread = new Thread(new ParameterizedThreadStart((id) => Console.WriteLine(id)));
            thread.Start(2);
            
            // be careful, it cannot be started twice
            // thread.Start(3);
        }
    }
}
