using System.Globalization;
using ProjetoVetor_Parte2;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args){ 

            int n = int.Parse(Console.ReadLine());
            Produto[] vect = new Produto[n];

             for (int i = 0; i < n; i++)
             {
                string name = Console.ReadLine();
                double price =  double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                vect[i] = new Produto{Name = name, Price = price};
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++){
                sum += vect[i].Price;
            }
            double avg = sum / n;
            Console.WriteLine("AVERAGE PRICE = " +avg.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}