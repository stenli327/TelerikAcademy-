using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Write a program that calculates the value of given arithmetical expression.
/// The expression can contain the following elements only:
///     Real numbers, e.g. 5, 18.33, 3.14159, 12.6
///     Arithmetic operators: +, -, *, / (standard priorities)
///     Mathematical functions: ln(x), sqrt(x), pow(x,y)
///     Brackets (for changing the default priorities): (, )
///     
/// Hint: Use the classical Shunting-yard algorithm and Reverse Polish notation.
/// 
/// </summary>
class ArithmeticalExpressions
{
    private static string[] operators = {"+", "-","*", "/"};
    static void Main(string[] args)
    {
        string input = "(3+5.3) * 2.7 - ln(22) / pow(2.2, -1.7)";

        Queue<string> q = new Queue<string>();
        Stack<string> s = new Stack<string>();

        //TODO must implement
    }
}

