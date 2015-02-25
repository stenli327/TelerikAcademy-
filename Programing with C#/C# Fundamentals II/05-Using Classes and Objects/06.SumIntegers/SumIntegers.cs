using System;
/// <summary>
/// You are given a sequence of positive integer values written into a string, separated by spaces.
/// Write a function that reads these values from given string and calculates their sum.
/// </summary>
class SumIntegers
{
    static void Main()
    {
        Console.WriteLine("Enter a sequence of positive integer, separated by spaces:");
        string[] numbers = Console.ReadLine().Split(' ');
        Console.WriteLine("Result is: {0}", CalculateSum(numbers));
    }
    private static long sum;

    private static long CalculateSum(string[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += long.Parse(numbers[i]);
        }
        return sum;
    }
}
