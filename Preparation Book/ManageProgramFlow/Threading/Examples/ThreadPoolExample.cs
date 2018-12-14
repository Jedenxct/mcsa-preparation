using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Threading.Interfaces;

namespace Threading.Examples
{
    public class ThreadPoolExample : IExample
    {
        // instead of letting the threads die, it is a good idea to keep them in the pool
        // every time new task is scheduled, the pool dedicates/reuses existing thread that was inactive

        public void Run()
        {
            // what is a?
            ThreadPool.QueueUserWorkItem((a) => Console.WriteLine("Previously queued, now running."));
        }
  
    }
}
