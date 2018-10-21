using System;

namespace Lambdas
{
    public class Program
    {
        public delegate int BusinessRulesHandler(int a, int b);

        static void Main(string[] args)
        {
            var data = new ProcessData();

            // you can either pass in handler
            var addDelegate = new BusinessRulesHandler(Add);
            data.Process(2, 3, addDelegate);
            
            // or you can pass a lambda
            // lambda automatically infers types of a and b
            data.Process(2, 3, (a, b) => a + b);
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
