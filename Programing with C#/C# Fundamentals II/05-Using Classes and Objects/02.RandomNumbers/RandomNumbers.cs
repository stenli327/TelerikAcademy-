using System;
using System.Security.Cryptography;
/// <summary>
/// Write a program that generates and prints to the console 10 random values in the range [100, 200].
/// </summary>
class RandomNumbers
{
    static void Main()
    {
        for (int i = 0; i < 10; i++)
        {
            int result = RandomNumbers.Generate(100, 200);
            Console.WriteLine("{0}.  {1}", i + 1, result);
        }
    }
}
public static class RandomNumbers
{
    private static Random Generator = new Random();

    public static int Generate(int a, int b)
    {
        int result = Generator.Next(a, b);
        return result;
    }

}