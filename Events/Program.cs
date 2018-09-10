using System;

namespace Events
{
    class Program
    {
        // declaration of a delegate
        // Handler suffix is a good practice
        public delegate void WorkPerformedHandler(int hours, WorkType workType);

        static void Main(string[] args)
        {
            // instantiate the delegate
            // tell it what method should it call
            var del = new WorkPerformedHandler(WorkPerformed);
            var del2 = new WorkPerformedHandler(WorkPerformed2);

            // execute the delegate
            del(2, WorkType.MakePizza);
        }

        static void WorkPerformed(int hours, WorkType workType)
        {
            Console.WriteLine($"Working on: {workType.ToString()} for {hours} hours");
        }

        static void WorkPerformed2(int hours, WorkType workType)
        {
            Console.WriteLine($"Working on: {workType.ToString()} for {hours} hours | work2");
        }
    }

    public enum WorkType
    {
        MakePizza,
        DoNothing,
        GenerateReports
    }
}
