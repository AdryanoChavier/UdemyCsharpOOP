using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using ProjetoLista_Part2;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Quantos funcionarios a serem cadastrados? ");
           int n = int.Parse(Console.ReadLine());

           List<Funcionario> list = new List<Funcionario>();

           for(int i = 0; i < n;i++){
                Console.WriteLine("Funcionario #"+i+":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                list.Add(new Funcionario(id,name,salary));
                Console.WriteLine();
           }

           Console.Write("Insira o ID do funcionário que terá aumento salarial: ");
           int searchId = int.Parse(Console.ReadLine());

           Funcionario emp = list.Find( x=> x.Id == searchId);
           if(emp != null){
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                emp.AcrecimoSalary(percentage);
           }else{
                Console.WriteLine("O id não existe!");
           }

           Console.WriteLine();
           Console.WriteLine("Lista de funcionarios atualizada");
           foreach(Funcionario obj in list){
                Console.WriteLine(obj);
           }
           {
            
           }

        }
    }
}
