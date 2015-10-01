using System;

namespace Problem_4.Unicode_Character
{
    class UnicodeCharacter
    {
        static void Main(string[] args)
        {
            char symbol='\u002A';
            Console.WriteLine("The symbol that has unicode {0} is {1}",(int)symbol,symbol);
        }
    }
}
