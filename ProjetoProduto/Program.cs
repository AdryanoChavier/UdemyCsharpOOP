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
            Console.WriteLine("Dados do produto: " + produto);
            Console.Write("Digite o numero de produtos a ser adicionado no estoque: ");


            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdtuos(qte);
            Console.WriteLine("Dados do produto: " + produto);
            Console.Write("Digite o numero de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdtuos(qte);
            Console.WriteLine("Dados do produto: " + produto);
        }
    }
}