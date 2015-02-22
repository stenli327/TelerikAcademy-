using System;
/// <summary>
/// Write a program to convert decimal numbers to their hexadecimal representation.
/// </summary>
class DecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter decimal number: ");
        int number = int.Parse(Console.ReadLine());
        string result = number.ToString("X");
        Console.WriteLine("Hexadecimal representation of number {0} is {1:x}", number, result);
        Console.WriteLine();

    }
}
