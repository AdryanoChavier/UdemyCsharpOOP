using System;
using System.Globalization;
using System.Net.NetworkInformation;
using ProjetoProduto;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto= new Produto();
            Console.Write("Entre com o nome do produto: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Qual o preço dele: ");
            produto.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Quantidade dele no estoque: ?");
            produto.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("");

        }
    }
}