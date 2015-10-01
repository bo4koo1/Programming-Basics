using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Calculate_Hypotenuse
{
    class Program
    {
        static void Main(string[] args)
        {
            double cathed_1a = 3;
            double cathed_1b = 4;
            double hypotenuse_1 = (Math.Sqrt(cathed_1a * cathed_1a + cathed_1b * cathed_1b));
            Console.WriteLine("The hypotenuse 1 is:" + Math.Round(hypotenuse_1, 2));

            double cathed_2a = 10;
            double cathed_2b = 12;
            double hypotenuse_2 = (Math.Sqrt(cathed_2a * cathed_2a + cathed_2b * cathed_2b));
            Console.WriteLine("The hypotenuse 2 is:" + Math.Round(hypotenuse_2, 2));

            double cathed_3a = 100;
            double cathed_3b = 250;
            double hypotenuse_3 = (Math.Sqrt(cathed_3a * cathed_3a + cathed_3b * cathed_3b));
            Console.WriteLine("The hypotenuse 3 is:" + Math.Round(hypotenuse_3, 2));
        }
    }
}
