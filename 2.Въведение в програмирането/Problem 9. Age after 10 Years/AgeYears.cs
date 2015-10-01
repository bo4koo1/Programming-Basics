using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.Age_after_10_Years
{
    class AgeYears
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Enter your birthday:");
            Console.WriteLine("year:");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("month:");
            int month= int.Parse(Console.ReadLine());
            Console.WriteLine("day:");
            int day= int.Parse(Console.ReadLine());

            int yearNow = 2015;
            int old;
            int after;
            old = yearNow - year;
            after = old + 10;
            Console.WriteLine("Your birthday is on:{0},{1},{2}",day,month,year);
            Console.WriteLine("Your are " + old + "years old now");
            Console.WriteLine("After 10 years you will be " + after + "years old!");          
        }
    }
}
