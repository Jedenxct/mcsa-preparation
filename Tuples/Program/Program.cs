using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // unnamed tuple
            var unnamed = (2, "Franto", 3);

            Console.WriteLine(unnamed.Item1);
            Console.WriteLine(unnamed);

            // named tuple
            var named = (age: 23, name: "Franto");

            // named tuples have aliases for properties
            Console.WriteLine(named.Item1);
            Console.WriteLine(named.age);
            Console.WriteLine(named);
        }
    }
}
