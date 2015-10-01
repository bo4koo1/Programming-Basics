using System;

namespace Problem_7.Reformat_CSharp_Code
{
    class GoodFormattedCode
    {
        static void Main()
        {
          Console.WriteLine("Hi, I am good formatted program");
          Console.WriteLine("Numbers and squares:");

             for (int i = 0; i < 10; i++)
                {                
                   Console.WriteLine(i+" --> " + i*i);
                }   
        }
    }
}