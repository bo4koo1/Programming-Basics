using System;

namespace Problem_13.Comparing_Floats_____
{
    class Comparing
    {
        static void Main(string[] args)
        {
            double eps = 0.000001;
            Console.WriteLine("Enter first number:");
            double a = (double.Parse(Console.ReadLine()));
            Console.WriteLine("Enter second number:");
            double b = (double.Parse(Console.ReadLine()));
            bool equalAB = Math.Abs(a - b) < eps;
            Console.WriteLine("Are number {0} and {1} equal? {2}", a, b, equalAB);
        }
    }
}
