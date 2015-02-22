using System;
/// <summary>
/// Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
/// </summary>
class BinaryShort
{
    static void Main()
    {
        Console.WriteLine("Enter 16-bit signed number: ");
        short number = short.Parse(Console.ReadLine());
        Console.Write("The binary representation of the number is: ");
        Console.WriteLine(Convert.ToString(number, 2));
    }
}
