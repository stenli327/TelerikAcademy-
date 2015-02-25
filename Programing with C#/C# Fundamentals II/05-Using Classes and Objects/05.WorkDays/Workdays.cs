using System;
using System.Collections.Generic;
/// <summary>
/// Write a method that calculates the number of workdays between today and given date, passed as parameter.
/// Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
/// </summary>
class Workdays
{
    private static int currentYear = DateTime.Now.Year;

    private static List<DateTime> holidays = new List<DateTime>
            { new DateTime(currentYear, 1, 1),
               new DateTime(currentYear, 3, 3),
               new DateTime(currentYear, 5, 1),
               new DateTime(currentYear, 5, 2),
               new DateTime(currentYear, 5, 6),
               new DateTime(currentYear, 5, 24),
               new DateTime(currentYear, 9, 22),
               new DateTime(currentYear, 12, 24),
               new DateTime(currentYear, 12, 25),
               new DateTime(currentYear, 12, 26),
               new DateTime(currentYear, 12, 31),
            };

    static void Main()
    {
        Console.WriteLine("Enter a end date in YYYY/MM/DD format");
        string endDate = Console.ReadLine();
        DateTime endDateTime = ParseDate(endDate);
        int woorkdays = CalculateWorkdays(endDateTime);

        Console.WriteLine("Workdays between today and given date {0} is = {1}", endDate, woorkdays);

    }

    private static DateTime ParseDate(string date)
    {
        string[] dateArray = date.Split('/');
        int day = int.Parse(dateArray[2]);
        int month = int.Parse(dateArray[1]);
        int year = int.Parse(dateArray[0]);

        DateTime result = new DateTime(year, month, day);

        return result;
    }

    private static int CalculateWorkdays(DateTime endDate)
    {
        DateTime start = DateTime.Today;

        int woorkdays = 0;

        for (DateTime date = start; date <= endDate; date = date.AddDays(1))
        {
            if ((date.DayOfWeek != DayOfWeek.Saturday) 
                && (date.DayOfWeek != DayOfWeek.Sunday) 
                && (holidays.IndexOf(date) == -1))
            {
                woorkdays++;
            }
        }

        return woorkdays;
    }
}
