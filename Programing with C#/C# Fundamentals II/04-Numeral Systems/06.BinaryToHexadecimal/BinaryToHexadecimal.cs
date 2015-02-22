using System;
/// <summary>
/// Write a program to convert binary numbers to hexadecimal numbers (directly).
/// </summary>
class BinaryToHexadecimal
{
    static void Main()
    {
        Console.WriteLine("Program that convert binary numbers to hexadecimal numbers (directly)");
        Console.WriteLine("Enter binary number :");
        string number = Console.ReadLine();
        string strHex = Convert.ToInt32(number, 2).ToString("X");
        Console.WriteLine("Hexadecimal number of {0} is {1}", number, strHex);
        Console.WriteLine();
    }
}
