using System;
/// <summary>
/// Write a program to convert hexadecimal numbers to their decimal representation.
/// </summary>
class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("Enter hexadecimal number: ");
        string number = Console.ReadLine();
        long result = Convert.ToInt64(number, 16);
        Console.WriteLine("Decimal representation of {0:x} is {1}", number, result);
        Console.WriteLine();
    }
}
