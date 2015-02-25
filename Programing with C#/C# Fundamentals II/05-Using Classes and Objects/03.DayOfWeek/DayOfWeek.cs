using System;
using System.Data;
/// <summary>
/// Write a program that prints to the console which day of the week is today.
/// Use System.DateTime.
/// </summary>
class DayOfWeek
{
    static void Main()
    {
        string dayOfWeek = PrintWeekOfDay(DateTime.Now);
        Console.WriteLine(dayOfWeek);
    }
    public static string PrintWeekOfDay(DateTime today)
    {
        string result = today.DayOfWeek.ToString();
        return result;
    }
}