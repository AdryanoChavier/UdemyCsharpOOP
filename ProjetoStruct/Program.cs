using System;
using System.Drawing;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point();
            p.X = 10;
            p.Y = 20;
            Console.WriteLine(p);
        }
    }
}