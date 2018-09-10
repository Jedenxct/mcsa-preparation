using System;

namespace Event
{
    class Program
    {
        static void Main(string[] args)
        {
            var nose = new Nose();
            nose.Sneeze("fucking much");

            var delay = new Delay();
            delay.Run();
        }
    }
}
