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

            // this kind of resembles the javascript callbacks to me
            // you just pass a function to be called
            DoWork(del);
            DoWork(del2);

            // multiple delegates
            DoAllWork();
        }

        // modular design | no need to hardcode WorkPerformed, just call whatever is passed
        static void DoWork(WorkPerformedHandler handler)
        {
            // WorkPerformed(8, WorkType.DoNothing);
            handler(8, WorkType.DoNothing);
        }

        // add delegates 2 and 3 to the invocation list of the first one
        // methods get invoked in order that were added in
        static void DoAllWork()
        {
            var del = new WorkPerformedHandler(WorkPerformed);
            var del2 = new WorkPerformedHandler(WorkPerformed2);
            var del3 = new WorkPerformedHandler(WorkPerformed3);

            del += del2 += del3;

            del(1, WorkType.GenerateReports);
        }

        static void WorkPerformed(int hours, WorkType workType)
        {
            Console.WriteLine($"Working on: {workType.ToString()} for {hours} hours");
        }

        static void WorkPerformed2(int hours, WorkType workType)
        {
            Console.WriteLine($"Working on: {workType.ToString()} for {hours} hours | work2");
        }

        static void WorkPerformed3(int hours, WorkType workType)
        {
            Console.WriteLine($"Working on: {workType.ToString()} for {hours} hours | work3");
        }
    }

    public enum WorkType
    {
        MakePizza,
        DoNothing,
        GenerateReports
    }
}
