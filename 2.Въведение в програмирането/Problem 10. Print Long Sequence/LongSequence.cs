using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10.Print_Long_Sequence
{
    class LongSequence
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The first 1000 members of the sequence are:");
            for (int i = 2; i < 1002; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write((i) + ",");
                }
                else
                {
                    Console.Write((-i) + ",");
                }
            }
            Console.Write("\b");
            Console.Write("\t\n");
        }
    }
}

