using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem_3.Some_Factorials
{
    class Program
    {
       static void Main(string[] args){

        BigInteger number1=1;
          for (int i =1;i<=100;i++)
            {
               number1 = number1 * i;
            }
               Console.WriteLine("100!=" +number1 + "\n");
               
        BigInteger number2 = 1; 
          for (int i = 1; i <= 171; i++)
            {
                number2 = number2 * i;
            }
               Console.WriteLine("171!=" + number2 + "\n");

         BigInteger number3 = 1; 
          for (int i = 1; i <= 250; i++)
            {
                number3 = number3 * i;
            }
               Console.WriteLine("250!=" + number3);
        }
    }
}


