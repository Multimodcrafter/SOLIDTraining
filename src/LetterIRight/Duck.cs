using System;

namespace LetterIRight
{
    public class Duck : IRunnable, IFlyable, ISwimmable
    {
        public void Run()
        {
            Console.WriteLine("running");
        }

        public void Fly()
        {
            Console.WriteLine("flying");
        }

        public void Swim()
        {
            Console.WriteLine("swimming");
        }
    }
}