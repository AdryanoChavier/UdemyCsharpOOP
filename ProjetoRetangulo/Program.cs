using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.Writeline("Entre com a largura e altura do retângulo: ")
            retangulo.Largura = double.Parse(Console.Readline());
            retangulo.Altura = double.Parse(Console.Readline());

            double area = retangulo.Area();
            double perimetro = retangulo.Perimetro();
            double diagonal = retangulo.Diagonal();
            
            Console.Writeline("AREA = " + area);
            Console.Writeline("PERIMETRO = " + perimetro);
            Console.Writeline("DIAGONAL = " + diagonal);
        }
    }
}