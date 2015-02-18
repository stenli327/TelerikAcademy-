using System;

/// <summary>
/// You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).
/// </summary>
class SortByString
{
    static void Main()
    {
        string[] arr = { "gusto", "maina,", "ko staaa", "talasami", "kucheta", "opaa" };
        SortByLenght(arr);
        PrintMe(arr);
    }

    private static void PrintMe(string[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }

    private static void SortByLenght(string[] arr)
    {
        Array.Sort(arr, (x, y) => x.Length.CompareTo(y.Length));
    }
}
