using System;

namespace Problem_12.Null_Values_Arithmetic
{
    class nullValues
    {
        static void Main(string[] args)
        {
            int? nullInt = null;
            Console.WriteLine(nullInt);
            double? nullDouble = null;
            Console.WriteLine(nullDouble);
            nullInt = 5;
            Console.WriteLine(nullInt);
            nullDouble = 10;
            Console.WriteLine(nullDouble);
        }
    }
}
