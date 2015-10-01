using System;
using System.Linq;

class halfSum
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of numbers that you will enter:");
        int number = (int.Parse(Console.ReadLine()));
        int[] numbers = new int[number*2];
        Console.WriteLine("Enter the numbers:");

            for (int i = 0; i < number*2; i++)
                {
                   numbers[i] = (int.Parse(Console.ReadLine()));                   
                }
        Console.Write("The numbers are:");
            for (int i = 0; i < number*2; i++)
                {
                   Console.Write(numbers[i] + ",");
                }

        Console.Write("\b" + "\t");
        Console.WriteLine();
        int sum = numbers.Sum();
        Console.WriteLine("The sum of the numbers is:"+sum);
        int[] firstArray, secondArray;
        int mid = numbers.Length / 2;
        firstArray = numbers.Take(numbers.Length / 2).ToArray();
        secondArray = numbers.Skip(numbers.Length / 2).ToArray();
        int firstSum = firstArray.Sum();
        Console.WriteLine("The sum of the first half {0} numbers is {1}", number, firstSum);
        int secondSum = secondArray.Sum();
        Console.WriteLine("The sum of the other half of {0} numbers is {1}", number, secondSum);

           if (firstSum==secondSum )
               {
                  Console.WriteLine("Sums of halfs are equal! Sum={0}!", firstSum);
               }

           else 
               {
                  Console.WriteLine("Sums of halfs are not equal! Difference is {0}!", Math.Abs(firstSum - secondSum));
               }
    }
}
