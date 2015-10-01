using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Some_Primes
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            for (int i = 1; i <= 1700; i++)
            {
                int j;
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0 && i != j)
                    {
                        break;
                    }
                }
                if (j == i)
                {
                    count++;
                    if (count == 24)
                        Console.WriteLine("Prime" + 24 + ": " + i);
                    if (count == 101)
                        Console.WriteLine("Prime" + 101 + ": " + i);
                    if (count == 251)
                        Console.WriteLine("Prime" + 251 + ": " + i);
                }
            }
        }
    }
  }

  