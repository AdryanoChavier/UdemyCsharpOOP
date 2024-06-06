
using System.Globalization;
using ProjetoContrato.Entities;
using ProjetoContrato.Entities.Enum;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Enter department´s name: ");
           string department = Console.ReadLine();
           Console.WriteLine("");
           Console.WriteLine("Enter worker data: ");
           Console.Write("Name: ");
           string name = Console.ReadLine();
           Console.Write("Level (Junior/MidLevel/Senior): ");
           WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
           Console.Write("Base Salary: ");
           double baseSalary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
           
           Department detp = new Department(department);
           Worker worker = new Worker(name,level,baseSalary,detp);

           Console.Write("How many contracts to this worker? ");
           int n = int.Parse(Console.ReadLine());

           for(int i = 0; i < n; i++){
            Console.WriteLine($"Enter #{i} contract data:");
            Console.Write("Date (DD/MM/YYYY): ");
            DateTime data = DateTime.Parse(Console.ReadLine());
            Console.Write("Value per hour: ");
            double valuePerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Duration (hours):  ");
            int hours = int.Parse(Console.ReadLine()); 

            HourContract contract = new HourContract(data,valuePerHour,hours);
            worker.AddContract(contract);
           }

           Console.WriteLine("");
           Console.Write("Enter month and year to calculate income (MM/YYYY): ");
           string mothAndYear = Console.ReadLine();
           int month = int.Parse(mothAndYear.Substring(0,2));
           int year = int.Parse(mothAndYear.Substring(3));
           Console.WriteLine("");
           Console.WriteLine("Name: "+worker.Name);
           Console.WriteLine("Department: "+worker.Department.Name);
           Console.WriteLine("Income for "+mothAndYear+": "+worker.Income(year,month));
        }
    }       
}