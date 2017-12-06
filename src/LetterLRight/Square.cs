using System;

namespace LetterLRight
{
    public class Square : Figure
    {
        /// <summary>Initializes a new instance of the <see cref="T:System.Object"></see> class.</summary>
        public Square(int length)
        {
            Length = length;
            Console.WriteLine($"Creating {typeof(Square).FullName} with length of {length}");
        }

        public int Length { get; set; }

        public override int CalculateArea()
        {
            return Length * Length;
        }
    }
}