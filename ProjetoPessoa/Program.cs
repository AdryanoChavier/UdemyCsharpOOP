using System;
using System.Net.NetworkInformation;
using ProjetoPessoa;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.Write("Digite o nome da primeira pessoa: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Digite a idade dela: ");
            p1.idade = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome da segunda pessoa: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Digite a idade dela: ");
            p2.idade = int.Parse(Console.ReadLine());
            if (p1.idade > p2.idade){
                Console.Write("Pessoa mais velha: "+p1.Nome);
            }else if(p2.idade > p1.idade){
                Console.Write("Pessoa mais velha: " + p2.Nome);
            }else{
                Console.Write("Elas tem a mesma idade");
            }

        }
    }
}