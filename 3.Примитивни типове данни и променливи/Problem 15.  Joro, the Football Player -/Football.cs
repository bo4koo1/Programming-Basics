using System;
using System.Diagnostics;
using System.Threading;

class Football
{
    private static double leapYears;

    static void Main(string[] args)
    {
        Console.WriteLine("Enter type of year:t-for leap year, f-for year that is not leap");
        string symbol = Console.ReadLine();
        string leap = "t";
        string notLeap = "f";
        if (symbol == leap)
        {
            leapYears = 3;
        }
        else if (symbol == notLeap)
        {
            leapYears = 0;
        }
        else
        {
            Console.WriteLine("Error!Wrong insert!");
            System.Environment.Exit(1);
        }
        double totalWeekends = 52;
        Console.WriteLine("Enter number of holidays:");
        double holidays = (double.Parse(Console.ReadLine()));
        double holidayPlays = 0.5 * holidays;
        Console.WriteLine("Enter hometown weekends:");
        double hometownWeekends = (double.Parse(Console.ReadLine()));
        double normalWeekends = totalWeekends - hometownWeekends;
        double normalPlays = normalWeekends * 2 / 3;
        Console.WriteLine("Joro plays football {0} times", Math.Floor(hometownWeekends + normalPlays + holidayPlays + leapYears));

    }
}


