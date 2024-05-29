using System;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double? x = null;
            double? y = 10.0;
            double? a = null;
            double? b = 10;
            double? c = a ?? 5; //se ?? se o valor de a for nulo joga 5 no c
            double? d = b ?? 10; //se ?? se o valor de b for nulo joga 5 no d

            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine();
            Console.WriteLine(x.GetValueOrDefault()); 
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);//vai ver a a variavel tem valor, se nao tiver é false se tiver é true
            Console.WriteLine(y.HasValue);//vai ver a a variavel tem valor, se nao tiver é false se tiver é true


            if(x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("X is null");
            if(y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("Y is null");

        }
    }
}