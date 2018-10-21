using System;
using System.Collections.Generic;
using System.Text;
using static Lambdas.Program;

namespace Lambdas
{
    public class ProcessData
    {
        // process method is modular
        // you can pass whatever business logic you want
        public void Process(int a, int b, BusinessRulesHandler handler)
        {
            int result = handler(a, b);
            Console.WriteLine(result);
        }
    }
}
