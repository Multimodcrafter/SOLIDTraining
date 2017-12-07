using System;

namespace LetterIRight
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var duck = new Duck();
            DoRun(duck);
            DoSwim(duck);
            DoFly(duck);

            var runnerDuck = new RunnerDuck();
            DoRun(runnerDuck);
            DoSwim(runnerDuck);
            //DoFly(runnerDuck); <-- not possible: Build will fail!

            Console.ReadLine();
        }

        private static void DoSwim(ISwimmable duck)
        {
            duck.Swim();
        }

        private static void DoFly(IFlyable duck)
        {
            duck.Fly();
        }

        private static void DoRun(IRunnable duck)
        {
            duck.Run();
        }
    }
}
