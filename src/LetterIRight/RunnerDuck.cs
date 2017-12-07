using System;

namespace LetterIRight
{
    public class RunnerDuck : IRunnable, ISwimmable
    {
        public void Run()
        {
            Console.WriteLine("running");
        }

        public void Swim()
        {
            Console.WriteLine("swimming");
        }
    }
}