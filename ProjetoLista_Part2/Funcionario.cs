using System.Globalization;
using System.Runtime.InteropServices;

namespace ProjetoLista_Part2;

public class Funcionario
{
    public int Id{ get; set; }
    public string Name{ get; set; }
    public double Salary{ get; set; }

    public Funcionario(int id,string name, double salary){
        Id = id;
        Name = name;
        Salary = salary;
    }
    public void AcrecimoSalary(double percentage){
        Salary += Salary * percentage/100;
    }
    public override string ToString(){
        return Id + ", "+Name+", "+Salary.ToString("F2",CultureInfo.InvariantCulture);
    }
}
