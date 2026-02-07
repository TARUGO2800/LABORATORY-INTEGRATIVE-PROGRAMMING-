using System;

namespace MathApp
{
    class MathProgram
    {
        static void Main(string[] args)
        {
            int a = 11;
            int b = 5;

            int absoluteValue = Math.Abs(-a);

            int maxValue = Math.Max(a, b);

            int minValue = Math.Min(a, b);

            double powerValue = Math.Pow(a, b);

            double squareRootValue = Math.Sqrt(a);

            Console.WriteLine("------------------");
            Console.WriteLine("Absolute value: " + absoluteValue);
            Console.WriteLine("Maximum value: " + maxValue);
            Console.WriteLine("Minimum value: " + minValue);
            Console.WriteLine("Power value: " + powerValue);
            Console.WriteLine("Square root: " + squareRootValue);
            Console.WriteLine("------------------");

            Console.ReadLine();
        }
    }
}