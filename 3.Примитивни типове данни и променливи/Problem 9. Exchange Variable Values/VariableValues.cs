using System;

namespace Problem_9.Exchange_Variable_Values
{
    class VariableValues
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Before:\na={0}\nb={1}", a, b);
            a += 5;
            b += -5;
            Console.WriteLine("After:\na={0}\nb={1}", a, b);
        }
    }
}
