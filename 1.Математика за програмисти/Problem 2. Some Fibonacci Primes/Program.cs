using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Some_Fibonacci_Primes
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 30;
            int a = 0;
            int b = 1;
            int sum = 0;
            

            Console.WriteLine("The first 30 Fibonacci numbers are:\n");
            for (int i = 0; i < n; i++)
            {
                sum = a;
                a = b;
                b = sum + b;

                Console.Write(sum + ", ");
                
                if (sum == 89)
                    Console.WriteLine("\nThe 24th Prime number is 89 and it is a Fibonacci number!" +"It is the "+ ++i +"th number in Fibonacci number set.\n" );
                
                if (sum == 1597)
                    Console.WriteLine("\nThe 251th Prime number is 1597 and it is a Fibonacci number!" + "It is the " + i + "th number in Fibonacci number set.\n");
              }
        
           }
       }
}
    


