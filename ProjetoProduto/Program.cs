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
            /*Produto produto= new Produto("TV",500.00,10);//Com construtor*/



            Console.Write("Entre com o nome do produto: ");
            string nome = Console.ReadLine();
            Console.Write("Qual o preço dele: ");
            double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        
            Produto produto = new Produto();

            Console.WriteLine("Dados do produto: " + produto);
            Console.Write("Digite o numero de produtos a ser adicionado no estoque: ");


            int qte = int.Parse(Console.ReadLine());
            produto.AdicionarProdtuos(qte);
            Console.WriteLine("Dados do produto: " + produto);
            Console.Write("Digite o numero de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            produto.RemoverProdtuos(qte);
            Console.WriteLine("Dados do produto: " + produto);
        }
    }
}