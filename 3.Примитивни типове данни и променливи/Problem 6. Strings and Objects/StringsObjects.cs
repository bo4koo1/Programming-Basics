using System;

namespace Problem_6.Strings_and_Objects
{
    class StringsObjects
    {
        static void Main(string[] args)
        {
            string stringFirst = "Hello";
            string stringSecond = "World";
            object concatenation = (stringFirst + " " + stringSecond);
            string stringThird = (string)concatenation;
            Console.WriteLine(stringThird);
        }
    }
}
