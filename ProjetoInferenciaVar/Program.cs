using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args){


        var x = 10;
        var y = 20.0;
        var z = "Maria";

        Console.WriteLine(x);
        Console.WriteLine(y.ToString("F2",CultureInfo.InvariantCulture));
        Console.WriteLine(z);
        }
    }
}