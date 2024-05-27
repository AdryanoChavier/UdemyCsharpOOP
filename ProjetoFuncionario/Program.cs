using System;
using System.Globalization;
using System.Net.NetworkInformation;
using ProjetoFuncionario;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.Write("Dados do primeiro funcionário: ");
            f1.nome = Console.ReadLine();
            Console.Write("Digite o Salario dele: ");
            f1.salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Dados do segundo funcionário: ");
            f2.nome = Console.ReadLine();
            Console.Write("Digite o Salario dele: ");
            f2.salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double media = (f2.salario + f1.salario) / 2.0;

            Console.Write("Salário medio = " + media.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
