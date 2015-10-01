using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Least_Common_Multiple
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1234;
            int b = 3456;
            int LCM;   //Least Common Multiple 
            
                while (a != b)
                {
                    if (a > b) a = a - b;
                    else b = b - a;
                }
                Console.WriteLine("First found Most Greatest Common Divisor via Euclidean algorithm");
                Console.WriteLine("MGCD is:" + a);  //MGCD-most greatest common divisor
                Console.WriteLine("Second found Least Common Multiple by: LCM(a,b)=(axb)/MGCD(a,b) ");
                LCM = (1234 * 3456) / a;
                Console.WriteLine("Least Common Multiple of 1234 and 3456 is:" + LCM);
            
        }
    }
}