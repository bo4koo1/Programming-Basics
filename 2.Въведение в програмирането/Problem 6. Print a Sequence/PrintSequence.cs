using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Print_a_Sequence
{
    class PrintSequence
    {
        static void Main(string[] args)
        {
          Console.WriteLine("The first 10 members of the sequence are:");
            for (int i = 2; i < 12; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write((i)+",");
                }
                else
                {
                    Console.Write((-i)+",");
                }                            
            }
            Console.Write("\b");
            Console.Write("\t\n");
        }
    }
}


        
