using System;
using System.Globalization;
using ProjetoSistemaBancario;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            ContaBancaria conta;


            Console.Write("Entre com o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n): ");
            char resp = char.Parse(Console.ReadLine());
            if(resp == 's'|| resp == 'S'){
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero,titular,depositoInicial);
            }
            else{
                conta = new ContaBancaria(numero,titular);
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Dados da conta: ");
            System.Console.WriteLine(conta);
            System.Console.WriteLine();

            System.Console.WriteLine();
            System.Console.WriteLine("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            System.Console.WriteLine();
            System.Console.WriteLine("Dados da conta atualizados: ");
            System.Console.WriteLine(conta);

            System.Console.WriteLine();
            System.Console.WriteLine("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            System.Console.WriteLine();
            System.Console.WriteLine("Dados da conta atualizados: ");
            System.Console.WriteLine(conta);


        }
    }
}