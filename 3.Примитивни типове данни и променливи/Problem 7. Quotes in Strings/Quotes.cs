using System;

namespace Problem_7.Quotes_in_Strings
{
    class Quotes
    {
        static void Main(string[] args)
        {
            string stringFirst="The \"use\" of quotations causes difficulties.";
            string stringSecond = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(stringFirst);
            Console.WriteLine(stringSecond);
        }
    }
}
